using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'A';
        char b = 'B';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'B'; // smaller character
        char b = 'A'; // larger character

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'A'; // smaller character
        char c = 'C'; // larger character

        // Act
        string result = CharacterRange.GetRange(a, c);

        // Assert
        Assert.AreEqual("B", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char d = 'D'; // smaller character
        char g = 'G'; // larger character

        // Act
        string result = CharacterRange.GetRange(d, g);

        // Assert
        Assert.AreEqual("E F", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char x = 'X'; // smaller character
        char z = 'Z'; // larger character

        // Act
        string result = CharacterRange.GetRange(x, z);

        // Assert
        Assert.AreEqual("Y", result);
    }
}
