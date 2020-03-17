using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week:");
            bool tryAgain = false;
            do
            {
                try
                {
                    Weekdays today = (Weekdays)Enum.Parse(typeof(Weekdays), Console.ReadLine());
                    Console.WriteLine("Today is: " + today);
                    tryAgain = false;
                    Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week:");
                    tryAgain = true;
                }
            }
            while (tryAgain == true);
        }
    }
    public enum Weekdays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
