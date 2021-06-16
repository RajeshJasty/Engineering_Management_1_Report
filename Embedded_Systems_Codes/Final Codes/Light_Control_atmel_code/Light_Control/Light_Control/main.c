/*
 * Light_Control.c
 *
 * Created: 25/10/2020 2:45:27 PM
 * Author : Rajesh Jasti
 */ 

#define F_cpu8000000UL		// clock speed
#include <avr/io.h>			// AVR library
#include <avr/interrupt.h>	// Interrupt Library

#define RxBufferFull (UCSR1A & (1<<7))	//check if RX Buffer is full

ISR(USART1_RX_vect);		// calling interrupt function

unsigned count;


int main(void)
{
	setup();
	while(1)	
	{
		
		
	}
}
void setup(void)
{
	DDRC	= 0b00000001;	// PORTC, PIN0 setup to output
	UBRR1L	= 51;			// set for 9600 baud
	UCSR1B	= 0b10010000;	// rx interrupt enable, receiver enable
	UCSR1C	= 0b00000110;	// set for async, no parity, 1stop bit, 8 data bits
	TCCR0A	= 0b00100001;	// pwm
	TCCR0B	= 0b00001101;	// Prescaler, waveform gen
	sei();					// global interrupt enable
}
ISR(USART1_RX_vect)		// interrupt occurs on receive data complete
{
	if (RxBufferFull)	// data received to rx buffer
	{
		OCR0A = UDR1;	// light track bar value stored in output compare register
		count++;
	}
	
}





