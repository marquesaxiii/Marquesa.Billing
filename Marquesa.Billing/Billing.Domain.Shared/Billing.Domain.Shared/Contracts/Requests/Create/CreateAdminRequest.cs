namespace Billing.Domain.Shared.Contracts.Requests.Create;

public class CreateAdminRequest : RequestBase
{
    public string? Name { get; set; }
    public int Contact { get; set; }
}