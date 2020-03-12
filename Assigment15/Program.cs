using System;
using System.Text;

namespace Assigment15
{
    class Program
    {
        static void Main()
        {
            string first = "Hello, my ";
            string second = "name is ";
            string third = "Garrett.";

            Console.WriteLine(first + second + third);
            Console.ReadLine();

            Console.WriteLine(third.ToUpper());
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("Hello, how are you today?");
            paragraph.Append("\nI hope you are doing well.");
            paragraph.Append("\nI am having a lot of fun!");

            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
