namespace NunitTestNameSpace
{
    [TestFixture]
    public class TestsClass
    {
        int randomInt;

        [OneTimeSetUp]
        public void SetupForClass()
        {
            var random= new Random();
            randomInt=random.Next(0,4);
        }
        [SetUp]
        public void SetupForEachMetods()
        {
            var random = new Random();
            randomInt = random.Next(0, 4);
        }
        [Retry(2)]
        [Test]
        public void Summ()
        {
            //var
            var operand1 = 1;
            var operand2 = 2;
            var results = 3;

            //Action
            var actualResult= operand1+ operand2;

            //Assert
            //Assert.AreEqual(results, actualResult, $"Fail");
            Assert.AreEqual(results,actualResult,$"Summ{operand1}+{operand2}={actualResult}");
            Assert.True(actualResult == results, $"Results");
        }
        [Test]
        public void Collection()
        { //var
            var tooMucNumber = new[] { 1, 2, 3 ,4};
            var lessNumber = new[] { 1, 2, 3 };
            //Assert
            CollectionAssert.DoesNotContain(lessNumber, tooMucNumber);
        }

            [TearDown]

        public void TearDown()
        {

        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }

    }
}