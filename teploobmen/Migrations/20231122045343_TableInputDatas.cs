using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teploobmen.Migrations
{
    public partial class TableInputDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InputDatas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RasH = table.Column<int>(type: "INTEGER", nullable: false),
                    RasTm = table.Column<int>(type: "INTEGER", nullable: false),
                    RasTg = table.Column<int>(type: "INTEGER", nullable: false),
                    RasV = table.Column<float>(type: "REAL", nullable: false),
                    RasTemG = table.Column<float>(type: "REAL", nullable: false),
                    RasRas = table.Column<float>(type: "REAL", nullable: false),
                    RasTemM = table.Column<float>(type: "REAL", nullable: false),
                    RasTepl = table.Column<int>(type: "INTEGER", nullable: false),
                    RasD = table.Column<float>(type: "REAL", nullable: false),
                    M = table.Column<float>(type: "REAL", nullable: false),
                    Y0 = table.Column<float>(type: "REAL", nullable: false),
                    Y1 = table.Column<float>(type: "REAL", nullable: false),
                    Y1_DOP = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputDatas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputDatas");
        }
    }
}
