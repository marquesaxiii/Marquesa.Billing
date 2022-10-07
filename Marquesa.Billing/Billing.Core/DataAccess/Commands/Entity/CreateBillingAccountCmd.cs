namespace Billing.Core.DataAccess.Commands.Entity;

public class CreateBillingAccountCmd : CreateBillingAccountRequest, IRequest<CmdResponse<CreateBillingAccountCmd>>
{
}