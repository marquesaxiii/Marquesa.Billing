namespace Identity.Domain.Shared.Requests.Update;

public class UpdateIdentityInformationRequest : RequestBase
{
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public short Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public short CivilStatus { get; set; }
    public Guid? AddressGuid { get; set; }
    public Guid? ContactGuid { get; set; }
}