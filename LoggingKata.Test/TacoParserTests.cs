using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

            [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]

        public void ShouldParseLongitude(string testLine, double expected)
        {
            // Arrange
            TacoParser newTest = new TacoParser();
            // Act
            var test = newTest.Parse(testLine);
            // Assert
            Assert.Equal(expected, test.Location.Longitude);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string testLine, double expected)
        {
            // Arrange
            TacoParser newTest = new TacoParser();
            // Act
            var test = newTest.Parse(testLine);
            // Assert
            Assert.Equal(expected, test.Location.Latitude);
        }




    }
}