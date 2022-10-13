namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateAddressHandler : CommandBaseHandler, IRequestHandler<CreateAddressCmd, CmdResponse<CreateAddressCmd>>
{
    public CreateAddressHandler(MarquesaSystemContext context, IDataLayer dataLayer)
    {
        _context = context;
        _dataLayer = dataLayer;
    }
    public async Task<CmdResponse<CreateAddressCmd>> Handle(CreateAddressCmd request, CancellationToken cancellationToken)
    {
        var address = request.Adapt<Address>();
        address.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";

        await _context.Addresses.AddAsync(address, CancellationToken.None);
        await _context.SaveChangesAsync(CancellationToken.None);

        request.Guid = Guid.Parse(address.Guid);
        return new()
        {
            Message = "Address created successfully",
            HttpStatusCode = HttpStatusCode.Accepted,
        };
    }
}