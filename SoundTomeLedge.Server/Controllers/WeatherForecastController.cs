using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoundTomeLedge.DbContext;

namespace SoundTomeLedge.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IBookShelfContext _context;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IBookShelfContext context
    )
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("count")]
    public int GetCount()
    {
        return (_context.Libraries.Count());
    }

    [HttpGet]
    public IEnumerable<Library> Get()
    {
        //if (_context.Libraries.Take(1).Count() == 1)
        //{
        //    var library = _context.Libraries.Take(1).Single();
        //    library.Books.Add(
        //        new Book
        //        {
        //            ASIN = "123",
        //            Abridged = false,
        //            Description = "A Book.",
        //            ISBN = "897321",
        //            Explicit = false,

        //            Language = "English",
        //            PublishedDate = DateTimeOffset.Now.AddYears(-3).AddDays(-173).ToString(),
        //            PublishedYear = "2022",
        //            Title = "My Magic Book",
        //            UpdatedAt = DateTimeOffset.Now,
        //            CreatedAt = DateTimeOffset.Now,
        //            Library = library,
        //        }
        //    );
        //    _context.SaveChanges();
        //}
        return _context.Libraries.Include(l => l.Books).ToArray();
    }
}
