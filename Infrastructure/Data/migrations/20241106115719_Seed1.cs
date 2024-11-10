using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class Seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountConfirmed", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "540feda6-7ba4-4dee-9533-d92fb3829539", 0, false, null, "0bc36a61-8521-43dc-9c37-60159e083835", "mdayag4891@gmail.com", true, false, null, "MDAYAG4891@GMAIL.COM", "MDAYAG4891@GMAIL.COM", "AQAAAAIAAYagAAAAEPH+RqdaKAEqcr42AM9O4g02JHvMmYzYopp0NojonKHCDKrG57WR1EQxHICJdUYvKg==", null, false, "c831d81d-7fa9-4144-b4a9-244acf392767", false, "mdayag4891@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Application Bug" },
                    { 2, "Network Issue" },
                    { 3, "User Issue" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "ExpectedDays", "PriorityName" },
                values: new object[,]
                {
                    { 1, 5, "Low" },
                    { 2, 3, "Medium" },
                    { 3, 1, "High" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Product 1" },
                    { 2, "Product 2" },
                    { 3, "Product 3" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AssignedToId", "CategoryId", "Description", "ExpectedDate", "PriorityId", "ProductId", "RaisedBy", "RaisedDate", "Status", "Summary" },
                values: new object[,]
                {
                    { 1, null, 1, "Descriptio for ticket 1", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8721), 1, 1, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8703), "NEW", "Sample ticket 1" },
                    { 2, null, 2, "Descriptio for ticket 2", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8735), 2, 2, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8734), "OPEN", "Sample ticket 2" },
                    { 3, null, 3, "Descriptio for ticket 3", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8740), 3, 3, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8739), "CLOSED", "Sample ticket 3" },
                    { 4, null, 1, "Descriptio for ticket 1", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8746), 1, 1, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8744), "NEW", "Sample ticket 1" },
                    { 5, null, 2, "Descriptio for ticket 2", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8751), 2, 2, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8750), "OPEN", "Sample ticket 2" },
                    { 6, null, 3, "Descriptio for ticket 3", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8756), 3, 3, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8755), "CLOSED", "Sample ticket 3" },
                    { 7, null, 1, "Descriptio for ticket 1", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8761), 1, 1, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8760), "NEW", "Sample ticket 1" },
                    { 8, null, 2, "Descriptio for ticket 2", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8766), 2, 2, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8764), "OPEN", "Sample ticket 2" },
                    { 9, null, 3, "Descriptio for ticket 3", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8771), 3, 3, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8770), "CLOSED", "Sample ticket 3" },
                    { 10, null, 1, "Descriptio for ticket 1", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8776), 1, 1, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8775), "NEW", "Sample ticket 1" },
                    { 11, null, 2, "Descriptio for ticket 2", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8781), 2, 2, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8780), "OPEN", "Sample ticket 2" },
                    { 12, null, 3, "Descriptio for ticket 3", new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8787), 3, 3, "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8786), "CLOSED", "Sample ticket 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "540feda6-7ba4-4dee-9533-d92fb3829539");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
