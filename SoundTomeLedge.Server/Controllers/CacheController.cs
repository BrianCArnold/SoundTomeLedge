namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CacheController : ControllerBase
{
    private readonly ILogger<CacheController> _logger;
    private readonly IBookShelfContext _context;

    public CacheController(ILogger<CacheController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost("purge")]
    public async Task<IAsyncResult> PurgeCache()
    {
        throw new NotImplementedException();
    }

    [HttpPost("items/purge")]
    public async Task<IAsyncResult> PurgeItemsCache()
    {
        throw new NotImplementedException();
    }
}
