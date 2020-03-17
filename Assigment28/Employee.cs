using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment28
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("The employee's name is:");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("This employee has quit.");
            Console.ReadLine();
        }
        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool isTrue = true;
            if (employee1.Id == employee2.Id)
            {
                return isTrue;
            }
            else
            {
                isTrue = false;
                return isTrue;
            }
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool isTrue = true;
            if (employee1.Id == employee2.Id)
            {
                isTrue = false;
                return isTrue;
            }
            else
            {
                return isTrue;
            }
        }
    }
}
