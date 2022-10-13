namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetIdentityInformationListHandler : QueryBaseHandler, IRequestHandler<GetIdentityInformationListQuery, QueryResponse<List<IdentityInformationResponse>>>
{
    public GetIdentityInformationListHandler()
    {
        
    }
    public async Task<QueryResponse<List<IdentityInformationResponse>>> Handle(GetIdentityInformationListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}