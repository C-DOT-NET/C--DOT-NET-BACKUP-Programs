using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C_SHARP
{
    class Decreament
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter value for x \n");
            x = int.Parse(Console.ReadLine());
            x++;
            Console.Write("Preincreament of x is = " + x);
            --x;
            Console.Write("Postincreament of x is = " + x);

        }
    }
}
