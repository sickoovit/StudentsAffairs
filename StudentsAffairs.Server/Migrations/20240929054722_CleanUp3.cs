using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsAffairs.Server.Migrations
{
    /// <inheritdoc />
    public partial class CleanUp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdminRole",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_Id",
                table: "Tutors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_Id",
                table: "Lectures",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Id",
                table: "Assignments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Id",
                table: "Admins",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tutors_Id",
                table: "Tutors");

            migrationBuilder.DropIndex(
                name: "IX_Students_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_Id",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_Id",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Admins_Id",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "AdminRole",
                table: "Admins",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
