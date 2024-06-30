using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = { 3, 1, 2, 3, 4, 2 };
        int[] expected = { 1, 4, 2, 3 };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = { 5 };
        int[] expected = { 5 };

        // Act
        int[] result = Pattern.SortInPattern(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
