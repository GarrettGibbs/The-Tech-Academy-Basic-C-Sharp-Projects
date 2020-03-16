using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment26
{
    public class Test
    {
        public int Num { get; set; }

        public static void Half(string input)
        {
            int num = Convert.ToInt32(input);
            float newNum = num / 2f;
            Console.WriteLine("The number you typed divided by 2 is: " + newNum);
            Console.ReadLine();
        }
        public static int Double(int input)
        {
            int newNum = input * 2;
            return newNum;
        }
        public static decimal Double(decimal input)
        {
            decimal newNum = input * 2;
            return newNum;
        }
    }
}
