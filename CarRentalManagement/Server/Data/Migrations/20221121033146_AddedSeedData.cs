using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 31, 46, 20, DateTimeKind.Local).AddTicks(6522), new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(2064), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 11, 21, 11, 31, 46, 23, DateTimeKind.Local).AddTicks(3035), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8753), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8758), new DateTime(2022, 11, 21, 11, 31, 46, 24, DateTimeKind.Local).AddTicks(8759), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3159), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3164), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3168), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 11, 21, 11, 31, 46, 25, DateTimeKind.Local).AddTicks(3171), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
