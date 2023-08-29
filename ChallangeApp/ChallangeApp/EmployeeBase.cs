namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        //public virtual void SayHello() 
        //{
        //    Console.WriteLine($"Hello {Name}");
        //}

        public abstract void AddMark(float mark);

        public abstract void AddMark(string mark);

        public abstract void AddMark(char mark);

        public abstract Statistics GetStatistics();
    }
}
