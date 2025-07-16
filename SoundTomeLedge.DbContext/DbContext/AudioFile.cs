namespace SoundTomeLedge.DbContext;

public class AudioFile
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
    public required string FilePath { get; set; }
}
