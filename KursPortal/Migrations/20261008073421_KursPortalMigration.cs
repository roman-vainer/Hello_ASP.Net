using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursPortal.Migrations
{
    /// <inheritdoc />
    public partial class KursPortalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kursname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dozent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnzahlTeilnehmer = table.Column<int>(type: "int", nullable: false),
                    DauerInTagen = table.Column<int>(type: "int", nullable: false),
                    inhalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurse", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurse");
        }
    }
}
