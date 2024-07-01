using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;
public class PalindromeFinderTests
{
    [Test]
    public void Test_GetPalindromes_NullWordsList_ReturnsEmptyString()
    {
        // Arrange
        List<string> words = null;

        // Act
        string result = PalindromeFinder.GetPalindromes(words);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetPalindromes_EmptyWordsList_ReturnsEmptyString()
    {
        // Arrange
        List<string> words = new List<string>();

        // Act
        string result = PalindromeFinder.GetPalindromes(words);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetPalindromes_ListWithWords_ReturnsOnlyPalidromeWords()
    {
        // Arrange
        List<string> words = new List<string> { "level", "radar", "hello", "madam", "racecar" };

        // Act
        string result = PalindromeFinder.GetPalindromes(words);

        // Assert
        Assert.AreEqual("level radar madam racecar", result);
    }

    [Test]
    public void Test_GetPalindromes_ListWithoutPalindromeWords_ReturnsEmptyString()
    {
        // Arrange
        List<string> words = new List<string> { "hello", "world", "programming", "test" };

        // Act
        string result = PalindromeFinder.GetPalindromes(words);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetPalindromes_ListOnlyWithPalidromeWords_ReturnsStringWithAllWords()
    {
        // Arrange
        List<string> words = new List<string> { "level", "radar", "madam", "deified", "racecar" };

        // Act
        string result = PalindromeFinder.GetPalindromes(words);

        // Assert
        Assert.AreEqual("level radar madam deified racecar", result);
    }
}

