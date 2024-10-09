using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iRecipeAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favourite_Recepies_RecipeId",
                table: "Favourite");

            migrationBuilder.DropForeignKey(
                name: "FK_Favourite_Users_UserId",
                table: "Favourite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favourite",
                table: "Favourite");

            migrationBuilder.RenameTable(
                name: "Favourite",
                newName: "Favorits");

            migrationBuilder.RenameIndex(
                name: "IX_Favourite_UserId",
                table: "Favorits",
                newName: "IX_Favorits_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favourite_RecipeId",
                table: "Favorits",
                newName: "IX_Favorits_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorits",
                table: "Favorits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorits_Recepies_RecipeId",
                table: "Favorits",
                column: "RecipeId",
                principalTable: "Recepies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorits_Users_UserId",
                table: "Favorits",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorits_Recepies_RecipeId",
                table: "Favorits");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorits_Users_UserId",
                table: "Favorits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorits",
                table: "Favorits");

            migrationBuilder.RenameTable(
                name: "Favorits",
                newName: "Favourite");

            migrationBuilder.RenameIndex(
                name: "IX_Favorits_UserId",
                table: "Favourite",
                newName: "IX_Favourite_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorits_RecipeId",
                table: "Favourite",
                newName: "IX_Favourite_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favourite",
                table: "Favourite",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favourite_Recepies_RecipeId",
                table: "Favourite",
                column: "RecipeId",
                principalTable: "Recepies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favourite_Users_UserId",
                table: "Favourite",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
