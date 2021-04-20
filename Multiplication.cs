using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C_SHARP
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter value for a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.Write("Multiplication of a and b is = " + c);



        }
    }
}
