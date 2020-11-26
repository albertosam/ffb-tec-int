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
    public class CertificacaoController : ControllerBase
    {
        private readonly ICertificadoRepository _certificadoRepository;

        public CertificacaoController(ICertificadoRepository certificadoRepository)
        {
            _certificadoRepository = certificadoRepository;
        }

        [HttpGet]
        public Task<List<Certificacao>> GetAll()
        {
            return _certificadoRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public Task<Certificacao> Get([FromRoute] Guid id)
        {
            return _certificadoRepository.GetAsync(id);
        }

        [HttpPost]
        public Task<Certificacao> Post([FromBody] CertificacaoCreate novo)
        {
            var trilha = new Certificacao { Codigo = novo.Codigo, Descricao = novo.Descricao, Provedor = novo.Provedor };
            return _certificadoRepository.AddAsync(trilha);
        }
    }
}
