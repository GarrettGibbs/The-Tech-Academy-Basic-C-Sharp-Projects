using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 22, 15, 1008, 64, 91 };
            Console.WriteLine("There is a list of numbers already set.");
            Console.WriteLine("Please provide a number to divide each by:");
            bool restart = false;
            do
            {
                try
                {
                    restart = false;
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    foreach (int number in numbers)
                    {
                        int newNum = number / divisor;
                        Console.WriteLine(newNum);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a whole number:");
                    restart = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by 0. Please enter a whole number:");
                    restart = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Please try again:");
                    restart = true;
                }
            } while (restart);
            Console.WriteLine("The program has continued after the try/catch block.");
            Console.ReadLine();
        }
    }
}
