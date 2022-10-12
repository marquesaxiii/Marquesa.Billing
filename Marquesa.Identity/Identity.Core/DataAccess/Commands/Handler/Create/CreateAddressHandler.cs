namespace Identity.Core.DataAccess.Commands.Handler.Create;

public class CreateAddressHandler : CommandBaseHandler, IRequestHandler<CreateAddressCmd, CmdResponse<CreateAddressCmd>>
{
    public CreateAddressHandler(IDataLayer dataLayer)
    {
        _dataLayer = dataLayer;
    }
    public async Task<CmdResponse<CreateAddressCmd>> Handle(CreateAddressCmd request, CancellationToken cancellationToken)
    {
        var address = request.Adapt<Address>();
        address.Guid = request.Guid is null ? $"{Guid.NewGuid()}" : $"{request.Guid}";

        await _dataLayer.MarquesaSystemContext.Addresses.AddAsync(address, CancellationToken.None);
        await _dataLayer.MarquesaSystemContext.SaveChangesAsync(CancellationToken.None);

        request.Guid = Guid.Parse(address.Guid);
        return new()
        {
            Message = "Address created successfully",
            HttpStatusCode = HttpStatusCode.Accepted,
        };
    }
}