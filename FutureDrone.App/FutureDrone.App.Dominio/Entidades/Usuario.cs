using System;
namespace FutureDrone.App.Dominio
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Contraseña {get; set;}
        public string Email {get; set;}
        public int Rol {get; set;}
    }
}