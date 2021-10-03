using System;
namespace FutureDrone.App.Dominio
{
    public class Empleado
    {
        public int Id {get; set;}
        public int IdUsuario {get; set;}
        public string Documento {get; set;}
        public string Nombre {get; set;}
        public string Cargo {get; set;}
        public string Telefono {get; set;}
    }
}