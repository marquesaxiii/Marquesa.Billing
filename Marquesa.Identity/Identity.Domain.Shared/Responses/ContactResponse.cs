namespace Identity.Domain.Shared.Responses;

public class ContactResponse
{
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool? IsEnabled { get; set; }
    public bool IsDeleted { get; set; }
    public int MobileNumber { get; set; }
    public string? EmailAddress { get; set; }
}