using System.Collections.Generic;
using System.Threading.Tasks;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAsync();

    Task<List<TEntity>> SearchAsync(int take, int skip);

    Task AddAsync(TEntity entity);

    Task<int> CountAsync();

    Task RemoveAsync(TEntity entity);
}