using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.DataAccess.Concrete.EntityFramework
{
   public class EfQueryableRepository<TEntity>:IQueryableRepository<TEntity> where TEntity: class
    {
        private readonly NorthwindContext _northwindContext;
        private DbSet<TEntity> _entities;
        public EfQueryableRepository(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public IQueryable<TEntity> GetAll => this.Entities;

        protected virtual DbSet<TEntity> Entities => _entities ?? (_entities = _northwindContext.Set<TEntity>());
    }
}