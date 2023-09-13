using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicCity_ShillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class inserteduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 14, 5, 59, 469, DateTimeKind.Local).AddTicks(6750));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 28, 10, 16, 25, 72, DateTimeKind.Local).AddTicks(8468));
        }
    }
}
