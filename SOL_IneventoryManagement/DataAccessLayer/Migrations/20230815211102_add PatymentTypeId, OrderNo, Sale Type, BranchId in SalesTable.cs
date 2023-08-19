using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addPatymentTypeIdOrderNoSaleTypeBranchIdinSalesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderNo",
                table: "Sales",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SaleType",
                table: "Sales",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SaleType",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
