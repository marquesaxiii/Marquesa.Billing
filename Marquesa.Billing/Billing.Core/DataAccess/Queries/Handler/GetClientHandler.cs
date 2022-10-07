namespace Billing.Core.DataAccess.Queries.Handler;

public class GetClientHandler : QueryBaseHandler, IRequestHandler<GetClientQuery, QueryResponse<ClientResponse>>
{
    public GetClientHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<ClientResponse>> Handle(GetClientQuery request, CancellationToken cancellationToken)
    {
        var client = await Context.Clients
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);

        if (client is null)
        {
            return new()
            {
                Message = "Client not found",
            };
        }

        return new()
        {
            Response = client.Adapt<ClientResponse>()
        };
    }
}