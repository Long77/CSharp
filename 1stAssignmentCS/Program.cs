using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcs1
{
    class Program
    {
        static void Main()
        {
            string name1 = "Hello World!";
            int year1 = 1492;
            bool ifdog = false;
            string date = "10/4/2016";
            char letter = 'X';
            float price = 5.45f;

            Console.WriteLine("{0}", name1);

            Console.WriteLine("Columbus Sailed the world in {0}", year1);

            Console.WriteLine("It is {0} that I have a dog at home, but we will get one soon!", ifdog);

            Console.WriteLine("Today is {0}.", date);

            Console.WriteLine("I spent {0} on a Cheeseburger.", price);

            Console.WriteLine("{0} marks the Spot.", letter);
            Console.ReadLine();

        }
    }
}
