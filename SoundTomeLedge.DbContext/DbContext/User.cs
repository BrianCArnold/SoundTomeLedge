namespace SoundTomeLedge.DbContext;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public bool IsActive { get; set; }
    public bool IsLocked { get; set; }
    public DateTimeOffset LastSeen { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsModerator { get; set; }
    public bool IsListener { get; set; }
    public List<UserBookmark> Bookmarks { get; } = new();
    public List<EreaderDeviceUser> EreaderDevices { get; set; } = new();
}
