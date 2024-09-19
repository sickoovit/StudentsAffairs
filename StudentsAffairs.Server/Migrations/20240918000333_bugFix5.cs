using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsAffairs.Server.Migrations
{
    /// <inheritdoc />
    public partial class bugFix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
