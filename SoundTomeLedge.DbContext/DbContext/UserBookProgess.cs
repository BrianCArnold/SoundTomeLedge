namespace SoundTomeLedge.DbContext;

public class UserBookProgess
{
    public Guid Id { get; set; }
    public required User User { get; set; }
    public required Book Book { get; set; }
}
