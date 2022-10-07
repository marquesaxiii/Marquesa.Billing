namespace Billing.Core.DataAccess.Commands.Handler;

public class UpdateClientHandler : CommandBaseHandler, IRequestHandler<UpdateClientCmd, CmdResponse<UpdateClientCmd>>
{
    public UpdateClientHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<UpdateClientCmd>> Handle(UpdateClientCmd request, CancellationToken cancellationToken)
    {
        var existingClient = await Context.Clients.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingClient is null)
        {
            return new()
            {
                Message = "Client not found",
            };
        }
        var updatedClient = request.Adapt(existingClient);

        Context.Update(updatedClient);
        await Context.SaveChangesAsync(CancellationToken.None);

        return new()
        {
            Message = "Client updated"
        };
    }
}