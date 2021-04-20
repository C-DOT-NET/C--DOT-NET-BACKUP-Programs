using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StringReverse
    {
        public static void Main()
        {
            string str, reverse = "";
            int l = 0, Length;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Length = str.Length - 1;
            //finding length
            foreach (char chr in str)
            {
                l += 1;

            }


            Console.Write("Length of the string is : {0}\n\n", l);
            //reverser operation
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reverse);
            Console.ReadLine();
        }


    }
}
