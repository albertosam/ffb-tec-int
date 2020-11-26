using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilhas.Domain;

namespace Trilhas.Infrastructure.Repositories
{
    public class TrilhaRepository : ITrilhaRepository
    {
        private readonly TrilhaContext _context;

        public TrilhaRepository(TrilhaContext context)
        {
            _context = context;
        }

        public async Task<Trilha> AddAsync(Trilha entity)
        {
            await _context.Trilhas.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public Task<List<Trilha>> GetAllAsync()
        {
            return _context.Trilhas.ToListAsync();
        }

        public async Task<Trilha> GetAsync(Guid id)
        {
            return await _context.Trilhas.Include(x => x.Certificacoes)
                                            .ThenInclude(x => x.Certificacao)
                                            .Where(x => x.Id == id)
                                            .FirstOrDefaultAsync();
        }

        public Task<Trilha> UpdateAsync(Trilha entity)
        {
            throw new NotImplementedException();
        }
    }
}
