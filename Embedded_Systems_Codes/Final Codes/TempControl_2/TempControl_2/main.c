/*
 * TempControl_2.c
 *
 * Created: 26/10/2020 10:33:30 PM
 * Author : Rajesh
 */ 

#define F_CPU 80000000UL
#include <avr/io.h>
#include <avr/interrupt.h>

#define heaterOn	(PORTB |=(1<<7))	// heater on
#define heaterOff	(PORTB &=~(1<<7))	// heater off
#define fanOn		(PORTB |=(1<<5))	// fan on
#define fanOff		(PORTB &=~(1<<5))	// fan off
#define tempCh1		0b01100001			// temperature channel 1

#define startConversion		(ADCSRA |=(1<<ADSC)	// start conversion
#define conversionRunning	(ADCSRA &(1<<ADSC)	// conversion running

#define RxBufferFull	(UCSR1A & (1<<7))// rx buffer full
#define txBufferEmpty	(UCSR1A & (1<<5))// tx buffer empty
#define rxData			UDR1			 // UDR1 define to rx Data

#define rxHeaderState	0
#define rxIdleState		1
#define rxDataState1	2
#define rxDataState2	3

ISR(USART1_RX_vect)		// calling the interrupt function

int rxState, rxIdleState, rxHeaderState, rxCmdState, 
rxDataState1, rxData1, rxData2, rxEndPktState, newDataFlag;

int main(void)
{
	readADC(tempCh1);
	setup();
	while (1)
	{
	}
}

void setup(void)
{
	DDRB	= 0b01010001;	// heater, fan, light output
	ADCSRA	= 0b10000111;	// enable ADC, single conversion, slowest speed
	ADMUX	= 0b01100000;	// left adjusted, AVCC wit external capacitor
	UCSR1A	= 0b00100000;	// flag is set
	UCSR1B	= 0b10011110;	// interrupts enabled, rx tx on, 8 bit
	UCSR1C	= 0b00001110;	// 8bit, 2 stop bits, Async
	UBRR1L	= 51;			// Set for 9600 Baud
	TCCR1A	= 10100011;		//
	TCCR1B	= 00011111;
	ICR1	= 49;
	sei();
}
ISR(USART1_RX_vect)
{
	if (RxBufferFull)
	{
		if (rxData>0)
		{
			while (rxData>0)
			{
				switch (rxState)
				{
					case rxIdleState:
						if(rxData=='A')
							rxState = rxHeaderState;
						break;
					
					case rxHeaderState:
						if (rxData == 'F')
							rxState = rxCmdState;
						else
							rxState = rxIdleState;
						break;
					
					case rxCmdState:
							rxCmdState = rxData;
							rxState = rxDataState1;
						break;
					
					case rxDataState1:
							rxData1 = rxData;
							rxState = rxDataState2;
						break;
						
					case rxDataState2:
							rxData2 = rxData;
							rxState = rxEndPktState;
					
					case rxEndPktState:
							if(rxData == 'H')
							newDataFlag = 1;
							rxState = rxIdleState;
						break;
					default:
							rxState = rxIdleState;
						break;
				}
			}
		}
		
	}
}


char readADC(char channel)// function return value stored
{
	ADMUX = channel;	// setup a channel 1
	startConversion;	// start conversion
	while(conversionRunning); // wait for the conversion to be complete
	return(ADCH);		// return the ADC value
}


