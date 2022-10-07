namespace Billing.Domain.Shared.Contracts.Responses;

public class ClientResponse
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public string? Address { get; set; }
    public string? Guid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}