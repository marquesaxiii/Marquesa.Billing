namespace Billing.Core.DataAccess.Queries;

public class QueryResponse<T>
{
    public T Response { get; set; }
    public string Message { get; set; }
}