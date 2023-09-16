using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicCity_ShillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class identitytableinserted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 16, 22, 32, 24, 519, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
