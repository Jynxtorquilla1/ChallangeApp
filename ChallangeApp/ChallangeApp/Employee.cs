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
        
        public void AddMark(float mark)
        {
            if (mark >= 0 && mark < 100)
            {
                this.marks.Add(mark);
            }
            else 
            {
                Console.WriteLine($"{mark} is invalid mark value");
            }
            
        }
        
        public void AddMark(string mark)
        {
            if (float.TryParse(mark, out float result))
            {
                this.AddMark(result);
            }
            else
            {
                Console.WriteLine($"string {mark} is not float ");
            }
        }
                       
        public void AddMark(double mark)
        {
            float doubleInFloat = (float)Math.Round(mark, 2);
            this.AddMark(doubleInFloat);
        }

        public void AddMark(long mark)
        {
            float doubleInLong = (float)mark;
            this.AddMark(doubleInLong);
        }

        public void AddMark(decimal mark)
        {
            float doubleInDecimal = (float)Math.Round(mark, 2);
            this.AddMark(doubleInDecimal);
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
