using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type number to have 10 added to it:");
            int input = Convert.ToInt32(Console.ReadLine());
            int value1 = MathStuffs.Add(input);
            Console.WriteLine(input + " plus 10 equals: " + value1);

            Console.WriteLine("Please type number with a decimal to have 10 added to it and the remainder removed:");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            int value2 = MathStuffs.Add(input2);
            Console.WriteLine(input2 + " plus 10 with the remainder removed equals: " + value2);

            Console.WriteLine("Please type another number to have 10 added to it:");
            string input3 = Console.ReadLine();
            int value3 = MathStuffs.Add(input3);
            Console.WriteLine(input3 + " plus 10 equals: " + value3);

            Console.ReadLine();
        }
    }
}
