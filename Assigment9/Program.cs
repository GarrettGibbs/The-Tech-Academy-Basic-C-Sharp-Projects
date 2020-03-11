using System;


namespace Assigment9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Program");
            //collect info
            Console.WriteLine("Please give us the following information:");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int applicantAge = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false':");
            string dui = Console.ReadLine();
            bool applicantDui = Convert.ToBoolean(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int applicantTickets = Convert.ToInt32(tickets);
            // determination
            bool qualified = (applicantAge > 15 && applicantDui == false && applicantTickets < 4);
            Console.WriteLine("Qualified for car insurance?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
