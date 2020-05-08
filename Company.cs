using System;
using System.Collections.Generic;

namespace Lesson7
{
    internal class Company
    {
        public List<Employee> Employees;
        public string Name { get; private set; }

        public Office Office { get; set; }

        public Company(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
        
        public string GetCompanyFullInfo()
        {
            string companyFullInfo = $"{Name} {Office.Address} Total area: {Office.GetArea()}\n";
            
            foreach (var employee in Employees)
            {
                companyFullInfo = companyFullInfo + employee.GetInfo();
            }

            return companyFullInfo;
        }
    }
}
