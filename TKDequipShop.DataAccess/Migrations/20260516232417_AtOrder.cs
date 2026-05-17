using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKDequipShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AtOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemData_CartDatas_CartDataId",
                table: "CartItemData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItemData",
                table: "CartItemData");

            migrationBuilder.RenameTable(
                name: "CartItemData",
                newName: "CartItemDatas");

            migrationBuilder.RenameIndex(
                name: "IX_CartItemData_CartDataId",
                table: "CartItemDatas",
                newName: "IX_CartItemDatas_CartDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItemDatas",
                table: "CartItemDatas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultPaymentMethod = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemDatas_OrderDatas_OrderDataId",
                        column: x => x.OrderDataId,
                        principalTable: "OrderDatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDatas_OrderDataId",
                table: "OrderItemDatas",
                column: "OrderDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartDataId",
                table: "CartItemDatas",
                column: "CartDataId",
                principalTable: "CartDatas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartDataId",
                table: "CartItemDatas");

            migrationBuilder.DropTable(
                name: "OrderItemDatas");

            migrationBuilder.DropTable(
                name: "ProductDatas");

            migrationBuilder.DropTable(
                name: "UserDatas");

            migrationBuilder.DropTable(
                name: "OrderDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItemDatas",
                table: "CartItemDatas");

            migrationBuilder.RenameTable(
                name: "CartItemDatas",
                newName: "CartItemData");

            migrationBuilder.RenameIndex(
                name: "IX_CartItemDatas_CartDataId",
                table: "CartItemData",
                newName: "IX_CartItemData_CartDataId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItemData",
                table: "CartItemData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemData_CartDatas_CartDataId",
                table: "CartItemData",
                column: "CartDataId",
                principalTable: "CartDatas",
                principalColumn: "Id");
        }
    }
}
