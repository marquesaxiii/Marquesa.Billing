namespace Identity.Domain.Shared.Responses;

public class RoleResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }

    public RoleEntityResponse? Entity { get; set; }
    public CredentialResponse? Credential { get; set; }
}