using System;
using System.Collections.Generic;
using Lesson6;

namespace Lesson7
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new BAEmployee("Bob", "Black", "AX5422", "Intermediate"),
                new QAEmployee("Bob", "Black", "AX5422", "Good"),
                new DevEmployee("Bob", "Black", "AX5422", 10)
            };
            List<Room> rooms = new List<Room>
            {
                new Room(50.5, 24.7),
                new Room(54.8, 20.36)
            };

            Company company = new Company("ISSoft", employees)
            {
                Office = new Office("Gurskogo 44", rooms)
            };

            Console.WriteLine(company.GetCompanyFullInfo());  

        }
    }




}
