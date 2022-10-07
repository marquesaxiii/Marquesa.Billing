namespace Billing.Core.DataAccess.Queries.Entity;

public class GetBillingInformationListQuery :GetBillingInformationListRequest, IRequest<QueryResponse<List<BillingInformationResponse>>>
{
    
}