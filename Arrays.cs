using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            String[,] arr = new String[3, 3];//declaration of 2D array  
            arr[0, 1] = "sameer";//initialization  
            arr[1, 2] = "Vignesh";
            arr[2, 0] = "Rahul";

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }
}
