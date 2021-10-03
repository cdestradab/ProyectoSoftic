using Microsoft.EntityFrameworkCore;
using FutureDrone.App.Dominio;


namespace FutureDrone.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Ciudad> Ciudad{get;set;}
        public DbSet<Cliente> Cliente{get;set;}
        public DbSet<Drone> Drone{get;set;}
        public DbSet<Empleado> Empleado{get;set;}
        public DbSet<Encuesta> Encuesta{get;set;}
        public DbSet<Envio> Envio{get;set;}
        public DbSet<Usuario> Usuario{get;set;}
        public DbSet<Empresa> Empresa{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = FutureDroneData");
            }
        }
    }
}