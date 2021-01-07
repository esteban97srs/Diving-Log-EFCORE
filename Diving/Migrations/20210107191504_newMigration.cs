using Microsoft.EntityFrameworkCore.Migrations;

namespace Diving_Log.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateLog = table.Column<string>(maxLength: 15, nullable: false),
                    WindDirection = table.Column<string>(maxLength: 50, nullable: false),
                    SurfaceCurrent = table.Column<string>(maxLength: 50, nullable: false),
                    DivingPermit = table.Column<string>(maxLength: 50, nullable: false),
                    WaveHeight = table.Column<string>(maxLength: 5, nullable: false),
                    DiversNumber = table.Column<string>(maxLength: 5, nullable: false),
                    Observations = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divings", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divings");
        }
    }
}
