using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment25
{
    class Program
    {
        static void Main(string[] args)
        {
            MathTest test = new MathTest();
            Console.WriteLine("Please input two whole numbers:");
            Console.WriteLine("First number:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            int value2 = Convert.ToInt32(Console.ReadLine());
            MathTest.Add(value1: value1, value2: value2);
        }
    }
}
