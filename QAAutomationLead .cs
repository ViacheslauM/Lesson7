namespace Lesson6
{
    class QAAutomationLead : Employee, IDeveloper, ITester, ITaskAssigner
    {
        public QAAutomationLead(string first, string last, int age, string passportNumber, string quality) : base(first, last, age, passportNumber)
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
