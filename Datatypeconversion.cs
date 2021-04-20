using System;
using System.Collections.Generic;
using System.Text;
/** 
program on datatype conversion
coder sameer
date 3/feb/2021

 * */
namespace ConsoleApp1
{
    //class name Datatypeconveri
    class Datatypeconversion
    {
        static void Main(string[] args)
        {
            //converting string to double
            Console.WriteLine("Enter decimal number:");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entered Number is: " + num);
            Console.WriteLine("Enter String:");
            string stringvalue = Console.ReadLine();

            Console.WriteLine("Entered String is: " + stringvalue);

        }
    }
}
