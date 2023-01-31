namespace SolidLessons.SRP;

public record User
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string Role { get; init; }
}