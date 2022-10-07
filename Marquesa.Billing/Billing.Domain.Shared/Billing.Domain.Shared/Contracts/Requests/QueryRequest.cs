namespace Billing.Domain.Shared.Contracts.Requests;

public class QueryRequest
{
    public string Search { get; set; }
    public int History { get; set; } = 5;
}