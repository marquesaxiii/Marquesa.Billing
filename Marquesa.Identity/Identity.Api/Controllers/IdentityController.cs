using Identity.Core.DataAccess.Commands.Entity.Create;
using Identity.Core.DataAccess.Queries.Entity.Get;
using Identity.Core.DataAccess.Queries.Entity.GetList;
using Identity.Domain.Shared.BusinessObjects;
using Identity.Domain.Shared.Requests.Create;
using Identity.Domain.Shared.Requests.Delete;
using Identity.Domain.Shared.Requests.Update;
using Identity.Domain.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class IdentityController : Controller
{
   private readonly IMediator _mediator;

   public IdentityController(IMediator mediator)
   {
      _mediator = mediator;
   }
  
   // GET
   [HttpGet("GetAddress")]
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
   public async Task<IActionResult> CreateAddress([FromBody] CreateAddressRequest request)
   {
      var response = await _mediator.Send(request);
      return Ok(response);
   }
   
   
   // UPDATE
   [HttpPut("Update/Address")]
   public async Task<IActionResult> UpdateAddress([FromBody] UpdateAddressRequest request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }

   
   // DELETE
   [HttpDelete("Delete/Address")]
   public async Task<IActionResult> DeleteAddress([FromBody] DeleteAddressRequest request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
}
