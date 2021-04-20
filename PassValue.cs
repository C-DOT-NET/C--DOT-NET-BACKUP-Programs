using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PassValue
    {
		static void ChangeValue(String name)
		{
			name = "sameer";

			Console.WriteLine(name);
		}

		public static void Main()
		{
			//first it will run main method  after it will print other value method(calls)
			String s = "Niteesh";

			Console.WriteLine(s);

			ChangeValue(s);

			//Console.WriteLine(s);
		}
	}
}
