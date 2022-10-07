using Client.Api.DataTransferObjects;
using Client.Api.Interfaces;

namespace Client.Api.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly MarquesaSystemContext _context;

    public ClientRepository(MarquesaSystemContext context)
    {
        _context = context;
    }

    public async Task<List<ClientInfo>> GetAllClients()
    {
        throw new NotImplementedException();
    }

    public async Task<ClientInfo> GetClientById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ClientInfo> CreateClient(ClientInfo client)
    {
        throw new NotImplementedException();
    }
}