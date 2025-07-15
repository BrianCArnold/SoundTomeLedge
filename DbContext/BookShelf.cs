using Microsoft.EntityFrameworkCore;


public class BookShelfContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<CollectionBook> CollectionsBook { get; set; }
    public DbSet<BookAuthor> BookAuthor { get; set; }
    public DbSet<UserBookProgess> UserBookProgess { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserBookmark> UserBookmarks { get; set; }
    public DbSet<Library> Libraries { get; set; }
    public DbSet<Narrator> Narrators { get; set; }
    public DbSet<BookNarrator> BookNarrators { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }
    public DbSet<BookTag> BookTags { get; set; }
    public DbSet<BookChapter> BookChapters { get; set; }
    public DbSet<EBookFile> EBookFiles { get; set; }
    public DbSet<AudioFile> AudioFiles { get; set; }

    public string DbPath { get; }

    public BookShelfContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "bookshelf.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Collection
{
    public Guid Id { get; set; }
		public List<CollectionBook> Books { get; } = new();
}

public class CollectionBook
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
}

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

public class BookAuthor
{

    public Guid Id { get; set; }
		public Book Book { get; set; }
		public Author Author { get; set; }
}

public class UserBookProgess
{
    public Guid Id { get; set; }
		public User User { get; set; }
		public Book Book { get; set; }
}

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public bool IsActive { get; set; }
    public bool IsLocked { get; set; }
    public DateTimeOffset LastSeen { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsModerator { get; set; }
		public bool IsListener { get; set; }
		public List<UserBookmark> Bookmarks { get; } = new();
}

public class UserBookmark
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public TimeSpan BookmarkTime { get; set; }
}


public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
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
    public Library Library { get; set; }

}

public class Library
{
    public Guid Id { get; set; }
		public string Name { get; set; }
		public string Path { get; set; }
		public List<Book> Books { get; } = new();
}

public class BookNarrator
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public Narrator Narrator { get; set; }
}

public class Tag
{
    public Guid Id { get; set; }
		public string Name { get; set; }
		public List<BookTag> Books { get; } = new();

}

public class Genre
{
    public Guid Id { get; set; }
		public string Name { get; set; }
		public List<BookGenre> Books { get; } = new();
}

public class BookGenre
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public Genre Genre { get; set; }
}

public class BookTag
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public Tag Tag { get; set; }
}

public class BookChapter
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public string Title{ get; set; }
		public int Number { get; set; }
}

public class EBookFile
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public string FilePath { get; set; }
}

public class AudioFile
{
    public Guid Id { get; set; }
		public Book Book { get; set; }
		public string FilePath { get; set; }
}

public class Narrator
{
    public Guid Id { get; set; }
		public string Name { get; set; }
    public string LastFirst { get; set; }
    public string ASIN { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
		public DateTimeOffset UpdatedAt { get; set; }
		public DateTimeOffset CreatedAt { get; set; }

    public List<BookNarrator> BookNarrators { get; } = new();
}

