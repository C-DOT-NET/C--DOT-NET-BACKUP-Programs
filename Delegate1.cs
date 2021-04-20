using System;
using System.Collections.Generic;
using System.Text;


delegate int sam(int n);
namespace ConsoleApp1
{
    class Delegate1
    {

        public static int num = 10;

        public static int Addition(int p)
        {
            num = num + p;
            return num;
        }


        public static int Multiplication(int q)
        {
            num = num * q;
            return num;
        }


        public static int Getnum()
        {
            return num;
        }
        public static void Main(String[] args)
        {

            sam s = new sam(Addition);
            sam s1 = new sam(Multiplication);
            s(10);
            Console.WriteLine("value of addition :{0}", Getnum());
            s1(5);
            Console.WriteLine("value of multiplication :{0}", Getnum());
            Console.ReadKey();

        }
    }
}
