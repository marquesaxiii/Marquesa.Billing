namespace Identity.Domain.Shared.Requests.Create;

public class CreateRoleIdentityRequest : RequestBase
{
    public short RoleLevel { get; set; }
    public string? Description { get; set; }
}