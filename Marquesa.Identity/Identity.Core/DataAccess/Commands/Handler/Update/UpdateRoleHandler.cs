namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateRoleHandler : CommandBaseHandler, IRequestHandler<UpdateRoleCmd, CmdResponse<UpdateRoleCmd>>
{
    public UpdateRoleHandler()
    {
        
    }
    public async Task<CmdResponse<UpdateRoleCmd>> Handle(UpdateRoleCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}