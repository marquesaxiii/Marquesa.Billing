namespace Identity.Core.DataAccess.Commands.Handler.Delete;

public class DeleteAddressHandler : CommandBaseHandler, IRequestHandler<DeleteAddressCmd, CmdResponse<DeleteAddressCmd>>
{
    public DeleteAddressHandler(MarquesaSystemContext context,IDataLayer dataLayer)
    {
        _context = context;
        _dataLayer = dataLayer;
    }
    public async Task<CmdResponse<DeleteAddressCmd>> Handle(DeleteAddressCmd request, CancellationToken cancellationToken)
    {
        var existingAddress = await _context.Addresses.FirstOrDefaultAsync(x => x.Guid == $"{request.Guid}", CancellationToken.None);
        if (existingAddress is null)
        {
            return new()
            {
                HttpStatusCode = HttpStatusCode.NotFound,
                Message = "Address not found"
            };
        }
        
        existingAddress.IsDeleted = true;
        existingAddress.IsEnabled = false;

        _context.Update(existingAddress);
        await _context.SaveChangesAsync(CancellationToken.None);
        
        return new()
        {
            HttpStatusCode = HttpStatusCode.OK,
            Message = "Address deleted"
        };
    }
}