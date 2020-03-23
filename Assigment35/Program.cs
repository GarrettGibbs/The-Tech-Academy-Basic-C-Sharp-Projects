using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your age:");
            bool restart = false;
            int age = 0;
            do
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new ZeroOrNegativeException();
                    }
                    restart = false;
                }
                catch (ZeroOrNegativeException)
                {
                    Console.WriteLine("Please type a number above zero:");
                    restart = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, something went wrong, please try again:");
                    restart = true;
                }
            } while (restart);
            age = age * -1;
            DateTime today = DateTime.Now;
            DateTime birthYear = today.AddYears(age); 
            Console.WriteLine("You were born in " + birthYear.Year);
            Console.ReadLine();
        }
    }
}
