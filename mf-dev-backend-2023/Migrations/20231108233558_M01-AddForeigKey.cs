using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2023.Migrations
{
    public partial class M01AddForeigKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Transacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_UsuarioId",
                table: "Transacoes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Usuarios_UsuarioId",
                table: "Transacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Usuarios_UsuarioId",
                table: "Transacoes");

            migrationBuilder.DropIndex(
                name: "IX_Transacoes_UsuarioId",
                table: "Transacoes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Transacoes");
        }
    }
}
