using Identity.Domain.Shared.Requests.Update;

namespace Identity.Core.DataAccess.Commands.Entity.Update;

public class UpdateRoleCmd : UpdateRoleRequest, IRequest<CmdResponse<UpdateRoleCmd>>
{
    
}