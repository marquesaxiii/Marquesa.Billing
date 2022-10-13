using Identity.Domain.Shared.Requests.Create;

namespace Identity.Core.DataAccess.Commands.Entity.Create;

public class CreateCredentialCmd : CreateCredentialRequest, IRequest<CmdResponse<CreateCredentialCmd>>
{
    
}