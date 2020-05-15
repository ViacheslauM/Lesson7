using Lesson7;

namespace Lesson6
{
    class PMEmployee : Employee, ITaskAssigner
    {
        public PMEmployee(string first, string last, string number, string quality) : base(first, last, number)
        {
           
        }

        public void AssignTask(Employee employee, string task)
        {
            employee.Task = task;
        }

        public void EstimateTask(string task)
        {
        }

        public override void Work()
        {
        }
    }
}
