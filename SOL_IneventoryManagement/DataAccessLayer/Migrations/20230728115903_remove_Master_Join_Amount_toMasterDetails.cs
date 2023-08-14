using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class remove_Master_Join_Amount_toMasterDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDetail_Masters_MasterId",
                table: "MasterDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Masters_TrID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Masters_TrID",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "Masters");

            //migrationBuilder.DropIndex(
            //    name: "IX_MasterDetail_MasterId",
            //    table: "MasterDetail");

            migrationBuilder.DropColumn(
                name: "MasterId",
                table: "MasterDetail");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SourceId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceiveDate",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReceivedByID",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "AmountId",
                table: "MasterDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchIncharge = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BranchId",
                table: "Sales",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_BranchId",
                table: "Purchases",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterDetail_AmountId",
                table: "MasterDetail",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_Branchs_Name",
                table: "Branchs",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail",
                column: "AmountId",
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
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales",
                column: "BranchId",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDetail_Amounts_AmountId",
                table: "MasterDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Branchs_BranchId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Branchs_BranchId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropIndex(
                name: "IX_Sales_BranchId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_BranchId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_MasterDetail_AmountId",
                table: "MasterDetail");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "ReceiveDate",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "ReceivedByID",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "AmountId",
                table: "MasterDetail");

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Purchases",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "SourceId",
                table: "Purchases",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "MasterId",
                table: "MasterDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrID = table.Column<int>(type: "int", nullable: false),
                    TrType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterDetail_MasterId",
                table: "MasterDetail",
                column: "MasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDetail_Masters_MasterId",
                table: "MasterDetail",
                column: "MasterId",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Masters_TrID",
                table: "Purchases",
                column: "TrID",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Masters_TrID",
                table: "Sales",
                column: "TrID",
                principalTable: "Masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
