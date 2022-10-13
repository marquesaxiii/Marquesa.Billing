namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateRoleIdentityHandler : CommandBaseHandler, IRequestHandler<UpdateRoleIdentityCmd, CmdResponse<UpdateRoleIdentityCmd>>
{
    public UpdateRoleIdentityHandler()
    {
        
    }
    public async Task<CmdResponse<UpdateRoleIdentityCmd>> Handle(UpdateRoleIdentityCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}