namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetContactListHandler : QueryBaseHandler, IRequestHandler<GetContactListQuery, QueryResponse<List<ContactResponse>>>
{
    public GetContactListHandler()
    {
        
    }
    public async Task<QueryResponse<List<ContactResponse>>> Handle(GetContactListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}