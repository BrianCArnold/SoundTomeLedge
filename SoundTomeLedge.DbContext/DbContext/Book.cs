namespace SoundTomeLedge.DbContext;

public class Book
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Subtitle { get; set; }
    public string? PublishedYear { get; set; }
    public string? PublishedDate { get; set; }
    public string? Description { get; set; }
    public string? ISBN { get; set; }
    public string? ASIN { get; set; }
    public string? Language { get; set; }
    public bool Explicit { get; set; }
    public bool Abridged { get; set; }
    public string? CoverImagePath { get; set; }
    public TimeSpan? Duration { get; set; }
    public List<BookNarrator> Narrators { get; } = new();
    public List<AudioFile> AudioFiles { get; } = new();
    public List<EBookFile> EBookFiles { get; } = new();
    public List<BookChapter> Chapters { get; } = new();
    public List<BookTag> Tags { get; } = new();
    public List<BookGenre> Genres { get; } = new();
    public List<CollectionBook> Collections { get; } = new();
    public List<BookAuthor> BookAuthors { get; } = new();

    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public required Library Library { get; set; }
}
