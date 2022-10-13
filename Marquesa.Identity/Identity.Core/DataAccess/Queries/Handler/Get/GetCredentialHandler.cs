namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetCredentialHandler : QueryBaseHandler, IRequestHandler<GetCredentialQuery, QueryResponse<CredentialResponse>>
{
    public GetCredentialHandler()
    {
        
    }
    public async Task<QueryResponse<CredentialResponse>> Handle(GetCredentialQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}