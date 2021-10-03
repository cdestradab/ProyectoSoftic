using Microsoft.EntityFrameworkCore.Migrations;

namespace FutureDrone.App.Persistencia.Migrations
{
    public partial class Mig211001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Usuario = table.Column<int>(type: "int", nullable: false),
                    id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Drone",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<int>(type: "int", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drone", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Usuario = table.Column<int>(type: "int", nullable: false),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Encuesta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Envio = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pregunta1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pregunta2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pregunta3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pregunta4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Envio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Usuario = table.Column<int>(type: "int", nullable: false),
                    id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    id_Drone = table.Column<int>(type: "int", nullable: false),
                    nombre_destinatario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documento_destinatario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion_destinatario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    producto_envio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_entrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documento_empleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<double>(type: "float", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Drone");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Encuesta");

            migrationBuilder.DropTable(
                name: "Envio");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });
        }
    }
}
