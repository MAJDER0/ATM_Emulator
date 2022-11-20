using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMEmulator.Migrations
{
    /// <inheritdoc />
    public partial class Migracja2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_login_username",
                table: "login",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_login_username",
                table: "login");
        }
    }
}
