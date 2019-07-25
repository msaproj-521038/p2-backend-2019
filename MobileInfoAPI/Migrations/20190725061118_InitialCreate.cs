using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileInfoAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobileSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModelNumber = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    BatteryRating = table.Column<int>(nullable: false),
                    PhoneLength = table.Column<double>(nullable: false),
                    PhoneWidth = table.Column<double>(nullable: false),
                    ScreenLength = table.Column<double>(nullable: false),
                    ScreenWidth = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileSpecs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobileSpecs");
        }
    }
}
