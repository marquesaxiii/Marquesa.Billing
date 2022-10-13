namespace Identity.Domain.Shared.Requests.Create;

public class CreateRoleRequest : RequestBase
{
    public Guid? EntityGuid { get; set; }
    public Guid? CredentialGuid { get; set; }
}