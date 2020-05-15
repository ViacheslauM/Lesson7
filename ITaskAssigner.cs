using Lesson7;

namespace Lesson6
{
    interface ITaskAssigner
    {
        void AssignTask(Employee employee, string task);
        void EstimateTask(string task);

    }
}
