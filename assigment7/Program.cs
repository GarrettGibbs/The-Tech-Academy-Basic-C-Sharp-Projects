using System;

namespace assigment7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //collect data 1
            Console.WriteLine("Person 1:");
            Console.WriteLine("Please type the hourly pay rate of the first person:");
            string hourlyRate = Console.ReadLine();
            decimal hourlyRateP1 = Convert.ToDecimal(hourlyRate);
            Console.WriteLine("Please type the hours worked per week of the first person:");
            string hoursWorked = Console.ReadLine();
            int hoursWorkedP1 = Convert.ToInt32(hoursWorked);
            //collect data 2
            Console.WriteLine("Person 2:");
            Console.WriteLine("Please type the hourly pay rate of the second person:");
            hourlyRate = Console.ReadLine();
            decimal hourlyRateP2 = Convert.ToDecimal(hourlyRate);
            Console.WriteLine("Please type the hours worked per week of the second person:");
            hoursWorked = Console.ReadLine();
            int hoursWorkedP2 = Convert.ToInt32(hoursWorked);
            //get yearly salaries
            decimal annualSalaryP1 = (hoursWorkedP1 * hourlyRateP1) * 52;
            decimal annualSalaryP2 = (hoursWorkedP2 * hourlyRateP2) * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalaryP1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalaryP2);
            //compare the two salaries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool answer = annualSalaryP1 > annualSalaryP2;
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
