using Client.Api.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Client.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ClientsController : ControllerBase
{
    private readonly MarquesaSystemContext _context;

    public ClientsController(MarquesaSystemContext context)
    {
        _context = context;
    }
    // GET
    [HttpGet]
    public async Task<IActionResult> GetAllClients()
    {
        var result = await _context.ClientInfos.ToListAsync();
        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetClients(int id)
    {
        var result = await _context.ClientInfos.FirstOrDefaultAsync(x => x.Id == id);
        return Ok(result);
    }
    
    // CREATE
    [HttpPost]
    public async Task<IActionResult> CreateClient([FromBody] ClientInfo clientInfo)
    {
        _context.ClientInfos.Add(clientInfo);
        await _context.SaveChangesAsync();
        return Ok(clientInfo);
    }
}