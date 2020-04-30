using System;
using Lesson6;

namespace Lesson7
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            Company company = new Company();

            company.name = "ISSoft";

            company.employees[0] = new DevEmployee("Bob", "Black", "AX5422", 5);
            company.employees[1] = new QAEmployee("Grace", "Robinson", "AA5632", "Good");
            company.employees[2] = new DevEmployee("Sam", "Black", "GG5567", 20);
            company.employees[3] = new BAEmployee("Sonya", "Swanson", "M7689L", "Advanced");
            company.employees[4] = new QAEmployee("Mike", "Journey", "MM9900", "Medium");
            company.employees[5] = new QAEmployee("Lucas", "Burke", "AZ5643", "Bad");
            company.employees[6] = new BAEmployee("Jordan", "Red", "GB4562", "Intermediate");
            company.employees[7] = new BAEmployee("Bella", "Hopkins", "ML0985", "Advanced");
            company.employees[8] = new DevEmployee("Marc", "Mosley", "BS7766", 40);
            company.employees[9] = new DevEmployee("Tia", "Scott", "DO9975", 7);
            
            company.Show();

            Room[] rooms = new Room[2];
            rooms[0] = new Room(50.5, 24.7);
            rooms[1] = new Room(54.8, 21.3);

            Office office = new Office("Gurskogo 44", rooms);

            Console.WriteLine("Office Address: " + office.Address + "\nTotal Office Area: " + office.GetArea());

            Console.ReadKey();
        }
    }




}
