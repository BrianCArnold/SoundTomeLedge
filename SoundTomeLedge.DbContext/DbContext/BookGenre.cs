namespace SoundTomeLedge.DbContext;

public class BookGenre
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required Genre Genre { get; set; }
}
