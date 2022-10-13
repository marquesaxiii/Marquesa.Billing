namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteContactHandler : CommandBaseHandler, IRequestHandler<DeleteContactCmd, CmdResponse<DeleteContactCmd>>
{
    public DeleteContactHandler()
    {
        
    }
    public async Task<CmdResponse<DeleteContactCmd>> Handle(DeleteContactCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}