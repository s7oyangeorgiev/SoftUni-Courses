using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        // Arrange
        List<int> nums = new List<int> { 10, 11, 12, 13, 37 };
        string s = "Messaging";

        string expected = "esgnM";

        // Act
        string result = Messaging.GetMessage(nums, s);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        // Arrange
        List<int> nums = new List<int>();
        string s = "Hello";

        // Act
        string result = Messaging.GetMessage(nums, s);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        List<int> nums = new List<int> { 1, 2, 3 };
        string s = string.Empty;

        // Act
        string result = Messaging.GetMessage(nums, s);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        // Arrange
        List<int> nums = null;
        string s = "Hello";

        // Act
        string result = Messaging.GetMessage(nums, s);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        // Arrange
        List<int> nums = new List<int> { 1, 2, 3 };
        string s = null;

        // Act
        string result = Messaging.GetMessage(nums, s);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }
}
