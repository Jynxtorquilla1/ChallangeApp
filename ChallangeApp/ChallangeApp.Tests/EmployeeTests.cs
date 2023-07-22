namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenMarksAreGiven_ShouldReturnCorrectMaxMinAndAvarageValues()
        {
            //arrange

            var employee1 = new Employee("Ferdynand", "Kiepski");
            employee1.addMark(7);
            employee1.addMark(9);
            employee1.addMark(2);
            employee1.addMark(5);
            float avarage = 5.75f;
            
            //act

            var statistics = employee1.GetStatistics();

            //assert

            Assert.AreEqual(9, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(avarage, statistics.Avarage);

        }


    }
}