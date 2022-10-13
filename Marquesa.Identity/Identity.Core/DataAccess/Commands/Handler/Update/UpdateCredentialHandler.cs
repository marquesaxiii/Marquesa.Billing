namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateCredentialHandler : CommandBaseHandler, IRequestHandler<UpdateCredentialCmd, CmdResponse<UpdateCredentialCmd>>
{
    public UpdateCredentialHandler()
    {
        
    }
    public async Task<CmdResponse<UpdateCredentialCmd>> Handle(UpdateCredentialCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}