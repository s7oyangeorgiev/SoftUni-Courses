using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> input = new List<int> { 42 };
        int expected = 42;

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new List<int> { 1, 3, 2, 5, 4 };
        int expected = 5; // Maximum value in the list

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new List<int> { -1, -3, -2, -5, -4 };
        int expected = -1; // Maximum value in the list

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new List<int> { -1, 3, -2, 5, -4 };
        int expected = 5; // Maximum value in the list

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> input = new List<int> { 1, 3, 2, 5, 5, 4 };
        int expected = 5; // Maximum value in the list

        // Act
        int result = MaxNumber.FindMax(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
