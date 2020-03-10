using System;

namespace Assigment6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number.");
            string inputNum = Console.ReadLine();
            int num1 = Convert.ToInt32(inputNum);
            int num2 = num1 * 50;
            Console.WriteLine(num2);

            Console.WriteLine("Input a number.");
            inputNum = Console.ReadLine();
            int num3 = Convert.ToInt32(inputNum);
            int num4 = num3 + 25;
            Console.WriteLine(num4);

            Console.WriteLine("Input a number.");
            inputNum = Console.ReadLine();
            int num5 = Convert.ToInt32(inputNum);
            float num6 = num1 / 12.5f;
            Console.WriteLine(num6);

            Console.WriteLine("Input a number.");
            inputNum = Console.ReadLine();
            int num7 = Convert.ToInt32(inputNum);
            bool greaterThan = num7 > 50;
            Console.WriteLine(greaterThan);

            Console.WriteLine("Input a number.");
            inputNum = Console.ReadLine();
            int num8 = Convert.ToInt32(inputNum);
            float num9 = num8 % 7;
            Console.WriteLine(num9);
            Console.ReadLine();
        }
    }
}
