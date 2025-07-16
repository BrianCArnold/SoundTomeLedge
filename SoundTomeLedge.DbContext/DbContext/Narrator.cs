namespace SoundTomeLedge.DbContext;

public class Narrator
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string LastFirst { get; set; }
    public required string ASIN { get; set; }
    public required string Description { get; set; }
    public required string ImagePath { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public List<BookNarrator> BookNarrators { get; } = new();
}
