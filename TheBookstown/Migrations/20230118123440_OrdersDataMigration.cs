using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBookstown.Migrations
{
    /// <inheritdoc />
    public partial class OrdersDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCartItems_OrderItems_OrderItemId",
                table: "UserCartItems");

            migrationBuilder.DropIndex(
                name: "IX_UserCartItems_OrderItemId",
                table: "UserCartItems");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "UserCartItems");

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                });

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
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderItemId",
                table: "OrderDetails",
                column: "OrderItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderItemId",
                table: "UserCartItems",
                type: "uniqueidentifier",
                nullable: true);

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
                column: "DateAdded",
                value: new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "PagesTextFields",
                keyColumn: "Id",
                keyValue: new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 1, 1, 30, 41, 502, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.CreateIndex(
                name: "IX_UserCartItems_OrderItemId",
                table: "UserCartItems",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCartItems_OrderItems_OrderItemId",
                table: "UserCartItems",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
