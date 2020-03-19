using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment34
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Garrett";
            var foodExample = "potato";
            Console.WriteLine("{0} likes {1}s", myName, foodExample);
            var math1 = new Maths(15);
            Console.WriteLine(math1.Result);
            Console.ReadLine();
        }
    }
}
