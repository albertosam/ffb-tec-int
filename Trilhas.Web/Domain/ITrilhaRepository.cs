using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Web.Domain
{
    public interface ITrilhaRepository
    {
        Task<List<Trilha>> GetAllAsync();
        Task<Trilha> GetAsync(Guid id);
        Task<Trilha> AddAsync(Trilha entity);
        Task<Trilha> UpdateAsync(Trilha entity);
    }
}
