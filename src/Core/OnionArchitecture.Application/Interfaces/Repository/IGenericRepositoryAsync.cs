using OnionArchitecture.Domain.Common;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces.Repository
{
    public interface IGenericRepostiroyAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid Id);
        Task<T> AddAsync(T Entity);
    }
}
