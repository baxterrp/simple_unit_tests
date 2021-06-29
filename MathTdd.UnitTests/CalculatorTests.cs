using Xunit;

namespace MathTdd.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void OnePlusOneReturnsTwo()
        {
            // Arrange - what we need to execute tests
            var numOne = 1;
            var numTwo = 1;
            var sut = new Calculator();

            // Act - execution 
            var result = sut.Add(numOne, numTwo);

            // Assert - do results match expected results
            Assert.Equal(2, result);
        }

        [Fact]
        public void OnePlusTwoReturnsThree()
        {
            // Arrange
            var numOne = 1;
            var numTwo = 2;
            var sut = new Calculator();

            // Act
            var result = sut.Add(numOne, numTwo);

            // Assert
            Assert.Equal(3, result);
        }
    }
}
