namespace SoundTomeLedge.DbContext;

public class EreaderDevice
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string AvailabilityOption { get; set; }
    public List<EreaderDeviceUser> Users { get; set; } = new();
}

public class EreaderDeviceUser
{
    public required EreaderDevice EreaderDevice { get; set; }
    public required User User { get; set; }
}
