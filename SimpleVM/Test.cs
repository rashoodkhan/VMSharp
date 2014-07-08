using System;

namespace SimpleVM
{
	public class Test
	{
		public static void Main(){
			VM vm= new VM (hello, 0, 0);
			vm.cpu ();
		}

		static int[] hello = {
			ByteCode.HALT
		};

		public Test () {

		}
	}
}

