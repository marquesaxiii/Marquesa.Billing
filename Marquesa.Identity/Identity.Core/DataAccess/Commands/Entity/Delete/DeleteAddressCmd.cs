using Identity.Domain.Shared.Requests.Delete;

namespace Identity.Core.DataAccess.Commands.Entity.Delete;

public class DeleteAddressCmd : DeleteAddressRequest, IRequest<CmdResponse<DeleteAddressCmd>>
{
    
}