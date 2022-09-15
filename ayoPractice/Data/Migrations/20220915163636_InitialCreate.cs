using Microsoft.EntityFrameworkCore.Migrations;

namespace ayoPractice.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MetricImperialUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitCoversion = table.Column<string>(nullable: true),
                    ConversionRate = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    CalculationConstant = table.Column<decimal>(type: "decimal(18,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricImperialUnits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetricImperialUnits");
        }
    }
}
