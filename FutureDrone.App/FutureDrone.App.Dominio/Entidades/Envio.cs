using System;
namespace FutureDrone.App.Dominio
{
    public class Envio
    {
        public int Id {get; set;}
        public int IdUsuario {get; set;}
        public int IdCiudad {get; set;}
        public int IdDrone {get; set;}
        public string NombreDestinatario{get; set;}
        public string DocumentoDestinatario {get; set;}
        public string DireccionDestinatario {get; set;}
        public string ProductoEnvio {get; set;}
        public string FechaEntrega {get; set;}
        public string DocumentoEmpleado {get; set;}
        public double Valor {get; set;}
        public int Estado {get; set;}
    }
}