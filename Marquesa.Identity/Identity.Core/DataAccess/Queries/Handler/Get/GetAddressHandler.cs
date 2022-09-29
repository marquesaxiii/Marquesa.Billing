namespace Identity.Core.DataAccess.Queries.Handler.Get;

public class GetAddressHandler : QueryBaseHandler, IRequestHandler<GetAddressQuery, QueryResponse<AddressResponse>>
{
    public GetAddressHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }

    public async Task<QueryResponse<AddressResponse>> Handle(GetAddressQuery request, CancellationToken cancellationToken)
    {
        var address = await _dataLayer.MarquesaSystemContext
            
    }
}