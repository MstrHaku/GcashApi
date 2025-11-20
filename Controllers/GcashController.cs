using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GCashApi.Models;

namespace GCashApi.Controllers;

public class GCashController : Controller
{
    private readonly ILogger<GCashController> _logger;

    public GCashController(ILogger<GCashController> logger)
    {
        _logger = logger;
    }

    public IActionResult GCashMain()
    {


        return View();
    }
}
