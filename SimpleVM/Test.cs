using System;

namespace SimpleVM
{
	public class Test
	{
		public static void Main(){
			VM vm= new VM (hello, 0, 0);
			vm.trace = true;
			vm.cpu ();
		}

		static int[] hello = {
			ByteCode.ICONST, 20202,
			ByteCode.PRINT,
			ByteCode.HALT
		};

		public Test () {

		}
	}
}

