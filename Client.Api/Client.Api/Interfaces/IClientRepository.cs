using Client.Api.DataTransferObjects;

namespace Client.Api.Interfaces;

public interface IClientRepository
{
    Task<List<ClientInfo>> GetAllClients();
    Task<ClientInfo> GetClientById(int id);
    Task<ClientInfo> CreateClient(ClientInfo client);
    Task<ClientInfo> UpdateClient(ClientInfo client);
    
}