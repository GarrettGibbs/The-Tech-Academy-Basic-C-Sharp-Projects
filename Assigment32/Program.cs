using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assigment32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number!");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Sample\numberFile.txt", true))
            {
                file.WriteLine(num);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Sample\numberFile.txt"));
            Console.ReadLine();
        }
    }
}
