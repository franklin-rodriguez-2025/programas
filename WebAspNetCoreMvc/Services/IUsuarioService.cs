
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http.HttpResults;
    using Microsoft.AspNetCore.Mvc;
    using NuGet.Protocol;
    using WebAspNetCoreMvc.Contexto;
    using WebAspNetCoreMvc.Models;

    namespace WebAspNetCoreMvc.Services;

    public interface IUsuarioService
    {
        // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      
        // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      

        public string GetUsuario(int id);

        public Task<List<UsuarioModel>> GetAllAsync();

        public Task<UsuarioModel?> GetAsync(int id);

        public Task<int?> PostAsync(UsuarioModel usuarioModel);
        
        public Task UpdateAsync(int id, UsuarioModel usuarioModel);

        public Task DeleteAsync(int id);

}
