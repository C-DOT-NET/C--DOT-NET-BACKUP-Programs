using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Linq
    {

        static void Main(string[] args)
        {
            //ADD funtion
            //list to store the countries type of string  
            List<string> countries = new List<string>();

            countries.Add("India");

            countries.Add("US");

            countries.Add("Australia");

            countries.Add("Russia");
            //use lambda expression to show the list of the countries  
            IEnumerable<string> result = countries.Select(x => x);

            //foreach loop to display the countries  
            foreach (var item in  result)   
  
            {

                Console.WriteLine(item);

            }

            //ToList(); funtion
            List<string> result1 = (from x in countries select x).ToList();
            foreach (string s in result1)
            {
                Console.WriteLine(s);
            }
        
            Console.ReadLine();


          
        }
    }
}
