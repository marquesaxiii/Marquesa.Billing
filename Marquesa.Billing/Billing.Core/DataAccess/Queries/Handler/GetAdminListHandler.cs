namespace Billing.Core.DataAccess.Queries.Handler;

public class GetAdminListHandler : QueryBaseHandler, IRequestHandler<GetAdminListQuery, QueryResponse<List<AdminResponse>>>
{
    public GetAdminListHandler(MarquesaBillingContext context)
    {
        Context = context;
    }
    
    public async Task<QueryResponse<List<AdminResponse>>> Handle(GetAdminListQuery request, CancellationToken cancellationToken)
    {
        var admin = await Context.Admins
            .Where(x => EF.Functions.ILike(x.Name, $"%{request.Search}%"))
            .OrderBy(x => x.Name)
            .Take(request.History)
            .AsNoTracking()
            .ToListAsync(CancellationToken.None);

        if (!admin.Any())
        {
            return new()
            {
                Message = "No admin found",
            };
        }

        return new()
        {
            Response = admin.Adapt<List<AdminResponse>>()
        };
    }
}