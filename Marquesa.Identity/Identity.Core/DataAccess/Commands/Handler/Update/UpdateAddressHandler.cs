using Identity.Core.DataAccess.Commands.Entity.Update;
using Identity.Domain.Shared.Requests.Update;

namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateAddressHandler : CommandBaseHandler, IRequestHandler<UpdateAddressCmd, CmdResponse<UpdateAddressCmd>>
{
    public UpdateAddressHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }

    public async Task<CmdResponse<UpdateAddressCmd>> Handle(UpdateAddressCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}