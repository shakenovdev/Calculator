using Xunit;
using Calculator;
using FluentAssertions;

namespace CalculatorTests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void Add()
        {
            // Arrange
            const int A = 5;
            const int B = 10;
            var calculator = new SimpleCalculator();

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
            var calculator = new SimpleCalculator();

            // Act
            int result = calculator.Subtract(A, B);

            // Assert
            result.Should().Be(expected);
        }
    }
}