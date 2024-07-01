using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        // Arrange
        string validPassword = "Pass123";

        // Act
        string result = PasswordValidator.CheckPassword(validPassword);

        // Assert
        Assert.AreEqual("Password is valid", result);
    }

    [Test]
    public void Test_CheckPassword_PasswordTooShort_ReturnsErrorMessage()
    {
        // Arrange
        string shortPassword = "Pas12";

        // Act
        string result = PasswordValidator.CheckPassword(shortPassword);

        // Assert
        Assert.AreEqual("Password must be between 6 and 10 characters", result);
    }

    [Test]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage()
    {
        // Arrange
        string passwordWithSpecialChars = "Pass@123";

        // Act
        string result = PasswordValidator.CheckPassword(passwordWithSpecialChars);

        // Assert
        Assert.AreEqual("Password must consist only of letters and digits", result);
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        // Arrange
        string passwordWithInsufficientDigits = "Password";

        // Act
        string result = PasswordValidator.CheckPassword(passwordWithInsufficientDigits);

        // Assert
        Assert.AreEqual("Password must have at least 2 digits", result);

    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        // Arrange
        string validPassword = "Password12";

        // Act
        string result = PasswordValidator.CheckPassword(validPassword);

        // Assert
        Assert.AreEqual("Password is valid", result);
    }
}
