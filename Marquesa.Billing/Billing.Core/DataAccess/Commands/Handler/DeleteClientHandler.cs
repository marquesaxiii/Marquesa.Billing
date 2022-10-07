namespace Billing.Core.DataAccess.Commands.Handler;

public class DeleteClientHandler : CommandBaseHandler, IRequestHandler<DeleteClientCmd, CmdResponse<DeleteClientCmd>>
{
    public DeleteClientHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<DeleteClientCmd>> Handle(DeleteClientCmd request, CancellationToken cancellationToken)
    {
        var existingClient = await Context.Clients.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingClient is null)
        {
            return new()
            {
                Message = "Client not found",
            };
        }
        
        existingClient.IsDeleted = true;
        existingClient.IsEnabled = false;

        Context.Update(existingClient);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Client deleted",
        };
    }
}