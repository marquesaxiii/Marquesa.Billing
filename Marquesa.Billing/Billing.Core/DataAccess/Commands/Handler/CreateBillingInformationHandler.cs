namespace Billing.Core.DataAccess.Commands.Handler;

public class CreateBillingInformationHandler : CommandBaseHandler, IRequestHandler<CreateBillingInformationCmd, CmdResponse<CreateBillingInformationCmd>>
{
    public CreateBillingInformationHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<CreateBillingInformationCmd>> Handle(CreateBillingInformationCmd request, CancellationToken cancellationToken)
    {
        var information = request.Adapt<BillingInformation>();
        information.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";
        information.CreatedAt = DateTime.UtcNow;
        
        await Context.BillingInformations.AddAsync(information, CancellationToken.None);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Billing information created successfully",
        };
    }
}