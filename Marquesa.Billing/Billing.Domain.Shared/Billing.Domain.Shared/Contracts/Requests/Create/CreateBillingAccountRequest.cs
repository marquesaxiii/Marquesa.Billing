namespace Billing.Domain.Shared.Contracts.Requests.Create;

public class CreateBillingAccountRequest : RequestBase
{
    public Guid? ClientGuid { get; set; }
    public Guid? AdminGuid { get; set; }
    public short? Status { get; set; }
    public Guid? InformationGuid { get; set; }
   
}