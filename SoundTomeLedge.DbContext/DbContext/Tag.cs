namespace SoundTomeLedge.DbContext;

public class Tag
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<BookTag> Books { get; } = new();
}
