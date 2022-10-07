namespace Identity.Domain.Shared.Responses;

public class IdentityInformationResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public short Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public short CivilStatus { get; set; }

    public AddressResponse? Address { get; set; }
    public ContactResponse? Contact { get; set; }
}