namespace Identity.Domain.Shared.Requests.Create;

public class CreateContactRequest : RequestBase
{
    public int MobileNumber { get; set; }
    public string? EmailAddress { get; set; }
}