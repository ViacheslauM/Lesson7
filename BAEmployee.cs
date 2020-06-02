namespace Lesson6
{
    internal class BAEmployee : Employee
    {
        public string EnglishLevel { get; private set; }

        public BAEmployee(string first, string last, int age, string passportNumber, string english) : base(first, last, age, passportNumber)
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
