namespace Billing.Core.DataAccess.Queries.Entity;

public class GetBillingAccountListQuery :GetBillingAccountListRequest, IRequest<QueryResponse<List<BillingAccountResponse>>>
{
    
}