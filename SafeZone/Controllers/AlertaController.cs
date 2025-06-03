using Microsoft.AspNetCore.Mvc;
using SafeZoneBusiness;
using SafeZoneModel;

namespace SafeZoneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertaController : ControllerBase
    {
        private readonly AlertaService _alertaService;

        public AlertaController(AlertaService alertaService)
        {
            _alertaService = alertaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var alertas = _alertaService.ListarTodos();
            return alertas.Count == 0 ? NoContent() : Ok(alertas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var alerta = _alertaService.ObterPorId(id);
            return alerta == null ? NotFound() : Ok(alerta);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AlertaModel alerta)
        {
            if (string.IsNullOrWhiteSpace(alerta.Tipo) || string.IsNullOrWhiteSpace(alerta.Descricao))
                return BadRequest("Tipo e Descrição são obrigatórios.");

            var criado = _alertaService.Criar(alerta);
            return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AlertaModel alerta)
        {
            if (alerta == null || alerta.Id != id)
                return BadRequest("Dados inconsistentes.");

            return _alertaService.Atualizar(alerta) ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _alertaService.Remover(id) ? NoContent() : NotFound();
        }
    }
}
