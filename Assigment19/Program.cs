using System;
using System.Collections.Generic;

namespace Assigment19
{
    class Program
    {
        static void Main()
        {
            //1
            string[] descriptors = { " is a great person!", " is super nice to hang out with!", " is just amazing!" };
            Console.WriteLine("Please type your name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < descriptors.Length; i++)
            {
                descriptors[i] = name + descriptors[i];
            }
            for (int i = 0; i < descriptors.Length; i++)
            {
                Console.WriteLine(descriptors[i]);
            }
            Console.ReadLine();

            //2-4
            Console.WriteLine("Press enter to count to 10:");
            Console.ReadLine();
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x + 1);
                x = x+1;
            }
            Console.ReadLine();

            //5
            Console.WriteLine("Press enter to count to 10 again:");
            Console.ReadLine();
            x = 0;
            while (x <= 9)
            {
                Console.WriteLine(x + 1);
                x = x + 1;
            }
            Console.ReadLine();

            //6-8
            List<string> days = new List<string>() { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
            Console.WriteLine("Please type a day of the week:");
            string dayInput = Console.ReadLine();
            bool test = false;
            restart:
            foreach (string day in days)
            {
                if (day == dayInput.ToUpper())
                {
                    Console.WriteLine("The day you typed is: " + day);
                    test = true;
                    Console.ReadLine();
                    break;
                }
            }
            if (test == false)
            {
                Console.WriteLine("Your input did not match any day of the week. Please try again:");
                dayInput = Console.ReadLine();
                goto restart;
            }

            //9-10
            List<string> pizzaToppings = new List<string>() { "PEPPERONI", "CHEESE", "SAUSAGE", "OLIVE", "JALAPENO", "SALAMI", "OLIVE" };
            Console.WriteLine("Please type a pizza topping to receive the index:");
            string toppingInput = Console.ReadLine();
            bool test2 = false;
            restart2:
            foreach (string topping in pizzaToppings)
            {
                if (topping == toppingInput.ToUpper())
                {
                    Console.WriteLine("The index of the topping you typed is: " + pizzaToppings.IndexOf(topping));
                    if (topping == "OLIVE")
                    {
                        Console.WriteLine("The index of the topping you typed is: " + pizzaToppings.LastIndexOf(topping));
                    }
                    test2 = true;
                    break;
                }
            }
            if (test2 == false)
            {
                Console.WriteLine("Your input did not match any topping we have in our list. Please try again:");
                toppingInput = Console.ReadLine();
                goto restart2;
            }
            Console.ReadLine();

            //11
            List<string> tempToppings = new List<string>();
            bool test3 = false; 
            foreach (string topping in pizzaToppings)
            {
                foreach (string temp in tempToppings)
                {
                    if (temp == topping)
                    {
                        test3 = true;
                    }
                }
                if (test3 == true)
                {
                    Console.WriteLine(topping + ": This topping HAS appeared before.");
                }
                else if (test3 == false)
                {
                    Console.WriteLine(topping + ": This topping has not appeared before.");
                }
                test3 = false;
                tempToppings.Add(topping);
            }
            Console.ReadLine();
        }
    }
}
