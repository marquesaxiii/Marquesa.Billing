namespace Travel.Domain.Shared.Requests.Update;

public class UpdateAgencyRequest
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public string? Address { get; set; }
    public int Rating { get; set; }
    public short Status { get; set; }
    public string? Guid { get; set; }
    public string? Email { get; set; }
}