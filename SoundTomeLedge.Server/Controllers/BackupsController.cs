namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackupsController : ControllerBase
{
    private readonly ILogger<BackupsController> _logger;
    private readonly IBookShelfContext _context;
    public required string BackupPath { get; set; }

    public BackupsController(ILogger<BackupsController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
        BackupPath = "/tmp/ERROR";
    }

    public record BackupData(
        IEnumerable<Backup> Backups,
        string BackupLocation,
        bool BackupPathEnvSet
    );

    [HttpGet()]
    public async Task<BackupData> GetAll()
    {
        return await GetCurrentBackupState();
    }

    [HttpPost("upload")]
    public async Task<BackupData> UploadBackup(Backup backup, Stream backupFile)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<BackupData> CreateBackup()
    {
        await RunBackup();
        return await GetCurrentBackupState();
    }

    [HttpDelete]
    public async Task<BackupData> DeleteBackup(Backup backup)
    {
        await Task.WhenAll(RemoveBackupFile(backup), RemoveBackupFromDatabase(backup));
        return await GetCurrentBackupState();
    }

    public async Task<StatusCodeResult> UpdatePath(string path)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}/download")]
    public async Task<Stream> Download(Guid id)
    {
        throw new NotImplementedException();
    }

    private async Task RemoveBackupFromDatabase(Backup backup)
    {
        var dbObject = await _context.Backups.SingleAsync(b => b.Id == backup.Id);
        _context.Backups.Remove(dbObject);
        await _context.SaveChangesAsync();
    }

    private async Task RemoveBackupFile(Backup backup)
    {
        throw new NotImplementedException();
    }

    private async Task<BackupData> GetCurrentBackupState()
    {
        return new BackupData(await _context.Backups.ToArrayAsync(), BackupPath, true);
    }

    private Task<bool> RunBackup()
    {
        return Task.FromResult(false);
    }
}
