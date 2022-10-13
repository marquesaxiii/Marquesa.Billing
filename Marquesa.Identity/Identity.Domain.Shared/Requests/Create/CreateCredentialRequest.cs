namespace Identity.Domain.Shared.Requests.Create;

public class CreateCredentialRequest : RequestBase
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public short Status { get; set; }
    public Guid? IdentityInformationGuid { get; set; }
}