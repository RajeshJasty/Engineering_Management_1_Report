/*
 * TemperatureControl.c
 *
 * Created: 28/10/2020 7:08:45 PM
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

void setup(void);
char readADC(char channel);
ISR(USART1_RX_vect);		// calling the interrupt function

unsigned fanTrackBar, lightTrackBar, tempTrackBar;


int main(void)
{
	
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
		while(rxData>0)
		{
			
			if (rxData == 'C')
			{
				while(!txBufferEmpty);
				rxData = 'V';
				while(!txBufferEmpty);
				rxData = 0;
			}
			if (rxData == 'F')
			{
				while(!txBufferEmpty);
				rxData = 'F';
				while(!txBufferEmpty);
				rxData = fanTrackBar;
			}
			if (rxData == 'L')
			{
				while(!txBufferEmpty);
				rxData = 'L';
				while(!txBufferEmpty);
				rxData = lightTrackBar;
			}
			if (rxData == 'T')
			{
				while(!txBufferEmpty);
				rxData = 'T';
				while(!txBufferEmpty);
				rxData = tempTrackBar;
			}
			if (rxData == 'H')
			{
				while(!txBufferEmpty);
				rxData = 'H';
				while(!txBufferEmpty);
				rxData = 1;
				if ( rxData = 1)
				{
					heaterOn;
				}
				else if (rxData = 0)
				{
					heaterOff;
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



