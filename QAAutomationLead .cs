using Lesson7;

namespace Lesson6
{
    class QAAutomationLead : Employee, IDeveloper, ITester, ITaskAssigner
    {
        public QAAutomationLead(string first, string last, int age, string quality) : base(first, last, age)
        {
        }
        public override void Work()
        {
        }

        public void AssignTask(Employee employee, string task)
        {
            employee.Task = task;
        }

        public void EstimateTask(string task)
        {
        }

        public int CreateBug(string task)
        {
            var bugsCreated = 0;

            return bugsCreated;
        }

        public bool Test(string task)
        {
            bool testResult = false;

            return testResult;
        }
    }
}
