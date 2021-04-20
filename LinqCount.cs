using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class LinqCount
    {
        public static void Main(String[] args)
        {
            //int[] Num = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine();
            //int count = Num.Count();
            //Console.WriteLine("{0}", count);

            //**********************//

            ////ToArray()
            //int[] Count = Num.ToArray();

            //foreach (int s in Count)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadLine();




            //**********************************/////

            //range 
            //IEnumerable<int> obj1 = Enumerable.Range(100, 10);
            ////foreach loop used to print the numbers from 100 to 109  
            //foreach (var item in obj1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //repeat
            //IEnumerable<int> obj1 = Enumerable.Repeat(100, 10);
            ////foreach loop used to print the numbers from 100 to 109  
            //foreach (var item in obj1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //************************************//
            //Concat
            //here we create two array type of string variable array1 and array2   
            //string[] array1 = { "a", "b", "c", "d" };

            //string[] array2 = { "c", "d", "e", "f" };
            ///*here we will concat two array with the help of 'concat' 
            //    method and store the output in 'result' variable*/
            //var result = array1.Concat(array2);
            ////foreach loop will print the value of result  
            //foreach (var item in result)

            //{

            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();


            //************************************//

            //GroupBY()

            List<Student> objStudent = new List<Student>()
            {
            new Student() { Name = "Ak Tyagi", Gender = "Male",Location="Chennai" },
            new Student() { Name = "Rohini", Gender = "Female", Location="Chennai" },
            new Student() { Name = "Praveen", Gender = "Male",Location="Bangalore" },
            new Student() { Name = "Sateesh", Gender = "Male", Location ="Vizag"},
            new Student() { Name = "Madhav", Gender = "Male", Location="Nagpur"}
            };
            // here with the help of GrouBy we will fetch the student on the base of location  
            var student1 = objStudent.GroupBy(x => x.Location);
            foreach (var sitem in student1)
            {
                // WriteLine() function here count the number of student  
                Console.WriteLine(sitem.Key, sitem.Count());
                Console.WriteLine();
            }
        }

        class Student
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Location { get; set; }
        }


        //    ********************************************//
        //    Aggregate max min
        //    int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //Console.WriteLine("The Maximum value in the array is:");
        //    /*Max() function is applied on the array to  
        //    find the maximum value from the arra*/
        //    int maximumNum = a.Max();

        //Console.WriteLine("The maximum Number is {0}", maximumNum);

        //    Console.ReadLine();
        }
    }

