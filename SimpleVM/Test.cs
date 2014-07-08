using System;

namespace SimpleVM
{
	public class Test
	{
		public static void Main(){
			VM vm= new VM (hello, 0, 1);
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

		public Test () {

		}
	}
}

