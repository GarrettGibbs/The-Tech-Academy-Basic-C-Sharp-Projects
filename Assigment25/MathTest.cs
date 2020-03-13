using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment25
{
    public class MathTest
    {
        public int Value { get; set; }
        public static void Add(int value1, int value2)
        {
            int newValue = value1 + 10;
            Console.WriteLine("The second number you entered was: " + value2);
            Console.ReadLine();
        }
    }
}
