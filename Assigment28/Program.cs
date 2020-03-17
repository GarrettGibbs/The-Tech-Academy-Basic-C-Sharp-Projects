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
            Employee test1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };
            test1.SayName();
            Employee test2 = new Employee() { firstName = "Sample2", lastName = "Student", Id = 2 };
            bool result = test1 == test2;
            Console.ReadLine();

            IQuittable test = new Employee();
            test.Quit();
        }
    }
}
