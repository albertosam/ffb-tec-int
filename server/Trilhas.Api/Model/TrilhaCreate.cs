using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Api.Model
{
    public class TrilhaCreate
    {
        public string Descricao { get; set; }
        public string Ano { get; set; }
        public bool Ativo { get; set; }
        public bool Notificar { get; set; }
        public List<TrilhaCertificacaoCreate> Certificacoes { get; set; }

        public class TrilhaCertificacaoCreate
        {
            public Guid CertificacaoId { get; set; }
        }
    }
}
