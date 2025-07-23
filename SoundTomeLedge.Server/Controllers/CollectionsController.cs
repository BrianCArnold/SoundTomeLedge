namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CollectionsController : ControllerBase
{
    private readonly ILogger<CollectionsController> _logger;
    private readonly IBookShelfContext _context;

    public CollectionsController(ILogger<CollectionsController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost]
    public async Task<Collection> CreateNewCollection(Collection newCollection)
    {
        var dbEntry = _context.Collections.Add(newCollection);
        await _context.SaveChangesAsync();
        return dbEntry.Entity;
    }

    [HttpGet]
    public async Task<IEnumerable<Collection>> GetAll()
    {
        return await _context.Collections.ToArrayAsync();
    }

    [HttpGet("{collectionId}")]
    public async Task<IEnumerable<Collection>> GetOne(Guid collectionId)
    {
        throw new NotImplementedException();
    }

    [HttpPatch("{collectionId}")]
    public async Task<Collection> Update(Guid collectionId, Collection update)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{collectionId}")]
    public async Task<IAsyncResult> DeleteCollection(Guid collectionId)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{collectionId}/book")]
    public async Task<IAsyncResult> AddBook(Guid collectionId, Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{collectionId}/batch/add")]
    public async Task<IAsyncResult> AddBooks(Guid collectionId, List<Guid> books)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{collectionId}/batch/remove")]
    public async Task<IAsyncResult> DeleteBooks(Guid collectionId, List<Guid> books)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{collectionId}/book")]
    public async Task<IAsyncResult> DeleteBook(Guid collectionId, Guid id)
    {
        throw new NotImplementedException();
    }
}
