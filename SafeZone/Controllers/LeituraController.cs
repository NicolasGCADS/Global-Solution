using Microsoft.AspNetCore.Mvc;
using SafeZoneBusiness;
using SafeZoneModel;

namespace SafeZoneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeituraController : ControllerBase
    {
        private readonly LeituraService _leituraService;

        public LeituraController(LeituraService leituraService)
        {
            _leituraService = leituraService;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            var leituras = _leituraService.ListarTodas();
            return leituras.Count == 0 ? NoContent() : Ok(leituras);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var leitura = _leituraService.ObterPorId(id);
            return leitura == null ? NotFound() : Ok(leitura);
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] LeituraModel leitura)
        {
            if (leitura == null)
                return BadRequest("Dados inválidos.");

            var criada = _leituraService.Criar(leitura);
            return CreatedAtAction(nameof(Get), new { id = criada.Id }, criada);
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LeituraModel leitura)
        {
            if (leitura == null || leitura.Id != id)
                return BadRequest("Dados inconsistentes.");

            return _leituraService.Atualizar(leitura) ? NoContent() : NotFound();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _leituraService.Remover(id) ? NoContent() : NotFound();
        }
    }
}
