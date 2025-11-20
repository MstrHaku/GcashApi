using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Home/GCashMain")]
public class PaymentController : Controller
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public PaymentController(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpPost]
    public IActionResult ProcessPayment([FromBody] PaymentRequest req)
    {   
        // SEND DATA TO MAIN CONTROLLER
        var context = _httpContextAccessor.HttpContext;

        if (context != null)
        {
            context.Session.SetString("PaymentData", JsonSerializer.Serialize(req));
        } else
        {
            Console.WriteLine("HttpContext is not available");
        }

        return RedirectToAction("GCashMain", "GCash");
    }
}