using API_Citas.Entities;
using API_Citas.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Citas.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsuarioController(UsuarioContext context) : ControllerBase
    {
        [HttpGet] // api/Usuarios
        public async Task<ActionResult<List<Usuario>>> GetProducts()
        {
            return context.Usuarios.ToList();
        }
    }
}
