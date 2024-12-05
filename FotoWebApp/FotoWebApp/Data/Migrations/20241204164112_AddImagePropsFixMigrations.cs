using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FotoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePropsFixMigrations : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Images");
        }
    }
}
