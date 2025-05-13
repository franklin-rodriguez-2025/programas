
using Microsoft.AspNetCore.Mvc;
using WebAspNetCoreMvc.Services;

namespace WebAspNetCoreMvc.ApiControllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;

    private readonly UsuarioService _usuarioService;

    public UsuarioController(
        ILogger<UsuarioController> logger,
        UsuarioService usuarioService
    )
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }
    


    // GET: api/Usuario/5
    [HttpGet("{id}")]
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
