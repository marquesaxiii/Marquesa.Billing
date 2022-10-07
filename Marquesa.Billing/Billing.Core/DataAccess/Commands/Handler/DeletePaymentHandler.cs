namespace Billing.Core.DataAccess.Commands.Handler;

public class DeletePaymentHandler : CommandBaseHandler, IRequestHandler<DeletePaymentCmd, CmdResponse<DeletePaymentCmd>>
{
    public DeletePaymentHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<DeletePaymentCmd>> Handle(DeletePaymentCmd request, CancellationToken cancellationToken)
    {
        var existingPayment = await Context.Payments.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingPayment is null)
        {
            return new()
            {
                Message = "Payment not found",
            };
        }
        
        existingPayment.IsDeleted = true;
        existingPayment.IsEnabled = false;

        Context.Update(existingPayment);
        await Context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            Message = "Payment deleted",
        };
    }
}