using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicCity_ShillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class createshillanumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShillaNumbers",
                columns: table => new
                {
                    ShillaNo = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShillaNumbers", x => x.ShillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 20, 34, 58, 675, DateTimeKind.Local).AddTicks(9271));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShillaNumbers");

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7329));
        }
    }
}
