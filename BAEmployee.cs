using System;
using Lesson7;

namespace Lesson6
{
    class BAEmployee : Employee
    {
        public string EnglishLevel { get; private set; }

        public BAEmployee(string first, string last, string number, string english) : base(first, last, number)
        {
            EnglishLevel = english;
        }
        public override void GetInfo()
        {
            Console.Write(" English:{0}\n", EnglishLevel);
        }
    }
}
