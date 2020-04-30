﻿using System;

namespace Lesson7
{
    internal class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PassportNumber { get; private set; }

        public Employee(string first, string last, string number)
        {
            FirstName = first;
            LastName = last;
            PassportNumber = number;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Employee");
        }

    }
}
