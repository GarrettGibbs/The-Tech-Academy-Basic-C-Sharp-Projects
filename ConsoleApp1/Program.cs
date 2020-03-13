using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers to have them added together plus 10:");
            Console.WriteLine("First number:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number (note: you can leave this blank and it will default to 5):");
            string value2 = Console.ReadLine();
            int value3 = 0;
            if (string.IsNullOrEmpty(value2))
            {
                value3 = MathTest.Add(value1);
            }
            else
            {
                value3 = MathTest.Add(value1, value2);
            }
            
            Console.WriteLine("The total is: " + value3);
            Console.ReadLine();
        }
    }
}
