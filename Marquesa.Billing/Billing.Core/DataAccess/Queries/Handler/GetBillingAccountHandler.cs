namespace Billing.Core.DataAccess.Queries.Handler;

public class GetBillingAccountHandler : QueryBaseHandler, IRequestHandler<GetBillingAccountQuery, QueryResponse<BillingAccountResponse>>
{
    public GetBillingAccountHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<BillingAccountResponse>> Handle(GetBillingAccountQuery request, CancellationToken cancellationToken)
    {
        var account = await Context.BillingAccounts
            .Include(x => x.Client)
            .Include(x => x.Admin)
            .Include(x => x.Information)
            .AsSplitQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);

        if (account is null)
        {
            return new()
            {
                Message = "Account not found",
            };
        }

        return new()
        {
            Response = account.Adapt<BillingAccountResponse>()
        };
    }
}