using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teploobmen.Migrations
{
    public partial class TableInputDataUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "InputDatas",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "InputDatas");
        }
    }
}
