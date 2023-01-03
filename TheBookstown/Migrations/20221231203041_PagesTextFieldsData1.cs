using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookstown.Migrations
{
    /// <inheritdoc />
    public partial class PagesTextFieldsData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7be15b61-0cf0-406c-a559-145bd63a0206", "AQAAAAIAAYagAAAAEJGKRIY5li9121PnZiVhXt05ODJnOKTc0ciMdzRwEXoCiRLjBD4IdE8RvE6v9S0zQg==" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5644), "Books" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5739), "Orders history" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5724), "Cart" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5709), "Authors" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5754), "Profile" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7edb227-86eb-4cff-85c4-f45c605fa782", "AQAAAAIAAYagAAAAEIEVKbeDu96YQkLgMHvZ8DspJHNRXFY7Zehygu4x6dKT6EWBk7SqT31x6g9e9NWFZw==" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1108), "Info page" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1193), "Info page" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1179), "Info page" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1164), "Info page" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                columns: new[] { "DateAdded", "Name" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 31, 35, 944, DateTimeKind.Local).AddTicks(1207), "Info page" });
        }
    }
}
