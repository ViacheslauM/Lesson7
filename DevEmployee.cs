namespace Lesson6
{
    internal class DevEmployee : Employee, IDeveloper
    {
        public int BugsCreated { get; private set; }

        public DevEmployee(string first, string last, int age, string passportNumber, int bugsCreated) : base(first, last, age, passportNumber)
        {
            BugsCreated = bugsCreated;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()} {BugsCreated}\n";
        }

        public override void Work()
        {
        }

        public int CreateBug(string task)
        {
            var bugsCreated = 0;

            return bugsCreated;
        }
    }
}
