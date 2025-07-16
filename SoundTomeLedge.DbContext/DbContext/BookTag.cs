namespace SoundTomeLedge.DbContext;

public class BookTag
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required Tag Tag { get; set; }
}
