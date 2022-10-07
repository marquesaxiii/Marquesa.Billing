namespace Billing.Core.DataAccess.Commands.Handler;

public class UpdateBillingAccountHandler : CommandBaseHandler, IRequestHandler<UpdateBillingAccountCmd, CmdResponse<UpdateBillingAccountCmd>>
{
    public UpdateBillingAccountHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<UpdateBillingAccountCmd>> Handle(UpdateBillingAccountCmd request, CancellationToken cancellationToken)
    {
        var existingAccount = await Context.BillingAccounts.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingAccount is null)
        {
            return new()
            {
                Message = "Account not found",
            };
        }
        var updatedAccount = request.Adapt(existingAccount);

        if (request.ClientGuid is null)
        {
            var client = await Context.Clients.FirstOrDefaultAsync(x => x.Guid == $"{request.ClientGuid}", CancellationToken.None);
            if (client is null)
            {
                return new()
                {
                    Message = "Client not found",
                };
            }
            updatedAccount.Client = client;
        }

        if (request.AdminGuid is null)
        {
            var admin = await Context.Admins.FirstOrDefaultAsync(x => x.Guid == $"{request.AdminGuid}", CancellationToken.None);
            if (admin is null)
            {
                return new()
                {
                    Message = "Admin not found",
                };
            }
            updatedAccount.Admin = admin;
        }

        if (request.InformationGuid is null)
        {
            var information = await Context.BillingInformations.FirstOrDefaultAsync(x => x.Guid == $"{request.InformationGuid}", CancellationToken.None);
            if (information is null)
            {
                return new()
                {
                    Message = "Billing information not found",
                };
            }
            updatedAccount.Information = information;
        }
        
        
        Context.Update(updatedAccount);
        
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Account updated"
        };
    }
}