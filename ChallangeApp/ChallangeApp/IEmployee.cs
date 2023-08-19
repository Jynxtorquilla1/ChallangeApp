namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

   
        Statistics GetStatistics();

        void AddMark(float mark);

        void AddMark(string mark);

        void AddMark(char mark);


    }
}
