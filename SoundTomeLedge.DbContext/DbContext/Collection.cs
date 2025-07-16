namespace SoundTomeLedge.DbContext;

public class Collection
{
    public Guid Id { get; set; }
    public List<CollectionBook> Books { get; } = new();
}
