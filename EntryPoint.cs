using System;

namespace Lesson7
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            Company company = new Company();

            company.name = "ISSoft";

            company.employees[0] = new Employee("Grace", "Robinson", "AA5632");
            company.employees[1] = new Employee("Bob", "Morley", "5632D");
            company.employees[2] = new Employee("Sam", "Black", "GG5567");
            company.employees[3] = new Employee("Sonya", "Swanson", "M7689L");
            company.employees[4] = new Employee("Mike", "Journey", "MM9900");
            company.employees[5] = new Employee("Lucas", "Burke", "AZ5643");
            company.employees[6] = new Employee("Jordan", "Red", "GB4562");
            company.employees[7] = new Employee("Bella", "Hopkins", "ML0985");
            company.employees[8] = new Employee("Marc", "Mosley", "BS7766");
            company.employees[9] = new Employee("Tia", "Scott", "DO9975");
            
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
