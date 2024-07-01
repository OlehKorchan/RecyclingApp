using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.BusinessLogic;
using RecyclingApp.DataAccess.Interfaces;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.Dto;
using RecyclingApp.Orchestrators.Interfaces;

namespace RecyclingApp.Orchestrators;

public class LocationsOrchestrator : ILocationsOrchestrator
{
    private readonly IRepository<RecyclingPlace> _repository;

    public LocationsOrchestrator(IRepository<RecyclingPlace> repository)
    {
        _repository = repository;
    }

    public Task<List<RecyclingPlace>> GetRecyclingLocationsAsync(FilterParameters parameters)
    {
        return _repository.SearchAsync(parameters.Count, parameters.Offset);
    }

    public Task CreateRecyclingLocationAsync(RecyclingPlace item)
    {
        return _repository.AddAsync(item);
    }

    public Task<RecyclingPlace> GetRecyclingLocationAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task RemoveRecyclingLocation(RecyclingPlace location)
    {
        return _repository.RemoveAsync(location);
    }

    public Task<object> UpdateLocationAsync(UpdatePlaceDto placeDto)
    {
        throw new System.NotImplementedException();
    }
}