using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.BusinessLogic;
using RecyclingApp.DataAccess.Models;
using RecyclingApp.Dto;

namespace RecyclingApp.Orchestrators.Interfaces;

public interface ILocationsOrchestrator
{
    Task<List<RecyclingPlace>> GetRecyclingLocationsAsync(FilterParameters parameters);

    Task CreateRecyclingLocationAsync(RecyclingPlace item);

    Task<RecyclingPlace> GetRecyclingLocationAsync(int id);

    Task RemoveRecyclingLocation(RecyclingPlace location);

    Task<object> UpdateLocationAsync(UpdatePlaceDto placeDto);
}