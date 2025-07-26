namespace SoundTomeLedge.DbContext;

public class Backup
{
    public Guid Id { get; set; }
    public required string Key { get; set; }
    public string DatePretty => "ddd, MMM D YYYY HH:mm";
    public required string BackupDirPath { get; set; }
    public required string FileName { get; set; }

    public required string Path { get; set; }
    public required string FullPath { get; set; }
    public required string ServerVersion { get; set; }
    public required ulong FileSize { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
