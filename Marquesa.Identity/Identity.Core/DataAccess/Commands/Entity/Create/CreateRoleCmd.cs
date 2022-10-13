using Identity.Domain.Shared.Requests.Create;

namespace Identity.Core.DataAccess.Commands.Entity.Create;

public class CreateRoleCmd : CreateRoleRequest, IRequest<CmdResponse<CreateRoleCmd>>
{
    
}