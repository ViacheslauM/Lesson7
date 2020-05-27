using Lesson7;

namespace Lesson6
{
    internal class PMEmployee : Employee, ITaskAssigner
    {
        public PMEmployee(string first, string last, int age, string passportNumber) : base(first, last, age, passportNumber)
        {
        }

        public void AssignTask(Employee employee, string task)
        {
            employee.Task = task;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}\n";
        }

        public void EstimateTask(string task)
        {
        }

        public override void Work()
        {
        }
    }
}
