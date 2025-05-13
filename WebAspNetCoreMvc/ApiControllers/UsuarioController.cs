
using Microsoft.AspNetCore.Mvc;
using WebAspNetCoreMvc.Models;
using WebAspNetCoreMvc.Services;

namespace WebAspNetCoreMvc.ApiControllers;


[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;

    private readonly IUsuarioService _usuarioService;

    public UsuarioController(
        ILogger<UsuarioController> logger,
        UsuarioService usuarioService
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
    public async Task<IActionResult> Get(int id)
    {
        var infoUsuario = await _usuarioService.GetUsuarioAsync(id);
        if( infoUsuario == null )
        {
            _logger.LogWarning($"UsuarioController[Get(id)]: Usuario con id = {id} no existe.");
            return NotFound();
        }
        return Ok(infoUsuario);
    }
}
