using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddMark(float mark);

        void AddMark(string mark);

        void AddMark(char mark);

        Statistics GetStatistics();

        event MarkAddedDelegate MarkAdded;

    }

}
