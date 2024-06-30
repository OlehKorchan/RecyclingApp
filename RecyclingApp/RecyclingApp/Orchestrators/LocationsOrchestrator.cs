using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.DataAccess.Interfaces;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.Orchestrators.Interfaces;

namespace RecyclingApp.Orchestrators;

public class LocationsOrchestrator : ILocationsOrchestrator
{
    private readonly ILocationsRepository _repository;

    public LocationsOrchestrator(ILocationsRepository repository)
    {
        _repository = repository;
    }

    public Task<List<RecyclingPlace>> GetRecyclingLocationsAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<bool> CreateRecyclingLocationAsync(RecyclingPlace item)
    {
        return _repository.CreateAsync(item);
    }
}