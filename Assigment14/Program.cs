using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment14
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Garrett";
            //string quote = "The man said \"Hello\", Garrett. \n Hello on a new line \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Garrett";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Garrett.");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
