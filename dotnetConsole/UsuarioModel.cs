
using System.ComponentModel.DataAnnotations;

namespace WebAspNetCoreMvc.Models;

public class UsuarioModel
{
    public int? Id { get; set; }
    public string? Correo { get; set; }
    public string? Contrasena { get; set; }
    [DataType(DataType.Date)]
    public DateTime? Cumpleanos { get; set; }
    public double? Altura { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
}

