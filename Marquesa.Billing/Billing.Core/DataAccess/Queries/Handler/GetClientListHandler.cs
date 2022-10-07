namespace Billing.Core.DataAccess.Queries.Handler;

public class GetClientListHandler : QueryBaseHandler, IRequestHandler<GetClientListQuery, QueryResponse<List<ClientResponse>>>
{
    public GetClientListHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<List<ClientResponse>>> Handle(GetClientListQuery request, CancellationToken cancellationToken)
    {
        var client = await Context.Clients
            .Where(x => EF.Functions.ILike(x.Name, $"%{request.Search}%"))
            .OrderBy(x => x.Name)
            .Take(request.History)
            .AsSplitQuery()
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!client.Any())
        {
            return new()
            {
                Message = "No client found",
            };
        }

        return new()
        {
            Response = client.Adapt<List<ClientResponse>>()
        };
    }
}