using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_SaleFrom_Field_to_Sales_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Members_MemberId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "SaleFrom",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustName",
                table: "Customers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Customers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SellingTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Types = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellingTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Members_MemberId",
                table: "Customers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Members_MemberId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "SellingTypes");

            migrationBuilder.DropColumn(
                name: "SaleFrom",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustName",
                table: "Customers",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Members_MemberId",
                table: "Customers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
