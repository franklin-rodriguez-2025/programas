
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class UsuarioController : Controller
{
    //
    // 
    // GET: /Usuario/
    public string Index()
    {
        return "ñá ñé ñí ñó  ñú [] {} ()   Página inicial para usuarios.";
    }
    //
    //
    // GET: /Usuario/Configuraciones/
    public string Configuraciones()
    {
        return "Ajustes de información de usuarios";
    }
    //
    //
    // GET: /Usuario/Consulta/
    public string Consulta(int id)
    {
        return "ñá ñé ñí ñó  ñú [] {} (). Usuario con id=" + id;
    }
}