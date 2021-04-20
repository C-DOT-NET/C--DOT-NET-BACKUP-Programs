using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C_SHARP
{
    class Increament
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter value for a \n");
            a = int.Parse(Console.ReadLine());
            a++;
            Console.Write("Preincreament of a is = " + a);
            --a;
            Console.Write("Postincreament of a is = " + a);

        }
    }
}
