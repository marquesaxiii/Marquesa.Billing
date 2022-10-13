namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateIdentityInformationHandler : CommandBaseHandler, IRequestHandler<UpdateIdentityInformationCmd, CmdResponse<UpdateIdentityInformationCmd>>
{
    public UpdateIdentityInformationHandler()
    {
        
    }
    public async Task<CmdResponse<UpdateIdentityInformationCmd>> Handle(UpdateIdentityInformationCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}