using Microsoft.EntityFrameworkCore.Migrations;

namespace com.b_velop.Slipways.GrQl.Migrations
{
    public partial class AddStreetColumnToSlipways : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Slipways",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "Slipways");
        }
    }
}
