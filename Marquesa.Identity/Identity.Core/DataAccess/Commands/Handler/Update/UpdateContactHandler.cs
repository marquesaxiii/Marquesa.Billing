namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateContactHandler : CommandBaseHandler, IRequestHandler<UpdateContactCmd, CmdResponse<UpdateContactCmd>>
{
    public UpdateContactHandler()
    {
        
    }
    public async Task<CmdResponse<UpdateContactCmd>> Handle(UpdateContactCmd request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}