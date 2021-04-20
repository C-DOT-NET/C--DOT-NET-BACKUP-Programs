using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Foreach
    {
        static public void Main()
        {

           // Console.WriteLine("Print names:");

            // creating an array 
            string[] a_array = new string[] { "sameer","niteesh","Vignesh","Rahul","sai" };

            // foreach loop begin 
            // it will run till the 
            // last element of the array 
            foreach (string items in a_array)
            {
                Console.WriteLine("Your name is = "+ items);
            }
        }
    }
}
