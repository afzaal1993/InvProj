using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inv.Core.Data.Migrations
{
    /// <inheritdoc />
    public partial class EntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Batches_BatchId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BatchId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_ProductId",
                table: "Batches",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Products_ProductId",
                table: "Batches",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Products_ProductId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_ProductId",
                table: "Batches");

            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BatchId",
                table: "Products",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Batches_BatchId",
                table: "Products",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
