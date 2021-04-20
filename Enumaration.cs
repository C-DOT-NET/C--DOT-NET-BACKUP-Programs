using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Enumaration
    {
        enum Categories
        {
            Electronics = 1,
            Food = 2,
            Automotive = 3,
            Arts ,
            BeautyCare = 4,
            Fashion = 5,
            WomanFashion = 6
        }
        public static void Main()
        {
            Console.WriteLine(Categories.Electronics);
            int stream = (int)Categories.Arts;
            Console.WriteLine(stream);

            var wd = (Categories)11;
            Console.WriteLine(wd);

        }
    }

   
}
