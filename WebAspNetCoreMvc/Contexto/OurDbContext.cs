
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAspNetCoreMvc.Models;

namespace WebAspNetCoreMvc.Contexto
{
    public class OurDbContext : DbContext
    {
        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Produtos { get; set; }
    }
}
