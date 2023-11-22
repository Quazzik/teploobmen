using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teploobmen.Migrations
{
    public partial class TableInputDatasNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "M",
                table: "InputDatas");

            migrationBuilder.DropColumn(
                name: "Y0",
                table: "InputDatas");

            migrationBuilder.DropColumn(
                name: "Y1",
                table: "InputDatas");

            migrationBuilder.DropColumn(
                name: "Y1_DOP",
                table: "InputDatas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "M",
                table: "InputDatas",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Y0",
                table: "InputDatas",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Y1",
                table: "InputDatas",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Y1_DOP",
                table: "InputDatas",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
