namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetIdentityInformationHandler : QueryBaseHandler, IRequestHandler<GetIdentityInformationQuery, QueryResponse<IdentityInformationResponse>>
{
    public GetIdentityInformationHandler()
    {
        
    }
    public async Task<QueryResponse<IdentityInformationResponse>> Handle(GetIdentityInformationQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}