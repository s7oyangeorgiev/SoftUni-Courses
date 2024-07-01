using System;
using NUnit.Framework;

namespace TestApp.Tests;
public class PrimeNumbersTests
{
    [Test]
    public void Test_GetPrimeNumbersInRange_StartNumberBiggerThanEndNumber_ReturnsErrorMessage()
    {
        // Arrange
        int startNum = 10;
        int endNum = 5;

        // Act
        string result = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        // Assert
        Assert.AreEqual("Start number should be bigger than end number.", result);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_StartAndEndNumberAreEqual_ReturnsEmptyString()
    {
        // Arrange
        int startNum = 4;
        int endNum = 4;

        // Act
        string result = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_NoPrimeNumbers_ReturnsEmptyString()
    {
        // Arrange
        int startNum = 0;
        int endNum =1;

        // Act
        string result = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_WithPrimeAndNonPrimeNumbers_ReturnsOnlyPrimeNumbers()
    {
        // Arrange
        int startNum = 1;
        int endNum = 18; 

        // Act
        string result = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        // Assert
        Assert.AreEqual("2 3 5 7 11 13 17", result);
    }

    [Test]
    public void Test_GetPrimeNumbersInRange_OnlyPrimeNumbers_ReturnsAllNumbers()
    {
        // Arrange
        int startNum = 3;
        int endNum = 5;

        // Act
        string result = PrimeNumbers.GetPrimeNumbersInRange(startNum, endNum);

        // Assert
        Assert.AreEqual("3 5", result);
    }
}

