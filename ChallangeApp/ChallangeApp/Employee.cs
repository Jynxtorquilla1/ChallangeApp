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
                marks.Add(mark);
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

        //public void AddMark (char mark)
        //{
        //    if (mark == 'A' || mark== 'a')
        //    {
        //        marks.Add(100);
        //    }
        //    else if (mark== 'B'|| mark == 'b')
        //    {
        //        marks.Add(80);
        //    }
        //}
        public void AddMark(char mark)
        {
            switch (mark)
            {
                case 'A':
                    marks.Add(100);
                    break;
                case 'B':
                    marks.Add(80);
                    break;
                case 'C':
                    marks.Add(60);
                    break;
                case 'D':
                    marks.Add(40);
                    break;
                case 'E':
                    marks.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong character");
                    marks.Add(0);
                    break;
            }
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