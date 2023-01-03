using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheBookstown.Migrations
{
    /// <inheritdoc />
    public partial class PagesTextFieldsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7edb227-86eb-4cff-85c4-f45c605fa782", "AQAAAAIAAYagAAAAEIEVKbeDu96YQkLgMHvZ8DspJHNRXFY7Zehygu4x6dKT6EWBk7SqT31x6g9e9NWFZw==" });

            migrationBuilder.InsertData(
                table: "PagesTextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Name" },
                values: new object[,]
                {
                    { new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"), "Home", new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1108), "Info page" },
                    { new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"), "Orders", new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1193), "Info page" },
                    { new Guid("88c027ca-a133-417d-a41a-c955b78a876a"), "Cart", new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1179), "Info page" },
                    { new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"), "Authors", new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1164), "Info page" },
                    { new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"), "Profile", new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1207), "Info page" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"));

            migrationBuilder.DeleteData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"));

            migrationBuilder.DeleteData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"));

            migrationBuilder.DeleteData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"));

            migrationBuilder.DeleteData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4978a84-0dfe-41fb-8838-f268e4bcff05", "AQAAAAIAAYagAAAAEGotsXNFeM3a5j5OHa5+HPlyynjQnsnN9l9nDXjlue4p11mdzZhOoR+Pupa9l+wi3A==" });
        }
    }
}
