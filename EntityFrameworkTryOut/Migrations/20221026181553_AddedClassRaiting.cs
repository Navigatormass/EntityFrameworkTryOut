using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkTryOut.Migrations
{
    public partial class AddedClassRaiting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassRaiting",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassRaiting",
                table: "Classes");
        }
    }
}
