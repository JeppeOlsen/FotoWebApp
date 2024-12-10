using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FotoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserPhotographerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Photographers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photographers_AspNetUsers_UserId",
                table: "Photographers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photographers_AspNetUsers_UserId",
                table: "Photographers");

            migrationBuilder.DropIndex(
                name: "IX_Photographers_UserId",
                table: "Photographers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Photographers");
        }
    }
}
