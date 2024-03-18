using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JapTutor.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "BasicPronunciations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PronunciationUrl",
                table: "BasicPronunciations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "BasicPronunciations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "BasicPronunciations");

            migrationBuilder.DropColumn(
                name: "PronunciationUrl",
                table: "BasicPronunciations");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BasicPronunciations");
        }
    }
}
