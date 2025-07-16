namespace SoundTomeLedge.DbContext;

public class BookNarrator
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required Narrator Narrator { get; set; }
}
