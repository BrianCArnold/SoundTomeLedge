namespace SoundTomeLedge.DbContext;

public class UserBookmark
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public TimeSpan BookmarkTime { get; set; }
}
