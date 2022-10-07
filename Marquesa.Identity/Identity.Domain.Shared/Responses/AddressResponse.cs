namespace Identity.Domain.Shared.Responses;

public class AddressResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public string? UnitNumber { get; set; }
    public string Street { get; set; }
    public string? Building { get; set; }
    public string? Barangay { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
}