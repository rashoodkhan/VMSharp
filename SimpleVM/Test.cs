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
			ByteCode.ICONST, 20202,
			ByteCode.GSTORE, 0,
			ByteCode.GLOAD, 0,
			ByteCode.PRINT,
			ByteCode.HALT
		};

		public Test () {

		}
	}
}

