using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addIsSelected_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Vendors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Sources",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Sizes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "SellingTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "SellFroms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "PaymentTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Measures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Colors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Branchs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "Bins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "SellingTypes");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "SellFroms");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "PaymentTypes");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Measures");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Branchs");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "Bins");
        }
    }
}
