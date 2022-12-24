using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            var result = calc.Additional(20, 80);
            Assert.AreEqual(100, result);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            var result = calc.Subtraction(90, 90);
            Assert.Zero(result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            var result = calc.Miltiplication(2, 5);
            Assert.True(10 == result);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            var result = calc.Division(4, 2);
            Assert.AreNotEqual(1, result);
        }
    }
}
