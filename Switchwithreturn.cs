using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Switchwithreturn
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            //showing logical operands in var 
            string Logicaloperand;
            float answer;

            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //logical operations reading as string
            Console.Write("Please enter an operand (+, -, /, *): ");
            Logicaloperand = Console.ReadLine();

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (Logicaloperand)
            {
                //for substraction
                case "-":
                    answer = num1 - num2;
                    break;
                //for addition
                case "+":
                    answer = num1 + num2;
                    break;
                //for division
                case "/":
                    answer = num1 / num2;
                    break;
                //for multiplication
                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    return;
            }
            Console.WriteLine(num1.ToString() + " " + Logicaloperand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

        }

    }
}
