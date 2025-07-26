
namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/emails")]
public class EmailSettingsController : ControllerBase
{
    private readonly ILogger<EmailSettingsController> _logger;
    private readonly IBookShelfContext _context;

    public EmailSettingsController(ILogger<EmailSettingsController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("settings")]
    public async Task<EmailSettings> GetSettings()
    {
        throw new NotImplementedException();
    }
    [HttpPatch("settings")]
    public async Task<EmailSettings> UpdateSettings(EmailSettings settings)
    {
        throw new NotImplementedException();
    }
    [HttpPost("test")]
    public async Task<EmailSettings> TestEmail()
    {
        throw new NotImplementedException();
    }
    [HttpPost("test")]
    public async Task<EmailSettings> UpdateEReaderDevices(List<EreaderDevice> ereaderDevices)
    {
        throw new NotImplementedException();
    }
    [HttpPost("send-ebook-to-device")]
    public async Task<IActionResult> SendEBookToDevice(string deviceName, Guid libraryItemId)
    {
        throw new NotImplementedException();
    }
}
