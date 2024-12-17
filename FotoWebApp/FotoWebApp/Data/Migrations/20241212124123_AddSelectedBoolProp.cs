using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FotoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSelectedBoolProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "Images",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Selected",
                table: "Images");
        }
    }
}
