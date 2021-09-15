using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_Hub_MVC.Data.Migrations
{
    public partial class Updatepicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostPicture",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostPicture",
                table: "BlogPosts");
        }
    }
}
