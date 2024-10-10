using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iRecipeAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixingdifficulty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Difficulties");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Recepies",
                newName: "RecipeDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipeDate",
                table: "Recepies",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Difficulties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
