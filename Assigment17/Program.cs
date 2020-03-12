using System;
using System.Collections.Generic;

namespace Assigment17
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Garrett", "Stephanie", "Tommy", "Jesse", "Cole", "Mia" };
            Console.WriteLine("Please select a number between '0' and '5' to get the corresponding name:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool realIndex = false;
            while (!realIndex)
            {
                if (num < 6 && num > -1)
                {
                    Console.WriteLine("The corresponding name is: " + names[num]);
                    realIndex = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please select a number between '0' and '5' to get the corresponding name:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] numbers = { 5, 6, 42, 307, 84, 106 };
            Console.WriteLine("Please select a number between '0' and '5' to get the corresponding number:");
            num = Convert.ToInt32(Console.ReadLine());
            realIndex = false;
            while (!realIndex)
            {
                if (num < 6 && num > -1)
                {
                    Console.WriteLine("The corresponding number is: " + Convert.ToInt32(numbers[num]));
                    realIndex = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please select a number between '0' and '5' to get the corresponding number:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> potato = new List<string>();
            potato.Add("French Fries");
            potato.Add("Chips");
            potato.Add("Baked"); 
            potato.Add("Baked");
            potato.Add("Loaded");

            Console.WriteLine("Please select a number between '0' and '4' to get the corresponding potato:");
            num = Convert.ToInt32(Console.ReadLine());
            realIndex = false;
            while (!realIndex)
            {
                if (num < 5 && num > -1)
                {
                    Console.WriteLine("The corresponding potato is: " + potato[num]);
                    realIndex = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please select a number between '0' and '4' to get the corresponding potato:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
