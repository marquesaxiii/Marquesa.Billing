namespace Billing.Core.DataAccess.Commands.Handler;

public class DeleteBillingInformationHandler : CommandBaseHandler, IRequestHandler<DeleteBillingInformationCmd, CmdResponse<DeleteBillingInformationCmd>>
{
    public DeleteBillingInformationHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<DeleteBillingInformationCmd>> Handle(DeleteBillingInformationCmd request, CancellationToken cancellationToken)
    {
        var existingInformation = await Context.BillingInformations.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingInformation is null)
        {
            return new()
            {
                Message = "Billing information not found",
            };
        }
        
        existingInformation.IsDeleted = true;
        existingInformation.IsEnabled = false;

        Context.Update(existingInformation);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Billing information deleted successfully",
        };
    }
}