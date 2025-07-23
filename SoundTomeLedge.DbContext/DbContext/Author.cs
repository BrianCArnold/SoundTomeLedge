namespace SoundTomeLedge.DbContext;

public class Author
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastFirst { get; set; }
    public string ASIN { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public List<BookAuthor> BookAuthors { get; } = new();
}
