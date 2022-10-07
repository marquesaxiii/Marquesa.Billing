namespace Identity.Domain.Shared.Requests.Create;

public class CreateAddressRequest : RequestBase
{
    public string? UnitNumber { get; set; }
    public string? Street { get; set; }
    public string? Building { get; set; }
    public string? Barangay { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
}