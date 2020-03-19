using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please input a number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((DateTime.Now.AddHours(hours)));
            Console.ReadLine();
        }
    }
}
