using Microsoft.AspNetCore.Mvc;

namespace PizzaDelivery.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaDeliveryController : ControllerBase
{
    private readonly ILogger<PizzaDeliveryController> _logger;

    public PizzaDeliveryController(ILogger<PizzaDeliveryController> logger)
    {
        _logger = logger;
    }

    // -------- Dapr Pub/Sub -------- //


    // -------- Application routes -------- //
    
}

