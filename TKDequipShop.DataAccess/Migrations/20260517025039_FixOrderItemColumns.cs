using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKDequipShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixOrderItemColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas");

            migrationBuilder.AddColumn<int>(
                name: "ProductDataId",
                table: "OrderItemDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderItemDatas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductDataId",
                table: "CartItemDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDatas_ProductDataId",
                table: "OrderItemDatas",
                column: "ProductDataId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDatas_ProductId",
                table: "OrderItemDatas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemDatas_ProductDataId",
                table: "CartItemDatas",
                column: "ProductDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemDatas_ProductDatas_ProductDataId",
                table: "CartItemDatas",
                column: "ProductDataId",
                principalTable: "ProductDatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDatas_ProductDatas_ProductDataId",
                table: "OrderItemDatas",
                column: "ProductDataId",
                principalTable: "ProductDatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDatas_ProductDatas_ProductId",
                table: "OrderItemDatas",
                column: "ProductId",
                principalTable: "ProductDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemDatas_ProductDatas_ProductDataId",
                table: "CartItemDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDatas_ProductDatas_ProductDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDatas_ProductDatas_ProductId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_OrderItemDatas_ProductDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_OrderItemDatas_ProductId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartItemDatas_ProductDataId",
                table: "CartItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas");

            migrationBuilder.DropColumn(
                name: "ProductDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderItemDatas");

            migrationBuilder.DropColumn(
                name: "ProductDataId",
                table: "CartItemDatas");

            migrationBuilder.CreateIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas",
                column: "UserId");
        }
    }
}
