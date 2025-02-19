using System.ComponentModel.DataAnnotations;

namespace WebApp.Model;

public class User
{
    public Guid Id { get; set; }
    [Required, Length(4, 30)]
    public required string Username { get; set; }
    [Required, EmailAddress]
    public required string Email { get; set; }
    [Required, Length(6, 16)]
    public required string Password { get; set; }
}