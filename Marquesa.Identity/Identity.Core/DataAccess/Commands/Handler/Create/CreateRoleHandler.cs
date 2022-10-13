namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateRoleHandler : CommandBaseHandler, IRequestHandler<CreateRoleCmd, CmdResponse<CreateRoleCmd>>
{
    public CreateRoleHandler()
    {
        
    }
    public async Task<CmdResponse<CreateRoleCmd>> Handle(CreateRoleCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}