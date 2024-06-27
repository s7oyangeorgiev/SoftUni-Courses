using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] input = { 42 };
        double expected = 42.0;

        // Act
        double result = Average.CalculateAverage(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        double expected = 3.0;  // (1 + 2 + 3 + 4 + 5) / 5 = 15 / 5 = 3.0

        // Act
        double result = Average.CalculateAverage(input);

        // Assert
        Assert.AreEqual(expected, result, 0.0001); // Added delta for floating point comparison
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] input = { -1, -2, -3, -4, -5 };
        double expected = -3.0;  // (-1 + -2 + -3 + -4 + -5) / 5 = -15 / 5 = -3.0

        // Act
        double result = Average.CalculateAverage(input);

        // Assert
        Assert.AreEqual(expected, result, 0.0001); // Added delta for floating point comparison
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] input = { -1, 2, -3, 4, -5 };
        double expected = -0.6;  // (-1 + 2 + -3 + 4 + -5) / 5 = -3 / 5 = -0.6

        // Act
        double result = Average.CalculateAverage(input);

        // Assert
        Assert.AreEqual(expected, result, 0.0001); // Added delta for floating point comparison
    }
}
