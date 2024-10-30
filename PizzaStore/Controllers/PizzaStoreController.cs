using Microsoft.AspNetCore.Mvc;

namespace PizzaStore.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaStoreController : ControllerBase
{
    private readonly ILogger<PizzaStoreController> _logger;

    public PizzaStoreController(ILogger<PizzaStoreController> logger)
    {
        _logger = logger;
    }

    // -------- Dapr State Store -------- //

    // -------- Dapr Service Invocation -------- //

    // -------- Dapr Pub/Sub -------- //

    // -------- Application routes -------- //

}
