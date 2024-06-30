using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess.Interfaces;

public interface ILocationsRepository
{
    public Task<List<RecyclingPlace>> GetAllAsync();

    public Task<bool> CreateAsync(RecyclingPlace item);
}