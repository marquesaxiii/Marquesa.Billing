namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateIdentityInformationHandler : CommandBaseHandler, IRequestHandler<CreateIdentityInformationCmd, CmdResponse<CreateIdentityInformationCmd>>
{
    public CreateIdentityInformationHandler()
    {
        
    }
    public async Task<CmdResponse<CreateIdentityInformationCmd>> Handle(CreateIdentityInformationCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}