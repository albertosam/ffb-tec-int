using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilhas.Domain;

namespace Trilhas.Infrastructure.Repositories
{
    public class CertificadoRepository : ICertificadoRepository
    {
        private readonly TrilhaContext _context;

        public CertificadoRepository(TrilhaContext trilhaContext)
        {
            _context = trilhaContext;
        }

        public async Task<Certificacao> AddAsync(Certificacao entity)
        {
            await _context.Certificacoes.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public Task<List<Certificacao>> GetAllAsync()
        {
            return _context.Certificacoes.ToListAsync();
        }

        public async Task<Certificacao> GetAsync(Guid id)
        {
            return await _context.Certificacoes
                                            .Where(x => x.Id == id)
                                            .FirstOrDefaultAsync();
        }

        public Task<Certificacao> UpdateAsync(Certificacao entity)
        {
            throw new NotImplementedException();
        }
    }
}
