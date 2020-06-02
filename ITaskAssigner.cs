namespace Lesson6
{
    internal interface ITaskAssigner
    {
        void AssignTask(Employee employee, string task);
        void EstimateTask(string task);

    }
}
