using System.Collections.Generic;

namespace Lesson6
{
    class AgeEmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Age - y.Age;
        }
    }
}
