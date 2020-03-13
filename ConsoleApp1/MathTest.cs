using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment24
{
    public class MathTest
    {
        public int Value { get; set; }
        public static int Add(int value1, string value2 = "5")
        {
            int value3 = Convert.ToInt32(value2);
            int newValue = value1 + value3 + 10;
            return newValue;
        }
    }
}
