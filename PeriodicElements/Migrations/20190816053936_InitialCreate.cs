using Microsoft.EntityFrameworkCore.Migrations;

namespace PeriodicElements.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    AtomicNumber = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Symbol = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ElectronConfiguration = table.Column<string>(nullable: true),
                    BondingType = table.Column<string>(nullable: true),
                    GroupBlock = table.Column<string>(nullable: true),
                    AtomicMass = table.Column<string>(nullable: true),
                    AtomicRadius = table.Column<string>(nullable: true),
                    FirstIonisationEnergy = table.Column<string>(nullable: true),
                    X_Position = table.Column<int>(nullable: false),
                    Y_Position = table.Column<int>(nullable: false),
                    MeltingPoint = table.Column<string>(nullable: true),
                    BoilingPoint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.AtomicNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");
        }
    }
}
