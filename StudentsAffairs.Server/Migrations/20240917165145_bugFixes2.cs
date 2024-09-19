using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsAffairs.Server.Migrations
{
    /// <inheritdoc />
    public partial class bugFixes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "Users",
                newName: "Discriminator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Users",
                newName: "UserType");
        }
    }
}
