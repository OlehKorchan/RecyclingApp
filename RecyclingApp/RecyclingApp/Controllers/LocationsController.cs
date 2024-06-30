using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.Orchestrators.Interfaces;

namespace RecyclingApp.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationsController : ControllerBase
{
    private readonly ILogger<LocationsController> _logger;

    private readonly ILocationsOrchestrator _orchestrator;

    public LocationsController(ILogger<LocationsController> logger, ILocationsOrchestrator orchestrator)
    {
        _logger = logger;
        _orchestrator = orchestrator;
    }

    [HttpGet]
    public async Task<IActionResult> GetLocations()
    {
        return Ok(await _orchestrator.GetRecyclingLocationsAsync());
    }

    [HttpPost]
    public async Task<IActionResult> CreateLocation([FromBody] RecyclingPlace item)
    {
        return Ok(await _orchestrator.CreateRecyclingLocationAsync(item));
    }
}