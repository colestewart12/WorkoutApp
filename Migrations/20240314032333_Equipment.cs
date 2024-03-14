using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApp.Migrations
{
    /// <inheritdoc />
    public partial class Equipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Equipment",
                table: "Exercise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipment",
                table: "Exercise");
        }
    }
}
