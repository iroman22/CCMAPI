using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Data.Migrations
{
    public partial class FixedNameClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Perso_Excedente",
                table: "Valijas",
                newName: "Peso_Excedente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peso_Excedente",
                table: "Valijas",
                newName: "Perso_Excedente");
        }
    }
}
