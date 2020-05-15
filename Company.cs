using System;
using System.Collections.Generic;
using Lesson6;

namespace Lesson7
{
    internal class Company
    {
        public List<Employee> Employees { get; private set; }
        public string Name { get; private set; }
        public Office Office { get; set; }

        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            //Office = new Office();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        
        public string GetCompanyFullInfo()
        {
            var companyFullInfo = $"{Name} {Office.Address} Total area: {Office.GetArea()}\n";
            
            foreach (var employee in Employees)
            {
                companyFullInfo += employee.GetInfo();
            }

            return companyFullInfo;
        }

        public void StartWorkingDay()
        {
            foreach (var employee in Employees)
            {
                employee.Work();
            }
        }

        public void AssignTask(string task)//(Employee employeeToAssignTask, string task)
        {
            foreach (var employee in Employees)
            {
                if(employee is ITaskAssigner assigner)
                {
                    assigner.AssignTask(task); //(employeeToAssignTask, task);
                }
            }
        }
    }
}
