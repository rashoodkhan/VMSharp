using System;

namespace SimpleVM
{
	public class Test
	{
		public static void Main(){
			VM vm= new VM (factorial, 22, 0);
			vm.trace = true;
			vm.cpu ();
		}

		static int[] hello = {
			ByteCode.ICONST, 90,
			ByteCode.ICONST, 10,
			ByteCode.IMUL,
			ByteCode.PRINT,
			ByteCode.HALT
		};

		static int[] factorial = {
			//Define Factorial : Less than 2 -> return 1
										//Address
			ByteCode.LOAD, -3,			//0
			ByteCode.ICONST, 2,			//2
			ByteCode.ILT,				//4
			ByteCode.BRF, 10,			//5
			ByteCode.ICONST,1,			//7
			ByteCode.RET,				//9

			//Returs N * FACT(N-1)
			ByteCode.LOAD,-3,			//10
			ByteCode.LOAD,-3,			//12
			ByteCode.ICONST, 1,			//14
			ByteCode.ISUB,				//16
			ByteCode.CALL, 0, 1,		//17
			ByteCode.IMUL,				//20
			ByteCode.RET,				//21

			//Main Method PRINT FACT(5)
			ByteCode.ICONST,4,			//22
			ByteCode.CALL,0,1,			//24
			ByteCode.PRINT,				//27
			ByteCode.HALT				//28
		};

		public Test () {

		}
	}
}

