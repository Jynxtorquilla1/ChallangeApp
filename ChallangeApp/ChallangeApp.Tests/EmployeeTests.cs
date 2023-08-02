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

            var statistics = employee1.GetStatisticsWithForeach();

            //assert

            Assert.AreEqual(9, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(avarage, statistics.Avarage);

        }

        [Test]

        public void WhenMarksAreGiven_ThreeDifferentMethodsShouldReturnSameValues()
        {
            //arrange

            var employee1 = new Employee("Ferdynand", "Kiepski");
            employee1.AddMark(7);
            employee1.AddMark(9);
            employee1.AddMark(2);
            employee1.AddMark(5);
            float avarage = 5.75f;

            //act

            var statisticsForeach = employee1.GetStatisticsWithForeach();
            var statisticsFor = employee1.GetStatisticsWithFor();
            var statisticsWhile = employee1.GetStatisticsWithWhile();
            var statisticsDoWhile = employee1.GetStatisticsWithDoWhile();

            List<float> statsForeachTest = new List<float>
            {
                statisticsForeach.Avarage, statisticsForeach.Min, statisticsForeach.Max
            };
            
            List<float> statsForTest = new List<float> 
            {
                statisticsFor.Avarage, statisticsFor.Min, statisticsFor.Max
            };
            
            List<float> statsWhile = new List<float> 
            {
                statisticsWhile.Avarage, statisticsWhile.Min, statisticsWhile.Max 
            };
           
            List<float> statsDoWhile = new List<float>
            { 
                statisticsDoWhile.Avarage, statisticsDoWhile.Min, statisticsDoWhile.Max
            };

            bool ForForeachEquality = statsForeachTest.SequenceEqual(statsForTest);
            bool WhileDoWhileEquality = statsWhile.SequenceEqual(statsDoWhile);
            bool ForWhileEquality = statsWhile.SequenceEqual(statsDoWhile);

            //assert

            Assert.AreEqual(true, ForForeachEquality);
            Assert.AreEqual(true, WhileDoWhileEquality);
            Assert.AreEqual(true, ForWhileEquality);

        }

    }
}