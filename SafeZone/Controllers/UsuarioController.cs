using Microsoft.AspNetCore.Mvc;
using SafeZoneBusiness;
using SafeZoneModel;

namespace SafeZoneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _usuarioService.ListarTodos();
            return usuarios.Count == 0 ? NoContent() : Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _usuarioService.ObterPorId(id);
            return usuario == null ? NotFound() : Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioModel usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Password))
                return BadRequest("Email e senha são obrigatórios.");

            var criado = _usuarioService.Criar(usuario);
            return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UsuarioModel usuario)
        {
            if (usuario == null || usuario.Id != id)
                return BadRequest("Dados inconsistentes.");

            return _usuarioService.Atualizar(usuario) ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _usuarioService.Remover(id) ? NoContent() : NotFound();
        }
    }
}
