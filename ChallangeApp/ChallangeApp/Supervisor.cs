
namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> marks = new List<float>();
        // po znaku = można uteż użyć skrótu new()

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddMark(float mark)
        {
            if (mark >= 0 && mark <= 100)
            {
                marks.Add(mark);
            }
            else
            {
                throw new Exception("invalid mark value");
            }

        }     

        public void AddMark(string mark)
        {
            switch (mark)
            {
                case "6":               
                    AddMark(100f);
                    break;
                case "5":                
                    AddMark(80f);
                    break;
                case "4":                
                    AddMark(60f);
                    break;
                case "3":                
                    AddMark(40f);
                    break;
                case "3-":
                case "-3":
                    AddMark(35f);
                    break;
                case "2+":
                case "+2":
                    AddMark(35f);
                    break;
                case "2":                
                    AddMark(20f);
                    break;
                case "1":                
                    AddMark(0);
                    break;
                default:
                    throw new Exception($" charakter {mark} is not a valid mark");                  
            }
        }

        public void AddMark(char mark)
        {
            throw new NotImplementedException();
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
