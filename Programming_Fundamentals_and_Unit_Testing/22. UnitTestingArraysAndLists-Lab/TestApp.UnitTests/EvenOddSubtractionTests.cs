using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] input = { 2, 4, 6, 8, 10 };
        int expected = 30;  // 2 + 4 + 6 + 8 + 10 = 30

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] input = { 1, 3, 5, 7, 9 };
        int expected = -25;  // -(1 + 3 + 5 + 7 + 9) = -25

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5, 6 };
        int expected = 3;  // (2 + 4 + 6) - (1 + 3 + 5) = 12 - 9 = 3

        // Act
        int result = EvenOddSubtraction.FindDifference(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
