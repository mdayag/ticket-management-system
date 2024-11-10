using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClosedBy",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "540feda6-7ba4-4dee-9533-d92fb3829539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "036a1f78-de90-43d2-bf10-2fe6cbb73d55", "AQAAAAIAAYagAAAAEHlppqkInpHtpwsHb++xxOYI97FoVWjNaoqeQKhploqP1lXOcx3+U39+LT6I2D1Elg==", "fca95182-7bd6-40f7-9a94-125b0d778077" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9464), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9493), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { null, null, new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedBy", "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { "540feda6-7ba4-4dee-9533-d92fb3829539", new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9509) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosedBy",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ClosedDate",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "540feda6-7ba4-4dee-9533-d92fb3829539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc36a61-8521-43dc-9c37-60159e083835", "AQAAAAIAAYagAAAAEPH+RqdaKAEqcr42AM9O4g02JHvMmYzYopp0NojonKHCDKrG57WR1EQxHICJdUYvKg==", "c831d81d-7fa9-4144-b4a9-244acf392767" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8756), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 7, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 11, 6, 19, 57, 17, 854, DateTimeKind.Local).AddTicks(8786) });
        }
    }
}
