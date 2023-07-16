namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectsScores_ShouldReturnCorrectSum_Positives()

        {
            var empl = new Employee("Jaros³aw", "Psikuta", 29);
            empl.addMark(7);
            empl.addMark(9);
            empl.addMark(21);


            var result = empl.Result;

            Assert.AreEqual(37, result);
        }

        [Test]
        public void WhenEmployeeCollectsScores_ShouldReturnCorrectSum_Negatives()

        {
            var empl = new Employee("Jaros³aw", "Psikuta", 29);
            empl.removeMark(13);
            empl.removeMark(2);
            empl.addMark(-12);

            var result = empl.Result;

            Assert.AreEqual(-27, result);
        }
        [Test]
        public void WhenUserCollectsScores_ShouldReturnCorrectSum_Both()

        {
            var empl = new Employee("Jaros³aw", "Psikuta", 29);
            empl.addMark(7);
            empl.addMark(9);
            empl.removeMark(13);
            empl.removeMark(2);
            empl.addMark(21);
            empl.addMark(-12);

            var result = empl.Result;

            Assert.AreEqual(10, result);

        }

    }
}