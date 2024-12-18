using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FotoWebApp.Migrations
{
    /// <inheritdoc />
    public partial class RenameAlbumLinkToLinkPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlbumLink",
                table: "Albums",
                newName: "LinkPassword");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkPassword",
                table: "Albums",
                newName: "AlbumLink");
        }
    }
}
