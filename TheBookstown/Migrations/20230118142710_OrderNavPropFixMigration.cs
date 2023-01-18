using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookstown.Migrations
{
    /// <inheritdoc />
    public partial class OrderNavPropFixMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderItemId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderItemId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderItemId",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acf37fd8-a2f0-4b70-8ef0-24013b12669d", "AQAAAAIAAYagAAAAELkLwC9cECEVQ+oNXqSzraTP3bym0DCF2Jd8ytl12St+9s3UuN8H/bXRvjODAnBbeA==" });

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 17, 34, 40, 282, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 17, 34, 40, 282, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 17, 34, 40, 282, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 17, 34, 40, 282, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 18, 17, 34, 40, 282, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderItemId",
                table: "OrderDetails",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderItems_OrderItemId",
                table: "OrderDetails",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
