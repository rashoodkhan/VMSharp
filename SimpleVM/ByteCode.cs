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
		public const short TRUE = 17;		//BOOLEAN TRUE
		public const short FALSE = 18;		//BOOLEAN FALSE

		public static Instruction[] opcodes = {
			null,
			new Instruction("IADD"),
			new Instruction("ISUB"),
			new Instruction("IMUL"),
			new Instruction("ILT"),
			new Instruction("IEQ"),
			new Instruction("BR",1),
			new Instruction("BRT",1),
			new Instruction("BRF",1),
			new Instruction("ICONST",1),
			new Instruction("LOAD",1),
			new Instruction("GLOAD",1),
			new Instruction("STORE",1),
			new Instruction("GSTORE",1),
			new Instruction("PRINT"),
			new Instruction("POP"),
			new Instruction("HALT")
		};

		public ByteCode () {
		}
	}

	public class Instruction
	{
		public string name;
		public int n = 0;

		public Instruction(string name) {
			this.name = name;
		}

		public Instruction(String name,int nargs) {
			this.name = name;
			this.n = nargs;
		}
	}
}

