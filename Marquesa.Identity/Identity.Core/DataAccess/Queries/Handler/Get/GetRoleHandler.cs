namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetRoleHandler : QueryBaseHandler, IRequestHandler<GetRoleQuery, QueryResponse<RoleResponse>>
{
    public GetRoleHandler()
    {
        
    }
    public async Task<QueryResponse<RoleResponse>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}