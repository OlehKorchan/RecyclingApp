using System;
using System.Linq.Expressions;
using RecyclingApp.DataAccess.Models;

namespace RecyclingApp.DataAccess.Specifications;

public abstract class Specification<TEntity> where TEntity : BaseEntity
{
    public Expression<Func<TEntity, bool>> Expression;
}