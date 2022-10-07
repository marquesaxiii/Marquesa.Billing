namespace Billing.Domain.Shared.Contracts.Requests.Update;

public class UpdateBillingAccountRequest : RequestBase
{
    public Guid? ClientGuid { get; set; }
    public Guid? AdminGuid { get; set; }
    public short? Status { get; set; }
    public Guid? InformationGuid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool? IsDeleted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}