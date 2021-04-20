using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Linqtostring
    {
        static void Main(string[] args)
        {
            string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };
            //used query syntax to convert the collection of the data into the list  
            List<string> result = (from x in countries select x).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
