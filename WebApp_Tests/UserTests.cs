using WebApp.Models;

namespace WebApp_Tests;

public class UserTests
{
    [Fact]
    public void UserSchema_Should_ConvertT_UserEntity()
    {
        // Arrange
        UserSchema schema = new UserSchema()
        {
            FirstName = "Lova",
            LastName = "Juhlin",
            Email = "lova.juhlin@learnet.se"
        };

        // Act
        UserEntity entity = schema;

        // Assert
        Assert.NotNull(entity);
        Assert.IsType<UserEntity>(entity);
        Assert.Equal(schema.FirstName, entity.FirstName);   
        Assert.Equal(schema.LastName, entity.LastName);
        Assert.Equal(schema.Email, entity.Email);
    }
}
