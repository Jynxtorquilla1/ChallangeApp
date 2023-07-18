namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenReferenceTypesAreGiven_ShouldConfirmTheyAreNotEqual()
        {
            //arrange
            var empl1 = GetEmpl("Marian");
            var empl2 = GetEmpl("Marian");

            //act

            //assert
            Assert.AreNotEqual(empl1, empl2);
        }

        private Employee GetEmpl(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void WhenIntValueTypesAreGiven_ShouldConfirmTheyAreEqual()
        {
            //arrange
            int num1 = 2;
            int num2 = 2;

            //act

            //assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void WhenFloatValueTypesAreGiven_ShouldConfirmTheyAreEqual()
        {
            //arrange
            float num1 = 2;
            float num2 = 2;

            //act

            //assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void WhenStringsAreGiven_ShouldConfirmTheyAreEqual()
        {
            //arrange
            string num1 = "3";
            string num2 = "3";

            //act

            //assert
            Assert.AreEqual(num1, num2);
        }

    }
    

    
}
