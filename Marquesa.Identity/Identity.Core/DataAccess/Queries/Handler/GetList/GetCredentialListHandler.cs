namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetCredentialListHandler : QueryBaseHandler, IRequestHandler<GetCredentialListQuery, QueryResponse<List<CredentialResponse>>>
{
    public GetCredentialListHandler()
    {
        
    }
    public async Task<QueryResponse<List<CredentialResponse>>> Handle(GetCredentialListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}