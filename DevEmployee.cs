using System;
using Lesson7;

namespace Lesson6
{
    class DevEmployee : Employee
    {
        public int BugsCreated { get; private set; }

        public DevEmployee(string first, string last, string number, int bugsCreated) : base(first, last, number)
        {
            BugsCreated = bugsCreated;
        }
        public override void GetInfo()
        {
            Console.Write(" Bugs:{0}\n", BugsCreated);
        }

    }
}
