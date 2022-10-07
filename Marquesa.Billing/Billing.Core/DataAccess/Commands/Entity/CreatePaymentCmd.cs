namespace Billing.Core.DataAccess.Commands.Entity;

public class CreatePaymentCmd : CreatePaymentRequest, IRequest<CmdResponse<CreatePaymentCmd>>
{
}