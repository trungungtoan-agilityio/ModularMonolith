using Microsoft.AspNetCore.Mvc;

namespace Module.Catalog.Controllers;

[ApiController]
[Route("/api/catalog/[controller]")]
internal class BrandsController : ControllerBase
{
    [HttpGet]
    public Task<IActionResult> GetAllAsync()
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}