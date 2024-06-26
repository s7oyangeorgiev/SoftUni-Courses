using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        /// Arrange
        int input = 0;
        int expectedOutput = 1;

        // Act
        int actualOutput = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int input = 1;
        int expectedOutput = 1;

        // Act
        int actualOutput = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}
