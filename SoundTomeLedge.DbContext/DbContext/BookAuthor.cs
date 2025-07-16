namespace SoundTomeLedge.DbContext;

public class BookAuthor
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required Author Author { get; set; }
}
