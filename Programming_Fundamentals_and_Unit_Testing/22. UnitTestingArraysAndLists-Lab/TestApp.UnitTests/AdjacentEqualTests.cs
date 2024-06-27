using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 2, 2, 3, 3, 3, 4, 5 };

        // Expected result after summing adjacent equal numbers
        string expected = "1 4 9 4 5";

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> input = new List<int> { 2, 2, 2, 2, 2 };

        // Expected result after summing all adjacent equal numbers
        string expected = "10";

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 1, 1, 2, 3, 4, 5 };

        // Expected result after summing adjacent equal numbers at the beginning
        string expected = "3 2 3 4 5";

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 2, 3, 4, 5, 5, 5 };

        // Expected result after summing adjacent equal numbers at the end
        string expected = "1 2 3 4 15";

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        // Expected result after summing adjacent equal numbers in the middle
        string expected = "1 4 3 8 5";

        // Act
        string result = AdjacentEqual.Sum(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
