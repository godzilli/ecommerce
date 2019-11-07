using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class alterarlogradouro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lougradouro",
                table: "Enderecos",
                newName: "logradouro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "Enderecos",
                newName: "lougradouro");
        }
    }
}
