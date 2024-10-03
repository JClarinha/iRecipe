using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iRecipeAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class PreparationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Preparation",
                table: "Recepies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preparation",
                table: "Recepies");
        }
    }
}
