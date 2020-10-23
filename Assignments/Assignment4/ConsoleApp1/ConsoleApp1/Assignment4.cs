using System;

namespace ConsoleApp1
{
    class Assignment4

    {
        static void Main(string[] args)
        {
            Employee marsWorker = SetupEmployee();
            Display(marsWorker);
        }

        public static Employee SetupEmployee()
        {
            Console.WriteLine("Please enter this Employee's first name");
            string inputFirstName = Console.ReadLine();
            Console.WriteLine("Please enter this Employee's last name");
            string inputLastName = Console.ReadLine();
            Console.WriteLine("Is this employee pay type Salary or Hourly?");
            string inputPayType = Console.ReadLine();
            Console.WriteLine("Please enter this Employee's pay rate: ");
            double inputPayRate = double.Parse(Console.ReadLine());
            Employee marsWorker = new Employee(inputFirstName, inputLastName, inputPayType, inputPayRate);

            return marsWorker;           

        }

        public static void Display(Employee anyWorker)
        {
            Console.WriteLine(anyWorker.ToString());
        }

    }
}
