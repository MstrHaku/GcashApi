using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Home/GCashMain")]
public class PaymentController : ControllerBase
{
    [HttpPost]
    public IActionResult ProcessPayment([FromBody] PaymentRequest req)
    {   
        Console.WriteLine($"Message from client: {req.Message}");

        // DIRECT
        string url = "https://prettied-punchily-angeles.ngrok-free.dev/";

        return Ok(new { status = "Success", redirect = url});
    }
}