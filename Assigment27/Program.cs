using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment27
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            example1.SayName();
            Console.ReadLine();
        }
    }
}
