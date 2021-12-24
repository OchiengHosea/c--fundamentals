using System;

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
