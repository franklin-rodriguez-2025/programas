
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
        // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      
        // "MySqlConnection": "server=127.0.0.1; port=3306; user=root; password=esUnSecreto; database=dbtemp;"      


        public DbSet<UsuarioModel> Usuario { get; set; }

        // por que hay gente fastidiosa que molesta a 
        // las personas mientras estan aprendiendo o mientras trabajan ?


        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            modelBuilder.Entity<UsuarioModel>().HasKey(u => u.Id);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Nombre).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Correo).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Contrasena).IsRequired().HasMaxLength(255);
            */
        }
    }
}
