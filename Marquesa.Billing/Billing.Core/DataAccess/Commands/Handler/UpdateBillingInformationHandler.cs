namespace Billing.Core.DataAccess.Commands.Handler;

public class UpdateBillingInformationHandler : CommandBaseHandler, IRequestHandler<UpdateBillingInformationCmd, CmdResponse<UpdateBillingInformationCmd>>
{
    public UpdateBillingInformationHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<UpdateBillingInformationCmd>> Handle(UpdateBillingInformationCmd request, CancellationToken cancellationToken)
    {
        var existingInformation = await Context.BillingInformations.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingInformation is null)
        {
            return new()
            {
                Message = "Billing information not found",
            };
        }
        var updatedInformation = request.Adapt(existingInformation);

        Context.Update(updatedInformation);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Billing information updated"
        };
    }
}