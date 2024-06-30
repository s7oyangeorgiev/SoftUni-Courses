using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long primeNumber = 13;
        long expected = 13;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long largeNumber = 600851475143;
        long expected = 6857; // Largest prime factor of 600851475143

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(largeNumber);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
