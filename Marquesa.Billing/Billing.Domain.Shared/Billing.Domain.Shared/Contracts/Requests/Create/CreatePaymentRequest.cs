namespace Billing.Domain.Shared.Contracts.Requests.Create;

public class CreatePaymentRequest : RequestBase
{
    public DateOnly PaymentDate { get; set; }
    public short Status { get; set; }
    public Guid? AccountGuid { get; set; }
}