using System;

namespace SimpleVM
{
	public class ByteCode
	{
		// INSTRUCTION for BYTECODE (OPCODES)
		public const short IADD = 1;		//ADD
		public const short ISUB = 2;		//SUB
		public const short IMUL = 3;		//MUL
		public const short ILT = 4;		//LESS THAN
		public const short IEQ = 5;		//EQUALs
		public const short BR = 6;			//BRANCH
		public const short BRT = 7;		//BRANCH IF TRUE
		public const short BRF = 8;		//BRANCH IF FALSE
		public const short ICONST = 9;		//PUSH INT ON TOP OF STACK
		public const short LOAD = 10;		//LOAD LOCAL VARIABLE
		public const short GLOAD = 11;		//LOAD GLOBAL VARIABLE
		public const short STORE = 12;		//STORE LOCAL VARIABLE
		public const short GSTORE = 13;	//STORE GLOBAL VARIABLE
		public const short PRINT = 14;		//PRINT THE TOP OF STACK
		public const short POP = 15;		//POP OF THE TOP OF STACK
		public const short HALT = 16;		//STOP THE PROGRAM

		public static string[] opcodes = {
			"",
			"IADD",
			"ISUB",
			"IMUL",
			"ILT",
			"IEQ",
			"BR",
			"BRT",
			"BRF",
			"ICONST",
			"LOAD",
			"GLOAD",
			"STORE",
			"GSTORE",
			"PRINT",
			"POP",
			"HALT"
		};

		public ByteCode () {
		}
	}
}

