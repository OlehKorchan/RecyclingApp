using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecyclingApp.DataAccess.Interfaces;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess.Repositories;

public class LocationsRepository : ILocationsRepository
{
    private readonly ApplicationContext _dbContext;

    public LocationsRepository(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<List<RecyclingPlace>> GetAllAsync()
    {
        return _dbContext.Set<RecyclingPlace>().ToListAsync();
    }

    public async Task<bool> CreateAsync(RecyclingPlace item)
    {
        await _dbContext.AddAsync(item);

        return await _dbContext.SaveChangesAsync() > 0;
    }
}