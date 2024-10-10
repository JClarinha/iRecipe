using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iRecipeAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class imageimplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recepies");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Recepies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Recepies");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Recepies",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
