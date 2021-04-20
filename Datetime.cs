using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Datetime
    {

        static public void Main()
        {
            //string simpleTime = "1/1/2000";
            //DateTime time = DateTime.Parse(simpleTime);
            //Console.WriteLine(time);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("M"));
        }
    }
}
