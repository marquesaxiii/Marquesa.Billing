namespace Billing.Core.DataAccess.Commands.Handler;

public class CreateAdminHandler : CommandBaseHandler, IRequestHandler<CreateAdminCmd, CmdResponse<CreateAdminCmd>>
{
    public CreateAdminHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<CmdResponse<CreateAdminCmd>> Handle(CreateAdminCmd request, CancellationToken cancellationToken)
    {
        var admin = request.Adapt<Admin>();
        admin.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";
        admin.CreatedAt = DateTime.UtcNow;
        
        await Context.Admins.AddAsync(admin, CancellationToken.None);
        await Context.SaveChangesAsync(CancellationToken.None);

        return new CmdResponse<CreateAdminCmd>()
        {
            Message = "Admin created successfully",
        };
    }
}