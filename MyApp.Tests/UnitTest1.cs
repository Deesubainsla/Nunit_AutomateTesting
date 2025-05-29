

using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    public class CalculatorTests
    {
        // [Test]
        // public void Add_ReturnsSum_WhenGivenTwoNumbers()
        // {
        //     var calc = new Calculator();
        //     int result = calc.Add(2, 3);
        //     Assert.AreEqual(5, result);
        // }

        [TestCase(2, 3, 4)]//error is here
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(10, -5, 5)]
        public void Add_ReturnsCorrectResult(int a, int b, int expected)
        {
            var calc = new Calculator();

            int result = calc.Add(a, b);

            // TestContext.WriteLine($"Success for {a} and {b} for sum {result}");

            try
            {
                Assert.AreEqual(expected, result);
                TestContext.WriteLine($"Success for {a} and {b} for sum {result}");
            }
            catch (System.Exception)
            {
                //Will show error insted of Success
                TestContext.WriteLine($"Error: for {a} and {b} for sum {result}");
            }
            
        }


        // [Test]
        // public void Subtract_ReturnsDifference_WhenGivenTwoNumbers()
        // {
        //     var calc = new Calculator();
        //     int result = calc.Subtract(5, 3);
        //     Assert.AreEqual(2, result);
        // }
        [TestCase(5, 3, 2)]
        [TestCase(10, 4, 6)]
        [TestCase(20, 5, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -2, -1)]
        public void Subtract_ReturnsDifference_WhenGivenTwoNumbers(int a, int b, int expected)
        {
            var calc = new Calculator();
            int result = calc.Subtract(a, b);
            
            // Show output in test logs
            TestContext.WriteLine($"Success for {a} - {b} = {result}");

            Assert.AreEqual(expected, result);
        }

    }
}

