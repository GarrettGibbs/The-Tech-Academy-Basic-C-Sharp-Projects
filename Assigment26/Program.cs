using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a whole number:");
            string input = Console.ReadLine();
            Test.Half(input);

            Console.WriteLine("Now input a number to double it:");
            input = Console.ReadLine();
            if (input.Contains("."))
            {
                decimal output = Convert.ToDecimal(input);
                Console.WriteLine("The number you typed times 2: " + Test.Double(output));
            }
            else
            {
                int output = Convert.ToInt32(input);
                Console.WriteLine("The number you typed times 2: " + Test.Double(output));
            }
            Console.ReadLine();
        }
    }
}
