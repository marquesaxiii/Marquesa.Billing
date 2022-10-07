namespace Billing.Core.DataAccess.Queries.Handler;

public class GetBillingInformationListHandler : QueryBaseHandler, IRequestHandler<GetBillingInformationListQuery, QueryResponse<List<BillingInformationResponse>>>
{
    public GetBillingInformationListHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<List<BillingInformationResponse>>> Handle(GetBillingInformationListQuery request, CancellationToken cancellationToken)
    {
        var information = await Context.BillingInformations
            .OrderBy(x => x.CreatedAt)
            .Take(request.History)
            .AsSplitQuery()
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!information.Any())
        {
            return new()
            {
                Message = "No billing information found",
            };
        }

        return new()
        {
            Response = information.Adapt<List<BillingInformationResponse>>()
        };
    }
}