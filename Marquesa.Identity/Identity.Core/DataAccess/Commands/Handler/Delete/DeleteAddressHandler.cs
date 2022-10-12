using Identity.Core.DataAccess.Commands.Entity.Delete;

namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteAddressHandler : CommandBaseHandler, IRequestHandler<DeleteAddressCmd, CmdResponse<DeleteAddressCmd>>
{
    public DeleteAddressHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }
    public async Task<CmdResponse<DeleteAddressCmd>> Handle(DeleteAddressCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}