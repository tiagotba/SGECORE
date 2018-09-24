using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGECOREDAO.Migrations
{
    public partial class primeiraCargaBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SET_SETOR",
                columns: table => new
                {
                    Id_Setor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome_Setor = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SET_SETOR", x => x.Id_Setor);
                });

            migrationBuilder.CreateTable(
                name: "VEIC_VEICULO",
                columns: table => new
                {
                    Id_Veiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PLC_VEICULO = table.Column<string>(type: "nvarchar(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEIC_VEICULO", x => x.Id_Veiculo);
                });

            migrationBuilder.CreateTable(
                name: "VAG_VAGA",
                columns: table => new
                {
                    Id_Vaga = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero_Vaga = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    ID_SETOR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VAG_VAGA", x => x.Id_Vaga);
                    table.ForeignKey(
                        name: "FK_VAG_VAGA_SET_SETOR_ID_SETOR",
                        column: x => x.ID_SETOR,
                        principalTable: "SET_SETOR",
                        principalColumn: "Id_Setor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DES_DESOCUPACAO",
                columns: table => new
                {
                    Id_Desocupacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DATA_SAIDA = table.Column<DateTime>(nullable: false),
                    ID_SETOR_DESO = table.Column<int>(nullable: false),
                    ID_VAGA_DESO = table.Column<int>(nullable: false),
                    ID_VEICULO_DESO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DES_DESOCUPACAO", x => x.Id_Desocupacao);
                    table.ForeignKey(
                        name: "FK_DES_DESOCUPACAO_SET_SETOR_ID_SETOR_DESO",
                        column: x => x.ID_SETOR_DESO,
                        principalTable: "SET_SETOR",
                        principalColumn: "Id_Setor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DES_DESOCUPACAO_VAG_VAGA_ID_VAGA_DESO",
                        column: x => x.ID_VAGA_DESO,
                        principalTable: "VAG_VAGA",
                        principalColumn: "Id_Vaga",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DES_DESOCUPACAO_VEIC_VEICULO_ID_VEICULO_DESO",
                        column: x => x.ID_VEICULO_DESO,
                        principalTable: "VEIC_VEICULO",
                        principalColumn: "Id_Veiculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OCU_OCUPACAO",
                columns: table => new
                {
                    Id_Ocup = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DATA_ENTRADA = table.Column<DateTime>(nullable: false),
                    ID_SETOR_OCU = table.Column<int>(nullable: false),
                    ID_VAGA_OCU = table.Column<int>(nullable: false),
                    ID_VEICULO_OCU = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCU_OCUPACAO", x => x.Id_Ocup);
                    table.ForeignKey(
                        name: "FK_OCU_OCUPACAO_SET_SETOR_ID_SETOR_OCU",
                        column: x => x.ID_SETOR_OCU,
                        principalTable: "SET_SETOR",
                        principalColumn: "Id_Setor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OCU_OCUPACAO_VAG_VAGA_ID_VAGA_OCU",
                        column: x => x.ID_VAGA_OCU,
                        principalTable: "VAG_VAGA",
                        principalColumn: "Id_Vaga",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OCU_OCUPACAO_VEIC_VEICULO_ID_VEICULO_OCU",
                        column: x => x.ID_VEICULO_OCU,
                        principalTable: "VEIC_VEICULO",
                        principalColumn: "Id_Veiculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DES_DESOCUPACAO_ID_SETOR_DESO",
                table: "DES_DESOCUPACAO",
                column: "ID_SETOR_DESO");

            migrationBuilder.CreateIndex(
                name: "IX_DES_DESOCUPACAO_ID_VAGA_DESO",
                table: "DES_DESOCUPACAO",
                column: "ID_VAGA_DESO");

            migrationBuilder.CreateIndex(
                name: "IX_DES_DESOCUPACAO_ID_VEICULO_DESO",
                table: "DES_DESOCUPACAO",
                column: "ID_VEICULO_DESO");

            migrationBuilder.CreateIndex(
                name: "IX_OCU_OCUPACAO_ID_SETOR_OCU",
                table: "OCU_OCUPACAO",
                column: "ID_SETOR_OCU");

            migrationBuilder.CreateIndex(
                name: "IX_OCU_OCUPACAO_ID_VAGA_OCU",
                table: "OCU_OCUPACAO",
                column: "ID_VAGA_OCU");

            migrationBuilder.CreateIndex(
                name: "IX_OCU_OCUPACAO_ID_VEICULO_OCU",
                table: "OCU_OCUPACAO",
                column: "ID_VEICULO_OCU");

            migrationBuilder.CreateIndex(
                name: "IX_VAG_VAGA_ID_SETOR",
                table: "VAG_VAGA",
                column: "ID_SETOR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DES_DESOCUPACAO");

            migrationBuilder.DropTable(
                name: "OCU_OCUPACAO");

            migrationBuilder.DropTable(
                name: "VAG_VAGA");

            migrationBuilder.DropTable(
                name: "VEIC_VEICULO");

            migrationBuilder.DropTable(
                name: "SET_SETOR");
        }
    }
}
