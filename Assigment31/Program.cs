using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment31
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Joe", LastName = "Smith", Id = 1 };
            Employee employee2 = new Employee() { firstName = "Jack", LastName = "Murcer", Id = 2 };
            Employee employee3 = new Employee() { firstName = "Jack", LastName = "Ryan", Id = 3 };
            Employee employee4 = new Employee() { firstName = "Joe", LastName = "Zimmerman", Id = 4 };
            Employee employee5 = new Employee() { firstName = "Sarah", LastName = "Aldred", Id = 5 };
            Employee employee6 = new Employee() { firstName = "Kristy", LastName = "Allen", Id = 6 };
            Employee employee7 = new Employee() { firstName = "Joe", LastName = "Conrad", Id = 7 };
            Employee employee8 = new Employee() { firstName = "Kelly", LastName = "Rhine", Id = 8 };
            Employee employee9 = new Employee() { firstName = "Maggie", LastName = "Clarckson", Id = 9 };
            Employee employee10 = new Employee() { firstName = "Becca", LastName = "Smith", Id = 10 };

            List<Employee> employees = new List<Employee>()
            { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10};
            //List<Employee> joeList = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        joeList.Add(employee);
            //    }
            //}

            List<Employee> joeList = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> newList = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.firstName + " " + employee.LastName);
            }
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName + " " + employee.LastName + " ID: " + employee.Id);
            }
            Console.ReadLine();
        }
    }
}
