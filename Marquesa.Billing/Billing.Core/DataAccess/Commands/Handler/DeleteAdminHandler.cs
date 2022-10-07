namespace Billing.Core.DataAccess.Commands.Handler;

public class DeleteAdminHandler : CommandBaseHandler, IRequestHandler<DeleteAdminCmd, CmdResponse<DeleteAdminCmd>>
{
    public DeleteAdminHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<DeleteAdminCmd>> Handle(DeleteAdminCmd request, CancellationToken cancellationToken)
    {
        var existingAdmin = await Context.Admins.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingAdmin is null)
        {
            return new()
            {
                Message = "Admin not found",
            };
        } 
        
        existingAdmin.IsDeleted = true;
        existingAdmin.IsEnabled = false;

        Context.Update(existingAdmin);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Admin deleted successfully",
        };
    }
}