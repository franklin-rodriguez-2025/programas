
using Microsoft.AspNetCore.Mvc;
using WebAspNetCoreMvc.Models;
using WebAspNetCoreMvc.Services;

namespace WebAspNetCoreMvc.ApiControllers;


[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      
    // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      

    private readonly ILogger<UsuarioController> _logger;

    private readonly IUsuarioService _usuarioService;

    public UsuarioController(
        ILogger<UsuarioController> logger,
        IUsuarioService usuarioService
    )
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }



    // GET: api/Usuario/27
    [HttpGet("{id}")]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //[ProducesResponseType(typeof(UsuarioModel), StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
    //[Produces("application/json")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var infoUsuario = await _usuarioService.GetAsync(id);
        if( infoUsuario == null )
        {
            _logger.LogWarning($"UsuarioController[GetAsync(id)]: Usuario con id = {id} no existe.");
            return NotFound();
        }
        return Ok(infoUsuario);
    }


    // POST: api/Usuario
    [HttpPost]
    public async Task<IActionResult> PostAsync( [FromBody] UsuarioModel usuarioModel )
    {
        if( !ModelState.IsValid || usuarioModel == null )
        {
            _logger.LogWarning($"UsuarioController[PostAsync(usuarioModel)]: UsuarioModel is null.");
            return BadRequest("UsuarioModel is null or has incomplete data.");
        }
        usuarioModel.Id = null;
        var intId = await _usuarioService.PostAsync(usuarioModel);
        if( intId == null )
        {
            var msg = "Error al guardar información del usuario.";
            _logger.LogWarning($"UsuarioController[PostAsync(usuarioModel)]: " + msg);
            return BadRequest(msg);
        }
        return CreatedAtAction( nameof(GetAsync), new { id = intId }, intId );
    }
}