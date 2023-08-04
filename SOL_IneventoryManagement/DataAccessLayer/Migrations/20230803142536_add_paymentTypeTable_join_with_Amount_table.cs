using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_paymentTypeTable_join_with_Amount_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Traport",
                table: "Amounts",
                newName: "Transport");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "Amounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payments = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amounts_PaymentTypeId",
                table: "Amounts",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_Payments",
                table: "PaymentTypes",
                column: "Payments",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Amounts_PaymentTypes_PaymentTypeId",
                table: "Amounts",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amounts_PaymentTypes_PaymentTypeId",
                table: "Amounts");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Amounts_PaymentTypeId",
                table: "Amounts");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Amounts");

            migrationBuilder.RenameColumn(
                name: "Transport",
                table: "Amounts",
                newName: "Traport");
        }
    }
}
