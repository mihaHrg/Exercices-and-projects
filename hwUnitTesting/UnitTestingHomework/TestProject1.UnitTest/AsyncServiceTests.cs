using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingHomework.Ex_3;

namespace TestProject1.UnitTest
{
    public class AsyncServiceTests
    {
        [Fact]
        public async Task FetchDataAsync_ReturnsCorrectResult()
        {
            // Arrange
            var asyncService = new AsyncService();

            // Act
            var resultTask = asyncService.FetchDataAsync();
            var result = await resultTask;

            // Assert
            Assert.Equal("Data fetched", result);
        }

        [Fact]
        public async Task FetchDataAsync_CompletesInExpectedTime()
        {
            // Arrange
            var asyncService = new AsyncService();
            var expectedDelay = 1000; // milliseconds

            // Act
            var startTime = DateTime.UtcNow;
            await asyncService.FetchDataAsync();
            var endTime = DateTime.UtcNow;
            var actualDelay = (endTime - startTime).TotalMilliseconds;

            // Assert
            Assert.True(actualDelay >= expectedDelay, $"The method completed in {actualDelay} milliseconds, expected at least {expectedDelay} milliseconds.");
        }
    }
}

