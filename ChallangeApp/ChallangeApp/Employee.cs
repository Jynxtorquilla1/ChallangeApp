using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<float> marks = new List<float>();

        public Employee() 
        {

        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddMark(float mark)
        {
            if (mark >= 0 && mark <= 100)
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
                this.AddMark(result);            }
            
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

        public void AddMark(char mark)
        {
            switch (mark)
            {
                case 'A':
                case 'a':
                    marks.Add(100);
                    break;
                case 'B':
                case 'b':
                    marks.Add(80);
                    break;
                case 'C':
                case 'c':
                    marks.Add(60);
                    break;
                case 'D':
                case 'd':
                    marks.Add(40);
                    break;
                case 'E':
                case 'e':
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

            switch (statistics.Avarage)
            {
                case var avr when statistics.Avarage >= 80:
                    statistics.AvarageLetter = 'A';
                    break;
                case var avr when statistics.Avarage >= 60:
                    statistics.AvarageLetter = 'B';
                    break;
                case var avr when statistics.Avarage >= 40:
                    statistics.AvarageLetter = 'C';
                    break;
                case var avr when statistics.Avarage >= 20:
                    statistics.AvarageLetter = 'D';
                    break;
                default:
                    statistics.AvarageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}