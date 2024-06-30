using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = string.Empty;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\Folder\File.txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.AreEqual("File name: File\nFile extension: txt", result);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = @"C:\Folder\FileWithoutExtension";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.AreEqual("File name: FileWithoutExtension", result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\Folder\File@Special#Character.ext";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.AreEqual("File name: File@Special#Character\nFile extension: ext", result);
    }
}
