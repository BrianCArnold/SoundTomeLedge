namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/custom-metadata-providers")]
public class CustomMetadataProvidersController : ControllerBase
{
    private readonly ILogger<CustomMetadataProvidersController> _logger;
    private readonly IBookShelfContext _context;

    public CustomMetadataProvidersController(ILogger<CustomMetadataProvidersController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<ClientCustomMetadataProvider>> GetAll()
    {
        return await _context.ClientCustomMetadataProviders.ToListAsync();

    }
    [HttpPost]
    public async Task<ClientCustomMetadataProvider> Create(string name, string url, MediaType mediaType, string authHeaderValue)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProvider(Guid id)
    {
        var provider = await _context.ClientCustomMetadataProviders.SingleAsync(c => c.Id == id);
        _context.ClientCustomMetadataProviders.Remove(provider);
        await _context.SaveChangesAsync();
        return Ok();
    }
}

