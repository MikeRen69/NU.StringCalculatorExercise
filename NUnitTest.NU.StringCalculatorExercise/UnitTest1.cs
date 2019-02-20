using NU.StringCalculatorExercise;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        public Tests()
        {
            _objStringCalculator = new StringCalculator();
        }
        private readonly StringCalculator _objStringCalculator;

        [SetUp]
        public void Setup()
        { 
        }

        [Test]
        public void TestExercise1()
        {
            int resultTest1 = _objStringCalculator.Add("");

            Assert.True(resultTest1 == 0);

            int resultTest2 = _objStringCalculator.Add("1");

            Assert.True(resultTest2 == 1);

            int resultTest3 = _objStringCalculator.Add("1,2");

            Assert.True(resultTest3 == 3);

        }
    }
}