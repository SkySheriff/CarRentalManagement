using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0c64737d-757e-46cc-adc3-c6eb669c389b", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEdvHPGs6rT/qg8ffXuRl0HuE17QkciIZKQyJhAcCPZVWwkMS3R4mD8XMlQBw3glPA==", null, false, "ec272d65-f2d1-42a9-b646-e3df7b3d3d78", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(7813), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8187), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8189), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8189), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8370), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8372), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8373), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8374), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 11, 22, 11, 46, 50, 931, DateTimeKind.Local).AddTicks(8375), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
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
                values: new object[] { new DateTime(2023, 11, 22, 11, 43, 30, 188, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 11, 22, 11, 43, 30, 188, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 43, 30, 188, DateTimeKind.Local).AddTicks(6526), new DateTime(2023, 11, 22, 11, 43, 30, 188, DateTimeKind.Local).AddTicks(6527) });
        }
    }
}
