using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CountSpace
    {

		public static int Countspace(string str)
		{
			int countspace = 0;
			string s1;
			for (int i = 0; i < str.Length; i++)
			{
				s1 = str.Substring(i, 1);
				if (s1 == " ")
					countspace++;
			}
			return countspace;
		}
		public static void Main()
		{
			string stringinput;
			CountSpace cs = new CountSpace();
			Console.Write("Please input a string : ");
			stringinput = Console.ReadLine();
			Console.WriteLine("\"" + stringinput + "\"" + " This string contains = {0} spaces", Countspace(stringinput));
		}
	}
}
