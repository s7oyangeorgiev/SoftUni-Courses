using NUnit.Framework;

namespace TestApp.Tests
{
    public class HashTagCheckerTests
    {
        [Test]
        public void Test_GetHashTags_ValidTextWithOneHashTag_ReturnMessageForOneHashTags()
        {
            // Arrange
            string textWithOneHashTag = "one #";
            string expectedMessage = "Only one! You know exactly what you #tag.";

            // Act
            string actualMessage = HashTagChecker.GetHashTags(textWithOneHashTag);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForEvenHashTags()
        {
            string textWithEvenHashTags = "This #is a #test with #four #tags.";
            string expectedMessage = "The text contains an even number of #tags (4 in total).";

            // Act
            string actualMessage = HashTagChecker.GetHashTags(textWithEvenHashTags);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForOddHashTags()
        {
            // Arrange
            string textWithOddHashTags = "This is a #test with #three #tags.";
            string expectedMessage = "The text contains an odd number of #tags (3 in total).";

            // Act
            string actualMessage = HashTagChecker.GetHashTags(textWithOddHashTags);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Test_GetHashTags_NullOrEmptyText_ReturnsErrorMessage()
        {
            // Arrange
            string nullText = null;
            string emptyText = "";
            string whitespaceText = "   ";
            string expectedMessage = "No content...";

            // Act
            string actualMessageNull = HashTagChecker.GetHashTags(nullText);
            string actualMessageEmpty = HashTagChecker.GetHashTags(emptyText);
            string actualMessageWhitespace = HashTagChecker.GetHashTags(whitespaceText);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessageNull);
            Assert.AreEqual(expectedMessage, actualMessageEmpty);
            Assert.AreEqual(expectedMessage, actualMessageWhitespace);
        }

        [Test]
        public void Test_GetHashTags_TestWithoutHashTags_ReturnsErrorMessage()
        {
            // Arrange
            string textWithoutHashTags = "This text does not contain any hashtags.";
            string expectedMessage = "The text does not contain #tags.";

            // Act
            string actualMessage = HashTagChecker.GetHashTags(textWithoutHashTags);

            // Assert
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}

