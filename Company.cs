using System.Collections.Generic;
using Lesson6;

namespace Lesson7
{
    internal class Company
    {
        public List<Employee> Employees { get; private set; }
        public string Name { get; private set; }
        public Office Office { get; set; }

        //public delegate void InformationCheck();
        // public delegate int InformationCheck(int information);

        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        
        public string GetCompanyFullInfo()
        {
            var companyFullInfo = $"{Name} {Office.Address}\n{Office.GetTotalOfficeArea()}\nAll Employees:\n";
           
            
            foreach (var employee in Employees)
            {
                companyFullInfo += employee.GetInfo();
            }

            return companyFullInfo;
        }

        public string GetQAEmployees()
        {
            var qaEmployeeInfo = $"QA Employees:\n";

            foreach (var employee in Employees)
            {
                if (employee is ITester)
                {
                    qaEmployeeInfo += (employee as Employee).GetInfo();
                }
            }

            return qaEmployeeInfo;
        }

        public string GetDevEmployees()
        {
            var qaEmployeeInfo = $"Dev Employees:\n";

            foreach (var employee in Employees)
            {
                if (employee is IDeveloper)
                {
                    qaEmployeeInfo += (employee as Employee).GetInfo();
                }
            }

            return qaEmployeeInfo;
        }

        public string GetTaskAssigners()
        {
            var qaEmployeeInfo = $"Task Assigners:\n";

            foreach (var employee in Employees)
            {
                if (employee is ITaskAssigner)
                {
                    qaEmployeeInfo += (employee as Employee).GetInfo();
                }
            }

            return qaEmployeeInfo;
        }

        public void StartWorkingDay()
        {
            foreach (var employee in Employees)
            {
                employee.Work();
            }
        }

        public void AssignTask(string task)
        {
            foreach (var employee in Employees)
            {
                if(employee is ITaskAssigner assigner)
                {
                    foreach (var employeeWithTask in Employees)
                    {
                        if (employeeWithTask.Task == null)
                        {
                            assigner.AssignTask(employeeWithTask, task);
                            break;
                        }
                    }
                }
            }
        }

        public int GetEmployeeStatistics()
        {
            PassportChecker checker = new PassportChecker();
            int count = 0;

            foreach (var employee in Employees)
            {
               if (employee.BringThePassport(checker.CheckPassportNumber))
               {
                    count++;
               }

            }

            return count;
        }


        //public void DoHoliday()
        //{
        //    foreach (var employee in Employees)
        //    {
        //        employee.DoSocialJob();
        //    }
        //}
    }
}
