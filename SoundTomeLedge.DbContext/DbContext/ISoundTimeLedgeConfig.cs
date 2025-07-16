namespace SoundTomeLedge.DbContext;

public interface ISoundTomeLedgeConfig
{
    string? SqliteDbPath { get; }
    DatabaseBackendType BackendType { get; }
}

public class SoundTomeLedgeConfig : ISoundTomeLedgeConfig
{
    public string? SqliteDbPath { get; set; }
    public DatabaseBackendType BackendType { get; set; }
}
