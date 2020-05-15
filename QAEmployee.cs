using System;
using Lesson7;

namespace Lesson6
{
    class QAEmployee : Employee
    {
        public string Quality { get; private set; }
        
        public QAEmployee(string first, string last, string number, string quality) : base(first, last, number)
        {
            Quality = quality;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} {Quality}\n";
        }

        public override void Work()
        {
          
        }
    }
}
