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
            List<double> grades = new List<double>() { 32.323, 54.23 };
            grades.Add(32.323);
            //for(int i=0; i < passtimers.Length - 1; i++)
            //{
            //    Console.WriteLine(passtimers[i]);
            //}

            foreach(string passtimer in passtimers)
            {
                Console.WriteLine(passtimer);
            }

            // get average grade

            Console.WriteLine(ComputeAverageGrade(grades));

            Book book = new Book("Simple Book", 1970, new List<string>());
            book.AddAuthor("Mr. Duke");
            book.PrintAuthors();
        }

        public static double ComputeAverageGrade(List<double> grades)
        {
            double total = 0, average;
            foreach (double grade in grades)
            {
                total += grade;
            }
            average = total / grades.Count;
            return average;
        }
    }
}
