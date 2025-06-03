using Microsoft.AspNetCore.Mvc;
using SafeZoneBusiness;
using SafeZoneModel;

namespace SafeZoneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DispositivoController : ControllerBase
    {
        private readonly DispositivoService _dispositivoService;

        public DispositivoController(DispositivoService dispositivoService)
        {
            _dispositivoService = dispositivoService;
        }

       
        [HttpGet]
        public IActionResult Get()
        {
            var dispositivos = _dispositivoService.ListarTodos();
            return dispositivos.Count == 0 ? NoContent() : Ok(dispositivos);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dispositivo = _dispositivoService.ObterPorId(id);
            return dispositivo == null ? NotFound() : Ok(dispositivo);
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] DispositivoModel dispositivo)
        {
            if (string.IsNullOrWhiteSpace(dispositivo.Descricao_Local))
                return BadRequest("Descrição do local é obrigatória.");

            var criado = _dispositivoService.Criar(dispositivo);
            return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
        }

      
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DispositivoModel dispositivo)
        {
            if (dispositivo == null || dispositivo.Id != id)
                return BadRequest("Dados inconsistentes.");

            return _dispositivoService.Atualizar(dispositivo) ? NoContent() : NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _dispositivoService.Remover(id) ? NoContent() : NotFound();
        }
    }
}
