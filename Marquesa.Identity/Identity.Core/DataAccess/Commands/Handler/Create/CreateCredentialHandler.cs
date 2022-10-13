namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateCredentialHandler : CommandBaseHandler, IRequestHandler<CreateCredentialCmd, CmdResponse<CreateCredentialCmd>>
{
    public CreateCredentialHandler()
    {
        
    }
    public async Task<CmdResponse<CreateCredentialCmd>> Handle(CreateCredentialCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}