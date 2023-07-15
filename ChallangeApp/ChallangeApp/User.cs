namespace ChallangeApp
{
    class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void addScore(int score)
        {
            this.score.Add(score);
        }

        public int Result
        {
            get
            {
                return score.Sum();
            }

        }
    }
}
