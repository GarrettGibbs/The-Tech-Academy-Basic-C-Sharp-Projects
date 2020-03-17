using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment28
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test1 = new Employee() { firstName = "Sample", lastName = "Student" };
            test1.SayName();
            Console.ReadLine();
        }
    }
}
