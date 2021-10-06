using Microsoft.EntityFrameworkCore;
using FutureDrone.App.Dominio;


namespace FutureDrone.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Ciudad> Ciudades{get;set;}
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<Drone> Drones{get;set;}
        public DbSet<Empleado> Empleados{get;set;}
        public DbSet<Encuesta> Encuestas{get;set;}
        public DbSet<Envio> Envios{get;set;}
        public DbSet<Usuario> Usuarios{get;set;}
        public DbSet<Empresa> Empresas{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = FutureDroneData");
            }
        }
    }
}