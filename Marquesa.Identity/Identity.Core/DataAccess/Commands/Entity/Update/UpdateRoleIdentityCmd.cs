using Identity.Domain.Shared.Requests.Update;

namespace Identity.Core.DataAccess.Commands.Entity.Update;

public class UpdateRoleIdentityCmd : UpdateRoleIdentityRequest, IRequest<CmdResponse<UpdateRoleIdentityCmd>>
{
    
}