using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureDrone.App.Persistencia.Migrations
{
    public partial class Mig211002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rol",
                table: "Usuario",
                newName: "Rol");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuario",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "Usuario",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Envio",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Envio",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Envio",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "producto_envio",
                table: "Envio",
                newName: "ProductoEnvio");

            migrationBuilder.RenameColumn(
                name: "nombre_destinatario",
                table: "Envio",
                newName: "NombreDestinatario");

            migrationBuilder.RenameColumn(
                name: "id_Usuario",
                table: "Envio",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "id_Drone",
                table: "Envio",
                newName: "IdDrone");

            migrationBuilder.RenameColumn(
                name: "id_Ciudad",
                table: "Envio",
                newName: "IdCiudad");

            migrationBuilder.RenameColumn(
                name: "fecha_entrega",
                table: "Envio",
                newName: "FechaEntrega");

            migrationBuilder.RenameColumn(
                name: "documento_empleado",
                table: "Envio",
                newName: "DocumentoEmpleado");

            migrationBuilder.RenameColumn(
                name: "documento_destinatario",
                table: "Envio",
                newName: "DocumentoDestinatario");

            migrationBuilder.RenameColumn(
                name: "direccion_destinatario",
                table: "Envio",
                newName: "DireccionDestinatario");

            migrationBuilder.RenameColumn(
                name: "pregunta4",
                table: "Encuesta",
                newName: "Pregunta4");

            migrationBuilder.RenameColumn(
                name: "pregunta3",
                table: "Encuesta",
                newName: "Pregunta3");

            migrationBuilder.RenameColumn(
                name: "pregunta2",
                table: "Encuesta",
                newName: "Pregunta2");

            migrationBuilder.RenameColumn(
                name: "pregunta1",
                table: "Encuesta",
                newName: "Pregunta1");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Encuesta",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Encuesta",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_Envio",
                table: "Encuesta",
                newName: "IdEnvio");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Empleado",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Empleado",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "documento",
                table: "Empleado",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "cargo",
                table: "Empleado",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Empleado",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_Usuario",
                table: "Empleado",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Drone",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Drone",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Drone",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Cliente",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Cliente",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "documento",
                table: "Cliente",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Cliente",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_Usuario",
                table: "Cliente",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "id_Ciudad",
                table: "Cliente",
                newName: "IdCiudad");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Ciudad",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Ciudad",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "Usuario",
                newName: "rol");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuario",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Usuario",
                newName: "contraseña");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Envio",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Envio",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Envio",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ProductoEnvio",
                table: "Envio",
                newName: "producto_envio");

            migrationBuilder.RenameColumn(
                name: "NombreDestinatario",
                table: "Envio",
                newName: "nombre_destinatario");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Envio",
                newName: "id_Usuario");

            migrationBuilder.RenameColumn(
                name: "IdDrone",
                table: "Envio",
                newName: "id_Drone");

            migrationBuilder.RenameColumn(
                name: "IdCiudad",
                table: "Envio",
                newName: "id_Ciudad");

            migrationBuilder.RenameColumn(
                name: "FechaEntrega",
                table: "Envio",
                newName: "fecha_entrega");

            migrationBuilder.RenameColumn(
                name: "DocumentoEmpleado",
                table: "Envio",
                newName: "documento_empleado");

            migrationBuilder.RenameColumn(
                name: "DocumentoDestinatario",
                table: "Envio",
                newName: "documento_destinatario");

            migrationBuilder.RenameColumn(
                name: "DireccionDestinatario",
                table: "Envio",
                newName: "direccion_destinatario");

            migrationBuilder.RenameColumn(
                name: "Pregunta4",
                table: "Encuesta",
                newName: "pregunta4");

            migrationBuilder.RenameColumn(
                name: "Pregunta3",
                table: "Encuesta",
                newName: "pregunta3");

            migrationBuilder.RenameColumn(
                name: "Pregunta2",
                table: "Encuesta",
                newName: "pregunta2");

            migrationBuilder.RenameColumn(
                name: "Pregunta1",
                table: "Encuesta",
                newName: "pregunta1");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Encuesta",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Encuesta",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdEnvio",
                table: "Encuesta",
                newName: "id_Envio");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Empleado",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleado",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Empleado",
                newName: "documento");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "Empleado",
                newName: "cargo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Empleado",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Empleado",
                newName: "id_Usuario");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Drone",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Drone",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Drone",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Cliente",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cliente",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Cliente",
                newName: "documento");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Cliente",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Cliente",
                newName: "id_Usuario");

            migrationBuilder.RenameColumn(
                name: "IdCiudad",
                table: "Cliente",
                newName: "id_Ciudad");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Ciudad",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ciudad",
                newName: "id");
        }
    }
}
