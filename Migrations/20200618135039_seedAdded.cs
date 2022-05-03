using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_Tutorial13.Migrations
{
    public partial class seedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_IdClient",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "IdClient");

            migrationBuilder.InsertData(
                table: "Confectionery",
                columns: new[] { "IdConectionery", "Name", "PricePerItem", "Type" },
                values: new object[] { 2, "nme", 2.5600000000000001, "okei" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "IdClient", "Name", "Surname" },
                values: new object[] { 2, "Steve", "Do" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "IdEmpl", "Name", "Surname" },
                values: new object[] { 2, "Steven", "Dou" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "DateAccepted", "DateFinished", "IdClient", "IdEmpl", "Notes" },
                values: new object[] { 2, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "NotesHere" });

            migrationBuilder.InsertData(
                table: "Confectionery_Order",
                columns: new[] { "IdOrder", "IdConfection", "Notes", "Quantity" },
                values: new object[] { 2, 2, "NOTED", 4 });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_IdClient",
                table: "Order",
                column: "IdClient",
                principalTable: "Customer",
                principalColumn: "IdClient",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_IdClient",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "Confectionery_Order",
                keyColumns: new[] { "IdOrder", "IdConfection" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "IdClient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "IdEmpl",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Confectionery",
                keyColumn: "IdConectionery",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "IdClient");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_IdClient",
                table: "Order",
                column: "IdClient",
                principalTable: "Customers",
                principalColumn: "IdClient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
