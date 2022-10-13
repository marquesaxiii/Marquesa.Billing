namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetRoleListHandler : QueryBaseHandler, IRequestHandler<GetRoleListQuery, QueryResponse<List<RoleResponse>>>
{
    public GetRoleListHandler()
    {
        
    }
    public async Task<QueryResponse<List<RoleResponse>>> Handle(GetRoleListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}