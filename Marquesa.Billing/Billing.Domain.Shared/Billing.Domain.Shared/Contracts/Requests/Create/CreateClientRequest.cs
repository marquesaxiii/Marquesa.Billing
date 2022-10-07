namespace Billing.Domain.Shared.Contracts.Requests.Create;

public class CreateClientRequest : RequestBase
{
    public string? Name { get; set; }
    public int Contact { get; set; }
    public string? Address { get; set; }
 
}