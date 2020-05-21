using Lesson7;

namespace Lesson6
{
    internal class BAEmployee : Employee
    {
        public string EnglishLevel { get; private set; }

        public BAEmployee(string first, string last, int age, string english) : base(first, last, age)
        {
            EnglishLevel = english;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} {EnglishLevel}\n";
        }

        public override void Work()
        {
            
        }
    }
}
