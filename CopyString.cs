using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CopyString
    {
        public static void Main(string[] args)
        {
            string s1 = "Hello ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
