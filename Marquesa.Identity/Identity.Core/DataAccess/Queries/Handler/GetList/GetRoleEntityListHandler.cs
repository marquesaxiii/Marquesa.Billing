namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetRoleEntityListHandler : QueryBaseHandler, IRequestHandler<GetRoleEntityListQuery, QueryResponse<List<RoleEntityResponse>>>
{
    public GetRoleEntityListHandler()
    {
        
    }
    public async Task<QueryResponse<List<RoleEntityResponse>>> Handle(GetRoleEntityListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}