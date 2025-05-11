
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class UsuarioController : Controller
{
    // 
    // GET: /Usuario/
    public string Index()
    {
        return "Pagina Web de inicio";
    }
    //
    // GET: /Usuario/Configuraciones/
    public string Configuraciones()
    {
        return "Pagina Web de configuraciones";
    }
}