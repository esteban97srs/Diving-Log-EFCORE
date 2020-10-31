using Microsoft.EntityFrameworkCore.Migrations;

namespace Diving_Log.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_log = table.Column<string>(nullable: true),
                    wind_direction = table.Column<string>(nullable: true),
                    surface_current = table.Column<string>(nullable: true),
                    diving_permit = table.Column<string>(nullable: true),
                    wave_height = table.Column<string>(nullable: true),
                    divers_number = table.Column<string>(nullable: true),
                    observations = table.Column<string>(nullable: true)
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
