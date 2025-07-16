namespace SoundTomeLedge.DbContext;

using Microsoft.EntityFrameworkCore;

public interface IBookShelfContext
{
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }
    DbSet<Collection> Collections { get; set; }
    DbSet<CollectionBook> CollectionsBook { get; set; }
    DbSet<BookAuthor> BookAuthor { get; set; }
    DbSet<UserBookProgess> UserBookProgess { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserBookmark> UserBookmarks { get; set; }
    DbSet<Library> Libraries { get; set; }
    DbSet<Narrator> Narrators { get; set; }
    DbSet<BookNarrator> BookNarrators { get; set; }
    DbSet<Tag> Tags { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<BookGenre> BookGenres { get; set; }
    DbSet<BookTag> BookTags { get; set; }
    DbSet<BookChapter> BookChapters { get; set; }
    DbSet<EBookFile> EBookFiles { get; set; }
    DbSet<AudioFile> AudioFiles { get; set; }
    int SaveChanges();
    int SaveChanges(bool acceptAllChangesOnSuccess);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default
    );
}

public class BookshelfContextFactory : IDbContextFactory<BookShelfContext>
{
    private Action<DbContextOptionsBuilder> Configurator { get; init; }

    public BookshelfContextFactory(ISoundTomeLedgeConfig config)
    {
        Configurator = options => options.UseSqlite($"Data Source=bookshelf.db");
        //Configurator = options => options.UseSqlite($"Data Source="bookshelf.db{config.SqliteDbPath}");
    }

    BookShelfContext IDbContextFactory<BookShelfContext>.CreateDbContext()
    {
        return InternalCreateDbContext();
    }

    private BookShelfContext InternalCreateDbContext()
    {
        return new BookShelfContext();
    }

    public IBookShelfContext CreateDbContext()
    {
        return InternalCreateDbContext();
    }
}

internal class BookShelfContext : DbContext, IBookShelfContext
{
    private readonly Action<DbContextOptionsBuilder> onConfiguring;

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
        this.onConfiguring = options => options.UseSqlite($"Data Source=bookshelf.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        onConfiguring(options);
}
