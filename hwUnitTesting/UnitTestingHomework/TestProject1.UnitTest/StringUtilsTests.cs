using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingHomework.Ex_5;

namespace TestProject1.UnitTest
{
    public class StringUtilsTests
    {
        private readonly StringUtils _stringUtils;

        public StringUtilsTests()
        {
            _stringUtils = new StringUtils();
        }

        [Fact]
        public void ReverseString_ValidInput_ReturnsReversedString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = _stringUtils.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _stringUtils.ReverseString(input));
        }

        [Fact]
        public void ReverseString_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = _stringUtils.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

