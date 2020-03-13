using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment22
{
    public class MathExample
    {
        public int Value { get; set; }
        public static int Add(int value)
        {
            int newValue = value + 10;
            return newValue;
        }
        public static int Subtract(int value)
        {
            int newValue = value - 3;
            return newValue;
        }
        public static int Multiply(int value)
        {
            int newValue = value * 7;
            return newValue;
        }
    }
}
