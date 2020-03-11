using System;

namespace Assigment11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight in pounds of the package you wish to ship?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("What is the width in inches of the package you wish to ship?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height in inches of the package you wish to ship?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length in inches of the package you wish to ship?");
            int length = Convert.ToInt32(Console.ReadLine());
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int quote = (width * weight * height * length) / 100;
            Console.WriteLine("The estimated total for shipping this package is: $" + Convert.ToString(quote) + ".00");
            Console.ReadLine();

        }
    }
}
