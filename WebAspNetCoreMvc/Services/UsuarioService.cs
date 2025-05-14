
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using WebAspNetCoreMvc.Contexto;
using WebAspNetCoreMvc.Models;

namespace WebAspNetCoreMvc.Services;

public class UsuarioService : IUsuarioService
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



    public async Task<UsuarioModel?> GetAsync(int id)
    {
        try
        {
            var usuario = await _context.DbUsuario.FindAsync(id);
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



    public async Task<int?> PostAsync(UsuarioModel usuarioModel)
    {
        try
        {
            await _context.DbUsuario.AddAsync(usuarioModel);
            await _context.SaveChangesAsync();
            return usuarioModel.Id != 0 ? usuarioModel.Id : null;
        }
        catch (Exception ex)
        {
            _logger.LogError($"UsuarioService[PostAsync(usuarioModel)]: Error al guardar info del usuario. Error: {ex.Message}");
            return null;
        }
    }

}
