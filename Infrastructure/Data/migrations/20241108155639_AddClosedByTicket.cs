using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.migrations
{
    /// <inheritdoc />
    public partial class AddClosedByTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "540feda6-7ba4-4dee-9533-d92fb3829539",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b919fa8d-1852-438e-8b1c-9cc1fc548469", "AQAAAAIAAYagAAAAEAkulVrneFoPoDMptsClSo5K6iHkv4gOzpDsNwgJs2Fm3qs/QSEYwwJtr4jKBtUu9Q==", "240f899f-4047-49a4-8214-43d81264a95e" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7017), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7033), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7046), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7053), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7059), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7067), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7076), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7082), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7090), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7096), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7102), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "LastUpdateDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 11, 9, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7110), null, new DateTime(2024, 11, 8, 23, 56, 32, 685, DateTimeKind.Local).AddTicks(7109) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "Attachments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9464), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9480), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 6,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 7,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9493), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 9,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 10,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 12,
                columns: new[] { "ClosedDate", "ExpectedDate", "RaisedDate" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 11, 8, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 11, 7, 20, 19, 23, 907, DateTimeKind.Local).AddTicks(9509) });
        }
    }
}
