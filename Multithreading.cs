using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Multithreading
    {
        //using single thread//
        //static void Main(string[] args)
        //{
        //    //creating thread object using built in thread keyword
        //    Thread t = Thread.CurrentThread;
        //    //printing the thread using Name keyword
        //    Console.WriteLine("This example is using single thread" + Thread.CurrentThread.Name);
        //    //wihtoud using bydefault generated Name keyword to print the string
        //   // Console.WriteLine("This example is using single thread" + Thread.CurrentThread);
        //    //Console.WriteLine(t);
        //    Console.Read();

        //}


        //multiple thread

        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
        
            //Executing the methods
            t1.Start();
            //if we want to stop method 1
            t1.Abort();
            //if we want to stop method 2
            t2.Abort();
           
            //Console.WriteLine("Main Thread Ended");
            Console.Read();
        }

        static void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine( i);
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine( i);
            }
            Console.WriteLine("Method Ended using " + Thread.CurrentThread.Name);
        }
    }
}
