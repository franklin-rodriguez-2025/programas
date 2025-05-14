
using System.ComponentModel.DataAnnotations;

namespace WebAspNetCoreMvc.Models;

public class UsuarioModel
{
    // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      
    // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      

    public int? Id { get; set; }

    public string? Correo { get; set; }

    public string? Contrasena { get; set; }

    [DataType(DataType.Date)]
    public DateTime? Cumpleanos { get; set; }

    public double? Altura { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }
}
