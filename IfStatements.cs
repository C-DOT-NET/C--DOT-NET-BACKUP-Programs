using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            int total = 100;
            Console.WriteLine("enter the marks");
            total = int.Parse(Console.ReadLine());
            if (total <= 35)
            {
                Console.WriteLine("Sorry! you earned bronze medal");
            }
            else if (total <= 75)
            {
                Console.WriteLine("Hurry!!! you have earned silver medal");
            }
            else
            {
                Console.WriteLine("Congratulations you have earned gold medal");
            }
        }
    }
}
