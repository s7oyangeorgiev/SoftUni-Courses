using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int input = 5;
        int expected = 5; // Fibonacci of 5 is 5 (sequence: 0, 1, 1, 2, 3, 5)

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}