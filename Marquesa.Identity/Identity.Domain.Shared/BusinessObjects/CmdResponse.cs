namespace Identity.Domain.Shared.BusinessObjects;

public class CmdResponse<T>
{
    public HttpStatusCode HttpStatusCode { get; set; }
    public string Message { get; set; }
    public T Response { get; set; }
}