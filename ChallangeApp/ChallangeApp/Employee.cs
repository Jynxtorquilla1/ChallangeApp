using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ChallangeApp
{
    public class Employee
    {
        public readonly char sex = 'M';
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
            this.sex = 'K';
        }

        public void AddMark(float mark)
        {
            if (mark >= 0 && mark <= 100)
            {
                marks.Add(mark);
            }
            else
            {
                throw new Exception($"{mark} is invalid mark value");
            }

        }

        public void AddMark(string mark)
        {
            if (float.TryParse(mark, out float result))
            {
                this.AddMark(result);               
            }
            else if (mark.Length==1)
            {
                char.TryParse(mark, out char CharResult);
                this.AddMark(CharResult);
            }            
            else
            {
                throw new Exception($"string {mark} is not float");
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
                    AddMark(100);
                    break;
                case 'B':
                case 'b':
                    AddMark(80);
                    break;
                case 'C':
                case 'c':
                    AddMark(60);
                    break;
                case 'D':
                case 'd':
                    AddMark(40);
                    break;
                case 'E':
                case 'e':
                    AddMark(20);
                    break;
                default:
                    throw new Exception($" charakter {mark} is not a valid mark");
                    //marks.Add(0);
                    //break;
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