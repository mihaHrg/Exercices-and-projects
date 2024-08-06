using Xunit;
using NSubstitute;
using UnitTestingHomework.Ex_2;

namespace YourNamespace.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void GetUser_ReturnsUser_FromRepository()
        {
            // Arrange
            int userId = 1;
            var expectedUser = new User { Id = userId, Name = "John Doe" };

            // Mock the IUserRepository interface
            var userRepository = Substitute.For<IUserRepository>();
            userRepository.GetUserById(userId).Returns(expectedUser);

            // Create an instance of UserService with the mock repository
            var userService = new UserService(userRepository);

            // Act
            var actualUser = userService.GetUser(userId);

            // Assert
            Assert.Equal(expectedUser, actualUser);
        }

        [Fact]
        public void SaveUser_Calls_SaveUser_OnRepository()
        {
            // Arrange
            var user = new User { Id = 1, Name = "Jane Doe" };

            // Mock the IUserRepository interface
            var userRepository = Substitute.For<IUserRepository>();

            // Create an instance of UserService with the mock repository
            var userService = new UserService(userRepository);

            // Act
            userService.SaveUser(user);

            // Assert
            userRepository.Received(1).SaveUser(user);
        }
    }
}



