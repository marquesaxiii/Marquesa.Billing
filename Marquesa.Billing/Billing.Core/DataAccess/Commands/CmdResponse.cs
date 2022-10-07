namespace Billing.Core.DataAccess.Commands;

public class CmdResponse<T>
{
    public T Response { get; set; }
    public string Message { get; set; }
}