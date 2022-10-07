using System.Net;
using Mapster;

namespace Identity.Core.DataAccess.Queries.Handler.GetList;

public class GetAddressListHandler : QueryBaseHandler, IRequestHandler<GetAddressListQuery, QueryResponse<List<AddressResponse>>>
{
    public GetAddressListHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }

    public async Task<QueryResponse<List<AddressResponse>>> Handle(GetAddressListQuery request, CancellationToken cancellationToken)
    {
        var address = await _dataLayer.MarquesaSystemContext.Addresses
            .OrderBy(x => x.CreatedAt)
            .Take(request.PageSize)
            .AsSplitQuery()
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!address.Any())
        {
            return new()
            {
                HttpStatusCode = HttpStatusCode.NotFound,
                Message = "No address found"
            };
        }

        return new()
        {
            Message = "Address Found",
            HttpStatusCode = HttpStatusCode.Accepted,
            Response = address.Adapt<List<AddressResponse>>()
        };
    }
}