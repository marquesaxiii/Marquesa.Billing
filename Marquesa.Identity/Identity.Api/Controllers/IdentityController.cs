using Identity.Core.DataAccess.Commands.Entity.Create;
using Identity.Core.DataAccess.Commands.Entity.Delete;
using Identity.Core.DataAccess.Commands.Entity.Update;
using Identity.Core.DataAccess.Queries.Entity.Get;
using Identity.Core.DataAccess.Queries.Entity.GetList;
using Identity.Domain.Shared.BusinessObjects;
using Identity.Domain.Shared.Requests.Create;
using Identity.Domain.Shared.Requests.Delete;
using Identity.Domain.Shared.Requests.Get;
using Identity.Domain.Shared.Requests.Update;
using Identity.Domain.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class IdentityController : ControllerBase
{
   private readonly IMediator _mediator;

   public IdentityController(IMediator mediator)
   {
      _mediator = mediator;
   }
  
   // GET
   [HttpGet("GetAddress/{Guid}")]
   public async Task<QueryResponse<AddressResponse>> GetAddress()
   {
      return await _mediator.Send(new GetAddressQuery());
   }
   
   // GET LIST
   [HttpGet("List/Address")]
   public async Task<QueryResponse<List<AddressResponse>>> ListAddress()
   {
      return await _mediator.Send(new GetAddressListQuery());
   }

   // CREATE
   [HttpPost("Create/Address")]
   public async Task<IActionResult> CreateAddress([FromBody] CreateAddressCmd request)
   {
      var response = await _mediator.Send(request);
      return Ok(response);
   }
   
   
   // UPDATE
   [HttpPut("Update/Address/{Guid}")]
   public async Task<IActionResult> UpdateAddress(Guid guid, [FromBody] UpdateAddressCmd request)
   {
      request.Guid = guid;
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   // DELETE
   [HttpDelete("Delete/Address/{Guid}")]
   public async Task<IActionResult> DeleteAddress(Guid guid, [FromBody] DeleteAddressCmd request)
   {
      request.Guid = guid;
      return Ok(await _mediator.Send(request));
   }
}
