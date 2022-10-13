namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetRoleEntityHandler : QueryBaseHandler, IRequestHandler<GetRoleEntityQuery, QueryResponse<RoleEntityResponse>>
{
    public GetRoleEntityHandler()
    {
        
    }
    public async Task<QueryResponse<RoleEntityResponse>> Handle(GetRoleEntityQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}