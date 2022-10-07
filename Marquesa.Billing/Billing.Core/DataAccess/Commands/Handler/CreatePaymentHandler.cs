namespace Billing.Core.DataAccess.Commands.Handler;

public class CreatePaymentHandler : CommandBaseHandler, IRequestHandler<CreatePaymentCmd, CmdResponse<CreatePaymentCmd>>
{
    public CreatePaymentHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<CreatePaymentCmd>> Handle(CreatePaymentCmd request, CancellationToken cancellationToken)
    {
        var account = await Context.BillingAccounts.FirstOrDefaultAsync(x => x.Guid == $"{request.AccountGuid}", CancellationToken.None);
        if (account is null)
        {
            return new()
            {
                Message = "Account not found",
            };
        }

        var payment = request.Adapt<Payment>();
        payment.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";
        payment.Account = account;
        payment.CreatedAt = DateTime.UtcNow;
        
        await Context.Payments.AddAsync(payment, CancellationToken.None);
        await Context.SaveChangesAsync(CancellationToken.None);

        return new()
        {
            Message = "Payment created successfully",
        };
    }
}