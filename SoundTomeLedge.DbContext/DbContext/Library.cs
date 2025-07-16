namespace SoundTomeLedge.DbContext;

public class Library
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Path { get; set; }
    public List<Book> Books { get; } = new();
}
