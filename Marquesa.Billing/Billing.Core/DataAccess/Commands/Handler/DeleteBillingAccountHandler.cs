namespace Billing.Core.DataAccess.Commands.Handler;

public class DeleteBillingAccountHandler : CommandBaseHandler, IRequestHandler<DeleteBillingAccountCmd, CmdResponse<DeleteBillingAccountCmd>>
{
    public DeleteBillingAccountHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<DeleteBillingAccountCmd>> Handle(DeleteBillingAccountCmd request, CancellationToken cancellationToken)
    {
        var existingAccount = await Context.BillingAccounts.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingAccount is null)
        {
            return new()
            {
                Message = "Account not found",
            };
        }
        
        existingAccount.IsDeleted = true;
        existingAccount.IsEnabled = false;

        Context.Update(existingAccount);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Account deleted",
        };
    }
}