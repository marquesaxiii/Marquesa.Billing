namespace Billing.Domain.Shared.Contracts.Requests.Update;

public class UpdateAdminRequest : RequestBase
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}