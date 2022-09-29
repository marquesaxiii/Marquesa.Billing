namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetAddressListHandler : QueryBaseHandler, IRequestHandler<GetAddressListQuery, QueryResponse<List<AddressResponse>>>
{
    public GetAddressListHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }

    public async Task<QueryResponse<List<AddressResponse>>> Handle(GetAddressListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}