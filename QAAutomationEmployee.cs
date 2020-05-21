using Lesson7;

namespace Lesson6
{
    internal class QAAutomationEmployee : Employee, ITester, IDeveloper
    {
        public QAAutomationEmployee(string first, string last, int age, string quality) : base(first, last, age)
        {
        }

        public int CreateBug(string task)
        {
            var bugsCreated = 0;

            return bugsCreated;
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
