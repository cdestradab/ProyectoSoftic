using System.Collections.Generic;
using FutureDrone.App.Dominio;

namespace FutureDrone.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleados();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int idEmpleado);
        Empleado GetEmpleado(int idEmpleado);
    }
}