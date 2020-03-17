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
            Employee<string> test1 = new Employee<string>();
            test1.Things = new List<string>();
            test1.Things.Add("Blue");
            test1.Things.Add("Green");
            test1.Things.Add("Red");

            Employee<int> test2 = new Employee<int>();
            test2.Things = new List<int>();
            test2.Things.Add(6);
            test2.Things.Add(15);
            test2.Things.Add(20);

            foreach (string color in test1.Things)
            {
                Console.WriteLine(color);
            }
            foreach (int number in test2.Things)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();

            //Employee test1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 1 };
            //test1.SayName();
            //Employee test2 = new Employee() { firstName = "Sample2", lastName = "Student", Id = 2 };
            //bool result = test1 == test2;
            //Console.ReadLine();

            //IQuittable test = new Employee();
            //test.Quit();
        }
    }
}
