using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMEmulator.Migrations
{
    /// <inheritdoc />
    public partial class Migracja3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AccountBalance",
                table: "login",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TransacationHistory",
                table: "login",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountBalance",
                table: "login");

            migrationBuilder.DropColumn(
                name: "TransacationHistory",
                table: "login");
        }
    }
}
