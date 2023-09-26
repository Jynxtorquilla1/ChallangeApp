namespace ChallangeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "marks.txt";

        public override event MarkAddedDelegate MarkAdded;

        public EmployeeInFile(string name, string surname) :
            base(name, surname)
        {
        }

        public override void AddMark(float mark)
        {

            if (mark >= 0 && mark <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(mark);
                }
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
            }
        }
       
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        if (float.TryParse(line, out float lineinfloat))
                        {
                            statistics.AddMark(lineinfloat);
                        }
                        else
                        {
                            throw new Exception("file contains invalid value");
                        }

                    }
                    
                }

            }
            return statistics;
        }
    }
}
