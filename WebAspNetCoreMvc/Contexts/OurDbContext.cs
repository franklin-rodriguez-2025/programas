
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
        public DbSet<UsuarioModel> DbUsuario => Set<UsuarioModel>();

        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            modelBuilder.Entity<UsuarioModel>().HasKey(u => u.Id);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Nombre).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Correo).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<UsuarioModel>().Property(u => u.Contrasena).IsRequired().HasMaxLength(255);
        }
    }
}
