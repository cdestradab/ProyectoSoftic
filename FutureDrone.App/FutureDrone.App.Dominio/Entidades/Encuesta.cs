using System;
namespace FutureDrone.App.Dominio
{
    public class Encuesta
    {
        public int Id {get; set;}
        public int IdEnvio {get; set;}
        public string Fecha {get; set;}
        public string Pregunta1 {get; set;}
        public string Pregunta2 {get; set;}
        public string Pregunta3 {get; set;}
        public string Pregunta4 {get; set;}
    }
}