using System;
using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    internal class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(10, 2) == 12);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Subtraction(10, 2) == 8);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Multiplication(10, 2) == 20);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Division(10, 2) == 5);
        }

        [Test]
        public void DivisionMustThrowDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
