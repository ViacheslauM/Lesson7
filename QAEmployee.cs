using Lesson7;

namespace Lesson6
{
    internal class QAEmployee : Employee, ITester
    {
        public string Quality { get; private set; }
        
        public QAEmployee(string first, string last, int age, string passportNumber, string quality) : base(first, last, age,passportNumber)
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

        public bool Test(string task)
        {
            bool testResult = false;

            return testResult;
        }
    }
}
