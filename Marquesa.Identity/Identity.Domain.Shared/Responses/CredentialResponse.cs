namespace Identity.Domain.Shared.Responses;

public class CredentialResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public short Status { get; set; }
    
    public IdentityInformationResponse? IdentityInformation { get; set; }
}