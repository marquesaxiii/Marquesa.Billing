namespace Billing.Domain.Shared.Contracts.Responses;

public class BillingInformationResponse
{
    public double PresentReading { get; set; }
    public double PreviousReading { get; set; }
    public double CurrentRate { get; set; }
    public double Amount { get; set; }
    public double Balance { get; set; }
    public double PreviousBalance { get; set; }
    public DateOnly DueDate { get; set; }
    public DateOnly ReadingDate { get; set; }
    public string? Guid { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}