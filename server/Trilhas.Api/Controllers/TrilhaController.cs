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

        public TrilhaController(ITrilhaRepository trilhaRepository)
        {
            _trilhaRepository = trilhaRepository;
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
        public Task<Trilha> Post([FromBody] TrilhaCreate novo)
        {
            var trilha = new Trilha { Descricao = novo.Descricao };
            return _trilhaRepository.AddAsync(trilha);
        }
    }
}
