namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteRoleHandler : CommandBaseHandler, IRequestHandler<DeleteRoleCmd, CmdResponse<DeleteRoleCmd>>
{
    public DeleteRoleHandler()
    {
        
    }
    public async Task<CmdResponse<DeleteRoleCmd>> Handle(DeleteRoleCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}