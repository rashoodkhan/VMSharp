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

		public bool trace = false;

		public VM (int[] code,int main,int datasize) {
			this.code = code;
			this.ip = main;
			data = new int[datasize];
			stack = new int[100];
		}

		public void cpu() {
			while ( ip < code.Length) {
				int opcode = code [ip];		// FETCH Operation
				if (trace) {
					Console.Error.WriteLine (" "+ip+" "+ByteCode.opcodes[opcode]);
				}
				ip++;
				switch (opcode) {
					case ByteCode.ICONST:
						int v = code [ip++];
						stack [++sp] = v;
						break;
					case ByteCode.PRINT:
						v = stack [sp];
						sp--;
						Console.WriteLine (v);
						break;
					case ByteCode.HALT:
						return;
				}

				opcode = code[ip];
			}
		}
	}
}

