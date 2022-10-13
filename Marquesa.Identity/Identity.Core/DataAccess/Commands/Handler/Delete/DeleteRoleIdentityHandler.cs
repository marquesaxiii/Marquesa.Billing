namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteRoleIdentityHandler : CommandBaseHandler, IRequestHandler<DeleteRoleIdentityCmd, CmdResponse<DeleteRoleIdentityCmd>>
{
    public DeleteRoleIdentityHandler()
    {
        
    }
    public async Task<CmdResponse<DeleteRoleIdentityCmd>> Handle(DeleteRoleIdentityCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}