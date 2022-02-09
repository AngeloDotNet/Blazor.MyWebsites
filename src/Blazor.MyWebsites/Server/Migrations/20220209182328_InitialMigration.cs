using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.MyWebsites.Server.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompetenzePersonali",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AreaTecnica = table.Column<string>(type: "TEXT", nullable: true),
                    Competenza = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenzePersonali", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetenzeTecniche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AreaTecnica = table.Column<string>(type: "TEXT", nullable: true),
                    Competenza = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenzeTecniche", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorsiOnline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Corso = table.Column<string>(type: "TEXT", nullable: true),
                    Piattaforma = table.Column<string>(type: "TEXT", nullable: true),
                    DataRilascio = table.Column<string>(type: "TEXT", nullable: true),
                    DataScadenza = table.Column<string>(type: "TEXT", nullable: true),
                    Certificato = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorsiOnline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EsperienzeProfessionali",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Esperienza = table.Column<string>(type: "TEXT", nullable: true),
                    Periodo = table.Column<string>(type: "TEXT", nullable: true),
                    Azienda = table.Column<string>(type: "TEXT", nullable: true),
                    Luogo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsperienzeProfessionali", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetenzePersonali");

            migrationBuilder.DropTable(
                name: "CompetenzeTecniche");

            migrationBuilder.DropTable(
                name: "CorsiOnline");

            migrationBuilder.DropTable(
                name: "EsperienzeProfessionali");
        }
    }
}
