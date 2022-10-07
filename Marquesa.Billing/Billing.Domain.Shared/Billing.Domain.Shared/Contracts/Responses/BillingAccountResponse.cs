namespace Billing.Domain.Shared.Contracts.Responses;

public class BillingAccountResponse
{
    public short? Status { get; set; }
    public string? Guid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }

    public ClientResponse? Client { get; set; }
    public AdminResponse? Admin { get; set; }
    public BillingInformationResponse? Information { get; set; }
}