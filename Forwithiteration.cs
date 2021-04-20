using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Forwithiteration
    {
		public static void Main()
		{
			for (int i = 0; i < 5; i++)
			{
				//Console.Write("i loop executes");	
				Console.WriteLine("Value of i: {0}", i);
			}

			for (int j = 1; j < 5; j++)
			{
				//Console.WriteLine("J loop executes\n");
				Console.WriteLine("Value of j: {0}\n", j);
			}

			for ( ; ; )
			{
				Console.WriteLine("this is empty for loop \n");
				//Console.WriteLine("Value of s: {0}\n", k);
				break;
			}
		}
	}
}
