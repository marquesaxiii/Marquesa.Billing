namespace Identity.Domain.Shared.Requests.Update;

public class UpdateRoleIdentityRequest : RequestBase
{
    public short RoleLevel { get; set; }
    public string? Description { get; set; }
}