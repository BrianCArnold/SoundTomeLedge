using Microsoft.AspNetCore.Mvc;

namespace fixedServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly BookShelfContext _context;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, BookShelfContext context)
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
    public IEnumerable<Book> Get()
    {
			 if (_context.Libraries.Take(1).Count() == 1)
			 {
					_context.Libraries.Take(1).Single().Books.Add(new Book{
						ASIN = "123",
						Abridged = false,
						Description = "A Book.",
						ISBN = "897321",
						Explicit = false,

						Language = "English",
						PublishedDate = DateTimeOffset.Now.AddYears(-3).AddDays(-173).ToString(),
						PublishedYear = "2022",
						Title = "My Magic Book",
						UpdatedAt = DateTimeOffset.Now,
						CreatedAt = DateTimeOffset.Now



							});
					_context.SaveChanges();
			 }
       return _context.Libraries.SelectMany(l=>l.Books).ToArray();

		}
}
