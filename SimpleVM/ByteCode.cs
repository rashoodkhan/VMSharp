using System;

namespace SimpleVM
{
	public class ByteCode
	{
		// INSTRUCTION for BYTECODE (OPCODES)
		public static short IADD = 1;		//ADD
		public static short ISUB = 2;		//SUB
		public static short IMUL = 3;		//MUL
		public static short ILT = 4;		//LESS THAN
		public static short IEQ = 5;		//EQUALs
		public static short BR = 6;			//BRANCH
		public static short BRT = 7;		//BRANCH IF TRUE
		public static short ICONST = 8;		//PUSH INT ON TOP OF STACK
		public static short LOAD = 9;		//LOAD LOCAL VARIABLE
		public static short GLOAD = 10;		//LOAD GLOBAL VARIABLE
		public static short STORE = 11;		//STORE LOCAL VARIABLE
		public static short GSTORE = 12;	//STORE GLOBAL VARIABLE
		public static short PRINT = 14;		//PRINT THE TOP OF STACK
		public static short POP = 15;		//POP OF THE TOP OF STACK
		public static short HALT = 16;		//STOP THE PROGRAM

		public ByteCode () {
		}
	}
}

