using CleanArch.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces.Base
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        Task AddAsync(T entity);

        IList<T> GetAll();
        Task<IList<T>> GetAllAsync();
    }
}
