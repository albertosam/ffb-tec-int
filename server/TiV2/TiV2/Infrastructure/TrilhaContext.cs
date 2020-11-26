using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilhas.Domain;

namespace Trilhas.Infrastructure
{
    public class TrilhaContext : DbContext
    {
        public DbSet<Trilha> Trilhas { get; set; }
        public DbSet<TrilhaCertificacao> TrilhaCertificacoes { get; set; }
        public DbSet<Certificacao> Certificacoes { get; set; }

        public TrilhaContext(DbContextOptions options) : base(options)
        {
        }
    }
}
