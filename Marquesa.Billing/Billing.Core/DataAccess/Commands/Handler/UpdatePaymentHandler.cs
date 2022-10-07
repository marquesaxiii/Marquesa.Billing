namespace Billing.Core.DataAccess.Commands.Handler;

public class UpdatePaymentHandler : CommandBaseHandler, IRequestHandler<UpdatePaymentCmd, CmdResponse<UpdatePaymentCmd>>
{
    public UpdatePaymentHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<UpdatePaymentCmd>> Handle(UpdatePaymentCmd request, CancellationToken cancellationToken)
    {
        var existingPayment = await Context.Payments.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingPayment is null)
        {
            return new()
            {
                Message = "Payment not found",
            };
        }
        var updatedPayment = request.Adapt(existingPayment);

        if (request.AccountGuid is null)
        {
            var account = await Context.BillingAccounts.FirstOrDefaultAsync(x => x.Guid == $"{request.AccountGuid}", CancellationToken.None);
            if (account is null)
            {
                return new()
                {
                    Message = "Account not found",
                };
            }
            updatedPayment.Account = account;
        }

        Context.Update(updatedPayment);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Payment updated",
        };
    }
}