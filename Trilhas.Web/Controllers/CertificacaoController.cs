using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trilhas.Web.Domain;
using Trilhas.Web.Model;

namespace Trilhas.Web.Controllers
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

        [HttpPut("{id}")]
        public async Task<Certificacao> Put([FromRoute] Guid id, [FromBody] CertificacaoUpdate update)
        {
            var cert = await _certificadoRepository.GetAsync(id);

            cert.Codigo = update.Codigo;
            cert.Descricao = update.Descricao;
            cert.Provedor = update.Provedor;

            return await _certificadoRepository.UpdateAsync(cert);
        }

        [HttpDelete("{id}")]
        public Task Delete([FromRoute] Guid id)
        {
            return _certificadoRepository.DeleteAsync(id);
        }
    }
}
