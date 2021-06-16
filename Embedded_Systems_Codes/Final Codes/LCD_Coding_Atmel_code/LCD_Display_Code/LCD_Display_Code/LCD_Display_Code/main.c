/*
 * LCD_Display_Code.c
 *
 * Created: 19/10/2020 10:00:45 AM
 * Author : Rajesh Jasti
 */ 

// Libraries 

#define F_CPU 80000000L
#include <avr/io.h>
#include <stdio.h>
#include <string.h>
#include <util/delay.h>

// defines 

#define rwHigh	(PORTC |=(1<<1))	// read write on
#define rwLow	(PORTC &=~(1<<1))	// read write off
#define rsHigh	(PORTC |=(1<<0))	// rs high on
#define rsLow	(PORTC &=~(1<<0))	// rs high off
#define enHigh	(PORTC |=(1<<2))	// enable high on
#define enLow	(PORTC &=~(1<<2))	// enable high off
#define dataInput	PINA			// display data input 
#define dataOutput	PORTA			// display data output

void setup();
void initializeLCD(void);	//Initialize the LCD when first powered on.
void LCDLineOne(char *One); //Calls up routines to output the first line of characters on the LCD
void LCDLineTwo(char *Two); //Calls up routines to output the second line of characters on the LCD
void writeInstruction(char instruction); //outputs an instruction to the display
char checkBusy(void);		//checks the busy bit of LCD, returns a one if busy else returns a zero
void writeData(char LCDdata);//outputs a character to the LCD

char One[] = "Rajesh";		//test parameters
char Two[] = "Temperature";	//Line two output text 
int main()
{
	setup();				// calling functions
	initializeLCD();		// Initializing to LCD 
	while(1)				// Infinity loop
	{
		LCDLineOne (One);    //output (line one) Rajesh
		LCDLineTwo (Two);    //output (line two) Temperature
	}
}

void initializeLCD(void)
{
	_delay_ms(100);					//wait more than 100ms before send in first instruction
	writeInstruction(0b00110000);	//set LCD for 8 bits
	_delay_ms(4.1);					//wait more than 4.1ms
	writeInstruction(0b00110000);	//set LCD for 8 bits
	_delay_us(100);					//wait more than 100us
	writeInstruction(0b00110000);	//set LCD for 8 bits
	while(checkBusy());				//wait for LCD to complete processing
	writeInstruction(0b00111100);	//8 bits, 2 lines, 5x7 dots
	while(checkBusy());				//wait for LCD to complete processing
	writeInstruction(0b00001111);	//display off
	while(checkBusy());				//wait for LCD to complete processing
	writeInstruction(0b00000001);	//display on
	while(checkBusy());				//wait for LCD to complete processing
	writeInstruction(0b00000110);	//display on
}

// LCD Display Line one function 

void LCDLineOne(char *line1)
{
	char loop, end;
	while(checkBusy());
	writeInstruction(0b00000010);	//return home
	for(loop=0; loop<24; loop++)	//clear the line
	{
		while(checkBusy());
		writeData(0b00100000);		//write spaces to data memory (line one)
	}
	while(checkBusy());
	writeInstruction(0b00000010);	//return home
	end = strlen(line1);
	for(loop = 0; (loop<end) && (loop<24); loop++)
	{
		while(checkBusy());
		writeData(line1[loop]);		//output character to data memory (line one)
	}
}

// LCD Display Line two function 

void LCDLineTwo(char *line2)
{
	char loop, end;
	while(checkBusy());
	writeInstruction(0b11000000);//return home
	for(loop=0; loop<24; loop++) //clear the line
	{
		while(checkBusy());
		writeData(0b00100000);	//write spaces to data memory (line two)
	}
	while(checkBusy());
	writeInstruction(0b11000000);//return home
	end = strlen(line2);
	for(loop=0; (loop<end) && (loop<24); loop++)
	{
		while(checkBusy());
		writeData(line2[loop]); //output character to data memory (line two)
	}
}


// checking busy bits LCD, if busy returns 1 otherwise 0
char checkBusy(void) 
{
	char busyflag;
	rwHigh;
	rsLow;
	DDRA = 0b11111111;
	enHigh;
	_delay_us(500);
	while(PINA7==1);
	enLow;
	_delay_us(500);
	return busyflag=0;
}

 //outputs a character to the LCD
void writeData(char character)  
{
	rsHigh;
	rwLow;
	DDRA = 0b11111111;
	PORTA = character;
	enHigh;
	_delay_us(500);
	enLow;
	_delay_us(500);
}
// write instructions function to display

void writeInstruction(char instruction)
{
	rsLow;
	rwLow;
	DDRA = 0b11111111;
	PORTA = instruction;
	enHigh;
	_delay_us(500);
	enLow;
	_delay_us(500);
}

// Input & outputs to registers

void setup(void)
{

	DDRC	= 0b00000111;
	DDRE	= 0b00000011;
	PORTE	= 0b00000011;
	DDRD	= 0b01100000;
	PORTD	= 0b00000000;
}

