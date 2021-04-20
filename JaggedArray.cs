using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class JaggedArray
    {
		public static void Main()
		{
			int[][,] jArray = new int[2][,];

			jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
			jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };

			Console.WriteLine(jArray[0][0, 0]);
			Console.WriteLine(jArray[0][0, 1]);
			Console.WriteLine(jArray[0][1, 0]);
			Console.WriteLine(jArray[0][1, 1]);

			Console.WriteLine(jArray[1][0, 0]);
			Console.WriteLine(jArray[1][0, 1]);
			Console.WriteLine(jArray[1][1, 0]);
			Console.WriteLine(jArray[1][1, 1]);
		}
	}
}
