
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class UsuarioController : Controller
{
    //
    // 
    // GET: /Usuario/
    public IActionResult Index()
    {
        return View();
        //return "ñá ñé ñí ñó  ñú [] {} ()   Página inicial para usuarios.";
    }
    //
    //
    // GET: /Usuario/Configuraciones/
    public IActionResult Configuraciones()
    {
        return View();
    }
    //
    //
    // GET: /Usuario/Consulta/
    public IActionResult Consulta(int id)
    {
        ViewData["id"] = id;
        return View();
    }
    /*
    //
    //
    // GET: /Usuario/Consulta/
    public string Consulta(int id)
    {
        return "ñá ñé ñí ñó  ñú [] {} (). Usuario con id=" + id;
    }
    */

}
