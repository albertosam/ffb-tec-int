using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilhas.Api.Model;
using Trilhas.Domain;

namespace Trilhas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrilhaController : ControllerBase
    {
        private readonly ITrilhaRepository _trilhaRepository;
        private readonly ICertificadoRepository _certificadoRepository;

        public TrilhaController(ITrilhaRepository trilhaRepository, ICertificadoRepository certificadoRepository)
        {
            _trilhaRepository = trilhaRepository;
            _certificadoRepository = certificadoRepository;
        }

        [HttpGet]
        public Task<List<Trilha>> GetAll()
        {
            return _trilhaRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public Task<Trilha> Get([FromRoute] Guid id)
        {
            return _trilhaRepository.GetAsync(id);
        }

        [HttpPost]
        public async Task Post([FromBody] TrilhaCreate novo)
        {
            var trilha = new Trilha(novo.Descricao, Convert.ToInt32(novo.Ano), novo.Ativo, novo.Notificar);

            int seq = 0;
            foreach (var item in novo.Certificacoes)
            {
                seq++;
                var cert = await _certificadoRepository.GetAsync(item.CertificacaoId);
                trilha.Certificacoes.Add(new TrilhaCertificacao { CertificacaoId = cert.Id, Sequencia = seq });
            }
            await _trilhaRepository.AddAsync(trilha);
        }

    }
}
