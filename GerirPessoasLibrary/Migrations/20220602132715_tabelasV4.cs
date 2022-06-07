using Microsoft.EntityFrameworkCore.Migrations;

namespace GerirInfosLibrary.Migrations
{
    public partial class tabelasV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_casa",
                table: "Reservas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_casa",
                table: "Reservas");
        }
    }
}
