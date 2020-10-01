using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Plants.Models;

namespace Plants.Backend
{
    public partial class InitDatastore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ImgURI = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
