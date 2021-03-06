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

            // Step 1 Tests

            int resultTest1 = _objStringCalculator.Add("");

            Assert.True(resultTest1 == 0);

            int resultTest2 = _objStringCalculator.Add("1");

            Assert.True(resultTest2 == 1);

            int resultTest3 = _objStringCalculator.Add("1,2");

            Assert.True(resultTest3 == 3);

            // Step 2 Tests
            int resultTest4 = _objStringCalculator.Add("1,2,3,4,5,6,7,8");

            Assert.True(resultTest4 == 36);

            // Step 3 Tests
            int resultTest5 = _objStringCalculator.Add("1\n2,3");

            Assert.True(resultTest5 == 6);

            //int resultTest6 = _objStringCalculator.Add("1,\n");

            //Assert.True(resultTest6 == 0);

            // Step 4 Tests
            int resultTest7 = _objStringCalculator.Add(@"//;\n1;2");

            Assert.True(resultTest7 == 3);

            // Step 5 Tests
            //int resultTest8 = _objStringCalculator.Add(@"-100");

            //Assert.True(resultTest8 == 0);

            // Step 6 Tests
            int resultTest9 = _objStringCalculator.Add(@"1001,1000,10");

            Assert.True(resultTest9 == 1010);

            // Step 7 Tests
            int resultTest10 = _objStringCalculator.Add(@"//[***]\n1***2***3");

            Assert.True(resultTest10 == 6);

            // Step 8 Tests
            int resultTest11 = _objStringCalculator.Add(@"//[*][%]\n1*2%3");

            Assert.True(resultTest11 == 6);

            // Step 9 Tests
            int resultTest12 = _objStringCalculator.Add(@"//[***][%%%]\n1***2%%%3");

            Assert.True(resultTest12 == 6);
        }
    }
}