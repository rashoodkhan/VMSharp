﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace SimpleVM
{
	public class VM
	{
		int[] data;			//Data Memory
		int[] code;			//Code Memory
		int[] stack;		//Stack
		int[] globals;

		int ip;				//Instruction Pointer
		int fp;				//Frame Pointer
		int sp = -1;				//Stack Pointer

		public bool trace = false;

		public VM (int[] code,int main,int datasize) {
			this.code = code;
			this.ip = main;
			data = new int[datasize];
			globals = new int[datasize];
			stack = new int[100];
		}

		public void cpu() {
			while ( ip < code.Length) {
				int opcode = code [ip];		// FETCH Operation

				if (trace) {
					disassemble (opcode);
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
						Console.WriteLine (">> {0}",v);
						break;

					//Loads the data from global memory
					case ByteCode.GLOAD:
						int addr = code [ip++];
						stack [++sp] = globals [addr--];
						break;

					//Stores data in to global memory
					case ByteCode.GSTORE:
						v = stack [sp];
						sp--;
						addr = code [ip++];
						globals [addr] = v;
						break;

					case ByteCode.IADD:
						int val2 = stack [sp--];
						int val1 = stack [sp--];
						stack [++sp] = val1 + val2;
						break;
					
					case ByteCode.ISUB:
						val2 = stack [sp--];
						val1 = stack [sp--];
						stack [++sp] = val1 - val2;
						break;

					case ByteCode.IMUL:
						val2 = stack [sp--];
						val1 = stack [sp--];
						stack [++sp] = val1 * val2;
						break;
					
					//Branches the instruction pointer -> go to statement
					case ByteCode.BR:
						ip = code [ip++];
						break;
					
					//Branches on true -> if statements
					case ByteCode.BRT:
						addr = code [ip++];
						if (stack [sp--] == ByteCode.TRUE)
							ip = addr;
						break;

					//Branches on false
					case ByteCode.BRF:
						addr = code [ip++];
						if (stack [sp--] == ByteCode.FALSE)
							ip = addr;
						break;
					
					//Loads the local variable from the stack
					case ByteCode.LOAD:
						int offset = code [ip++];
						stack [++sp] = stack [fp + offset];
						break;
					
					//Function call semantics
					case ByteCode.CALL:
						addr = code [ip++];
						int nargs = code [ip++];
						stack [++sp] = nargs;
						stack [++sp] = fp;
						stack [++sp] = ip;
						fp = sp;
						ip = addr;
						break;

					//Function return semantics
					case ByteCode.RET:
						int rvalue = stack [sp--];
						sp = fp;
						ip = stack [sp--];
						fp = stack [sp--];
						nargs = stack [sp--];
						sp -= nargs;
						stack [++sp] = rvalue;
						break;

					case ByteCode.ILT:
						val2 = stack [sp--];
						val1 = stack [sp--];
						if (val1 < val2)
							stack [++sp] = ByteCode.TRUE;
						else
							stack [++sp] = ByteCode.FALSE;
						break;
					
					case ByteCode.IEQ:
						val2 = stack [sp--];
						val1 = stack [sp--];
						if (val1 == val2)
							stack [++sp] = ByteCode.TRUE;
						else
							stack [++sp] = ByteCode.FALSE;
						break;

					case ByteCode.HALT:
						return;
				}

				opcode = code[ip];
			}
		}

		private void disassemble (int opcode) {
			Console.Error.Write (ip+" "+ByteCode.opcodes[opcode].name);

			if (ByteCode.opcodes [opcode].n == 1) {
				Console.Error.Write (" "+code [ip+1]);
			} 

			else if (ByteCode.opcodes [opcode].n == 2) {
				Console.Error.Write (" {0} , {1}",code[ip+1],code[ip+2]);
			}

			List<int> list = new List<int> ();
			for (int i = 0; i <= sp; i++) {
				list.Add (stack [i]);
			}

			Console.Error.Write (" [ ");
			Console.Error.Write (String.Join (", ",list.ToArray ()));
			Console.Error.Write (" ]");

			Console.Error.WriteLine ();
		}
	}
}

