namespace SoundTomeLedge;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder
            .Services.AddControllersWithViews()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        builder.Services.AddSingleton<ISoundTomeLedgeConfig, SoundTomeLedgeConfig>();
        builder.Services.AddSingleton<BookshelfContextFactory>();
        builder.Services.AddScoped<IBookShelfContext>(
            (isp) =>
            {
                return isp.GetRequiredService<BookshelfContextFactory>().CreateDbContext();
            }
        );

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(name: "default", pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html");
        ;

        app.Run();
    }
}
