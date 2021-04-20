using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Text
    {

        static void Main(string[] args)
        {
            string file = @"B:\\sameer.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(file).ToList();
            foreach(String line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("Avul Pakir\nsameer is good boy7");
            File.WriteAllLines(file, lines);
            Console.ReadLine();


            string str = File.ReadAllText(file);
            Console.WriteLine(str);


            // To read the entire file at once 



        }
    }
}


//C:\\Users\\user\\Desktop\\sameer.txt