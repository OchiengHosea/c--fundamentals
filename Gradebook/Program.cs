using System;
using System.Collections.Generic;
namespace Gradebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x = 3.434;
            double y = 20.545;
            Console.WriteLine(x + y);

            string[] passtimers = {"Music", "Movies", "Cards", "Checkers"};
            List<double> grades = new() { 32.323, 54.23 };
            grades.Add(32.323);
            //for(int i=0; i < passtimers.Length - 1; i++)
            //{
            //    Console.WriteLine(passtimers[i]);
            //}

            foreach(string passtimer in passtimers)
            {
                Console.WriteLine(passtimer);
            }
        }
    }
}
