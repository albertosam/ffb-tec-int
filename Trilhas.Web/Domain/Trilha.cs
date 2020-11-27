using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Web.Domain
{
    public class Trilha
    {
        public Trilha(string descricao, int ano, bool ativo, bool notificar)
        {
            Descricao = descricao;
            Ano = ano;
            Ativo = ativo;
            Notificar = notificar;
            Certificacoes = new List<TrilhaCertificacao>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Ativo { get; set; }
        public bool Notificar { get; set; }
        public List<TrilhaCertificacao> Certificacoes { get; set; }
    }
}
