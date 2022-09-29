namespace Identity.Domain.Shared.BusinessObjects;

public class QueryResponse<T>
{
    public HttpStatusCode HttpStatusCode { get; set; }
    public string Message { get; set; }
    public T Response { get; set; }
}