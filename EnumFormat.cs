using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EnumFormat
    {
        enum Months
        {
            January = 1,    // 0
            February = 2,   // 1
            March = 3,    // 6
            April = 4,      // 7
            May = 5,        // 8
            June = 6,       // 9
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.January;
            Console.WriteLine("enter the month");
            myNum = int.Parse(Console.ReadLine());
            if (myNum >= 3 && myNum <= 6)
            {
                Console.WriteLine("It is Summer");

            }
            else if (myNum >= 7 && myNum <= 9)
            {
                Console.WriteLine("It is Rainy");
            }
            else 
                    {
                
                    Console.WriteLine("It is Winter");
                    }
            }
        }
}
