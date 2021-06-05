using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("db683059-0055-40ee-98aa-a413b80bd677"), "Drama" },
                    { new Guid("75fb3cd7-94bf-4dde-8e56-2e2a0d91a261"), "Comedia" },
                    { new Guid("c8693cb0-09ab-4eb1-9945-c0f389ba539a"), "Romántica" },
                    { new Guid("fccdc11b-7a19-4bbb-9ad7-ae5d378131c1"), "Suspenso" },
                    { new Guid("6195ebc3-2717-4c5a-9bb8-412e329ca9dd"), "Terror" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Seats");
        }
    }
}
