using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to perform some math operation on:");
            int input = Convert.ToInt32(Console.ReadLine());
            int value1 = MathExample.Add(input);
            Console.WriteLine(Convert.ToString(input) + " plus 10 equals: " + value1);
            int value2 = MathExample.Subtract(input);
            Console.WriteLine(Convert.ToString(input) + " minus 3 equals: " + value2);
            int value3 = MathExample.Multiply(input);
            Console.WriteLine(Convert.ToString(input) + " times 7 equals: " + value3);
            Console.ReadLine();
        }
    }
}
