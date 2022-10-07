namespace Billing.Core.DataAccess.Commands.Handler;

public class UpdateAdminHandler : CommandBaseHandler, IRequestHandler<UpdateAdminCmd, CmdResponse<UpdateAdminCmd>>
{
    public UpdateAdminHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<UpdateAdminCmd>> Handle(UpdateAdminCmd request, CancellationToken cancellationToken)
    {
        var existingAdmin = await Context.Admins.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingAdmin is null)
        {
            return new()
            {
                Message = "Admin not found",
            };
        }
        var updatedAdmin = request.Adapt(existingAdmin);
        
        Context.Update(updatedAdmin);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Admin updated"
        };
    }
}