namespace Identity.Domain.Shared.Requests.Update;

public class UpdateRoleRequest : RequestBase
{
    public Guid? EntityGuid { get; set; }
    public Guid? CredentialGuid { get; set; }
}