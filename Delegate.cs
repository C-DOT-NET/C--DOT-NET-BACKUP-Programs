using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }



    class Delegate
    {
        //Our delegate
        public delegate bool FilterDelegate(Person p);



        static void Main(string[] args)
        {



            //Create 4 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };



            //Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };



            //Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);



            Console.Read();
        }



        /// <summary>
        /// A method to filter out the people you need
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="filter">A filter</param>
        /// <returns>A filtered list</returns>
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);



            foreach (Person p in people)
            {
                if (filter(p))
                {
                    // calling a method using delegate object
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }




            Console.Write("\n\n");
        }



        //==========FILTERS===================
        static bool IsChild(Person p)
        {
            return p.Age < 18;
        }



        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }



        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}

