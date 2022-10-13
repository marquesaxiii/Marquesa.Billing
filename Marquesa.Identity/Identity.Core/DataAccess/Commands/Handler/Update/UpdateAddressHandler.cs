namespace Identity.Core.DataAccess.Commands.Handler.Update;

public class UpdateAddressHandler : CommandBaseHandler, IRequestHandler<UpdateAddressCmd, CmdResponse<UpdateAddressCmd>>
{
    public UpdateAddressHandler(MarquesaSystemContext context,IDataLayer dataLayer)
    {
        _context = context;
        _dataLayer = dataLayer;
    }

    public async Task<CmdResponse<UpdateAddressCmd>> Handle(UpdateAddressCmd request, CancellationToken cancellationToken)
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
        var updatedAddress = request.Adapt(existingAddress);
        
        _context.Update(updatedAddress);
         await _context.SaveChangesAsync(CancellationToken.None);

         return new()
         {
             HttpStatusCode = HttpStatusCode.Accepted,
             Message = "Address updated"
         };
    }
}