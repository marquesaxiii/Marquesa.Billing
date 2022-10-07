namespace Billing.Core.DataAccess.Queries.Handler;

public class GetPaymentHandler : QueryBaseHandler, IRequestHandler<GetPaymentQuery, QueryResponse<PaymentResponse>>
{
    public GetPaymentHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<PaymentResponse>> Handle(GetPaymentQuery request, CancellationToken cancellationToken)
    {
        var payment = await Context.Payments
            .Include(x => x.Account)
            .AsSplitQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);

        if (payment is null)
        {
            return new()
            {
                Message = "Payment not found",
            };
        }

        return new()
        {
            Response = payment.Adapt<PaymentResponse>()
        };
    }
}