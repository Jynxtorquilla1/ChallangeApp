namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenMarksAreGiven_ShouldReturnCorrectMaxMinAndAvarageValues()
        {
            //arrange

            var employee1 = new Employee("Ferdynand", "Kiepski");
            employee1.AddMark(7);
            employee1.AddMark(9);
            employee1.AddMark(2);
            employee1.AddMark(5);
            float avarage = 5.75f;

            //act

            var statistics = employee1.GetStatistics();

            //assert

            Assert.AreEqual(9, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(avarage, statistics.Avarage);

        }

        [Test]
        public void WhenMarksAsCharsGiven_ShouldReturnCorrectStatistics()
        {
            //arrange

            var employee1 = new Employee();
            employee1.AddMark('A');
            employee1.AddMark('b');
            employee1.AddMark('C');
            employee1.AddMark('d');
            employee1.AddMark('E');
            

            //act

            var statistics = employee1.GetStatistics();

            //assert

            Assert.AreEqual(60, statistics.Avarage);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);

        }

        [Test]
        public void WhenMarksAreGiven_ShouldReturnCorrectAvarageLetter()
        {
            //arrange

            var employee1 = new Employee();
            employee1.AddMark(70);
            employee1.AddMark('b');
            employee1.AddMark(30);
            employee1.AddMark('d');
            employee1.AddMark(10);


            //act

            var statistics = employee1.GetStatistics();

            //assert

            Assert.AreEqual('C', statistics.AvarageLetter);
           
        }
    }
}