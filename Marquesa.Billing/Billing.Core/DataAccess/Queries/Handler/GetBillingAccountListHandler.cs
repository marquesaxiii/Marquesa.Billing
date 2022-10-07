namespace Billing.Core.DataAccess.Queries.Handler;

public class GetBillingAccountListHandler : QueryBaseHandler, IRequestHandler<GetBillingAccountListQuery, QueryResponse<List<BillingAccountResponse>>>
{
    public GetBillingAccountListHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<List<BillingAccountResponse>>> Handle(GetBillingAccountListQuery request, CancellationToken cancellationToken)
    {
        var account = await Context.BillingAccounts
            .Include(x => x.Admin)
            .Include(x => x.Client)
            .Include(x => x.Information)
            .OrderBy(x => x.CreatedAt)
            .Take(request.History)
            .AsSplitQuery()
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!account.Any())
        {
            return new()
            {
                Message = "No billing account found",
            };
        }

        return new()
        {
            Response = account.Adapt<List<BillingAccountResponse>>()
        };
    }
}