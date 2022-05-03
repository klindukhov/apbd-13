using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Tutorial13.Migrations
{
    public partial class seedCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                columns: new[] { "IdClient", "IdEmpl" },
                values: new object[] { 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                columns: new[] { "IdClient", "IdEmpl" },
                values: new object[] { 1, 1 });
        }
    }
}
