using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Duozin.Migrations
{
    public partial class Duozin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Age = table.Column<int>(type: "INT", nullable: false),
                    MartialArts = table.Column<int>(type: "INT", nullable: false),
                    Fights = table.Column<int>(type: "INT", nullable: false),
                    Defeats = table.Column<int>(type: "INT", nullable: false),
                    Victories = table.Column<int>(type: "INT", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mids", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mids");
        }
    }
}
