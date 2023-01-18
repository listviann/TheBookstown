using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookstown.Migrations
{
    /// <inheritdoc />
    public partial class BookTitleColumninODMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookTitle",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9bc5c1c-5ee9-4f94-8419-6a73d992d829", "AQAAAAIAAYagAAAAEHYCLBEAMBlRVnM5pL7NfL6eB/86Ts/6kalltuNs8Qi+dPwsa1DPe8WnpKLgIU/VAQ==" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 37, 6, 829, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 37, 6, 829, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 37, 6, 829, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 37, 6, 829, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 37, 6, 829, DateTimeKind.Local).AddTicks(8095));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookTitle",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad26762b-8b79-43ec-acbd-7ad630d1d37d", "AQAAAAIAAYagAAAAEHu9QhCYcyHzeGA+nlkudiEPUL5tWpTL56hLFJd/IESBdAYiV6gsbo7LVgNxgFmMlg==" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 27, 10, 569, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 27, 10, 569, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 27, 10, 569, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 27, 10, 569, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 19, 27, 10, 569, DateTimeKind.Local).AddTicks(8496));
        }
    }
}
