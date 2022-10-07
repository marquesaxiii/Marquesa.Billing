namespace Billing.Domain.Shared.Contracts.Responses;

public class AdminResponse
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public string? Guid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}