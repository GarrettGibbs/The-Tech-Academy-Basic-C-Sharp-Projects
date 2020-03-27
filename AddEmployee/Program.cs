using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Employee Application");
            Console.Write("\nPlease enter the first name of the new employee: ");
            string fName = Console.ReadLine();
            Console.Write("Please enter the last name of the new employee: ");
            string lName = Console.ReadLine();
            Console.Write("Please enter the phone number of the new employee: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Please enter the department of the new employee: ");
            bool tryAgain = true;
            Department department = Department.Unknown;
            do
            {
                string input = Console.ReadLine().ToLower();
                if (input == "management") { department = Department.Management; tryAgain = false; }
                else if (input == "development") { department = Department.Development; tryAgain = false; }
                else if (input == "qualitycontrol") { department = Department.QualityControl; tryAgain = false; }
                else if (input == "production") { department = Department.Production; tryAgain = false; }
                else if (input == "sales") { department = Department.Sales; tryAgain = false; }
                else
                {
                    Console.WriteLine("Sorry, we did not get that, please enter one of the folowing:");
                    Console.WriteLine("Management, Development, QualityControl, Production, Sales");
                    tryAgain = true;
                }
            } while (tryAgain);
            Employee employee = new Employee()
            {
                FirstName = fName,
                LastName = lName,
                PhoneNumber = phoneNumber,
                Department = department
            };
            using (var db = new EmployeeDB())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            Console.WriteLine("\nWould you like to see a list of all employees?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("\nAll employees in database:");
                using (var db = new EmployeeDB())
                {
                    var query = from b in db.Employees
                                orderby b.FirstName
                                select b;
                    foreach (var person in query)
                    {
                        Console.WriteLine(person.FirstName + " " + person.LastName);
                    }
                }
            }
            Console.WriteLine("\n\nThanks so much for visiting our app! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
