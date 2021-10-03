using System;
namespace FutureDrone.App.Dominio
{
    public class Cliente
    {
        public int Id {get; set;}
        public int IdUsuario {get; set;}
        public int IdCiudad {get; set;}
        public string Documento {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
    }
}