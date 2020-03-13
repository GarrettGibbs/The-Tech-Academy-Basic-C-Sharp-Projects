using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment23
{
    class MathStuffs
    {
        public int Value { get; set; }
        public static int Add(int value)
        {
            int newValue = value + 10;
            return newValue;
        }
        public static int Add(decimal value)
        {
            decimal newValue = value + 10;
            int newValue1 = Convert.ToInt32(newValue);
            return newValue1;
        }
        public static int Add(string value)
        {
            int newValue = Convert.ToInt32(value);
            newValue = newValue + 10;
            return newValue;
        }
    }
}
