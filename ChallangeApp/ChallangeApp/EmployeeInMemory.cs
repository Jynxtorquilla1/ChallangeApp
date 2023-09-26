namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event MarkAddedDelegate MarkAdded;
        public EmployeeInMemory(string name, string surname) :base(name, surname)
        {            
        }
                   
        private List<float> marks = new();

        public override void AddMark(float mark)
        {
            if (mark >= 0 && mark <= 100)
            {
                marks.Add(mark);

                if (MarkAdded != null)
                {
                    MarkAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid mark value");
            }
        }

        public override void AddMark(string mark)
        {
            if (float.TryParse(mark, out float result))
            {
                this.AddMark(result);
            }
            else if (char.TryParse(mark, out char CharResult))
            {
                this.AddMark(CharResult);
            }
            else
            {
                throw new Exception($"string {mark} is not float");
            }
        }

        public override void AddMark(char mark)
        {
            switch (mark)
            {
                case 'A':
                case 'a':
                    AddMark(100f);
                    break;
                case 'B':
                case 'b':
                    AddMark(80f);
                    break;
                case 'C':
                case 'c':
                    AddMark(60f);
                    break;
                case 'D':
                case 'd':
                    AddMark(40f);
                    break;
                case 'E':
                case 'e':
                    AddMark(20f);
                    break;
                default:
                    throw new Exception($" charakter {mark} is not a valid mark");
                    //marks.Add(0);
                    //break; <- nie trzeba używać gdy jest throw new Exception
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

           foreach (var mark in this.marks)
            {
                statistics.AddMark(mark);
            }

            return statistics;
        }
    }    
}
