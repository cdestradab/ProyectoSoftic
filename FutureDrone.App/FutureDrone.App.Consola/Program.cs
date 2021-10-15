using System;
using FutureDrone.App.Dominio;
using FutureDrone.App.Persistencia;

namespace FutureDrone.App.Consola
{
    class Program
    {
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddEmpleado();

            Console.WriteLine("Todo bien");
        }
    

        private static void AddEmpleado()
        {
            var empleado = new Empleado
            {
                IdUsuario = 343,
                Documento = "1910928932",
                Nombre = "Montecristo",
                Cargo = "Conde",
                Telefono = "4223432434"
            };

            _repoEmpleado.AddEmpleado(empleado);


        }
    }
}