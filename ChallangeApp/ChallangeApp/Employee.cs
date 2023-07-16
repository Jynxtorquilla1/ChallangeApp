namespace ChallangeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        private List<int> mark = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void addMark(int mark)
        {
            this.mark.Add(mark);
        }

        public void removeMark(int mark)
        {
            this.mark.Add(-mark);
        }

        public int Result
        {
            get
            {
                return mark.Sum();
            }

        }
    }
}
