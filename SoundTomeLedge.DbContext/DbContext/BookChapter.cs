namespace SoundTomeLedge.DbContext;

public class BookChapter
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required string Title { get; set; }
    public int Number { get; set; }
}
