namespace Travel.Domain.Shared.Responses;

public class AgencyResponse
{
    public string Name { get; set; } = null!;
    public int Contact { get; set; }
    public string Address { get; set; } = null!;
    public int Rating { get; set; }
    public short Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool IsDeleted { get; set; }
    public bool? IsEnabled { get; set; }
    public string Guid { get; set; } = null!;
    public string Email { get; set; } = null!;
}