namespace ChallangeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<float> marks = new List<float>();

        public Employee(string name, string surname)
        { 
            this.Name = name;
            this.Surname = surname;
        }


        public void addMark(float mark)
        {
            this.marks.Add(mark);
        }

        public void removeMark(float mark)
        {
            this.marks.Add(-mark);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var mark in this.marks)
            {
                statistics.Max = Math.Max(statistics.Max, mark);
                statistics.Min = Math.Min(statistics.Min, mark);
                statistics.Avarage += mark;
            }

            statistics.Avarage /= this.marks.Count;


            return statistics;
        }

    }
}
