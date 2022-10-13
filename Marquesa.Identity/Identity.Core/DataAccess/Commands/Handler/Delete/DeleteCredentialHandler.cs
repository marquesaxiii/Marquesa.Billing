namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteCredentialHandler : CommandBaseHandler, IRequestHandler<DeleteCredentialCmd, CmdResponse<DeleteCredentialCmd>>
{
    public DeleteCredentialHandler()
    {
        
    }
    public async Task<CmdResponse<DeleteCredentialCmd>> Handle(DeleteCredentialCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}