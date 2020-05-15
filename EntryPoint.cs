using System;
using System.Collections.Generic;
using Lesson6;

namespace Lesson7
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>
            {
                new Room(50.5, 24.7),
                new Room(54.8, 20.36)
            };

            Company company = new Company("ISSoft")
            {
                Office = new Office("Gurskogo 44", rooms)
            };
            company.AddEmployee(new BAEmployee("Bob", "Black", "HB4237", "Intermediate"));
            company.AddEmployee(new QAEmployee("Lynda", "Johnson", "AX5422", "Good"));

            Console.WriteLine(company.GetCompanyFullInfo());  

            company.StartWorkingDay();

        }
    }




}
