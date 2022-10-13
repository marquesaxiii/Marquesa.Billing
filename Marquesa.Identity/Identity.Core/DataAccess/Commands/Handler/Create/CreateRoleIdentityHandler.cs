namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateRoleIdentityHandler : CommandBaseHandler, IRequestHandler<CreateRoleIdentityCmd, CmdResponse<CreateRoleIdentityCmd>>
{
    public CreateRoleIdentityHandler()
    {
        
    }
    public async Task<CmdResponse<CreateRoleIdentityCmd>> Handle(CreateRoleIdentityCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}