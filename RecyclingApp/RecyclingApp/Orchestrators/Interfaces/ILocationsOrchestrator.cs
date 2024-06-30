using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.Orchestrators.Interfaces;

public interface ILocationsOrchestrator
{
    Task<List<RecyclingPlace>> GetRecyclingLocationsAsync();

    Task<bool> CreateRecyclingLocationAsync(RecyclingPlace item);
}