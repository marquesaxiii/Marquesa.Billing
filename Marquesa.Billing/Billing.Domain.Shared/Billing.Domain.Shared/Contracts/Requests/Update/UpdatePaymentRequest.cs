namespace Billing.Domain.Shared.Contracts.Requests.Update;

public class UpdatePaymentRequest : RequestBase
{
    public DateOnly PaymentDate { get; set; }
    public short Status { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public Guid? AccountGuid { get; set; }
}