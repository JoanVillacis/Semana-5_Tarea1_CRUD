using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class estado_cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Clientes",
                newName: "Correo");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Clientes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Clientes",
                newName: "correo");
        }
    }
}
