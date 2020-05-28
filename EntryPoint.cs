using System;
using Lesson6;

namespace Lesson7
{
    internal class EntryPoint
    {

        private static void Main(string[] args)
        {

        var company = new Company("ISSoft")
            {
                Office = new Office("Gurskogo 44")
            };
            company.Office.AddRoom(new Room(20.2, 16.9));
            company.Office.AddRoom(new Room(10.0, 11.4));
            company.Office.AddRoom(new Room(15.5, 18.9));
            

            company.AddEmployee(new BAEmployee("Lynda", "Black", 31, "XM1767", "Intermediate"));
            company.AddEmployee(new QAEmployee("Bob", "Johnson", 25, "AP9187", "Good"));
            company.AddEmployee(new DevEmployee("Max", "Payne", 42, "FR72634", 10));
            company.AddEmployee(new PMEmployee("Jack", "Dow", 30, "M1517"));

            //company.Employees[0].MyActivity = PrepareBalloons;
            //company.Employees[1].MyActivity = PrepareCups;
            //company.Employees[2].MyActivity = PrepareFlowers;

            company.AssignTask("NewTask");
            company.AssignTask("NewTask1");
            company.AssignTask("NewTask2");

            company.Employees.Sort(new AgeEmployeeComparer());
            company.Office.Rooms.Sort(new RoomComparer());

            //company.StartWorkingDay();

            //company.DoHoliday();

            Console.WriteLine(company.GetCompanyFullInfo());

            Console.WriteLine(company.GetQAEmployees());
            Console.WriteLine(company.GetDevEmployees());
            Console.WriteLine(company.GetTaskAssigners());

            Console.WriteLine($"Employees with the \"1\" letter in Passport: {company.GetEmployeePassportStatistics()}");

        }

        //static void PrepareBalloons()
        //{
        //    Console.WriteLine("Balloons are prepared");
        //}
        //static void PrepareCups()
        //{
        //    Console.WriteLine("Cups are prepared");
        //}
        //static void PrepareFlowers()
        //{
        //    Console.WriteLine("Flowers are prepared");
        //}

    }
}
