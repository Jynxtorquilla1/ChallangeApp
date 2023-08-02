using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

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

        public Statistics GetStatisticsWithForeach()
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

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var index = 0; index < marks.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, marks[index]);
                statistics.Min = Math.Min(statistics.Min, marks[index]);
                statistics.Avarage += marks[index];
            }
            statistics.Avarage /= marks.Count;
            return statistics;
        }


        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.marks.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.marks[index]);
                statistics.Min = Math.Min(statistics.Min, this.marks[index]);
                statistics.Avarage += this.marks[index];
                index++;
            }
            statistics.Avarage /= marks.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.marks[index]);
                statistics.Min = Math.Min(statistics.Min, this.marks[index]);
                statistics.Avarage += this.marks[index];
                index++;
            } while (index < this.marks.Count);

            statistics.Avarage /= marks.Count;
            return statistics;
        }
    }
}
