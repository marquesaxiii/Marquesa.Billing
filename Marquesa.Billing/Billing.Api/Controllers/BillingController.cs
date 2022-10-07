
using Billing.Core.DataAccess.Commands.Entity;
using Billing.Core.DataAccess.Queries;

namespace Billing.Api.Controllers;

public class BillingController : ControllerBase
{
   private readonly IMediator _mediator;
   
   public BillingController( IMediator mediator)
   {
      _mediator = mediator;
   }

   //GET LIST
   [HttpGet("List/Admin")]
   public async Task<QueryResponse<List<AdminResponse>>> AdminList(GetAdminListQuery query)
   {
      return await _mediator.Send(query);
   }
   
   [HttpGet("List/Client")]
   public async Task<QueryResponse<List<ClientResponse>>> ClientList(GetClientListQuery query)
   {
      return await _mediator.Send(query);
   }
   
   [HttpGet("List/BillingAccount")]
   public async Task<QueryResponse<List<BillingAccountResponse>>> BillingAccountList(GetBillingAccountListQuery query)
   {
      return await _mediator.Send(query);
   }
   
   [HttpGet("List/BillingInformation")]
   public async Task<QueryResponse<List<BillingInformationResponse>>> BillingInformationList(GetBillingInformationListQuery query)
   {
      return await _mediator.Send(query);
   }
   
   [HttpGet("List/Payment")]
   public async Task<QueryResponse<List<PaymentResponse>>> PaymentList(GetPaymentListQuery query)
   {
      return await _mediator.Send(query);
   }

   
   //GET BY GUID
   [HttpGet("Admin/{Guid}")]
   public async Task<QueryResponse<AdminResponse>> GetAdmin()
   {
      return await _mediator.Send(new GetAdminQuery());
   }
   
   [HttpGet("Client/{Guid}")]
   public async Task<QueryResponse<ClientResponse>> GetClient()
   {
      return await _mediator.Send(new GetClientQuery());
   }
   
   [HttpGet("BillingAccount/{Guid}")]
   public async Task<QueryResponse<BillingAccountResponse>> GetBillingAccount()
   {
      return await _mediator.Send(new GetBillingAccountQuery());
   }
   
   [HttpGet("BillingInformation/{Guid}")]
   public async Task<QueryResponse<BillingInformationResponse>> GetBillingInformation()
   {
      return await _mediator.Send(new GetBillingInformationQuery());
   }
   
   [HttpGet("Payment/{Guid}")]
   public async Task<QueryResponse<PaymentResponse>> GetPayment()
   {
      return await _mediator.Send(new GetPaymentQuery());
   }


   // CREATE
   [HttpPost("Create/Admin")]
   public async Task<IActionResult> CreateAdmin([FromBody] CreateAdminCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPost("Create/Client")]
   public async Task<IActionResult> CreateClient([FromBody] CreateClientCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPost("Create/BillingAccount")]
   public async Task<IActionResult> CreateBillingAccount([FromBody] CreateBillingAccountCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPost("Create/BillingInformation")]
   public async Task<IActionResult> CreateBillingInformation([FromBody] CreateBillingInformationCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPost("Create/Payment")]
   public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   // UPDATE
   [HttpPut("Update/Admin")]
   public async Task<IActionResult> UpdateAdmin([FromBody] UpdateAdminCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPut("Update/Client")]
   public async Task<IActionResult> UpdateClient([FromBody] UpdateClientCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPut("Update/BillingAccount")]
   public async Task<IActionResult> UpdateBillingAccount([FromBody] UpdateBillingAccountCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPut("Update/BillingInformation")]
   public async Task<IActionResult> UpdateBillingInformation([FromBody] UpdateBillingInformationCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpPut("Update/Payment")]
   public async Task<IActionResult> UpdatePayment([FromBody] UpdatePaymentCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   // DELETE
   [HttpDelete("Delete/Admin")]
   public async Task<IActionResult> DeleteAdmin([FromBody] DeleteAdminCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpDelete("Delete/Client")]
   public async Task<IActionResult> DeleteClient([FromBody] DeleteClientCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpDelete("Delete/BillingAccount")]
   public async Task<IActionResult> DeleteBillingAccount([FromBody] DeleteBillingAccountCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpDelete("Delete/BillingInformation")]
   public async Task<IActionResult> DeleteBillingInformation([FromBody] DeleteBillingInformationCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
   
   [HttpDelete("Delete/Payment")]
   public async Task<IActionResult> DeletePayment([FromBody] DeletePaymentCmd request)
   {
      var result = await _mediator.Send(request);
      return Ok(result);
   }
}