namespace Identity.Domain.Shared.Requests;

public class QueryableRequest : RequestBase
{
    public int PageSize { get; set; } = 100;
    public string SearchField { get; set; }
}