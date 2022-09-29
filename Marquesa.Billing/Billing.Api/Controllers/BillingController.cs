using Microsoft.AspNetCore.Mvc;

namespace Billing.Api.Controllers;

public class BillingControllers : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}