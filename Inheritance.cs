using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Inheritance
    {
		public string name;
		public string place;

		// public method of base class 
		public void readers(string name, string place)
		{
			this.name = name;
			this.place = place;
			Console.WriteLine("I am: " + name);
			Console.WriteLine("I Belongs to: " + place);
		}
	}

	// inheriting the Inheritance class using : 
	 class Childclass : Inheritance
	{

		// constructor of derived class 
		public Childclass()
		{
			Console.WriteLine("Good Morning! Hava a nice day");
		}
	}

	// Driver class 
	class Mainclass
	{

		// Main Method 
		static void Main(string[] args)
		{

			// creating object of derived class 
			Childclass c = new Childclass();

			// calling the method of base class 
			// using the derived class object 
			c.readers("sameer", "HUBBALLI");
		}
	}
}

