using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class Top10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("2af980dd-d30d-4c98-a0a7-8380bd77ed98"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("302fcedb-4b8d-4f26-a99d-c00cc765a86f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("98044a18-cee6-47c0-b8b1-02d230342d5e"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("a7c35ddd-8f9d-4fa3-9566-62a16d2163d2"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("aeb1766c-eacb-4694-ae15-47c2b9a20bcb"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b9f49af9-4a31-4b62-9282-bb82ad871d69"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c5cc5c27-6402-4cf9-9319-260ce6bc6dfe"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e9d608e5-b5bf-4cef-a3fe-00b49e2455e6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0cb4de8f-9325-4323-b57e-5cd053e777df"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("24263667-5d49-4302-89f9-850f0b6ef70c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3cb33be8-184c-4d8a-9496-a94f7945c352"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f1ac22c-78f4-4499-86d7-b8ebc2e05c88"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("56fb256a-a443-4486-98da-c81daa6e0412"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("67f1701c-1faf-4ba7-8dc4-43cad05d5597"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("879733d3-edd2-4dc1-b187-fb0c30286bdb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("959aea22-bbd8-4afc-83c9-a406bfcd1a16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9a779d25-ccf6-4928-8eee-47045212d19c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a54692c7-c863-414f-a47a-afa4bcfee665"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b05c4175-8258-48bd-a7ae-d14bfd72eaa0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("da720276-44d1-4209-b840-d2556670bb16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f57d04ce-3d21-4b95-b282-e20943f1a261"));

            migrationBuilder.CreateTable(
                name: "Top10",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Top10", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Top10_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d015d12d-e3cd-4d63-9d29-c20688ba15a7"), "Actor" },
                    { new Guid("731c6aa3-da3e-467b-be26-c64040516cbd"), "Director" },
                    { new Guid("561bd9f1-f639-4d47-97f9-2fe17a24c1cd"), "Productor" },
                    { new Guid("76e5648d-f6ce-4c8e-8b57-bf857522d84f"), "Asistente de dirección" },
                    { new Guid("7586cd40-b8ed-4934-b1a9-add3f54cca81"), "Productor Ejecutivo" },
                    { new Guid("b1b5ff9b-834e-4742-ba55-6c82574d683a"), "Guionista" },
                    { new Guid("0efd796a-6fab-49a6-8f8c-e1c6694cbf8d"), "Diseñador de Vestuario" },
                    { new Guid("bcda5d63-6f89-4a33-abdc-bac32ffa51b1"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a97b0883-7b2c-4829-a8f6-4ae2d09b2210"), "Aventura" },
                    { new Guid("b95f0c4c-0c3f-41e2-88ef-40c9c2da368b"), "Ciencia Ficción" },
                    { new Guid("b8fab495-6bb4-4117-b21c-7aa5b98dbe9f"), "Ficción" },
                    { new Guid("631bbec2-de09-4d3e-acd2-5e8740daac02"), "Documental" },
                    { new Guid("d30f8b7f-c419-4c44-9d44-3256c4c7e9a0"), "Hístorico" },
                    { new Guid("204e0b1f-4127-4c8b-b6ee-6a2b95bceca4"), "Romántica" },
                    { new Guid("e4575e86-ab2f-453f-a611-53a98d82f33f"), "Terror" },
                    { new Guid("6d875347-b4df-4f64-9475-8b10fb9f5597"), "Suspenso" },
                    { new Guid("30160a59-c633-4471-b0db-366bb9fcd0eb"), "Musical" },
                    { new Guid("9074a790-64ae-4d9b-94cb-4358b8855722"), "Comedia" },
                    { new Guid("9666c8bd-0192-4acf-b860-59ccd6bbc7c0"), "Drama" },
                    { new Guid("e35856ec-0fc6-4f6e-92fe-fdfa0f9f7a8e"), "Tragicomedia" },
                    { new Guid("5192a3ab-2aa1-4f1a-bc94-6351723ad339"), "Erótico" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Top10");

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("0efd796a-6fab-49a6-8f8c-e1c6694cbf8d"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("561bd9f1-f639-4d47-97f9-2fe17a24c1cd"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("731c6aa3-da3e-467b-be26-c64040516cbd"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("7586cd40-b8ed-4934-b1a9-add3f54cca81"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("76e5648d-f6ce-4c8e-8b57-bf857522d84f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b1b5ff9b-834e-4742-ba55-6c82574d683a"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("bcda5d63-6f89-4a33-abdc-bac32ffa51b1"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("d015d12d-e3cd-4d63-9d29-c20688ba15a7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("204e0b1f-4127-4c8b-b6ee-6a2b95bceca4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("30160a59-c633-4471-b0db-366bb9fcd0eb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5192a3ab-2aa1-4f1a-bc94-6351723ad339"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("631bbec2-de09-4d3e-acd2-5e8740daac02"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6d875347-b4df-4f64-9475-8b10fb9f5597"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9074a790-64ae-4d9b-94cb-4358b8855722"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9666c8bd-0192-4acf-b860-59ccd6bbc7c0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a97b0883-7b2c-4829-a8f6-4ae2d09b2210"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b8fab495-6bb4-4117-b21c-7aa5b98dbe9f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b95f0c4c-0c3f-41e2-88ef-40c9c2da368b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d30f8b7f-c419-4c44-9d44-3256c4c7e9a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e35856ec-0fc6-4f6e-92fe-fdfa0f9f7a8e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4575e86-ab2f-453f-a611-53a98d82f33f"));

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c5cc5c27-6402-4cf9-9319-260ce6bc6dfe"), "Actor" },
                    { new Guid("2af980dd-d30d-4c98-a0a7-8380bd77ed98"), "Director" },
                    { new Guid("98044a18-cee6-47c0-b8b1-02d230342d5e"), "Productor" },
                    { new Guid("aeb1766c-eacb-4694-ae15-47c2b9a20bcb"), "Asistente de dirección" },
                    { new Guid("e9d608e5-b5bf-4cef-a3fe-00b49e2455e6"), "Productor Ejecutivo" },
                    { new Guid("b9f49af9-4a31-4b62-9282-bb82ad871d69"), "Guionista" },
                    { new Guid("a7c35ddd-8f9d-4fa3-9566-62a16d2163d2"), "Diseñador de Vestuario" },
                    { new Guid("302fcedb-4b8d-4f26-a99d-c00cc765a86f"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("879733d3-edd2-4dc1-b187-fb0c30286bdb"), "Aventura" },
                    { new Guid("67f1701c-1faf-4ba7-8dc4-43cad05d5597"), "Ciencia Ficción" },
                    { new Guid("9a779d25-ccf6-4928-8eee-47045212d19c"), "Ficción" },
                    { new Guid("959aea22-bbd8-4afc-83c9-a406bfcd1a16"), "Documental" },
                    { new Guid("4f1ac22c-78f4-4499-86d7-b8ebc2e05c88"), "Hístorico" },
                    { new Guid("da720276-44d1-4209-b840-d2556670bb16"), "Romántica" },
                    { new Guid("24263667-5d49-4302-89f9-850f0b6ef70c"), "Terror" },
                    { new Guid("3cb33be8-184c-4d8a-9496-a94f7945c352"), "Suspenso" },
                    { new Guid("0cb4de8f-9325-4323-b57e-5cd053e777df"), "Musical" },
                    { new Guid("56fb256a-a443-4486-98da-c81daa6e0412"), "Comedia" },
                    { new Guid("a54692c7-c863-414f-a47a-afa4bcfee665"), "Drama" },
                    { new Guid("b05c4175-8258-48bd-a7ae-d14bfd72eaa0"), "Tragicomedia" },
                    { new Guid("f57d04ce-3d21-4b95-b282-e20943f1a261"), "Erótico" }
                });
        }
    }
}
