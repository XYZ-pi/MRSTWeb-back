using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TKDequipShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImageRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Badge",
                table: "ProductDatas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ProductDatas",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RatingCount",
                table: "ProductDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "RatingRate",
                table: "ProductDatas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Badge",
                table: "ProductDatas");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProductDatas");

            migrationBuilder.DropColumn(
                name: "RatingCount",
                table: "ProductDatas");

            migrationBuilder.DropColumn(
                name: "RatingRate",
                table: "ProductDatas");
        }
    }
}
