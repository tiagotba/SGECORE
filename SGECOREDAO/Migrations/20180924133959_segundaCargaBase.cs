using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGECOREDAO.Migrations
{
    public partial class segundaCargaBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId_Cliente",
                table: "VEIC_VEICULO",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_VEICULO_CLI",
                table: "VEIC_VEICULO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CLI_CLIENTE",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome_Cliente = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Rg_Cliente = table.Column<string>(nullable: true),
                    Cpf_Cliente = table.Column<string>(type: "nvarchar(18)", nullable: false),
                    E_Func_Cliente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLI_CLIENTE", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "TEL_TELEFONE",
                columns: table => new
                {
                    Id_Telefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DDD_TELEFONE = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    NUM_TELEFONE = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ID_TELEFONE_CLI = table.Column<int>(nullable: false),
                    ClienteId_Cliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEL_TELEFONE", x => x.Id_Telefone);
                    table.ForeignKey(
                        name: "FK_TEL_TELEFONE_CLI_CLIENTE_ClienteId_Cliente",
                        column: x => x.ClienteId_Cliente,
                        principalTable: "CLI_CLIENTE",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VEIC_VEICULO_ClienteId_Cliente",
                table: "VEIC_VEICULO",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TEL_TELEFONE_ClienteId_Cliente",
                table: "TEL_TELEFONE",
                column: "ClienteId_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ClienteId_Cliente",
                table: "VEIC_VEICULO",
                column: "ClienteId_Cliente",
                principalTable: "CLI_CLIENTE",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VEIC_VEICULO_CLI_CLIENTE_ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropTable(
                name: "TEL_TELEFONE");

            migrationBuilder.DropTable(
                name: "CLI_CLIENTE");

            migrationBuilder.DropIndex(
                name: "IX_VEIC_VEICULO_ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropColumn(
                name: "ClienteId_Cliente",
                table: "VEIC_VEICULO");

            migrationBuilder.DropColumn(
                name: "ID_VEICULO_CLI",
                table: "VEIC_VEICULO");
        }
    }
}
