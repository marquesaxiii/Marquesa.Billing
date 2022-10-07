namespace Billing.Domain.Shared.Contracts.Requests.Create;

public class CreateBillingInformationRequest : RequestBase
{
    public double PresentReading { get; set; }
    public double PreviousReading { get; set; }
    public double CurrentRate { get; set; }
    public double Amount { get; set; }
    public double Balance { get; set; }
    public double PreviousBalance { get; set; }
    public DateOnly DueDate { get; set; }
    public DateOnly ReadingDate { get; set; }
  
}