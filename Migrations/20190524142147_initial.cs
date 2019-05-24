using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHotel.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2019, 5, 14, 16, 21, 47, 302, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2019, 5, 19, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2019, 5, 23, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 5, 22, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(3662), new DateTime(2019, 5, 27, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 5, 23, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(6107), new DateTime(2019, 5, 28, 16, 21, 47, 304, DateTimeKind.Local).AddTicks(6114) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 1, 17, 24, 17, 42, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 6, 17, 24, 17, 45, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisterDate",
                value: new DateTime(2019, 2, 10, 17, 24, 17, 45, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 2, 11, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(3759), new DateTime(2019, 2, 21, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckinDate", "CheckoutDate" },
                values: new object[] { new DateTime(2019, 2, 11, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(9405), new DateTime(2019, 2, 21, 17, 24, 17, 46, DateTimeKind.Local).AddTicks(9540) });
        }
    }
}
