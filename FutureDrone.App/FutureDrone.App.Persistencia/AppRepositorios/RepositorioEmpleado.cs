using System.Collections.Generic;
using System.Linq;
using FutureDrone.App.Dominio;

namespace FutureDrone.App.Persistencia
{
    public class RepositorioEmpleado:IRepositorioEmpleado
    {
        ///<summary>
        ///Referencia al contexto de persona
        ///</summary>

        private readonly AppContext _appContext;

        ///<summary>
        ///Método constructor
        ///Inyección de dependencias
        ///</summary>
        ///<param name="appContext"></param>

        public RepositorioEmpleado(AppContext appContext)
        {
            _appContext = appContext; 
        }

        Empleado IRepositorioEmpleado.AddEmpleado(Empleado empleado)
        {
            var empleadoInsertado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoInsertado.Entity;
        }

        void IRepositorioEmpleado.DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(p => p.Id == idEmpleado);
            if(empleadoEncontrado == null) {
                return;
            }
            _appContext.Empleados.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Empleado> IRepositorioEmpleado.GetAllEmpleados()
        {
            return _appContext.Empleados;
        }

        Empleado IRepositorioEmpleado.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(p => p.Id == empleado.Id);
            if(empleadoEncontrado != null) {
                empleadoEncontrado.Nombre = empleado.Nombre;
                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
        }
        
        Empleado IRepositorioEmpleado.GetEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(p => p.Id == idEmpleado);
            return empleadoEncontrado;
        }
    } 

}