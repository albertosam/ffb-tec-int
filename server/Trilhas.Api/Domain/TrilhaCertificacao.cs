using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Domain
{
    public class TrilhaCertificacao
    {
        [Key]
        public Guid Id { get; set; }
        public int Sequencia { get; set; }
        public Guid TrilhaId { get; set; }
        public Guid CertificacaoId { get; set; }
        public Certificacao Certificacao { get; set; }
        public Trilha Trilha { get; set; }
    }
}
