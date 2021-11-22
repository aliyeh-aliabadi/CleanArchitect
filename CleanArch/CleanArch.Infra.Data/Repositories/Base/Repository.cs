using CleanArch.Domain.Interfaces.Base;
using CleanArch.Domain.Models.Base;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        internal Repository(ProjectDbContext dbContext)
        {
            Dbcontext =
                dbContext ?? throw new ArgumentNullException(nameof(dbContext));

            Dbset = dbContext.Set<T>();
        }

        internal ProjectDbContext Dbcontext { get; }

        internal DbSet<T> Dbset { get;}

        public virtual void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(paramName: nameof(entity));

            Dbset.Add(entity);
        }

        public virtual async Task AddAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(paramName: nameof(entity));

            await Dbset.AddAsync(entity);
        }

        public IList<T> GetAll()
        {
            var result =
                Dbset.ToList();

            return result;
        }

        public async Task<IList<T>> GetAllAsync()
        {
            var result =
                await
                Dbset.ToListAsync();

            return result;
        }
    }
}
