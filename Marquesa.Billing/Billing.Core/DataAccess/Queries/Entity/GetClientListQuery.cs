namespace Billing.Core.DataAccess.Queries.Entity;

public class GetClientListQuery :GetClientListRequest, IRequest<QueryResponse<List<ClientResponse>>>
{
    
}