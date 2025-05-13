
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.AspNetCore.Mvc;
    using NuGet.Protocol;
    using WebAspNetCoreMvc.Contexto;
    using WebAspNetCoreMvc.Models;

    namespace WebAspNetCoreMvc.Services;

    public interface IUsuarioService
    {
        public string GetUsuario(int id);

        public Task<UsuarioModel?> GetUsuarioAsync(int id);
    }
