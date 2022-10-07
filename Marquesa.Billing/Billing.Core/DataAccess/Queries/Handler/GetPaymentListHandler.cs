namespace Billing.Core.DataAccess.Queries.Handler;

public class GetPaymentListHandler : QueryBaseHandler, IRequestHandler<GetPaymentListQuery, QueryResponse<List<PaymentResponse>>>
{
    public GetPaymentListHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<List<PaymentResponse>>> Handle(GetPaymentListQuery request, CancellationToken cancellationToken)
    {
        var payment = await Context.Payments
            .Include(x => x.Account)
            .OrderBy(x => x.CreatedAt)
            .AsSplitQuery()
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!payment.Any())
        {
            return new()
            {
                Message = "No payment found",
            };
        }

        return new()
        {
            Response = payment.Adapt<List<PaymentResponse>>()
        };
    }
}