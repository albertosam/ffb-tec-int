using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Domain
{
    public interface ICertificadoRepository
    {
        Task<List<Certificacao>> GetAllAsync();
        Task<Certificacao> GetAsync(Guid id);
        Task<Certificacao> AddAsync(Certificacao entity);
        Task<Certificacao> UpdateAsync(Certificacao entity);
    }
}
