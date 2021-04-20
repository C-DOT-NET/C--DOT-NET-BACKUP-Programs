using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	 class PrivateSpecifier
	{

		// Member x declared 
		// as protected 
		public string name = "Egg first";

		public PrivateSpecifier()
		{
			name = "Chicken first";
		}
	}

	// class Y inherits the 
	// class X 
	class PublicSpecifier : PrivateSpecifier//adding sealed class to derived class

	{

		// Members of Y can access 'x' 
		 public string getName()
		{
			return name;
		}
	}

	class MainClass
	{

		 static void Main(string[] args)
		{
			PrivateSpecifier obj1 = new PrivateSpecifier();
			PublicSpecifier obj2 = new PublicSpecifier();

			// Displaying the value of x 
			Console.WriteLine("Yes ur right! = {0}", obj2.getName());
		}
	}
}