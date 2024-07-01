using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> emptyWordsList = new List<string>();
        string wordToErase = "test";
        string expectedOutput = string.Empty;

        // Act
        string actualOutput = wordEraser.Erase(emptyWordsList, wordToErase);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> nullWordsList = null;
        string wordToErase = "test";
        string expectedOutput = string.Empty;

        // Act
        string actualOutput = wordEraser.Erase(nullWordsList, wordToErase);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> wordsList = new List<string> { "This", "is", "a", "test" };
        string nullWordToErase = null;
        string emptyWordToErase = "";
        string expectedOutput = "This is a test";

        // Act
        string actualOutputNull = wordEraser.Erase(wordsList, nullWordToErase);
        string actualOutputEmpty = wordEraser.Erase(wordsList, emptyWordToErase);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutputNull);
        Assert.AreEqual(expectedOutput, actualOutputEmpty);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> wordsList = new List<string> { "test", "test", "test" };
        string wordToErase = "test";
        string expectedOutput = string.Empty;

        // Act
        string actualOutput = wordEraser.Erase(wordsList, wordToErase);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> wordsList = new List<string> { "This", "is", "a", "test", "sentence", "with", "test", "words" };
        string wordToErase = "test";
        string expectedOutput = "This is a sentence with words";

        // Act
        string actualOutput = wordEraser.Erase(wordsList, wordToErase);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}

