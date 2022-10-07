namespace Billing.Core.DataAccess.Queries.Handler;

public class GetBillingInformationHandler : QueryBaseHandler, IRequestHandler<GetBillingInformationQuery, QueryResponse<BillingInformationResponse>>
{
    public GetBillingInformationHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<BillingInformationResponse>> Handle(GetBillingInformationQuery request, CancellationToken cancellationToken)
    {
        var information = await Context.BillingInformations
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);

        if (information is null)
        {
            return new()
            {
                Message = "Billing information not found",
            };
        }

        return new()
        {
            Response = information.Adapt<BillingInformationResponse>()
        };
    }
}