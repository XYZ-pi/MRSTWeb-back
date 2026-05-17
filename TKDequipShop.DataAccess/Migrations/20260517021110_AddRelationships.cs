using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKDequipShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartDataId",
                table: "CartItemDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDatas_OrderDatas_OrderDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_OrderItemDatas_OrderDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartItemDatas_CartDataId",
                table: "CartItemDatas");

            migrationBuilder.DropColumn(
                name: "OrderDataId",
                table: "OrderItemDatas");

            migrationBuilder.DropColumn(
                name: "CartDataId",
                table: "CartItemDatas");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderItemDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDatas_OrderId",
                table: "OrderItemDatas",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDatas_UserId",
                table: "OrderDatas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemDatas_CartId",
                table: "CartItemDatas",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemDatas_ProductId",
                table: "CartItemDatas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDatas_UserDatas_UserId",
                table: "CartDatas",
                column: "UserId",
                principalTable: "UserDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartId",
                table: "CartItemDatas",
                column: "CartId",
                principalTable: "CartDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemDatas_ProductDatas_ProductId",
                table: "CartItemDatas",
                column: "ProductId",
                principalTable: "ProductDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDatas_UserDatas_UserId",
                table: "OrderDatas",
                column: "UserId",
                principalTable: "UserDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDatas_OrderDatas_OrderId",
                table: "OrderItemDatas",
                column: "OrderId",
                principalTable: "OrderDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDatas_UserDatas_UserId",
                table: "CartDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartId",
                table: "CartItemDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItemDatas_ProductDatas_ProductId",
                table: "CartItemDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDatas_UserDatas_UserId",
                table: "OrderDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemDatas_OrderDatas_OrderId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_OrderItemDatas_OrderId",
                table: "OrderItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_OrderDatas_UserId",
                table: "OrderDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartItemDatas_CartId",
                table: "CartItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartItemDatas_ProductId",
                table: "CartItemDatas");

            migrationBuilder.DropIndex(
                name: "IX_CartDatas_UserId",
                table: "CartDatas");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderItemDatas");

            migrationBuilder.AddColumn<int>(
                name: "OrderDataId",
                table: "OrderItemDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartDataId",
                table: "CartItemDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDatas_OrderDataId",
                table: "OrderItemDatas",
                column: "OrderDataId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItemDatas_CartDataId",
                table: "CartItemDatas",
                column: "CartDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemDatas_CartDatas_CartDataId",
                table: "CartItemDatas",
                column: "CartDataId",
                principalTable: "CartDatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemDatas_OrderDatas_OrderDataId",
                table: "OrderItemDatas",
                column: "OrderDataId",
                principalTable: "OrderDatas",
                principalColumn: "Id");
        }
    }
}
