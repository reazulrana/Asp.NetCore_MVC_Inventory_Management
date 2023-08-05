using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_Remove_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Amounts_TrID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Branchs_BranchId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Amounts_TrID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_TrID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_TrID",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "TrID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "TrID",
                table: "Purchases");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AmountId",
                table: "MasterDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentOnCash",
                table: "Amounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail",
                column: "AmountId",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Branchs_BranchId",
                table: "Purchases",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Branchs_BranchId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "PaymentOnCash",
                table: "Amounts");

            migrationBuilder.AddColumn<int>(
                name: "TrID",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Purchases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TrID",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AmountId",
                table: "MasterDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_TrID",
                table: "Sales",
                column: "TrID",
                unique: true,
                filter: "[TrID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_TrID",
                table: "Purchases",
                column: "TrID",
                unique: true,
                filter: "[TrID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail",
                column: "AmountId",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Amounts_TrID",
                table: "Purchases",
                column: "TrID",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Branchs_BranchId",
                table: "Purchases",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Amounts_TrID",
                table: "Sales",
                column: "TrID",
                principalTable: "Amounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
