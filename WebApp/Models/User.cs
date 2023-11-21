using Microsoft.EntityFrameworkCore.Update.Internal;

namespace WebApp.Models;

public class UserSchema
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

}
public class UserEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;


    public static implicit operator UserEntity(UserSchema schema)
    {
        return new UserEntity
        {
            FirstName = schema.FirstName,
            LastName = schema.LastName,
            Email = schema.Email
        };
    }
}

