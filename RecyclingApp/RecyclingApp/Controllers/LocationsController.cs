using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecyclingApp.BusinessLogic;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.Dto;
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
    public async Task<IActionResult> GetLocations([FromQuery] FilterParameters parameters)
    {
        return Ok(await _orchestrator.GetRecyclingLocationsAsync(parameters));
    }

    [HttpPost]
    public async Task<IActionResult> CreateLocation([FromBody] RecyclingPlace item)
    {
        await _orchestrator.CreateRecyclingLocationAsync(item);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveLocation(int id)
    {
        var location = await _orchestrator.GetRecyclingLocationAsync(id);

        if (location is null)
        {
            return NotFound();
        }

        await _orchestrator.RemoveRecyclingLocation(location);

        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetLocation(int id)
    {
        var location = await _orchestrator.GetRecyclingLocationAsync(id);

        if (location is null)
        {
            return NotFound();
        }

        return Ok(location);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLocation(UpdatePlaceDto place)
    {
        return Ok(await _orchestrator.UpdateLocationAsync(place));
    }
}