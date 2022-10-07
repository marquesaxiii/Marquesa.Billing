namespace Billing.Core.DataAccess.Commands.Handler;

public class CreateClientHandler : CommandBaseHandler, IRequestHandler<CreateClientCmd, CmdResponse<CreateClientCmd>>
{
    public CreateClientHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<CreateClientCmd>> Handle(CreateClientCmd request, CancellationToken cancellationToken)
    {
        var client = request.Adapt<Client>();
        client.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";
        client.CreatedAt = DateTime.UtcNow;
        
        await Context.Clients.AddAsync(client, CancellationToken.None);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Client created successfully",
        };
    }
}