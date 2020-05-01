using System;

namespace Lesson7
{
    internal class Company
    {
        public Employee[] Employees { get; private set; } = new Employee[10];
        public string Name { get; set; }
        
        public void Show()
        {
            Console.WriteLine("Company: {0}", Name);

            foreach (var employee in Employees)
            {
                Console.Write("First Name:{0} Last Name:{1} Passport:{2}" + employee.GetInfo(), 
                                    employee.FirstName, employee.LastName, employee.PassportNumber);
            }
        }
    }
}
