namespace Travel.Domain.Shared.Requests.Create;

public class CreateAgencyRequest
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public string? Address { get; set; }
    public int Rating { get; set; }
    public short Status { get; set; }
    public string? Guid { get; set; }
    public string? Email { get; set; }
}