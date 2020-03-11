using System;

namespace Assigment13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type the number corresponding to the correct answer:");
            Console.WriteLine("What color is the sky?");
            Console.WriteLine("1: Green");
            Console.WriteLine("2: Purple");
            Console.WriteLine("3: Blue");
            Console.WriteLine("4: Red");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("You answered GREEN. That is incorrect, please try again.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You answered PURPLE. That is incorrect, please try again.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You answered BLUE. That is correct! Good Job!");
                        isGuessed = true;
                        Console.Read();
                        break;
                    case 4:
                        Console.WriteLine("You answered RED. That is incorrect, please try again.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please answer '1','2','3' or '4'.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();

            Console.WriteLine("Press Enter to Count to 10!");
            Console.ReadLine();

            int count = 0;

            while (count < 10)
            {
                Console.WriteLine(count + 1);
                count++;
            }
            Console.ReadLine();
        }
    }
}
