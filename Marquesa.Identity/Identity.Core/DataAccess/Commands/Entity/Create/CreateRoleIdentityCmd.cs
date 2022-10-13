using Identity.Domain.Shared.Requests.Create;

namespace Identity.Core.DataAccess.Commands.Entity.Create;

public class CreateRoleIdentityCmd : CreateRoleIdentityRequest, IRequest<CmdResponse<CreateRoleIdentityCmd>>
{
    
}