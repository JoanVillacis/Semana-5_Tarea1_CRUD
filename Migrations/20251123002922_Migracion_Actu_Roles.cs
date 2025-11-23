using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_Actu_Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion_Rol",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Estado_Rol",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion_Rol",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Estado_Rol",
                table: "Roles");
        }
    }
}
