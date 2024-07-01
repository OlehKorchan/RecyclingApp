using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecyclingApp.DataAccess.Interfaces;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    readonly ApplicationContext _context;

    public Repository(ApplicationContext context)
    {
        _context = context;
    }

    public Task<List<TEntity>> GetAsync()
    {
        return _context.Set<TEntity>().ToListAsync();
    }

    public Task<List<TEntity>> SearchAsync(int take, int skip)
    {
        return _context.Set<TEntity>().Skip(skip).Take(take).ToListAsync();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);

        var result = await _context.SaveChangesAsync();
    }

    public Task<int> CountAsync()
    {
        return _context.Set<TEntity>().CountAsync();
    }

    public async Task RemoveAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);

        await _context.SaveChangesAsync();
    }
}