using System.Collections.Generic;
using Lesson7;

namespace Lesson6
{
    class FirstNameEmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}
