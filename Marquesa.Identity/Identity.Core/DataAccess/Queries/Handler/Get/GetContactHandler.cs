namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetContactHandler : QueryBaseHandler, IRequestHandler<GetContactQuery, QueryResponse<ContactResponse>>
{
    public GetContactHandler()
    {
        
    }
    public async Task<QueryResponse<ContactResponse>> Handle(GetContactQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}