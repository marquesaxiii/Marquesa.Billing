namespace Identity.Domain.Shared.Requests.Update;

public class UpdateContactRequest : RequestBase
{
    public int MobileNumber { get; set; }
    public string? EmailAddress { get; set; }
}