namespace SoundTomeLedge.DbContext;

public class ClientCustomMetadataProvider
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string AuthHeaderValue { get; set; }
    public MediaType MediaType { get; set; }
    public string Slug { get; set; }
}

public enum MediaType
{
    Book,
    Podcast

}
