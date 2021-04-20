using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArrayConcat
    {
        public static void Main()
        {
            // Make an array of strings. Note that we have included spaces.
            string[] str = { "hello ", "welcome ", "to ", "Kalpita "};

            // Put all the strings together.
            Console.WriteLine(string.Concat(str));
        }
    }
}
