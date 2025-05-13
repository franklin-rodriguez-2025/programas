
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAspNetCoreMvc.Contexto;

namespace WebAspNetCoreMvc.Services;

public class UsuarioService
{
    private readonly ILogger<UsuarioService> _logger;

    private readonly OurDbContext _context;

    public UsuarioService(
        ILogger<UsuarioService> logger,
        OurDbContext context
    )
    {
        _logger = logger;
        _context = context;
    }

    public string GetUsuario()
    {
        return "UsuarioService - GetUsuario";
    }

    public string GetUsuario(int id)
    {
        return $"UsuarioService - GetUsuario {id}";
    }


    public async Task<IActionResult> GetUsuarioAsync(int id)
    {
        var usuario = await _context.ContextoUsuario.FindAsync(id);
        if ( usuario == null )
        {
            _logger.LogWarning($"Usuario con id = {id} no existe.");
            return new NotFoundResult();
        }
        return new OkObjectResult(usuario);
    }


}
