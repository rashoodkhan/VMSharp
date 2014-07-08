using System;
using System.Collections.Generic;
using System.Collections;

namespace SimpleVM
{
	public class VM
	{
		int[] data;			//Data Memory
		int[] code;			//Code Memory
		int[] stack;		//Stack

		int ip;				//Instruction Pointer
		int fp;				//Frame Pointer
		int sp = -1;				//Stack Pointer

		public VM (int[] code,int main,int datasize) {
			this.code = code;
			this.ip = main;
			data = new int[datasize];
			stack = new int[100];
		}

		public void cpu() {
		
		}
	}
}

