using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = { 'a', '1', 'b', '2', 'c', '3', 'd' };
        char[] expected = { 'a', 'b', 'c', 'd' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = { 'a', 'b', 'c', 'd' };
        char[] expected = { 'a', 'b', 'c', 'd' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();
        char[] expected = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
