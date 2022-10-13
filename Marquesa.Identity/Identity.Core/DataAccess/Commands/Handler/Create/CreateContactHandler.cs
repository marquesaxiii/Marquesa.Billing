namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateContactHandler : CommandBaseHandler, IRequestHandler<CreateContactCmd, CmdResponse<CreateContactCmd>>
{
    public CreateContactHandler()
    {
        
    }
    public async Task<CmdResponse<CreateContactCmd>> Handle(CreateContactCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}