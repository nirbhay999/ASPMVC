using Microsoft.EntityFrameworkCore.Migrations;

namespace CGIDataAccess.Migrations
{
    public partial class AddCloumnTagNUmber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagNumber",
                table: "Assets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagNumber",
                table: "Assets");
        }
    }
}
