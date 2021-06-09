using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clubMemberGenres_ClubMembers_ClubMemberId",
                table: "clubMemberGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_clubMemberGenres_Genres_GenreId",
                table: "clubMemberGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clubMemberGenres",
                table: "clubMemberGenres");

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("0aebe5dc-f434-4d90-a0c6-56633b2548a0"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("467a57d2-a478-4dcc-bb2e-0bdce570bedc"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("6ce98246-0381-42ed-af08-62fbe8438028"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("8987b25c-812f-4aac-bef5-ceb9f775c720"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("90028982-7c11-445d-873d-58d62e06f291"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("a549a375-6ee0-47d8-9660-d2ee900c916c"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("cc0d1d05-eb0c-4f85-aaa4-c69692f6e419"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e2a37e14-6568-457e-9ba2-2fa8728dd38a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0d5ee7c4-c1ae-4bce-82bc-f9d3c413e7a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1726faa4-9a5d-4c73-955e-3158f4c68867"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("26e8ddf5-3bba-4943-aa9e-318eb0e3d578"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2f63347a-9aa5-4f41-909e-5ac15e434c4a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("355a4e39-442c-4a4f-ab65-50414ea971fe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f35d70b-0348-4ae4-9a19-8bee077d58e4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5e3564c2-4435-4e82-a7a4-5736c62d57a5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("823e7646-6013-4b16-9141-d41ef00e4092"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("84eeee98-c73d-4883-9c63-79f824b0ae65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("90d25f73-b702-46a1-8490-af10a4b54c65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bb470b9f-e073-41bf-9200-b49aff0a3725"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce0d061e-a46d-4818-b82f-b097d191f45d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d0f80de4-f257-409b-bd4b-81b442ae97ed"));

            migrationBuilder.RenameTable(
                name: "clubMemberGenres",
                newName: "ClubMemberGenres");

            migrationBuilder.RenameColumn(
                name: "StarTime",
                table: "FilmScreenings",
                newName: "Time");

            migrationBuilder.RenameIndex(
                name: "IX_clubMemberGenres_GenreId",
                table: "ClubMemberGenres",
                newName: "IX_ClubMemberGenres_GenreId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "FilmScreenings",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClubMemberGenres",
                table: "ClubMemberGenres",
                columns: new[] { "ClubMemberId", "GenreId" });

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("87955c70-fe62-4b9e-ba32-fd4809f87532"), "Actor" },
                    { new Guid("fc0fec66-b831-4aeb-b004-91f1b5a0835b"), "Director" },
                    { new Guid("8e09e9b1-b6e5-4471-8551-12584cd064b1"), "Productor" },
                    { new Guid("4a1a3e1b-e366-4c85-a282-be5225d1515a"), "Asistente de dirección" },
                    { new Guid("4effbe87-57a0-4003-85b8-5aabcfec7a44"), "Productor Ejecutivo" },
                    { new Guid("c74b3b15-8a96-4e6e-8567-6d28e0606e88"), "Guionista" },
                    { new Guid("c3e5b33c-9bdf-4c3b-9fc9-2d4aea811577"), "Diseñador de Vestuario" },
                    { new Guid("e55185a3-8526-4c70-a165-a968f61bcedf"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("039e8849-a5a9-4e15-a1de-47e0fc9efd6e"), "Aventura" },
                    { new Guid("e074cebb-5f95-4b96-a283-76e19dd45fc4"), "Ciencia Ficción" },
                    { new Guid("74783895-168f-4480-a7fd-02242de45d2f"), "Ficción" },
                    { new Guid("bad90d05-9c22-4912-ae12-57cdf7ad2639"), "Documental" },
                    { new Guid("6952025e-f3a7-4e46-8f29-3e89105418d6"), "Hístorico" },
                    { new Guid("60e9e2fd-9027-46f0-85d1-1d03e3a5f308"), "Romántica" },
                    { new Guid("d1e87c30-1fbe-429d-848c-9ff12437f6e0"), "Terror" },
                    { new Guid("716175a2-b939-4922-a1c8-63bdf99fa1a1"), "Suspenso" },
                    { new Guid("2f436b72-24c8-45c5-8f04-e9df4df8634c"), "Musical" },
                    { new Guid("c90747f2-73fd-47bd-acfe-1696d8717ea4"), "Comedia" },
                    { new Guid("b3c304dc-58e5-4d7e-bd5e-e24983121aac"), "Drama" },
                    { new Guid("98690325-81d6-4a60-9ace-40b9e2096011"), "Tragicomedia" },
                    { new Guid("94a0fba8-ba43-43e6-8421-154c0996ce85"), "Erótico" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClubMemberGenres_ClubMembers_ClubMemberId",
                table: "ClubMemberGenres",
                column: "ClubMemberId",
                principalTable: "ClubMembers",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubMemberGenres_Genres_GenreId",
                table: "ClubMemberGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubMemberGenres_ClubMembers_ClubMemberId",
                table: "ClubMemberGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubMemberGenres_Genres_GenreId",
                table: "ClubMemberGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClubMemberGenres",
                table: "ClubMemberGenres");

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("4a1a3e1b-e366-4c85-a282-be5225d1515a"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("4effbe87-57a0-4003-85b8-5aabcfec7a44"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("87955c70-fe62-4b9e-ba32-fd4809f87532"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("8e09e9b1-b6e5-4471-8551-12584cd064b1"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c3e5b33c-9bdf-4c3b-9fc9-2d4aea811577"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c74b3b15-8a96-4e6e-8567-6d28e0606e88"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e55185a3-8526-4c70-a165-a968f61bcedf"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("fc0fec66-b831-4aeb-b004-91f1b5a0835b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("039e8849-a5a9-4e15-a1de-47e0fc9efd6e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2f436b72-24c8-45c5-8f04-e9df4df8634c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("60e9e2fd-9027-46f0-85d1-1d03e3a5f308"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6952025e-f3a7-4e46-8f29-3e89105418d6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("716175a2-b939-4922-a1c8-63bdf99fa1a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("74783895-168f-4480-a7fd-02242de45d2f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94a0fba8-ba43-43e6-8421-154c0996ce85"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("98690325-81d6-4a60-9ace-40b9e2096011"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b3c304dc-58e5-4d7e-bd5e-e24983121aac"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bad90d05-9c22-4912-ae12-57cdf7ad2639"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c90747f2-73fd-47bd-acfe-1696d8717ea4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d1e87c30-1fbe-429d-848c-9ff12437f6e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e074cebb-5f95-4b96-a283-76e19dd45fc4"));

            migrationBuilder.DropColumn(
                name: "Date",
                table: "FilmScreenings");

            migrationBuilder.RenameTable(
                name: "ClubMemberGenres",
                newName: "clubMemberGenres");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "FilmScreenings",
                newName: "StarTime");

            migrationBuilder.RenameIndex(
                name: "IX_ClubMemberGenres_GenreId",
                table: "clubMemberGenres",
                newName: "IX_clubMemberGenres_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clubMemberGenres",
                table: "clubMemberGenres",
                columns: new[] { "ClubMemberId", "GenreId" });

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0aebe5dc-f434-4d90-a0c6-56633b2548a0"), "Actor" },
                    { new Guid("467a57d2-a478-4dcc-bb2e-0bdce570bedc"), "Director" },
                    { new Guid("e2a37e14-6568-457e-9ba2-2fa8728dd38a"), "Productor" },
                    { new Guid("cc0d1d05-eb0c-4f85-aaa4-c69692f6e419"), "Asistente de dirección" },
                    { new Guid("90028982-7c11-445d-873d-58d62e06f291"), "Productor Ejecutivo" },
                    { new Guid("6ce98246-0381-42ed-af08-62fbe8438028"), "Guionista" },
                    { new Guid("8987b25c-812f-4aac-bef5-ceb9f775c720"), "Diseñador de Vestuario" },
                    { new Guid("a549a375-6ee0-47d8-9660-d2ee900c916c"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d5ee7c4-c1ae-4bce-82bc-f9d3c413e7a0"), "Aventura" },
                    { new Guid("823e7646-6013-4b16-9141-d41ef00e4092"), "Ciencia Ficción" },
                    { new Guid("26e8ddf5-3bba-4943-aa9e-318eb0e3d578"), "Ficción" },
                    { new Guid("4f35d70b-0348-4ae4-9a19-8bee077d58e4"), "Documental" },
                    { new Guid("ce0d061e-a46d-4818-b82f-b097d191f45d"), "Hístorico" },
                    { new Guid("1726faa4-9a5d-4c73-955e-3158f4c68867"), "Romántica" },
                    { new Guid("d0f80de4-f257-409b-bd4b-81b442ae97ed"), "Terror" },
                    { new Guid("bb470b9f-e073-41bf-9200-b49aff0a3725"), "Suspenso" },
                    { new Guid("355a4e39-442c-4a4f-ab65-50414ea971fe"), "Musical" },
                    { new Guid("90d25f73-b702-46a1-8490-af10a4b54c65"), "Comedia" },
                    { new Guid("84eeee98-c73d-4883-9c63-79f824b0ae65"), "Drama" },
                    { new Guid("5e3564c2-4435-4e82-a7a4-5736c62d57a5"), "Tragicomedia" },
                    { new Guid("2f63347a-9aa5-4f41-909e-5ac15e434c4a"), "Erótico" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_clubMemberGenres_ClubMembers_ClubMemberId",
                table: "clubMemberGenres",
                column: "ClubMemberId",
                principalTable: "ClubMembers",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clubMemberGenres_Genres_GenreId",
                table: "clubMemberGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
