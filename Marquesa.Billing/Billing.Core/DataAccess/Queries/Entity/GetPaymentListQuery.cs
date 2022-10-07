namespace Billing.Core.DataAccess.Queries.Entity;

public class GetPaymentListQuery :GetPaymentListRequest, IRequest<QueryResponse<List<PaymentResponse>>>
{
    
}