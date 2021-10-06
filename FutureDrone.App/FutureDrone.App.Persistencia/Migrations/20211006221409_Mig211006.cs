using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureDrone.App.Persistencia.Migrations
{
    public partial class Mig211006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Envio",
                table: "Envio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encuesta",
                table: "Encuesta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drone",
                table: "Drone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Envio",
                newName: "Envios");

            migrationBuilder.RenameTable(
                name: "Encuesta",
                newName: "Encuestas");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Empresas");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "Drone",
                newName: "Drones");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Ciudad",
                newName: "Ciudades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Envios",
                table: "Envios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encuestas",
                table: "Encuestas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drones",
                table: "Drones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Envios",
                table: "Envios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encuestas",
                table: "Encuestas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drones",
                table: "Drones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Envios",
                newName: "Envio");

            migrationBuilder.RenameTable(
                name: "Encuestas",
                newName: "Encuesta");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "Empresa");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "Drones",
                newName: "Drone");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "Ciudad");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Envio",
                table: "Envio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encuesta",
                table: "Encuesta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drone",
                table: "Drone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad",
                column: "Id");
        }
    }
}
