using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FotoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddImageProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Images",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Images");
        }
    }
}
