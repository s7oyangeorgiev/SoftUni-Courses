using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] input = { 42 };
        string expected = "42";

        // Act
        string result = Reverse.ReverseArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        string expected = "5 4 3 2 1";

        // Act
        string result = Reverse.ReverseArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
