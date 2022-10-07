namespace Billing.Domain.Shared.Contracts.Responses;

public class PaymentResponse
{
    public DateOnly PaymentDate { get; set; }
    public short Status { get; set; }
    public string? Guid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }

    public BillingAccountResponse? Account { get; set; }
}