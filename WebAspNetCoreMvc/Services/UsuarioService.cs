
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using WebAspNetCoreMvc.Contexto;
using WebAspNetCoreMvc.Models;

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


    public string GetUsuario(int id)
    {
        return $"UsuarioService[GetUsuario(id)]: {id}";
    }


    public async Task<UsuarioModel?> GetUsuarioAsync(int id)
    {
        try
        {
            var usuario = await _context.ContextoUsuario.FindAsync(id);
            if ( usuario == null )
            {
                _logger.LogWarning($"UsuarioService[GetUsuarioAsync(id)]: Usuario con id = {id} no existe.");
                return null;
            }
            return usuario;
        }
        catch (Exception ex)
        {
            _logger.LogError($"UsuarioService[GetUsuarioAsync(id)]: Error al obtener el usuario con id = {id}. Error: {ex.Message}");
            return null;
        }
    }

}
