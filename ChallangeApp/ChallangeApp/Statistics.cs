
namespace ChallangeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Avarage { get
            {
                return this.Sum / this.Count;
            }
        }

        public char AvarageLetter
        {
            get
            {
                switch (this.Avarage)
                {
                    case var avr when Avarage >= 80:
                        return 'A';                       
                    case var avr when Avarage >= 60:
                        return 'B';
                    case var avr when Avarage >= 40:
                        return 'C';
                    case var avr when Avarage >= 20:
                        return 'D';
                    default:
                        return 'E';
                        
                }
           
            }
        }
        public float Sum { get; private set; }

        public int Count { get; private set; } // poparwić w klasach Employee...

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
            
        }
        public void AddMark(float mark)
        {
            this.Count++;
            this.Sum += mark;
            this.Min = Math.Min(mark, this.Min);
            this.Max = Math.Max(mark, this.Max);
        }
    }
}