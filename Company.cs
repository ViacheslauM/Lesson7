using System;

namespace Lesson7
{
    internal class Company
    {
        public Employee[] employees = new Employee[10];
        public string name { get; set; }
        
        public void Show()
        {
            Console.WriteLine("Company: {0}", name);

            foreach (var employee in employees)
            {
                Console.WriteLine("First Name:{0} Last Name:{1} Passport:{2}", 
                                    employee.FirstName, employee.LastName, employee.PassportNumber);
            }
        }
    }
}
