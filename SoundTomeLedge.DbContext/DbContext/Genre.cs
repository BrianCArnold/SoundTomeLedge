namespace SoundTomeLedge.DbContext;

public class Genre
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<BookGenre> Books { get; } = new();
}
