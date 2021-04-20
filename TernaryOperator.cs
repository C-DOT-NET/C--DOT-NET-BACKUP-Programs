using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NestedTernaryOperator
    {

        private int marks;

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }


    }
    class TernaryOperator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************Nested Ternary Operator in C#*********\n");
            NestedTernaryOperator student = new NestedTernaryOperator();

            Console.WriteLine("\nEnter Marks that you obtained in your exam ");


            student.Marks = Convert.ToInt32(Console.ReadLine());

            string medal = (student.Marks >= 90 && student.Marks <= 100) ?
                "White gold medal" : (student.Marks >= 80 && student.Marks <= 90) ?
                "Golden gold medal" : "Silver medal";

            Console.WriteLine("And you deserve a " + medal);
            Console.ReadLine();

        }
    }
}
