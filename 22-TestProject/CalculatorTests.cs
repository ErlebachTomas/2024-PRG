using System;
using Xunit;
using _22_Testy;
namespace _22_TestProject
{
    public class CalculatorTests
    {
        private readonly Calculator _calc; // Instance testované tøídy

        public CalculatorTests()
        {
            _calc = new Calculator();
        }

        /// <summary>
        /// Test: metoda Addition vrací správné výsledky
        /// </summary>
        [Fact]
        public void Addition_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calc.Addition(1, 1));
            Assert.Equal(1.42, _calc.Addition(3.14, -1.72), 3);     // tolerance 3 desetinná místa
      
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-3, -7, -10)]
        [InlineData(0.1, 0.2, 0.3)]
        public void Addition_ShouldWorkWithMultipleValues(double a, double b, double expected)
        {
            Assert.Equal(expected, _calc.Addition(a, b), 3);
        }

        [Fact]
        public void Subtraction_ShouldReturnCorrectResult()
        {
            Assert.Equal(0, _calc.Subtraction(1, 1));
            Assert.Equal(4.86, _calc.Subtraction(3.14, -1.72), 3);
        }

        [Fact]
        public void Multiplication_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calc.Multiplication(1, 2));
            Assert.Equal(-5.401, _calc.Multiplication(3.14, -1.72), 3);
        }

        [Fact]
        public void Division_ShouldReturnCorrectResult()
        {
            Assert.Equal(2, _calc.Division(4, 2));
            Assert.Equal(-1.826, _calc.Division(3.14, -1.72), 3);
            Assert.Equal(1, _calc.Division(1.0 / 3, 1.0 / 3));
        }

        [Fact]
        public void Division_ByZero_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calc.Division(5, 0));
        }
    }
}