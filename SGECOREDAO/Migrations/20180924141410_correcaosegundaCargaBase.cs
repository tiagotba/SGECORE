using Microsoft.EntityFrameworkCore.Migrations;

namespace SGECOREDAO.Migrations
{
    public partial class correcaosegundaCargaBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEL_TELEFONE_CLI_CLIENTE_ClienteId_Cliente",
                table: "TEL_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropIndex(
                name: "IX_VEIC_VEICULO_ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropIndex(
                name: "IX_TEL_TELEFONE_ClienteId_Cliente",
                table: "TEL_TELEFONE");

            migrationBuilder.DropColumn(
                name: "ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropColumn(
                name: "ClienteId_Cliente",
                table: "TEL_TELEFONE");

            migrationBuilder.CreateIndex(
                name: "IX_VEIC_VEICULO_ID_VEICULO_CLI",
                table: "VEIC_VEICULO",
                column: "ID_VEICULO_CLI");

            migrationBuilder.CreateIndex(
                name: "IX_TEL_TELEFONE_ID_TELEFONE_CLI",
                table: "TEL_TELEFONE",
                column: "ID_TELEFONE_CLI");

            migrationBuilder.AddForeignKey(
                name: "FK_TEL_TELEFONE_CLI_CLIENTE_ID_TELEFONE_CLI",
                table: "TEL_TELEFONE",
                column: "ID_TELEFONE_CLI",
                principalTable: "CLI_CLIENTE",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ID_VEICULO_CLI",
                table: "VEIC_VEICULO",
                column: "ID_VEICULO_CLI",
                principalTable: "CLI_CLIENTE",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TEL_TELEFONE_CLI_CLIENTE_ID_TELEFONE_CLI",
                table: "TEL_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ID_VEICULO_CLI",
                table: "VEIC_VEICULO");

            migrationBuilder.DropIndex(
                name: "IX_VEIC_VEICULO_ID_VEICULO_CLI",
                table: "VEIC_VEICULO");

            migrationBuilder.DropIndex(
                name: "IX_TEL_TELEFONE_ID_TELEFONE_CLI",
                table: "TEL_TELEFONE");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId_Cliente",
                table: "VEIC_VEICULO",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId_Cliente",
                table: "TEL_TELEFONE",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VEIC_VEICULO_ClienteId_Cliente",
                table: "VEIC_VEICULO",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TEL_TELEFONE_ClienteId_Cliente",
                table: "TEL_TELEFONE",
                column: "ClienteId_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_TEL_TELEFONE_CLI_CLIENTE_ClienteId_Cliente",
                table: "TEL_TELEFONE",
                column: "ClienteId_Cliente",
                principalTable: "CLI_CLIENTE",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ClienteId_Cliente",
                table: "VEIC_VEICULO",
                column: "ClienteId_Cliente",
                principalTable: "CLI_CLIENTE",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
