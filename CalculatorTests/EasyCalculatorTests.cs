using Xunit;
using Calculator;
using FluentAssertions;

namespace CalculatorTests
{
    public class EasyCalculatorTests
    {
        [Fact]
        public void Add()
        {
            // Arrange
            const int A = 5;
            const int B = 10;
            var calculator = new EasyCalculator();

            // Act
            int result = calculator.Add(A, B);

            // Assert
            result.Should().Be(15);
        }

        [Theory]
        [InlineData(15, 10, 5)]
        [InlineData(10, 15, -5)]
        [InlineData(0, 0, 0)]
        public void Substract(int A, int B, int expected)
        {
            // Arrange
            var calculator = new EasyCalculator();

            // Act
            int result = calculator.Subtract(A, B);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(8, 3)]
        public void Logarithm(double A, double expected)
        {
            // Arrange
            var calculator = new EasyCalculator();

            // Act
            double result = calculator.Logarithm(A);

            // Assert
            result.Should().Be(expected);
        }
    }
}