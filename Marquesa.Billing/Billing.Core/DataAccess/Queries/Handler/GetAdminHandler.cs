namespace Billing.Core.DataAccess.Queries.Handler;

public class GetAdminHandler : QueryBaseHandler, IRequestHandler<GetAdminQuery, QueryResponse<AdminResponse>>
{
    public GetAdminHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    public async Task<QueryResponse<AdminResponse>> Handle(GetAdminQuery request, CancellationToken cancellationToken)
    {
        var admin = await Context.Admins
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);

        if (admin is null)
        {
            return new()
            {
                Message = "Admin not found",
            };
        }

        return new()
        {
            Response = admin.Adapt<AdminResponse>()
        };

    }
}