using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The Employee Class Hierachy ");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Console.ReadLine();

            Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-23-2322", 9000);
            Console.ReadLine();
        }
    }
}
