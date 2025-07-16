namespace SoundTomeLedge.DbContext;

public class CollectionBook
{
    public Guid Id { get; set; }
    public required Book Book { get; set; }
}
