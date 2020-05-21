namespace Lesson7
{
    internal abstract class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string Task { get; set; }

        public Employee(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName} {Age} {Task}";

        }

        public abstract void Work();
    }
}
