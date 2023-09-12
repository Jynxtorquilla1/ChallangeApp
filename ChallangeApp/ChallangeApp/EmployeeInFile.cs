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

        private List<float> MarksToList(string fileName)
        {
            var listedMarks = new List<float>();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        if (float.TryParse(line, out float lineInFloat))
                        {
                            listedMarks.Add(lineInFloat);
                        }
                        else
                        {
                            throw new Exception("file contains invalid value");
                        }

                    }
                }

            }
            return listedMarks;
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            var listedMarks = MarksToList(fileName);

            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var mark in listedMarks)
            {
                statistics.Max = Math.Max(statistics.Max, mark);
                statistics.Min = Math.Min(statistics.Min, mark);
                statistics.Avarage += mark;
            }
            statistics.Avarage /= listedMarks.Count;
            statistics.Num = listedMarks.Count;



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
