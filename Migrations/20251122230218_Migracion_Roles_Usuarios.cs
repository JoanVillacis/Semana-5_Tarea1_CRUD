using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Roles_Usuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_Rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_Rol);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Estado_Usuario = table.Column<bool>(type: "bit", nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_Rol_Id",
                        column: x => x.Rol_Id,
                        principalTable: "Roles",
                        principalColumn: "Id_Rol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Nombre_Rol",
                table: "Roles",
                column: "Nombre_Rol",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Rol_Id",
                table: "Usuarios",
                column: "Rol_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
