namespace Billing.Core.DataAccess.Commands.Handler;

public class CreateBillingAccountHandler : CommandBaseHandler, IRequestHandler<CreateBillingAccountCmd, CmdResponse<CreateBillingAccountCmd>>
{
    public CreateBillingAccountHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<CreateBillingAccountCmd>> Handle(CreateBillingAccountCmd request, CancellationToken cancellationToken)
    {
        var client = await Context.Clients.FirstOrDefaultAsync(x => x.Guid == $"{request.ClientGuid}", CancellationToken.None);
        if (client is null)
        {
            return new()
            {
                Message = "Client not found",
            };
        }

        var admin = await Context.Admins.FirstOrDefaultAsync(x => x.Guid == $"{request.AdminGuid}", CancellationToken.None);
        if (admin is null)
        {
            return new()
            {
                Message = "Admin not found",
            };
        }

        var information = await Context.BillingInformations.FirstOrDefaultAsync(x => x.Guid == $"{request.InformationGuid}", CancellationToken.None);
        if (information is null)
        {
            return new()
            {
                Message = "Billing information not found",
            };
        }
        
        var account = request.Adapt<BillingAccount>();
        account.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";
        account.Client = client;
        account.Admin = admin;
        account.Information = information;
        account.CreatedAt = DateTime.UtcNow;
        
        await Context.BillingAccounts.AddAsync(account, CancellationToken.None);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Billing account created",
        };
    }
}