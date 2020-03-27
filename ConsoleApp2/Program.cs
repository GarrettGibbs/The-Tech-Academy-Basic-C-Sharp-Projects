using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1())
            {
                Console.WriteLine("Enter new students name:");
                string sName = Console.ReadLine();
                Student student1 = new Student() { FirstMidName = sName };
                db.Students.Add(student1);
                db.SaveChanges();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
