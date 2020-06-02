using System.Collections.Generic;

namespace Lesson6
{
    class LastNameEmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
