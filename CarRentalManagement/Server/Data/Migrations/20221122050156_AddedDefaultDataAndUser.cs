using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "77e01c69-012b-4831-9db3-4914ecf4c90a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "09c41d2e-9dfe-41d0-ae94-de845a6043a7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "439fdb35-e9ba-4f4a-a538-cf5ea7d8d79f", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELUAzdIv9opIpIviV2kS8A1eSN30SVFjs1fbWr7JDc4bM7aUVnOqMZn9XV5PvGnxjA==", null, false, "ca7ccf8b-fa51-4d11-9f86-ffbccd789708", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 553, DateTimeKind.Local).AddTicks(4343), new DateTime(2022, 11, 22, 13, 1, 55, 555, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 555, DateTimeKind.Local).AddTicks(1895), new DateTime(2022, 11, 22, 13, 1, 55, 555, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(3167), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(3183), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6193), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6202), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6205), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6207), new DateTime(2022, 11, 22, 13, 1, 55, 556, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 20, DateTimeKind.Local).AddTicks(6522), new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8758), new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3171) });
        }
    }
}
