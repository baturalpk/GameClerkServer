using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameClerkServer.Migrations
{
    /// <inheritdoc />
    public partial class ExtendGameplayActivityModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerId",
                table: "GameplayActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "GameplayActivities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "GameplayActivities",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "GameplayActivities");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "GameplayActivities");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "GameplayActivities");
        }
    }
}
