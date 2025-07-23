namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorsController : ControllerBase
{
    private readonly ILogger<AuthorsController> _logger;
    private readonly IBookShelfContext _context;

    public AuthorsController(ILogger<AuthorsController> logger, IBookShelfContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<Author> FindOne(Guid Id)
    {
        return await _context.Authors.SingleAsync(a => a.Id == Id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthor(Guid Id)
    {
        var dbObject = await _context.Authors.SingleAsync(a => a.Id == Id);
        _context.Authors.Remove(dbObject);
        await _context.SaveChangesAsync();
        return Ok();
    }

    public record AuthorResult(Author author);

    public record AuthorUpdateResult(Author author, bool Updated);

    public record AuthorMergedResult(Author author, bool Merged);

    [HttpPatch("{id}")]
    public async Task<AuthorMergedResult> UpdateAuthor(Guid Id, Author newData)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}/match")]
    public async Task<AuthorUpdateResult> UpdateAuthorMatch(Guid Id, Author newData)
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}/image")]
    public async Task<AuthorResult> SetAuthorImage(Guid Id, byte[] imageStream)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}/image")]
    public async Task<AuthorResult> DeleteAuthorImage(Guid Id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}/image")]
    public async Task<IActionResult> FindImage(Guid Id)
    {
        throw new NotImplementedException();
        //byte[] fileBytes = new byte[] { };
        //await Task.CompletedTask;
        //return File(fileBytes, "image/jpeg");
    }
    // * GET: /api/authors/:id
    // * PATCH: /api/authors/:id
    // * DELETE: /api/authors/:id
    // * POST: /api/authors/:id/image
    // * DELETE: /api/authors/:id/image
    // * POST: /api/authors/:id/match
    // * GET: /api/authors/:id/image
}
