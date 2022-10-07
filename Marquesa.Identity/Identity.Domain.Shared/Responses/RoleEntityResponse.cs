namespace Identity.Domain.Shared.Responses;

public class RoleEntityResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public short RoleLevel { get; set; }
    public string? Description { get; set; }
}