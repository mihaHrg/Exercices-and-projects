using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingHomework.Ex_4;

namespace TestProject1.UnitTest
{
    public class OperationTests
    {
        private readonly Operation _operations;

        public OperationTests()
        {
            _operations = new Operation();
        }

        [Theory]
        [InlineData(3, 5, "add", 8)]        // Test addition
        [InlineData(10, 4, "subtract", 6)]   // Test subtraction
        [InlineData(6, 2, "multiply", 12)]   // Test multiplication
        [InlineData(20, 4, "divide", 5)]     // Test division
        public void PerformOperation_ValidOperations_ReturnsCorrectResult(int a, int b, string operation, int expected)
        {
            // Act
            var result = _operations.PerformOperation(a, b, operation);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 0, "divide")]    // Test division by zero
        [InlineData(5, 2, "unknown")]    // Test unknown operation
        public void PerformOperation_InvalidOperations_ThrowsException(int a, int b, string operation)
        {
            // Assert
            Assert.ThrowsAny<Exception>(() => _operations.PerformOperation(a, b, operation));
        }
    }
}


