namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteIdentityInformationHandler : CommandBaseHandler, IRequestHandler<DeleteIdentityInformationCmd, CmdResponse<DeleteIdentityInformationCmd>>
{
    public DeleteIdentityInformationHandler()
    {
        
    }
    public async Task<CmdResponse<DeleteIdentityInformationCmd>> Handle(DeleteIdentityInformationCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}