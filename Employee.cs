namespace Lesson6
{
    abstract class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string PassportNumber { get; private set; }
        public string Task { get; set; }

        //public delegate void SocialActivity();
        public delegate bool InformationCheck(string text);

        //public SocialActivity MyActivity { get; set; }

        public Employee(string first, string last, int age, string passportNumber)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            PassportNumber = passportNumber;
        }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} {Age} {PassportNumber} {Task}";

        }

        public abstract void Work();

        //public void DoSocialJob()
        //{
        //    MyActivity?.Invoke();
        //}

        public bool BringThePassport(InformationCheck check)
        {
            return check.Invoke(this.PassportNumber);
        }

    }
}
