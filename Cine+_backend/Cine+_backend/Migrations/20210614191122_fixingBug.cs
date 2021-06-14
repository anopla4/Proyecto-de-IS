using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class fixingBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("fae7cdce-365f-4dbe-8670-4a3ef202b8ae"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("5e76a5e4-2b44-4642-8545-e5e0fa5acd48") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("eee0a661-86ee-4375-a488-7274433897cc") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("65a936aa-9ce1-4c83-a328-355406017839"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("6da3e38a-a5ee-4af9-8d32-9733e8097ddf"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("7b34ae4b-e62f-4fcb-a9ed-a85063ac1189"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("f670e960-cfc1-45da-9483-a882d24b8256"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3a349cf2-4957-44b3-b0cf-4ddd982a6157"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3da69ea0-63d1-43dd-b21c-66913c1f0888"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3fc8ef17-5cb2-4a23-96ea-0dbe48eab391"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5f20c8b2-c09e-4ece-9a7b-add2d74079de"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9dbf95da-76f2-4f03-8d1f-d665f25894fe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bf16b858-84c9-434b-b4ce-05b1f905266d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c385fe14-bdbb-4f27-b8a9-db78636143ee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c495322f-d153-4d8d-8fdc-e7c61d036226"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e813597c-5b2a-4fcc-8ce5-0f3b8df02d8d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f9021ba7-04a3-4fd1-b264-d47e38b7d6a4"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("00432ef2-088e-43a2-8baf-b186bfd84b7f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("00b9c31e-473f-4c6c-957a-84b2fa181b69"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("0133e8e7-decd-4b4b-a148-ece9dc780b47"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("026743b0-bbf1-44b2-9902-7749f1f1cd3f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("03143780-1c95-4d64-bf14-a6dd507c0edf"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("035e3b7d-5bae-4f2e-b3ed-d11b54a95427"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0605f8a2-1f67-4b50-bcc5-d02da74a6ea8"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("06315f81-28cd-4b63-8936-7c358fb79b01"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("08c8683d-d0dd-4997-83c6-92784edab4f1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("09b5cce1-938a-4f20-8c67-c4042ef47f10"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0b779e47-bff3-45b4-9a65-11cea0fdad6f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0bb44680-72ae-4c4f-b42a-ac327806ef0f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0bf3518b-1b81-403e-9988-5cbe4effa4c3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("0dbd79b8-90bf-4bc8-a89b-8d9fcb247ad5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0e0557c5-63e9-4f7d-a196-4898dd15561d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1059fdd7-6fe4-4545-bcb2-8399b86cfb79"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("10672adf-5d7e-45d0-969c-2957d26d91c9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("150a96d3-a322-4a20-88dc-7a2ba8009f35"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("160317a3-80e0-49c8-a188-8cf893855463"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1713aae2-63cb-4fce-bc11-f0f2956c4cce"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1733e0c0-21ca-4b75-a90c-a94cf580ece4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("17fd0d2f-452e-40c3-bbce-18cb0dfef214"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("181dcb03-4eac-4253-8615-111d1155c1ca"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("182d85a6-8797-4243-920c-07f3786f5c2d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1871dbcb-b2bb-437f-991c-0a0b2148bc46"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("193bae54-71ba-4010-a5b6-8f81ae753b3b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("19406d11-30ec-4881-afb0-a09491cb4333"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1b5fb473-8195-4412-a4af-186899e70876"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1e40e6c3-b015-4a7b-99dd-498a64db1f5b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1e721155-7dba-49e3-a6f4-b3b99eff44b7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1f6bd54b-c227-414d-90a4-2923eaa56f12"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1f8a5589-4e4f-43b0-9289-1bcca848505a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2054bd72-67b1-4578-bc09-0374c144711a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("233bff50-9ba2-4bdc-ab7c-0a2677d60019"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("23a0649d-f363-4fe5-9261-3bf2c23ee4fd"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("23cf0c91-d52e-4dc6-94c6-acd45a2e0953"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("24101bd1-2a53-4a72-96fc-41280e6b512d"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("244ff7d9-5b58-4c15-8c46-fa67666297b1"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2559cfbe-f89a-4b84-bd9a-2a8de3bde292"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("269a23eb-4792-468e-aafd-ed605ab1edb9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("27613d9e-a87d-4858-8452-722d3ce0ff5c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2868e558-fd55-48b7-8719-b51842fa37cc"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("28cf4d2c-8f47-49ac-921f-667cb7cb604b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2c284d80-3342-4f30-9887-d5142753ac84"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("2c83dbd3-2fe5-4bd9-bc12-94689cac1ae4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2cf58beb-b675-449b-997e-cbc32bea9d88"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2d436f74-8db0-49c7-aa33-2d8e08c1f094"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("2e95a812-f5bf-4873-9ba1-a027b2ffdce0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("30e87983-e9be-4b8a-b1e0-75a89f2ad7aa"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("34349ba1-953f-41bb-ad41-2b2fe2b715a1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("34722c4d-3ca0-4e82-aafb-ea9df94c3b77"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("355069ba-2fb4-47fd-9ec4-2a4d231a5f85"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3616171c-65ae-41b3-bd24-29d03a250de4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("369121fa-31a6-4960-b321-2c9950b21bae"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("370cd6a7-967b-430e-af37-b6bb1f91a894"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("37691600-2f8d-45c3-9a0a-6b740242d923"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("37a092ee-e5f4-4cc9-9cd6-11211119dfc1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("388e143b-e5b6-469c-bd55-e7d2a1ba4589"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("389519cb-5bab-4b96-bced-7699dde87e0c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("38b027d9-2bd7-4b5a-bfdb-ae2bfa1bcb68"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3aeed818-b994-4aba-bab7-edd0ce9d907a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3c0dd811-7d45-4b42-bf63-a9233b1a7982"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3cee8ac5-10e5-40f8-bba9-db62692741c0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3d8f50a5-c34f-4ca1-a6b5-e2305e8d2f3b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3dafb1c0-df8e-403f-b441-658449f87e3e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3fbd66e3-ef43-4174-ae5f-213639c18972"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("40e323d0-ff33-492e-b6e9-f52b58efc79a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("416f0e4d-4ffa-43c1-af54-d16f744d217d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4415688f-d35b-46e5-bad5-34f657a9ffdf"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("442391a4-62fb-429a-8f51-70834c7b8503"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("443dc906-743a-468c-b437-4c9ef7b5e979"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("480dc732-7cbc-40f5-a55a-c7c9b82676d4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("48b33000-4d25-466f-8ed2-4be2c698e808"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4bb84527-6244-487f-ae53-dcc8f2eb9ab1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4bcb44e0-650f-4308-8162-fead4e3454e4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4cc7ae11-3487-487b-a6f3-dbc956a854a3"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4cfb293c-dbd4-4639-a7a7-940d8a951ca4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4d7341f4-4571-46b7-8ac7-6b67d140af21"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4df50643-ede0-4354-9aa1-2c61c827588f"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4e874e00-ffa3-41c2-877e-4eca7ae8b218"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4ea6b390-45a7-4053-8ec2-45126c5c35df"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4f7bdc31-4ff0-4681-b006-f63517ad37b5"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4fcbf7a1-ae8f-4c38-8f71-330ef9b20bc7"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("53ab115c-4459-44a2-b0c0-bd84fc9e9e38"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("551cb569-3e50-45f5-857b-bd278c3243d5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("575d6a4a-900a-489e-bb55-b1a3f708bbc0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("58307a0f-ec77-4a5c-ad81-8a221a560390"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5a1ead09-6a16-478b-bc31-64dacd0b04b4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5a8362b8-2961-4dc3-93d9-b73f9760a550"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5bb35ab7-741d-45e1-bc11-9e04fc97e81b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5dd2b23e-f5df-4824-8d29-35cd8971051f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5dfc5b03-2e0a-462d-8db7-a1417554eb62"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5e0b67eb-b276-4339-b6da-221224d165b8"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5eb19684-9cc6-4357-9ae8-adede88f6be7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("60a79ecd-e961-4397-80b7-50e104796d2c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6158a7b7-405c-4541-a60e-c697cbc00e40"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("61868607-e76b-41e3-bdd5-f2083e7ebd1b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6352a14e-818b-4879-bd6d-5e4ac0761402"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("63d27235-79e8-473c-8023-7ee264bad0e4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("64294ee6-6915-470d-936e-a3256da9ab32"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("643511ee-d36a-47bc-9d54-b619f9125171"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("64927317-9cee-4fb4-adbc-ce7c9a5eb09a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("65754412-17f8-46f9-b52a-1fe292ae66b2"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("65e5c79a-5f8c-4828-bb15-73abc66e39a5"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("667415fe-1b80-4beb-93e2-84013a35b888"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("69b364a6-6227-438e-b40d-31b610795f6a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6b3fbbd9-00e7-40d1-a9e1-c92c16dbd5d6"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c365ffc-9e77-49a3-a62a-91dc63991b13"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6c429853-32b4-4644-a544-b4cb886d4b0a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c5e6340-4da8-49af-8920-a67f16ee9081"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c71e427-86fb-4af6-bb5c-d9ebfa040797"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6d3db07f-4d56-4f05-ac1a-0bee9f6a88fd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6d8cbc67-721b-45e9-aed2-d08708a0e6e4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6efb5a9f-0cad-4d6a-a989-a7326ae81e34"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6f73f930-baf0-4e19-ae18-3fe30e92c050"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6faa88f9-e28b-452d-a1b6-7cae2275b1b4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6fbab38f-223d-4bc5-9010-a7e272bdb73c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("70f57103-9f9f-44c4-947d-1fe8c48282ee"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("71dc5e36-8ede-4d7f-b10c-ab4b3e7e74e2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("720371ae-ed2f-4b7c-9bef-a0af75a2b795"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("721502e5-49ff-4be2-9e97-145f656c647b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("721b55fc-2659-413b-a330-0134fecbd996"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7296d736-9182-4c87-aa38-527c26a30adf"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("73917595-af22-42c9-a781-509efa65fd1b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7469d933-78b8-4aa3-a0eb-274c4ab30295"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7646058b-4555-401a-bf5b-2db32d222b56"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7729e4b5-da1b-4e38-92fe-d51356cbdbb7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("77ef747f-c3c9-4e53-82ef-04098c26d07e"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("785b03ae-06e6-47c3-94f6-e250309cb04e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("78dd8376-a0e6-43d2-bcb5-c21574f3f5f2"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7a449214-90d2-4d76-b504-745491be7686"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7b88df97-e1e6-4c80-9194-deba186ac065"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7c122bf2-8edc-4526-aead-0eefb1ea28ea"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7c25c2a0-5e37-4ca0-9eeb-8fe3eb516afd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7cff8c31-e22e-4698-941f-5e34729ebe63"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7db80942-d91d-4502-9641-e3d0fdeba707"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7f5b9f88-2b39-406a-94fb-1512ef84025a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7f954ec2-39d9-43e8-8fe6-4f11572471ac"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7fad7ccb-594a-45ba-b8d1-febe9bc9891c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("800094f9-b7a9-4f7e-8338-484908174ff9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("80046ef2-ded1-43ea-a6bd-3a59b7c848ac"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("816a3b9b-8ccc-42dd-b444-eda0dae736c8"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8237cc30-c12f-4188-8ef2-5c9c60afe9b3"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8403b7fb-cc20-44eb-af2b-253181ba149d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("844a53f1-af9f-48b4-aa82-45192d7d0c46"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("85fc36b9-acc8-4ffe-9e97-bd7598b80c95"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8670da08-cb23-44e2-98de-fd9fa39972e6"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8828fb88-50f3-49f9-af47-4073a5ee0de0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8a4c0c92-d0c8-4644-a595-affc1b5b26aa"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8c2e7174-6c1e-4742-a443-e975b1392ed1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8c52baf4-b5c3-45c0-b017-57efe31ca1dc"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8e629068-722c-41bb-9534-816235f1e78c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8ec7a52d-2504-4b36-bb34-cb2161874b1c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("91889ae0-0cfb-40af-a66d-db920d53106d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("91921245-9c34-449b-a66f-ee2e6e9df209"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9281c7fa-b385-4c03-a90b-6b07aac2a3b2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9394fac9-a801-4cc9-84b4-d24caac3bc68"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9433e939-ee17-4586-a5cd-88f38246606c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("94919cf9-f4c9-4bac-a367-2e7a489d2485"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("97c8c104-b7f6-4786-ab22-4d8ea7ba55b1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("97e7bd21-c58b-4b6c-a072-374d8548d28d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9907c0c7-165d-4f8a-a6b3-c47fa69b3023"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("99ebafb6-61ec-4a22-881a-cc1191339d5a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9b6db61b-a98c-4f77-bb0d-a86b7589751c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9ce12b09-bb74-4000-a566-f09547c88a73"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9df37d62-7bb7-43e8-9fc2-98ec06d0d1ff"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9e157974-cc7b-4c39-b528-2c7c94d0430d"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9e20262a-31f4-4a43-8e4a-d304a3c53db1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a07febfe-b80b-49e7-a36d-e45f18c78ed0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a0b194a5-e8e6-4d96-97f3-cba0d918f09b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a128f2d2-a218-4a14-ac68-692b1d387106"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a2ec14d2-7b6a-40d0-97c7-4db1cdf810e6"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a3760256-d899-40bb-8581-a4a3ae30189c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a41e3f2b-0b45-4a6c-8cc6-145679c6a983"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a46b06e0-b27c-46e5-b46c-277ef8fb1322"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a5c871f8-99d5-42aa-8067-2fb7c8f1a1d6"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a5cb3161-11dd-4e6c-b2c3-1ef368e182fc"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a7c6b4ec-6616-4cca-8c33-72b50145ffc0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a877204c-5b6f-4d60-9820-60b43adb34c0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a895efc0-7d65-434c-b89a-a5dafa041190"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a8de2e4d-21f1-43fc-9257-779eca04133a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ab2298f8-0f1f-478b-aabf-84fe9f8dd351"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ab44ca2f-1e6d-4ee1-a76b-6fd3158fb69d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("abf866af-ad40-4785-99c4-89d85408054a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("aee3b5df-1e8c-452e-9022-d0b177c0fb68"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("af5c55e9-1ba5-48a5-bf30-251edf20ad01"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("afdce0a2-026c-4035-87ef-2392a4e27ad9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b0279fbb-a07c-4bcb-8d48-a7581bf8f38f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b142e0f6-c483-4b6b-89f5-4d746ca8464d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b19cc3c8-4114-43fa-95b9-c098b3c68543"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b1a73ebc-fc7f-428a-9b02-1c59005bc4f9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b23b35f1-9a07-4393-9a6b-2595303b2e9e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b2aa3b9c-c531-4489-b0c7-81529d07b17b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b368360f-7dc8-4f84-903d-a997efbef40f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b377cb28-c123-4c8c-95c1-d90683967df3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b50c4687-e455-4b84-9573-9d38defc6c30"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b5c68b7f-fc6c-40d8-96cd-0d0328693a3c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b79ef6de-4756-4a18-ac09-174269fae8da"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b8da3d92-84c4-41a0-a02e-64e5aba0e729"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ba247d83-c39c-4428-aaac-2afb623e775e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bac54cab-4cb7-48e5-8edb-66c1acb62a10"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bd281f00-3a81-4fc8-be80-c928b2eb8a7b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bd4c56eb-1116-4454-aed5-07e47e73eb59"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("bdb1b465-e7c3-42b8-81f0-a3e310a65197"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bf94fbaa-f3c9-423b-b866-3b4d84da6087"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bfce8105-3ba7-4db9-839c-01ce47a57e59"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c1f6ea87-2b23-460e-91ae-3e7e88eab785"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c2ab188c-07f6-4a8f-9150-036c632c005c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c3d03cea-5f2e-42aa-9f8d-5519c7b94ad0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c4cbce54-9219-45e0-9d76-618778d7d291"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c7d660f8-f331-41d5-8ed5-90769fa09553"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c98b80e6-9df1-4509-a74f-1e1611cf48bd"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c9abfcf4-331e-44d1-867c-72785440386f"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("caeab8c2-c328-4a65-93cf-f46fc7bd3cd5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("cba0188f-a52e-43f5-bb8d-e4e7d52e7acb"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cbe1816d-a2d0-4677-b1ad-b2d117091aaf"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cc6914d2-4cfd-467c-a911-33c716d1b6b2"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ccc7c81f-0228-4d0f-89f7-f1202a41e172"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cf1b0046-7f40-42d1-b5c8-193dd97505b1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d138c33d-1571-46b2-a8ec-12a3fa3836d3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d151d233-5dcb-4e8d-ab9e-efed54ad994b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1a04c09-13bd-4cf2-862b-00f9eb37b4fb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1d15c68-6785-4b96-812a-009690d505b0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1daaf9d-8f6c-4350-9b31-821d0369288a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d250f083-d2d3-4658-832e-fe616ea143ea"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d2f0bf3e-34ec-4ce1-b9bd-24f0365e2760"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d36022af-3f82-4369-8c68-da77339369b8"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d4e01fb4-ac66-4f68-a28b-72c4b66d2b3f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d52263f5-ce69-4cc4-bf0b-d47566461a97"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d825af1e-9fd5-4c20-90b6-4da954df94e7"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d84bca31-bb8a-4920-9f29-843f7e768ef0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d862a774-8fed-4788-a468-04ba89d39103"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d9190a4e-489a-4ad7-9187-bd5d44cc49ad"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("daf97bd7-e20f-4396-b0f1-b26f18fc0d20"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("db4cd2c4-d3b1-4422-8190-f4788cc60e6c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("dc47df41-9d47-4696-8787-9c7e4713aa3e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("dec0a4c2-5609-41d6-a2e2-f80a27afc3a0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e0b3bfdc-a678-499d-a8bd-739da9f7948e"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e0c266a5-6850-4e6e-b7ca-c6ed43c81794"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e1f29c5c-08c2-4273-b981-d6249cd3d460"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e26a29ea-b77b-4d7f-bdee-c42a9e235af2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e6368075-91a2-4c31-ab5f-9579bad574bb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e6a2f8b9-e36f-40b1-80c8-970ed5f7caed"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e9941d54-e792-47ee-b2a8-11b124762b7c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e9d4fe2d-eb65-4181-9343-265474af7df0"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("eb6641ed-9220-4129-9f4a-0b3499b8759f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ed8c0e8f-d956-4ffa-a9b7-e18030113f14"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("edbe4a72-21c6-4886-997d-c1af8cc55b4b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("edd279be-70d7-4489-93e6-128044438138"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ee808d18-5f9a-4d84-a6a8-fe2ce47bfce0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("eea054dc-c6b9-4620-a762-7cadfd196f17"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ef3be4d6-d570-4eeb-b1b7-120bfcd3f000"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("efb20c2d-2c40-4a1b-a49d-49502bae1c14"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f0e780b5-95b7-4b2d-9f28-74c694ae865b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f0fffe19-e1b7-49d7-9266-fd52d985f145"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f193b70c-a067-4c4d-ac65-92557ee0ca7e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f1c17a1f-ef48-47fd-9905-4fbbd7b91667"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f1c3a15e-e945-46b2-aaaa-6b0c6cda6c0a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f4b25cb6-abec-4ca2-9560-94044a0c2875"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f67046a1-c288-4f8a-af24-11cdcf1c09be"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f6a41e30-380d-4183-b172-b6bb18be1ffd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("facd1e00-3333-4153-9f68-2c15aeb238bb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fb26fbc3-7e6e-4143-8f61-941e0942e55a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fb6358a6-fb27-4a35-96e8-1bb2a3ed8a7c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("fdd5aa0a-b920-4e61-b0a2-5af241d6eadf"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fed88963-2989-4d35-93c1-eaf390740ed5"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("fae7cdce-365f-4dbe-8670-4a3ef202b8ae"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5e76a5e4-2b44-4642-8545-e5e0fa5acd48"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eee0a661-86ee-4375-a488-7274433897cc"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a45da717-ff84-4e52-965f-551808807281"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00432ef2-088e-43a2-8baf-b186bfd84b7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00b9c31e-473f-4c6c-957a-84b2fa181b69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0133e8e7-decd-4b4b-a148-ece9dc780b47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("026743b0-bbf1-44b2-9902-7749f1f1cd3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03143780-1c95-4d64-bf14-a6dd507c0edf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("035e3b7d-5bae-4f2e-b3ed-d11b54a95427"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0605f8a2-1f67-4b50-bcc5-d02da74a6ea8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06315f81-28cd-4b63-8936-7c358fb79b01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08c8683d-d0dd-4997-83c6-92784edab4f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09b5cce1-938a-4f20-8c67-c4042ef47f10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b779e47-bff3-45b4-9a65-11cea0fdad6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bb44680-72ae-4c4f-b42a-ac327806ef0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bf3518b-1b81-403e-9988-5cbe4effa4c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0dbd79b8-90bf-4bc8-a89b-8d9fcb247ad5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e0557c5-63e9-4f7d-a196-4898dd15561d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1059fdd7-6fe4-4545-bcb2-8399b86cfb79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10672adf-5d7e-45d0-969c-2957d26d91c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("150a96d3-a322-4a20-88dc-7a2ba8009f35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("160317a3-80e0-49c8-a188-8cf893855463"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1713aae2-63cb-4fce-bc11-f0f2956c4cce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1733e0c0-21ca-4b75-a90c-a94cf580ece4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17fd0d2f-452e-40c3-bbce-18cb0dfef214"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("181dcb03-4eac-4253-8615-111d1155c1ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("182d85a6-8797-4243-920c-07f3786f5c2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1871dbcb-b2bb-437f-991c-0a0b2148bc46"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("193bae54-71ba-4010-a5b6-8f81ae753b3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19406d11-30ec-4881-afb0-a09491cb4333"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b5fb473-8195-4412-a4af-186899e70876"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e40e6c3-b015-4a7b-99dd-498a64db1f5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e721155-7dba-49e3-a6f4-b3b99eff44b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f6bd54b-c227-414d-90a4-2923eaa56f12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f8a5589-4e4f-43b0-9289-1bcca848505a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2054bd72-67b1-4578-bc09-0374c144711a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("233bff50-9ba2-4bdc-ab7c-0a2677d60019"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23a0649d-f363-4fe5-9261-3bf2c23ee4fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23cf0c91-d52e-4dc6-94c6-acd45a2e0953"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24101bd1-2a53-4a72-96fc-41280e6b512d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("244ff7d9-5b58-4c15-8c46-fa67666297b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2559cfbe-f89a-4b84-bd9a-2a8de3bde292"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("269a23eb-4792-468e-aafd-ed605ab1edb9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27613d9e-a87d-4858-8452-722d3ce0ff5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2868e558-fd55-48b7-8719-b51842fa37cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28cf4d2c-8f47-49ac-921f-667cb7cb604b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c284d80-3342-4f30-9887-d5142753ac84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c83dbd3-2fe5-4bd9-bc12-94689cac1ae4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cf58beb-b675-449b-997e-cbc32bea9d88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d436f74-8db0-49c7-aa33-2d8e08c1f094"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e95a812-f5bf-4873-9ba1-a027b2ffdce0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30e87983-e9be-4b8a-b1e0-75a89f2ad7aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34349ba1-953f-41bb-ad41-2b2fe2b715a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34722c4d-3ca0-4e82-aafb-ea9df94c3b77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("355069ba-2fb4-47fd-9ec4-2a4d231a5f85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3616171c-65ae-41b3-bd24-29d03a250de4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("369121fa-31a6-4960-b321-2c9950b21bae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("370cd6a7-967b-430e-af37-b6bb1f91a894"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37691600-2f8d-45c3-9a0a-6b740242d923"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37a092ee-e5f4-4cc9-9cd6-11211119dfc1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("388e143b-e5b6-469c-bd55-e7d2a1ba4589"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("389519cb-5bab-4b96-bced-7699dde87e0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38b027d9-2bd7-4b5a-bfdb-ae2bfa1bcb68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aeed818-b994-4aba-bab7-edd0ce9d907a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c0dd811-7d45-4b42-bf63-a9233b1a7982"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cee8ac5-10e5-40f8-bba9-db62692741c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d8f50a5-c34f-4ca1-a6b5-e2305e8d2f3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3dafb1c0-df8e-403f-b441-658449f87e3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fbd66e3-ef43-4174-ae5f-213639c18972"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40e323d0-ff33-492e-b6e9-f52b58efc79a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("416f0e4d-4ffa-43c1-af54-d16f744d217d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4415688f-d35b-46e5-bad5-34f657a9ffdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("442391a4-62fb-429a-8f51-70834c7b8503"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("443dc906-743a-468c-b437-4c9ef7b5e979"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("480dc732-7cbc-40f5-a55a-c7c9b82676d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48b33000-4d25-466f-8ed2-4be2c698e808"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bb84527-6244-487f-ae53-dcc8f2eb9ab1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bcb44e0-650f-4308-8162-fead4e3454e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cc7ae11-3487-487b-a6f3-dbc956a854a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cfb293c-dbd4-4639-a7a7-940d8a951ca4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d7341f4-4571-46b7-8ac7-6b67d140af21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4df50643-ede0-4354-9aa1-2c61c827588f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e874e00-ffa3-41c2-877e-4eca7ae8b218"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ea6b390-45a7-4053-8ec2-45126c5c35df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f7bdc31-4ff0-4681-b006-f63517ad37b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fcbf7a1-ae8f-4c38-8f71-330ef9b20bc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53ab115c-4459-44a2-b0c0-bd84fc9e9e38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("551cb569-3e50-45f5-857b-bd278c3243d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("575d6a4a-900a-489e-bb55-b1a3f708bbc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58307a0f-ec77-4a5c-ad81-8a221a560390"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a1ead09-6a16-478b-bc31-64dacd0b04b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a8362b8-2961-4dc3-93d9-b73f9760a550"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bb35ab7-741d-45e1-bc11-9e04fc97e81b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5dd2b23e-f5df-4824-8d29-35cd8971051f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5dfc5b03-2e0a-462d-8db7-a1417554eb62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e0b67eb-b276-4339-b6da-221224d165b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5eb19684-9cc6-4357-9ae8-adede88f6be7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60a79ecd-e961-4397-80b7-50e104796d2c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6158a7b7-405c-4541-a60e-c697cbc00e40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61868607-e76b-41e3-bdd5-f2083e7ebd1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6352a14e-818b-4879-bd6d-5e4ac0761402"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63d27235-79e8-473c-8023-7ee264bad0e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64294ee6-6915-470d-936e-a3256da9ab32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("643511ee-d36a-47bc-9d54-b619f9125171"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64927317-9cee-4fb4-adbc-ce7c9a5eb09a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65754412-17f8-46f9-b52a-1fe292ae66b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65e5c79a-5f8c-4828-bb15-73abc66e39a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("667415fe-1b80-4beb-93e2-84013a35b888"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69b364a6-6227-438e-b40d-31b610795f6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b3fbbd9-00e7-40d1-a9e1-c92c16dbd5d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c365ffc-9e77-49a3-a62a-91dc63991b13"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c429853-32b4-4644-a544-b4cb886d4b0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c5e6340-4da8-49af-8920-a67f16ee9081"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c71e427-86fb-4af6-bb5c-d9ebfa040797"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d3db07f-4d56-4f05-ac1a-0bee9f6a88fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d8cbc67-721b-45e9-aed2-d08708a0e6e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6efb5a9f-0cad-4d6a-a989-a7326ae81e34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f73f930-baf0-4e19-ae18-3fe30e92c050"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6faa88f9-e28b-452d-a1b6-7cae2275b1b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fbab38f-223d-4bc5-9010-a7e272bdb73c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70f57103-9f9f-44c4-947d-1fe8c48282ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71dc5e36-8ede-4d7f-b10c-ab4b3e7e74e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("720371ae-ed2f-4b7c-9bef-a0af75a2b795"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("721502e5-49ff-4be2-9e97-145f656c647b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("721b55fc-2659-413b-a330-0134fecbd996"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7296d736-9182-4c87-aa38-527c26a30adf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73917595-af22-42c9-a781-509efa65fd1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7469d933-78b8-4aa3-a0eb-274c4ab30295"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7646058b-4555-401a-bf5b-2db32d222b56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7729e4b5-da1b-4e38-92fe-d51356cbdbb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77ef747f-c3c9-4e53-82ef-04098c26d07e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("785b03ae-06e6-47c3-94f6-e250309cb04e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78dd8376-a0e6-43d2-bcb5-c21574f3f5f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a449214-90d2-4d76-b504-745491be7686"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b88df97-e1e6-4c80-9194-deba186ac065"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c122bf2-8edc-4526-aead-0eefb1ea28ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c25c2a0-5e37-4ca0-9eeb-8fe3eb516afd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7cff8c31-e22e-4698-941f-5e34729ebe63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7db80942-d91d-4502-9641-e3d0fdeba707"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f5b9f88-2b39-406a-94fb-1512ef84025a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f954ec2-39d9-43e8-8fe6-4f11572471ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fad7ccb-594a-45ba-b8d1-febe9bc9891c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("800094f9-b7a9-4f7e-8338-484908174ff9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80046ef2-ded1-43ea-a6bd-3a59b7c848ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("816a3b9b-8ccc-42dd-b444-eda0dae736c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8237cc30-c12f-4188-8ef2-5c9c60afe9b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8403b7fb-cc20-44eb-af2b-253181ba149d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("844a53f1-af9f-48b4-aa82-45192d7d0c46"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85fc36b9-acc8-4ffe-9e97-bd7598b80c95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8670da08-cb23-44e2-98de-fd9fa39972e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8828fb88-50f3-49f9-af47-4073a5ee0de0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a4c0c92-d0c8-4644-a595-affc1b5b26aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c2e7174-6c1e-4742-a443-e975b1392ed1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c52baf4-b5c3-45c0-b017-57efe31ca1dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e629068-722c-41bb-9534-816235f1e78c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ec7a52d-2504-4b36-bb34-cb2161874b1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91889ae0-0cfb-40af-a66d-db920d53106d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91921245-9c34-449b-a66f-ee2e6e9df209"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9281c7fa-b385-4c03-a90b-6b07aac2a3b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9394fac9-a801-4cc9-84b4-d24caac3bc68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9433e939-ee17-4586-a5cd-88f38246606c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94919cf9-f4c9-4bac-a367-2e7a489d2485"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97c8c104-b7f6-4786-ab22-4d8ea7ba55b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97e7bd21-c58b-4b6c-a072-374d8548d28d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9907c0c7-165d-4f8a-a6b3-c47fa69b3023"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99ebafb6-61ec-4a22-881a-cc1191339d5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b6db61b-a98c-4f77-bb0d-a86b7589751c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ce12b09-bb74-4000-a566-f09547c88a73"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9df37d62-7bb7-43e8-9fc2-98ec06d0d1ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e157974-cc7b-4c39-b528-2c7c94d0430d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e20262a-31f4-4a43-8e4a-d304a3c53db1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a07febfe-b80b-49e7-a36d-e45f18c78ed0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0b194a5-e8e6-4d96-97f3-cba0d918f09b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a128f2d2-a218-4a14-ac68-692b1d387106"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2ec14d2-7b6a-40d0-97c7-4db1cdf810e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3760256-d899-40bb-8581-a4a3ae30189c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a41e3f2b-0b45-4a6c-8cc6-145679c6a983"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a46b06e0-b27c-46e5-b46c-277ef8fb1322"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5c871f8-99d5-42aa-8067-2fb7c8f1a1d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5cb3161-11dd-4e6c-b2c3-1ef368e182fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7c6b4ec-6616-4cca-8c33-72b50145ffc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a877204c-5b6f-4d60-9820-60b43adb34c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a895efc0-7d65-434c-b89a-a5dafa041190"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8de2e4d-21f1-43fc-9257-779eca04133a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab2298f8-0f1f-478b-aabf-84fe9f8dd351"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab44ca2f-1e6d-4ee1-a76b-6fd3158fb69d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abf866af-ad40-4785-99c4-89d85408054a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aee3b5df-1e8c-452e-9022-d0b177c0fb68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af5c55e9-1ba5-48a5-bf30-251edf20ad01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afdce0a2-026c-4035-87ef-2392a4e27ad9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0279fbb-a07c-4bcb-8d48-a7581bf8f38f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b142e0f6-c483-4b6b-89f5-4d746ca8464d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b19cc3c8-4114-43fa-95b9-c098b3c68543"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1a73ebc-fc7f-428a-9b02-1c59005bc4f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b23b35f1-9a07-4393-9a6b-2595303b2e9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2aa3b9c-c531-4489-b0c7-81529d07b17b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b368360f-7dc8-4f84-903d-a997efbef40f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b377cb28-c123-4c8c-95c1-d90683967df3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b50c4687-e455-4b84-9573-9d38defc6c30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5c68b7f-fc6c-40d8-96cd-0d0328693a3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b79ef6de-4756-4a18-ac09-174269fae8da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8da3d92-84c4-41a0-a02e-64e5aba0e729"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba247d83-c39c-4428-aaac-2afb623e775e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bac54cab-4cb7-48e5-8edb-66c1acb62a10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd281f00-3a81-4fc8-be80-c928b2eb8a7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd4c56eb-1116-4454-aed5-07e47e73eb59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdb1b465-e7c3-42b8-81f0-a3e310a65197"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf94fbaa-f3c9-423b-b866-3b4d84da6087"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfce8105-3ba7-4db9-839c-01ce47a57e59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1f6ea87-2b23-460e-91ae-3e7e88eab785"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2ab188c-07f6-4a8f-9150-036c632c005c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3d03cea-5f2e-42aa-9f8d-5519c7b94ad0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4cbce54-9219-45e0-9d76-618778d7d291"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7d660f8-f331-41d5-8ed5-90769fa09553"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c98b80e6-9df1-4509-a74f-1e1611cf48bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9abfcf4-331e-44d1-867c-72785440386f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caeab8c2-c328-4a65-93cf-f46fc7bd3cd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cba0188f-a52e-43f5-bb8d-e4e7d52e7acb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbe1816d-a2d0-4677-b1ad-b2d117091aaf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc6914d2-4cfd-467c-a911-33c716d1b6b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccc7c81f-0228-4d0f-89f7-f1202a41e172"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf1b0046-7f40-42d1-b5c8-193dd97505b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d138c33d-1571-46b2-a8ec-12a3fa3836d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d151d233-5dcb-4e8d-ab9e-efed54ad994b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1a04c09-13bd-4cf2-862b-00f9eb37b4fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1d15c68-6785-4b96-812a-009690d505b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1daaf9d-8f6c-4350-9b31-821d0369288a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d250f083-d2d3-4658-832e-fe616ea143ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2f0bf3e-34ec-4ce1-b9bd-24f0365e2760"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d36022af-3f82-4369-8c68-da77339369b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4e01fb4-ac66-4f68-a28b-72c4b66d2b3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d52263f5-ce69-4cc4-bf0b-d47566461a97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d825af1e-9fd5-4c20-90b6-4da954df94e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d84bca31-bb8a-4920-9f29-843f7e768ef0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d862a774-8fed-4788-a468-04ba89d39103"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9190a4e-489a-4ad7-9187-bd5d44cc49ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("daf97bd7-e20f-4396-b0f1-b26f18fc0d20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db4cd2c4-d3b1-4422-8190-f4788cc60e6c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc47df41-9d47-4696-8787-9c7e4713aa3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dec0a4c2-5609-41d6-a2e2-f80a27afc3a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0b3bfdc-a678-499d-a8bd-739da9f7948e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0c266a5-6850-4e6e-b7ca-c6ed43c81794"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1f29c5c-08c2-4273-b981-d6249cd3d460"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e26a29ea-b77b-4d7f-bdee-c42a9e235af2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6368075-91a2-4c31-ab5f-9579bad574bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6a2f8b9-e36f-40b1-80c8-970ed5f7caed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9941d54-e792-47ee-b2a8-11b124762b7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9d4fe2d-eb65-4181-9343-265474af7df0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb6641ed-9220-4129-9f4a-0b3499b8759f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed8c0e8f-d956-4ffa-a9b7-e18030113f14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("edbe4a72-21c6-4886-997d-c1af8cc55b4b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("edd279be-70d7-4489-93e6-128044438138"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee808d18-5f9a-4d84-a6a8-fe2ce47bfce0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eea054dc-c6b9-4620-a762-7cadfd196f17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef3be4d6-d570-4eeb-b1b7-120bfcd3f000"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efb20c2d-2c40-4a1b-a49d-49502bae1c14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0e780b5-95b7-4b2d-9f28-74c694ae865b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0fffe19-e1b7-49d7-9266-fd52d985f145"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f193b70c-a067-4c4d-ac65-92557ee0ca7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1c17a1f-ef48-47fd-9905-4fbbd7b91667"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1c3a15e-e945-46b2-aaaa-6b0c6cda6c0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4b25cb6-abec-4ca2-9560-94044a0c2875"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f67046a1-c288-4f8a-af24-11cdcf1c09be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6a41e30-380d-4183-b172-b6bb18be1ffd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("facd1e00-3333-4153-9f68-2c15aeb238bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb26fbc3-7e6e-4143-8f61-941e0942e55a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb6358a6-fb27-4a35-96e8-1bb2a3ed8a7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdd5aa0a-b920-4e61-b0a2-5af241d6eadf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fed88963-2989-4d35-93c1-eaf390740ed5"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d"));

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5ff257a9-65c2-4d96-ac5d-6861089c438f"), "Productor Ejecutivo" },
                    { new Guid("569d329d-6a2e-4608-ac0d-4084b15f2df3"), "Técnico de Sonido" },
                    { new Guid("8e5d23d0-469c-483d-a384-0823474367d5"), "Diseñador de Vestuario" },
                    { new Guid("f17136b5-3c89-4626-9a29-bdbdcb69330d"), "Guionista" },
                    { new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Actor" },
                    { new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Director" },
                    { new Guid("3147e6e4-0913-498e-af09-52845dfdecad"), "Productor" },
                    { new Guid("3188ed81-4623-4720-bb3f-14d5138b6483"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre", "1999" },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("15e06669-6cf8-4ff8-86d6-db623e1e5c34"), "Erótico" },
                    { new Guid("bccc34a8-b507-4102-90e5-90e22daec76f"), "Musical" },
                    { new Guid("77406b8c-43b6-425c-a6eb-9a80f075af1e"), "Aventura" },
                    { new Guid("ac0db189-841d-45b4-81e1-6e9300b5d305"), "Ficción" },
                    { new Guid("c06534ae-8269-4063-adbc-0321a3e98e64"), "Documental" },
                    { new Guid("88b3b367-0d97-44fa-a1fb-08f9a1c43378"), "Hístorico" },
                    { new Guid("14f57847-7536-44e2-be43-c7e791cefccd"), "Ciencia Ficción" },
                    { new Guid("b3d1e73b-f1e8-4e99-bf46-bb35762158e6"), "Terror" },
                    { new Guid("f853a386-dbb3-4e13-8e71-3ee0d0d676ca"), "Suspenso" },
                    { new Guid("1995c4d1-dc60-42a1-9821-39e21e65e00f"), "Romántica" },
                    { new Guid("22e11313-9901-46c7-acd9-d77a70c0394b"), "Comedia" },
                    { new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a"), "Drama" },
                    { new Guid("c2179c54-738a-4a33-b4a6-37cc791836ad"), "Tragicomedia" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), "Platea Baja", 10 },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), "Sala 1" },
                    { new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), "Sala 2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("65fa6437-2c13-48d6-ac40-d590e00be46a"), "C2" },
                    { new Guid("aeff94e8-ef3b-4a85-91f2-3349a45d1c88"), "C1" },
                    { new Guid("1cd07ac7-1712-4ae1-b8e7-cb38af6937a4"), "B3" },
                    { new Guid("e80d2669-511f-4f69-a16f-7bcea33fc249"), "B2" },
                    { new Guid("b352b12e-36aa-4b1a-9c5d-eb425348e6ca"), "B1" },
                    { new Guid("4ebb03ba-3303-41c7-aceb-c7bbba3918db"), "A3" },
                    { new Guid("e1ada6ce-8132-4769-8553-ff8d3e4b9084"), "G2" },
                    { new Guid("cd805de8-809c-4534-b9aa-819fa405ca5b"), "A1" },
                    { new Guid("dbdd260e-1ab6-44bf-9526-08f93d718f16"), "H2" },
                    { new Guid("2b38cf54-05da-4616-bdbf-b91ee27a036e"), "H1" },
                    { new Guid("d50c025f-9b43-4d82-b9f1-82780b778eb2"), "G1" },
                    { new Guid("8e730d04-d424-4bd5-b8e3-3e2a3daa2015"), "C3" },
                    { new Guid("2358c8b9-c3a7-4dfe-a391-1495327b5e95"), "A2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("ca441910-5da0-4535-9141-5bdd7830e57f"), "D1" },
                    { new Guid("9ef3dce8-20fe-4449-9da2-62354c0eb1a6"), "A1" },
                    { new Guid("546f072d-c1a2-4cda-abcf-588e3af8bbf5"), "D3" },
                    { new Guid("e9ef8d93-ca57-4326-9bff-b0af3424ede3"), "E1" },
                    { new Guid("99e7c724-209a-4f28-905f-844a2cfe45ef"), "E2" },
                    { new Guid("ea55ef1c-172f-431a-8125-0c88a978711f"), "E3" },
                    { new Guid("780bb2d4-01fe-4056-823d-5afd53ae3481"), "F1" },
                    { new Guid("32f389ee-d0c8-4078-bbcb-6da3b78d9aad"), "F2" },
                    { new Guid("c927254b-8e33-43a2-ac03-1d19bdc128da"), "F3" },
                    { new Guid("4c93f1b0-dbcd-4ad9-beae-ec2f47b354bf"), "G1" },
                    { new Guid("fad2c712-c744-4720-b0ac-8ad29b12be60"), "G2" },
                    { new Guid("514cafc8-bee8-4a03-a868-e40a1bb063db"), "G3" },
                    { new Guid("010063ba-f338-4cc0-b7f6-f47aeae66b28"), "H1" },
                    { new Guid("03f55550-d819-46a2-9c21-23c4470dde76"), "H2" },
                    { new Guid("c8d279bc-cd68-4186-b7a6-d8dcea1fbecf"), "H3" },
                    { new Guid("9ab3182a-bd85-44a6-a9fb-ab6376d820b7"), "F2" },
                    { new Guid("ce5525d0-2706-426f-b140-d7b7fd22358a"), "D2" },
                    { new Guid("70a6a4df-d7dc-4a34-8ba8-a5ee75a853d9"), "F1" },
                    { new Guid("24e14136-d63c-41a5-8ce1-b3a91578d458"), "G2" },
                    { new Guid("99238e0d-e33b-4848-ae57-bde04bfe43a0"), "E1" },
                    { new Guid("68bfa52e-687b-4d0f-aad9-b353492d6ec8"), "A3" },
                    { new Guid("221b1135-fd11-480e-9a8d-e587083d054f"), "B1" },
                    { new Guid("babf2c01-91dc-4935-a57d-b6f3880550d5"), "B2" },
                    { new Guid("3b94183d-78a2-4dcb-80fd-6949f6a92cc3"), "B3" },
                    { new Guid("efbfe94b-6e59-4690-8132-1a1088c459af"), "C1" },
                    { new Guid("249acb35-1062-4777-9c97-438cbb53c4fc"), "C2" },
                    { new Guid("5e18c728-564c-45b0-a56d-058f146032fe"), "C3" },
                    { new Guid("59344681-70b9-424f-9da8-dc02bb857aa6"), "D1" },
                    { new Guid("783b092d-731f-4291-82e0-960e6be33fd5"), "D2" },
                    { new Guid("02394b47-cacc-4f39-9b44-411a5583d6a7"), "D3" },
                    { new Guid("84763256-7150-46e9-b5b1-e6cb583e48cc"), "E1" },
                    { new Guid("05808884-423e-42d0-bb4c-9f4360a6ad90"), "E2" },
                    { new Guid("4fedb4d5-1de2-49cd-9901-642cf87bdb3d"), "E3" },
                    { new Guid("718e63a7-2f4f-4a33-a612-fb3b33af7559"), "F1" },
                    { new Guid("3bd881fd-2ed2-4b31-a442-0aca43890567"), "E2" },
                    { new Guid("e8bd007a-ecc0-4a0b-8279-187904beebcd"), "F2" },
                    { new Guid("6b9b9a34-9ff6-47ec-aa15-f1a8b5e55960"), "G1" },
                    { new Guid("ab6a7ce5-f139-4b6a-8266-d9e183b2c152"), "B1" },
                    { new Guid("65a284b6-7d54-4db3-8434-eb589d8e0a0b"), "G3" },
                    { new Guid("c5b5a70b-abc6-446f-8d9c-c44e7181a425"), "H1" },
                    { new Guid("264f52f0-da26-4d28-b175-40fcc1cf5020"), "H2" },
                    { new Guid("7f5bcf75-1fc7-436c-ac3b-5bc9890db3bf"), "H3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("502017f9-f1fb-41d0-891c-a182e880586f"), "A1" },
                    { new Guid("5c9b4032-8dec-4c60-942a-d2cdf48d69f0"), "A2" },
                    { new Guid("a7c5698b-e452-4092-92b8-47123d3aa849"), "B1" },
                    { new Guid("02babe69-e5bb-494c-893d-0ecfdc41e0d0"), "B2" },
                    { new Guid("62837e09-b5d2-473c-9c17-30632547bda1"), "C1" },
                    { new Guid("05f9a8f5-5a9e-41e5-b24d-3a901fdd704d"), "C2" },
                    { new Guid("1d8e15c5-a3c7-4c4b-a0ce-7b48dbcdd352"), "D1" },
                    { new Guid("be2dd774-7704-4e9c-a3bf-291420c07809"), "D2" },
                    { new Guid("7be03017-81c9-4250-adea-08a87d7ac073"), "F3" },
                    { new Guid("f012c342-75f6-4698-9cd9-ff1a4615dc05"), "B2" },
                    { new Guid("4aba4bcd-bc04-46ad-88f1-443a3d0c7127"), "F3" },
                    { new Guid("9190e247-9d8d-498e-b9f4-6889b69aee57"), "C2" },
                    { new Guid("6b22a652-0a5d-4330-8ac9-d2a18c07ea0c"), "D1" },
                    { new Guid("b5d35a90-37b5-40dc-97f5-f65a79314bcc"), "D2" },
                    { new Guid("3a26569d-591b-49aa-aa62-c60623db1d1c"), "D3" },
                    { new Guid("c566cb76-a78d-423c-8a05-89a3b8904d9f"), "D4" },
                    { new Guid("dc9bb667-9825-4039-9618-b63b5b8bd17a"), "E1" },
                    { new Guid("fe655877-1272-481c-a664-f37e58f20e3a"), "E2" },
                    { new Guid("ca748afc-898f-4a51-9430-66f9fc47aa76"), "E3" },
                    { new Guid("910c52cc-4dd4-4d79-a19b-30d167af1ba8"), "F1" },
                    { new Guid("2329cd38-66a0-423e-a815-61d1d4215766"), "F2" },
                    { new Guid("3eb90adc-65aa-4cbe-9dc1-5953c44713b8"), "A1" },
                    { new Guid("690eda91-7abd-45df-9615-4c31ca2a2cfb"), "B1" },
                    { new Guid("df7fc3d4-24b3-4d85-a93a-0ece11a7e8a7"), "B2" },
                    { new Guid("709f911f-a968-4125-835d-ffe4b4b98ecd"), "C1" },
                    { new Guid("5146a4b1-4db1-4cb6-8925-b7f8639dedf0"), "C2" },
                    { new Guid("0b1f5dfb-11d4-4bda-a44c-4150360688f2"), "C5" },
                    { new Guid("2e8b6c2e-a664-4b14-ab84-6c54bdb14e2c"), "C3" },
                    { new Guid("f44530af-459c-4431-aee6-55bd938b4c63"), "D2" },
                    { new Guid("e246ee72-f3e4-4d74-b4c4-0b8b83239ab8"), "D3" },
                    { new Guid("395fb6de-a595-49d9-8a99-b95540531b25"), "D4" },
                    { new Guid("c9ebd9ed-12f7-4844-9abc-51f349508577"), "E1" },
                    { new Guid("d67178e3-1e97-4588-aabd-cd22640b958f"), "E2" },
                    { new Guid("54fa7808-d74a-4115-adb6-248647068a3d"), "E3" },
                    { new Guid("84e529ca-bd6d-4bd8-a93c-df12bea40322"), "E4" },
                    { new Guid("011bf308-6adf-49e1-86e2-28fb86fafaa4"), "E5" },
                    { new Guid("06bdb555-d268-4ffb-ba56-56cd5933709c"), "F1" },
                    { new Guid("2dd4bf29-d587-4ef3-913b-ea492ebac8a7"), "F2" },
                    { new Guid("15a97d1a-c748-4ac7-90ae-98ace5bcb603"), "F3" },
                    { new Guid("8bf4d337-fd32-4cf6-a475-739546ccd293"), "F4" },
                    { new Guid("1ed60272-a370-4c3f-9804-27a0f038446b"), "F5" },
                    { new Guid("86216c8e-041c-4ddd-ae57-b35bc2b31749"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("e822b620-1543-40e2-9e4c-bf07a4b26822"), "D1" },
                    { new Guid("1fb51e0f-7f5d-40df-b8cc-a3feb437e5bc"), "C1" },
                    { new Guid("c3348430-7881-40fa-8c21-9d36f920c413"), "C4" },
                    { new Guid("2866c0d8-a784-4019-a4d4-2439756d484e"), "C2" },
                    { new Guid("b8d28c88-0cb1-4855-974d-c0cc0f999a1f"), "C3" },
                    { new Guid("85cbdb71-9813-4484-a043-6d5146454d2d"), "D1" },
                    { new Guid("160bde93-83f2-4bb0-b000-b9af545c27a9"), "D2" },
                    { new Guid("5f2270c5-6157-4dea-8184-844662d760db"), "D3" },
                    { new Guid("340fbaef-2852-449a-8ce6-0a0986da9634"), "D4" },
                    { new Guid("e66f984d-364d-4ea4-8f89-ebf67d01047e"), "E1" },
                    { new Guid("2aee9843-ebec-4495-990c-aecbd94ce342"), "E2" },
                    { new Guid("75f24b5a-0e18-4674-8eb5-28c62a2f8a42"), "E3" },
                    { new Guid("a2d1af8e-1424-4bc1-9a27-b2d6e7d818c2"), "E4" },
                    { new Guid("e090027b-a00e-4cd1-8907-0d4d344dce70"), "E5" },
                    { new Guid("eb6077e0-5065-44cd-a029-eec737a088b0"), "F1" },
                    { new Guid("015e955a-b9db-488b-a9ae-a678798df1f2"), "F2" },
                    { new Guid("f56c76a0-ff11-4e19-b901-fe18b612aa02"), "A2" },
                    { new Guid("57128d1f-3ff8-4c91-baeb-45e73fcb47b4"), "F4" },
                    { new Guid("2c5ed516-c63e-439f-ba00-b6c860311172"), "C3" },
                    { new Guid("92e59758-1efd-485c-b7a8-8a50ad9d18b5"), "F5" },
                    { new Guid("1c9f84b3-8886-4320-a5fd-d24d5d2b64c1"), "A1" },
                    { new Guid("b9635b71-2084-4ad7-8537-8fcbe344ccd4"), "A2" },
                    { new Guid("294a1992-864f-42b5-ade7-059ffabcdbb5"), "A3" },
                    { new Guid("92a667e5-00ce-47bc-8f7e-e01e6cad4d15"), "A4" },
                    { new Guid("f1c632f0-10c1-4caa-b323-9aab8f53465e"), "A5" },
                    { new Guid("6b22464b-c6d7-4037-9aa0-285aebdc7f44"), "A6" },
                    { new Guid("8677522a-ad46-4ba7-ae8a-72da3fb3f172"), "A7" },
                    { new Guid("f0275619-7af4-4136-884b-1e1f4cc1d95c"), "B1" },
                    { new Guid("2ae3bc3a-d2ef-4d60-bf4d-aac104dbaaf6"), "B2" },
                    { new Guid("19709dc7-e459-4a38-b2e1-6382818dcb87"), "B3" },
                    { new Guid("e0c1184a-8128-4f04-8ccf-52afddddf303"), "B4" },
                    { new Guid("602862b5-879b-4c23-85d6-49f8abde4b44"), "B5" },
                    { new Guid("1b1456c0-27e3-44e5-b2a6-6c982688aa45"), "B6" },
                    { new Guid("32b3a442-17ca-4daa-a1b1-a1ce5d4226de"), "C1" },
                    { new Guid("5de89bae-8fe0-491b-a511-92563cb29dab"), "F6" },
                    { new Guid("4f08eace-b92e-4b0c-bce6-1a0e6b7820fc"), "A1" },
                    { new Guid("cc710dce-1b23-40e2-8556-964644e2035b"), "D2" },
                    { new Guid("34d8663f-a4e4-4c50-950c-12a4bbb625f3"), "F5" },
                    { new Guid("54233085-b0b5-4a7f-b80e-a1385c94d1f4"), "F1" },
                    { new Guid("d5e4d67e-96b0-4518-a7dc-dad60b1bbbf8"), "F2" },
                    { new Guid("abaa4eff-41c3-4d9b-821c-2cb939de846d"), "G1" },
                    { new Guid("14c1a4c1-a9ec-48c5-8af6-97336351bbf9"), "G2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("29ff579b-be97-4b42-a188-8621b3f8355d"), "H1" },
                    { new Guid("e1756edb-2a4d-4d7e-b649-bf296455948e"), "H2" },
                    { new Guid("725d5aa1-b2c7-4367-a346-a84d9add12df"), "A1" },
                    { new Guid("64faeda8-4204-468d-a899-d34aeb86dca0"), "A2" },
                    { new Guid("94b58af9-ad5d-43b8-b012-040399a81d55"), "A3" },
                    { new Guid("f99a2270-e49c-4f1a-b905-90105090549b"), "B1" },
                    { new Guid("0e6a1da9-2d5f-4e55-943d-a0ddd66bd409"), "B2" },
                    { new Guid("1a6c3246-e723-41db-bc0d-944d5aaea79d"), "B3" },
                    { new Guid("b1590fea-5433-4364-a6e9-9c06db8d043a"), "C1" },
                    { new Guid("48f5bdc3-3b15-427e-b0e4-06e5d461667c"), "C2" },
                    { new Guid("dd497af1-5b2b-43aa-bf6e-9ef65fb6debd"), "C3" },
                    { new Guid("215db5d4-282b-4741-9eaf-157c11731805"), "D1" },
                    { new Guid("08e6f095-8393-477d-ad52-0243a6878355"), "D2" },
                    { new Guid("8ac6d5d0-4e0f-4932-add9-e7487718e5ef"), "D3" },
                    { new Guid("8d0bed17-50ba-48d4-ad02-d8e4f1663481"), "E1" },
                    { new Guid("3f5c17bc-275b-437d-8683-1778fd15fcb3"), "E2" },
                    { new Guid("5b995ec0-fad6-4ba4-86a9-d84d28442ccb"), "E3" },
                    { new Guid("3597193d-b7c8-4306-b838-fbd4c95df76e"), "F1" },
                    { new Guid("90de9b53-fa5f-49ee-ba02-1c69aade3a45"), "F2" },
                    { new Guid("8736e70e-d5e4-49c1-b653-2e918d3c6a32"), "F3" },
                    { new Guid("61e1320e-067b-40fe-b803-39bd9cd6d888"), "G1" },
                    { new Guid("650e92a9-3aa5-4ba8-a947-9dc348c782c1"), "G2" },
                    { new Guid("a6ac9307-2881-4dd4-a194-ee696cae4fe7"), "G3" },
                    { new Guid("ab3f616f-3edd-4b79-80aa-a9700e2b71e8"), "H1" },
                    { new Guid("9acf3af8-c5eb-45c0-af2b-c9cc00e0e6a2"), "H2" },
                    { new Guid("8d62541c-eee5-4043-9e51-b30a2ca29b9f"), "E2" },
                    { new Guid("97832fdd-72d4-4930-9619-6e65a7ff2ca4"), "E1" },
                    { new Guid("78cd4754-1534-48eb-96af-26d0a07671f7"), "D2" },
                    { new Guid("32f6a05a-6b77-43de-9f9f-2560ebc75a60"), "D1" },
                    { new Guid("f3717b77-c225-40a4-a1a4-f34c2db61221"), "A1" },
                    { new Guid("6e304fa6-d7b5-43b2-bed7-2e9c1b066ff8"), "A2" },
                    { new Guid("be1f6600-5689-4a39-a172-ef62a6af953c"), "A3" },
                    { new Guid("999f6fd5-53ab-433f-91f8-487a16176c21"), "B1" },
                    { new Guid("511a7878-c8d9-4fc3-92e5-c28822a6439f"), "B2" },
                    { new Guid("4e854a37-9460-45be-aea9-a95a20929f0e"), "B3" },
                    { new Guid("81fb14fb-0722-4fbc-ae30-bdb28615260c"), "C1" },
                    { new Guid("db633429-e985-4812-969b-c0d7403b724e"), "C2" },
                    { new Guid("bd3ade66-821f-4b56-90b9-4cb3a0b958e7"), "C3" },
                    { new Guid("946ebe00-c4da-4db6-8c0f-f8d044f987ca"), "D1" },
                    { new Guid("2185e379-2788-4792-90f8-d98e96aa4fbc"), "D2" },
                    { new Guid("e19c7336-cfe8-43f8-947a-8e5951e07335"), "D3" },
                    { new Guid("74351f15-1cc2-4fe1-b763-dd00f446c12a"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("6e36f5d4-557c-417e-bdf5-2a6a73d54953"), "E2" },
                    { new Guid("d24ef46f-a51a-4c1d-a27c-8691e3212886"), "H3" },
                    { new Guid("209d1773-9648-4daa-8625-84a907046aa3"), "E3" },
                    { new Guid("ad17605b-0423-4e19-93d9-74452c1e00d7"), "F2" },
                    { new Guid("d9a0553e-a29a-43b9-a987-266b3a5e9cd0"), "F3" },
                    { new Guid("9821eba8-241b-4c09-b085-19613e4853f3"), "G1" },
                    { new Guid("45d4663e-0e68-43ad-bfcc-f6a17fde5e9b"), "G2" },
                    { new Guid("bf6af70e-77a6-479c-9549-628a2bc15dd5"), "G3" },
                    { new Guid("84e9dddd-bdbb-4de1-bdd9-acbb35980697"), "H1" },
                    { new Guid("31d3a994-64d4-468b-ae28-bfb754aa3260"), "H2" },
                    { new Guid("e47784fd-d07a-4990-9aaa-bd1d76a7de9d"), "H3" },
                    { new Guid("6c0c680a-7964-425b-b0ed-f01ece09a456"), "A1" },
                    { new Guid("fdf5326a-78c4-49ce-ab15-b627e04de8c4"), "A2" },
                    { new Guid("7f464736-eff5-4de5-acc4-8a4aae5c7f03"), "B1" },
                    { new Guid("75246b6a-7f64-456e-8211-1405ebeb208c"), "B2" },
                    { new Guid("a4f29ec3-8e74-4653-ac69-8d64d12768bb"), "C1" },
                    { new Guid("c5650dde-1787-4935-b09d-13d1db0e48dc"), "C2" },
                    { new Guid("ce5aadfd-de68-4f4d-b80d-83a11d0ee23a"), "F1" },
                    { new Guid("19c266cb-cb94-45ee-b024-57e1f86ba883"), "F6" },
                    { new Guid("c6125b6e-87ba-4b64-9cca-c492f18c0730"), "A1" },
                    { new Guid("554ea3b0-8c73-433d-9d30-3892f06b0933"), "B2" },
                    { new Guid("046e56db-6bf1-4f4e-8f1e-7b26fdac47a5"), "C4" },
                    { new Guid("5471da5b-e4bb-43bc-a7aa-6592c8d40815"), "C5" },
                    { new Guid("1a9515ca-f451-4ffa-8748-b6d256463981"), "D1" },
                    { new Guid("5e082451-e65e-48d4-9049-4882eb8585d1"), "D2" },
                    { new Guid("83d3004b-0518-4b3e-b413-2febe1d92957"), "D3" },
                    { new Guid("a051a374-b603-435b-a1a6-a42e77f05a06"), "D4" },
                    { new Guid("e6fa656f-3998-413d-9bce-c1bb0870aa2b"), "E1" },
                    { new Guid("567b14c0-783b-4a92-a1d2-06398ab635f2"), "E2" },
                    { new Guid("0b648da6-c362-462d-af7a-aeffa5dcd1c9"), "E3" },
                    { new Guid("c4d82628-28a9-4c98-abc0-fcddbad9bfcc"), "F1" },
                    { new Guid("c169f3d3-c5bf-4f2d-890d-56a38af8b188"), "F2" },
                    { new Guid("169ce779-cdac-4313-9439-9d3dc9f25a4b"), "A1" },
                    { new Guid("bb6dd75f-95fb-47c6-9b94-670f01f5b44e"), "B1" },
                    { new Guid("4ea38cb1-6314-475e-89e8-9429caacc688"), "B2" },
                    { new Guid("2bc9d71b-3e40-41eb-8623-92d6503c5838"), "C1" },
                    { new Guid("725e09ea-97dc-4692-93c0-9344d5179141"), "C2" },
                    { new Guid("4b5653c9-5427-490e-9cd2-989046b98f43"), "C3" },
                    { new Guid("13bdc807-55f4-4810-81ef-df8be25c8cff"), "D1" },
                    { new Guid("ee51284c-cf5c-4564-8cd2-ce6ea2c07415"), "D3" },
                    { new Guid("d450c7ac-063c-439f-8ecc-0f74b1d1b941"), "D4" },
                    { new Guid("a479208d-9682-4cdb-ba83-330bcdc137d3"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("724f8bf6-fe87-43b0-882c-e53d0a7939b7"), "E2" },
                    { new Guid("c0eb93b9-fcca-4b83-ab01-e43dd1a914e1"), "E3" },
                    { new Guid("46d85339-e7c2-40ca-8e38-ba46dd19a881"), "E4" },
                    { new Guid("13b4633c-a106-4399-b11c-c72ee65e19c5"), "E5" },
                    { new Guid("f5970877-3a11-402c-9cc7-f5bcfadc50c0"), "F1" },
                    { new Guid("af428d6e-7811-46dd-a704-6c29b79b2337"), "F2" },
                    { new Guid("bf0682ad-d81d-464f-ac90-6e86a954b01b"), "F3" },
                    { new Guid("20d7f304-6b31-4c63-9f0c-bbc2c7d0109c"), "F4" },
                    { new Guid("4586c036-e84d-4b14-9b38-b4bed4c6d76e"), "C3" },
                    { new Guid("8360c0cd-7d3c-43c0-b28e-26417aac8afa"), "B1" },
                    { new Guid("ef8e5353-d525-4cbc-8187-58391b8a8201"), "C2" },
                    { new Guid("ef9ea9b5-fa52-4bf2-8ae7-26a9d09da17e"), "B6" },
                    { new Guid("ada29700-eceb-409d-8a81-7dae63c9a1c8"), "C1" },
                    { new Guid("3203638e-2e9a-48ce-96fa-318d248a5a86"), "C2" },
                    { new Guid("4d59e2b7-363a-4710-ad35-00f7164734fd"), "C3" },
                    { new Guid("59f170b3-93af-4701-9f68-7c0b2d403c01"), "D1" },
                    { new Guid("845903cb-cfbc-46b1-ba46-26f144aad291"), "D2" },
                    { new Guid("b29936af-36b9-4278-8f3c-95b7608d8cca"), "D3" },
                    { new Guid("31d43fdf-0935-485f-8b33-52ae9da97986"), "D4" },
                    { new Guid("4db3f927-bbdd-4765-bccb-4109cda20688"), "E1" },
                    { new Guid("07738d2b-8b57-4e0a-8217-88557d6d7482"), "E2" },
                    { new Guid("f07395dd-8221-4510-861d-751d85b94a2b"), "E3" },
                    { new Guid("f01075f2-8f11-46d6-a0d0-0af13505a30d"), "E4" },
                    { new Guid("2cd6e191-13cd-43a2-beb3-ba8f7b89bd0c"), "E5" },
                    { new Guid("ee77c4d2-a371-426f-936b-597bc2946607"), "F1" },
                    { new Guid("6395a2a2-a7b6-48e7-ad39-da788e146e6e"), "C1" },
                    { new Guid("051a5f80-e009-40c8-8c45-72152fffff7e"), "F3" },
                    { new Guid("c3befd58-b7c2-4a45-a04a-d09e5e75241c"), "F2" },
                    { new Guid("fc2f5708-ee70-4dc1-a747-6154ad6f21ea"), "F5" },
                    { new Guid("9b8575d7-2c01-485b-8ba9-fc40f8308c16"), "B5" },
                    { new Guid("32f4254b-abe2-4a59-ac8b-d8c161a809d7"), "B4" },
                    { new Guid("416b6e1b-21e6-4fd4-bb77-81d1162db949"), "B3" },
                    { new Guid("7eb502df-8647-4153-876b-50bca0feb6fa"), "B2" },
                    { new Guid("1df34348-e096-4ddd-88cc-089e3cf0e8e7"), "B1" },
                    { new Guid("ed9680cf-a43f-4d92-843d-85475e521d85"), "A7" },
                    { new Guid("ba6921a9-2812-4606-ba71-0f97731ef36d"), "F4" },
                    { new Guid("ce487146-4a3c-4832-9c03-65048b2131c1"), "A6" },
                    { new Guid("13c82731-1027-4ba3-aec5-6b804efde4d0"), "A4" },
                    { new Guid("d959d5a3-bfa8-4222-a67d-e9c222b7ce28"), "A3" },
                    { new Guid("2aae7465-ea3c-455f-b623-0052f8f1fd26"), "A2" },
                    { new Guid("3376a52e-f746-49be-9798-8885161aedff"), "A1" },
                    { new Guid("7afe2599-3618-451a-b48d-20ef65c69699"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[] { new Guid("b16d176e-3791-4d79-8a28-39aa404e6d79"), "A5" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6"), "Sección 2" },
                    { new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe"), "Sección 1" },
                    { new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Cecilia Roth" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("8e5d23d0-469c-483d-a384-0823474367d5"), "Mary Sweeny" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("3147e6e4-0913-498e-af09-52845dfdecad"), "Roger Avary" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("3147e6e4-0913-498e-af09-52845dfdecad"), "Quentin Tarantino" },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Robert Zemeckis" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Quentin Tarantino" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "David Lynch" },
                    { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Pedro Almodovar" },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Robin Wright" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Samuel Jackson" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Una Thurman" },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "John Travolta" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Justin Theroux" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Laura Harring" },
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Naomi Watts" },
                    { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Penélope Cruz" },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("f853a386-dbb3-4e13-8e71-3ee0d0d676ca") },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("1995c4d1-dc60-42a1-9821-39e21e65e00f") },
                    { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") },
                    { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") },
                    { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("0e6a1da9-2d5f-4e55-943d-a0ddd66bd409"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b5d35a90-37b5-40dc-97f5-f65a79314bcc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3a26569d-591b-49aa-aa62-c60623db1d1c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c566cb76-a78d-423c-8a05-89a3b8904d9f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("dc9bb667-9825-4039-9618-b63b5b8bd17a"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("fe655877-1272-481c-a664-f37e58f20e3a"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ca748afc-898f-4a51-9430-66f9fc47aa76"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("910c52cc-4dd4-4d79-a19b-30d167af1ba8"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2329cd38-66a0-423e-a815-61d1d4215766"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("725d5aa1-b2c7-4367-a346-a84d9add12df"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("64faeda8-4204-468d-a899-d34aeb86dca0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("94b58af9-ad5d-43b8-b012-040399a81d55"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f99a2270-e49c-4f1a-b905-90105090549b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1a6c3246-e723-41db-bc0d-944d5aaea79d"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("90de9b53-fa5f-49ee-ba02-1c69aade3a45"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("48f5bdc3-3b15-427e-b0e4-06e5d461667c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("dd497af1-5b2b-43aa-bf6e-9ef65fb6debd"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("215db5d4-282b-4741-9eaf-157c11731805"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("08e6f095-8393-477d-ad52-0243a6878355"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8ac6d5d0-4e0f-4932-add9-e7487718e5ef"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8d0bed17-50ba-48d4-ad02-d8e4f1663481"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3f5c17bc-275b-437d-8683-1778fd15fcb3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5b995ec0-fad6-4ba4-86a9-d84d28442ccb"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3597193d-b7c8-4306-b838-fbd4c95df76e"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b22a652-0a5d-4330-8ac9-d2a18c07ea0c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8736e70e-d5e4-49c1-b653-2e918d3c6a32"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("61e1320e-067b-40fe-b803-39bd9cd6d888"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("650e92a9-3aa5-4ba8-a947-9dc348c782c1"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a6ac9307-2881-4dd4-a194-ee696cae4fe7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b1590fea-5433-4364-a6e9-9c06db8d043a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("0b1f5dfb-11d4-4bda-a44c-4150360688f2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8677522a-ad46-4ba7-ae8a-72da3fb3f172"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2c5ed516-c63e-439f-ba00-b6c860311172"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5c9b4032-8dec-4c60-942a-d2cdf48d69f0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("a7c5698b-e452-4092-92b8-47123d3aa849"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("02babe69-e5bb-494c-893d-0ecfdc41e0d0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("62837e09-b5d2-473c-9c17-30632547bda1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("05f9a8f5-5a9e-41e5-b24d-3a901fdd704d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1d8e15c5-a3c7-4c4b-a0ce-7b48dbcdd352"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("be2dd774-7704-4e9c-a3bf-291420c07809"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("99238e0d-e33b-4848-ae57-bde04bfe43a0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3bd881fd-2ed2-4b31-a442-0aca43890567"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("70a6a4df-d7dc-4a34-8ba8-a5ee75a853d9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9ab3182a-bd85-44a6-a9fb-ab6376d820b7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("d50c025f-9b43-4d82-b9f1-82780b778eb2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e1ada6ce-8132-4769-8553-ff8d3e4b9084"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2b38cf54-05da-4616-bdbf-b91ee27a036e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c3348430-7881-40fa-8c21-9d36f920c413"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("dbdd260e-1ab6-44bf-9526-08f93d718f16"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b9635b71-2084-4ad7-8537-8fcbe344ccd4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("294a1992-864f-42b5-ade7-059ffabcdbb5"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("92a667e5-00ce-47bc-8f7e-e01e6cad4d15"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f1c632f0-10c1-4caa-b323-9aab8f53465e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b22464b-c6d7-4037-9aa0-285aebdc7f44"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ab3f616f-3edd-4b79-80aa-a9700e2b71e8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f0275619-7af4-4136-884b-1e1f4cc1d95c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2ae3bc3a-d2ef-4d60-bf4d-aac104dbaaf6"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("19709dc7-e459-4a38-b2e1-6382818dcb87"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e0c1184a-8128-4f04-8ccf-52afddddf303"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("602862b5-879b-4c23-85d6-49f8abde4b44"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1b1456c0-27e3-44e5-b2a6-6c982688aa45"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("32b3a442-17ca-4daa-a1b1-a1ce5d4226de"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2866c0d8-a784-4019-a4d4-2439756d484e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1c9f84b3-8886-4320-a5fd-d24d5d2b64c1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9acf3af8-c5eb-45c0-af2b-c9cc00e0e6a2"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d450c7ac-063c-439f-8ecc-0f74b1d1b941"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("169ce779-cdac-4313-9439-9d3dc9f25a4b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ea55ef1c-172f-431a-8125-0c88a978711f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("780bb2d4-01fe-4056-823d-5afd53ae3481"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("32f389ee-d0c8-4078-bbcb-6da3b78d9aad"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c927254b-8e33-43a2-ac03-1d19bdc128da"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4c93f1b0-dbcd-4ad9-beae-ec2f47b354bf"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("fad2c712-c744-4720-b0ac-8ad29b12be60"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("514cafc8-bee8-4a03-a868-e40a1bb063db"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("010063ba-f338-4cc0-b7f6-f47aeae66b28"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("03f55550-d819-46a2-9c21-23c4470dde76"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c8d279bc-cd68-4186-b7a6-d8dcea1fbecf"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3eb90adc-65aa-4cbe-9dc1-5953c44713b8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("690eda91-7abd-45df-9615-4c31ca2a2cfb"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("df7fc3d4-24b3-4d85-a93a-0ece11a7e8a7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("709f911f-a968-4125-835d-ffe4b4b98ecd"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5146a4b1-4db1-4cb6-8925-b7f8639dedf0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2e8b6c2e-a664-4b14-ab84-6c54bdb14e2c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e822b620-1543-40e2-9e4c-bf07a4b26822"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f44530af-459c-4431-aee6-55bd938b4c63"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e246ee72-f3e4-4d74-b4c4-0b8b83239ab8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("395fb6de-a595-49d9-8a99-b95540531b25"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c9ebd9ed-12f7-4844-9abc-51f349508577"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("d67178e3-1e97-4588-aabd-cd22640b958f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("54fa7808-d74a-4115-adb6-248647068a3d"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("84e529ca-bd6d-4bd8-a93c-df12bea40322"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("011bf308-6adf-49e1-86e2-28fb86fafaa4"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("06bdb555-d268-4ffb-ba56-56cd5933709c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2dd4bf29-d587-4ef3-913b-ea492ebac8a7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("15a97d1a-c748-4ac7-90ae-98ace5bcb603"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8bf4d337-fd32-4cf6-a475-739546ccd293"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("99e7c724-209a-4f28-905f-844a2cfe45ef"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e9ef8d93-ca57-4326-9bff-b0af3424ede3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("546f072d-c1a2-4cda-abcf-588e3af8bbf5"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ce5525d0-2706-426f-b140-d7b7fd22358a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bb6dd75f-95fb-47c6-9b94-670f01f5b44e"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4ea38cb1-6314-475e-89e8-9429caacc688"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2bc9d71b-3e40-41eb-8623-92d6503c5838"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("725e09ea-97dc-4692-93c0-9344d5179141"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4b5653c9-5427-490e-9cd2-989046b98f43"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13bdc807-55f4-4810-81ef-df8be25c8cff"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("cc710dce-1b23-40e2-8556-964644e2035b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ee51284c-cf5c-4564-8cd2-ce6ea2c07415"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("502017f9-f1fb-41d0-891c-a182e880586f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a479208d-9682-4cdb-ba83-330bcdc137d3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("724f8bf6-fe87-43b0-882c-e53d0a7939b7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c0eb93b9-fcca-4b83-ab01-e43dd1a914e1"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("46d85339-e7c2-40ca-8e38-ba46dd19a881"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13b4633c-a106-4399-b11c-c72ee65e19c5"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d24ef46f-a51a-4c1d-a27c-8691e3212886"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f5970877-3a11-402c-9cc7-f5bcfadc50c0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bf0682ad-d81d-464f-ac90-6e86a954b01b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("20d7f304-6b31-4c63-9f0c-bbc2c7d0109c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("34d8663f-a4e4-4c50-950c-12a4bbb625f3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("19c266cb-cb94-45ee-b024-57e1f86ba883"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("cd805de8-809c-4534-b9aa-819fa405ca5b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2358c8b9-c3a7-4dfe-a391-1495327b5e95"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4ebb03ba-3303-41c7-aceb-c7bbba3918db"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b352b12e-36aa-4b1a-9c5d-eb425348e6ca"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e80d2669-511f-4f69-a16f-7bcea33fc249"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1cd07ac7-1712-4ae1-b8e7-cb38af6937a4"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("aeff94e8-ef3b-4a85-91f2-3349a45d1c88"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("65fa6437-2c13-48d6-ac40-d590e00be46a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8e730d04-d424-4bd5-b8e3-3e2a3daa2015"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ca441910-5da0-4535-9141-5bdd7830e57f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("af428d6e-7811-46dd-a704-6c29b79b2337"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c169f3d3-c5bf-4f2d-890d-56a38af8b188"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4586c036-e84d-4b14-9b38-b4bed4c6d76e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("0b648da6-c362-462d-af7a-aeffa5dcd1c9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4db3f927-bbdd-4765-bccb-4109cda20688"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("07738d2b-8b57-4e0a-8217-88557d6d7482"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f07395dd-8221-4510-861d-751d85b94a2b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f01075f2-8f11-46d6-a0d0-0af13505a30d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2cd6e191-13cd-43a2-beb3-ba8f7b89bd0c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ee77c4d2-a371-426f-936b-597bc2946607"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c3befd58-b7c2-4a45-a04a-d09e5e75241c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("051a5f80-e009-40c8-8c45-72152fffff7e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ba6921a9-2812-4606-ba71-0f97731ef36d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("fc2f5708-ee70-4dc1-a747-6154ad6f21ea"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7afe2599-3618-451a-b48d-20ef65c69699"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4f08eace-b92e-4b0c-bce6-1a0e6b7820fc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f56c76a0-ff11-4e19-b901-fe18b612aa02"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("68bfa52e-687b-4d0f-aad9-b353492d6ec8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("221b1135-fd11-480e-9a8d-e587083d054f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("babf2c01-91dc-4935-a57d-b6f3880550d5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3b94183d-78a2-4dcb-80fd-6949f6a92cc3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("efbfe94b-6e59-4690-8132-1a1088c459af"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("249acb35-1062-4777-9c97-438cbb53c4fc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5e18c728-564c-45b0-a56d-058f146032fe"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("59344681-70b9-424f-9da8-dc02bb857aa6"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("783b092d-731f-4291-82e0-960e6be33fd5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("02394b47-cacc-4f39-9b44-411a5583d6a7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("84763256-7150-46e9-b5b1-e6cb583e48cc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("05808884-423e-42d0-bb4c-9f4360a6ad90"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4fedb4d5-1de2-49cd-9901-642cf87bdb3d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("718e63a7-2f4f-4a33-a612-fb3b33af7559"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e8bd007a-ecc0-4a0b-8279-187904beebcd"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("7be03017-81c9-4250-adea-08a87d7ac073"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("31d43fdf-0935-485f-8b33-52ae9da97986"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b29936af-36b9-4278-8f3c-95b7608d8cca"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("845903cb-cfbc-46b1-ba46-26f144aad291"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("59f170b3-93af-4701-9f68-7c0b2d403c01"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f3717b77-c225-40a4-a1a4-f34c2db61221"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6e304fa6-d7b5-43b2-bed7-2e9c1b066ff8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("be1f6600-5689-4a39-a172-ef62a6af953c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("999f6fd5-53ab-433f-91f8-487a16176c21"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("511a7878-c8d9-4fc3-92e5-c28822a6439f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4e854a37-9460-45be-aea9-a95a20929f0e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("81fb14fb-0722-4fbc-ae30-bdb28615260c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("db633429-e985-4812-969b-c0d7403b724e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bd3ade66-821f-4b56-90b9-4cb3a0b958e7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("946ebe00-c4da-4db6-8c0f-f8d044f987ca"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2185e379-2788-4792-90f8-d98e96aa4fbc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e19c7336-cfe8-43f8-947a-8e5951e07335"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("74351f15-1cc2-4fe1-b763-dd00f446c12a"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6e36f5d4-557c-417e-bdf5-2a6a73d54953"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b9b9a34-9ff6-47ec-aa15-f1a8b5e55960"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("209d1773-9648-4daa-8625-84a907046aa3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ad17605b-0423-4e19-93d9-74452c1e00d7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d9a0553e-a29a-43b9-a987-266b3a5e9cd0"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9821eba8-241b-4c09-b085-19613e4853f3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("45d4663e-0e68-43ad-bfcc-f6a17fde5e9b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bf6af70e-77a6-479c-9549-628a2bc15dd5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("84e9dddd-bdbb-4de1-bdd9-acbb35980697"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("31d3a994-64d4-468b-ae28-bfb754aa3260"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e47784fd-d07a-4990-9aaa-bd1d76a7de9d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c6125b6e-87ba-4b64-9cca-c492f18c0730"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8360c0cd-7d3c-43c0-b28e-26417aac8afa"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("554ea3b0-8c73-433d-9d30-3892f06b0933"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ada29700-eceb-409d-8a81-7dae63c9a1c8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3203638e-2e9a-48ce-96fa-318d248a5a86"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4d59e2b7-363a-4710-ad35-00f7164734fd"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ce5aadfd-de68-4f4d-b80d-83a11d0ee23a"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c4d82628-28a9-4c98-abc0-fcddbad9bfcc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("24e14136-d63c-41a5-8ce1-b3a91578d458"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c5b5a70b-abc6-446f-8d9c-c44e7181a425"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d5e4d67e-96b0-4518-a7dc-dad60b1bbbf8"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("abaa4eff-41c3-4d9b-821c-2cb939de846d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("14c1a4c1-a9ec-48c5-8af6-97336351bbf9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("29ff579b-be97-4b42-a188-8621b3f8355d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e1756edb-2a4d-4d7e-b649-bf296455948e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3376a52e-f746-49be-9798-8885161aedff"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2aae7465-ea3c-455f-b623-0052f8f1fd26"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d959d5a3-bfa8-4222-a67d-e9c222b7ce28"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13c82731-1027-4ba3-aec5-6b804efde4d0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b16d176e-3791-4d79-8a28-39aa404e6d79"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ce487146-4a3c-4832-9c03-65048b2131c1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ed9680cf-a43f-4d92-843d-85475e521d85"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1df34348-e096-4ddd-88cc-089e3cf0e8e7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7eb502df-8647-4153-876b-50bca0feb6fa"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("416b6e1b-21e6-4fd4-bb77-81d1162db949"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("32f4254b-abe2-4a59-ac8b-d8c161a809d7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9b8575d7-2c01-485b-8ba9-fc40f8308c16"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ef9ea9b5-fa52-4bf2-8ae7-26a9d09da17e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6395a2a2-a7b6-48e7-ad39-da788e146e6e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ef8e5353-d525-4cbc-8187-58391b8a8201"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1ed60272-a370-4c3f-9804-27a0f038446b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("046e56db-6bf1-4f4e-8f1e-7b26fdac47a5"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5471da5b-e4bb-43bc-a7aa-6592c8d40815"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1a9515ca-f451-4ffa-8748-b6d256463981"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5e082451-e65e-48d4-9049-4882eb8585d1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("83d3004b-0518-4b3e-b413-2febe1d92957"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a051a374-b603-435b-a1a6-a42e77f05a06"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e6fa656f-3998-413d-9bce-c1bb0870aa2b"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("567b14c0-783b-4a92-a1d2-06398ab635f2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("54233085-b0b5-4a7f-b80e-a1385c94d1f4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8d62541c-eee5-4043-9e51-b30a2ca29b9f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("97832fdd-72d4-4930-9619-6e65a7ff2ca4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("78cd4754-1534-48eb-96af-26d0a07671f7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("264f52f0-da26-4d28-b175-40fcc1cf5020"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("7f5bcf75-1fc7-436c-ac3b-5bc9890db3bf"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9ef3dce8-20fe-4449-9da2-62354c0eb1a6"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ab6a7ce5-f139-4b6a-8266-d9e183b2c152"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f012c342-75f6-4698-9cd9-ff1a4615dc05"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1fb51e0f-7f5d-40df-b8cc-a3feb437e5bc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9190e247-9d8d-498e-b9f4-6889b69aee57"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b8d28c88-0cb1-4855-974d-c0cc0f999a1f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("85cbdb71-9813-4484-a043-6d5146454d2d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("160bde93-83f2-4bb0-b000-b9af545c27a9"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5f2270c5-6157-4dea-8184-844662d760db"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("340fbaef-2852-449a-8ce6-0a0986da9634"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e66f984d-364d-4ea4-8f89-ebf67d01047e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2aee9843-ebec-4495-990c-aecbd94ce342"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("65a284b6-7d54-4db3-8434-eb589d8e0a0b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("75f24b5a-0e18-4674-8eb5-28c62a2f8a42"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e090027b-a00e-4cd1-8907-0d4d344dce70"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("eb6077e0-5065-44cd-a029-eec737a088b0"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("015e955a-b9db-488b-a9ae-a678798df1f2"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4aba4bcd-bc04-46ad-88f1-443a3d0c7127"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("57128d1f-3ff8-4c91-baeb-45e73fcb47b4"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("92e59758-1efd-485c-b7a8-8a50ad9d18b5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5de89bae-8fe0-491b-a511-92563cb29dab"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6c0c680a-7964-425b-b0ed-f01ece09a456"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("fdf5326a-78c4-49ce-ab15-b627e04de8c4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7f464736-eff5-4de5-acc4-8a4aae5c7f03"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("75246b6a-7f64-456e-8211-1405ebeb208c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a4f29ec3-8e74-4653-ac69-8d64d12768bb"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c5650dde-1787-4935-b09d-13d1db0e48dc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("32f6a05a-6b77-43de-9f9f-2560ebc75a60"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("a2d1af8e-1424-4bc1-9a27-b2d6e7d818c2"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") },
                    { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("86216c8e-041c-4ddd-ae57-b35bc2b31749"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("3147e6e4-0913-498e-af09-52845dfdecad"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("3147e6e4-0913-498e-af09-52845dfdecad"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("8e5d23d0-469c-483d-a384-0823474367d5"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("1995c4d1-dc60-42a1-9821-39e21e65e00f") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("b5725057-d217-44c8-a133-8dadb5691754"), new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"), new Guid("f853a386-dbb3-4e13-8e71-3ee0d0d676ca") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("3188ed81-4623-4720-bb3f-14d5138b6483"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("569d329d-6a2e-4608-ac0d-4084b15f2df3"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("5ff257a9-65c2-4d96-ac5d-6861089c438f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("f17136b5-3c89-4626-9a29-bdbdcb69330d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("14f57847-7536-44e2-be43-c7e791cefccd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("15e06669-6cf8-4ff8-86d6-db623e1e5c34"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("22e11313-9901-46c7-acd9-d77a70c0394b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("77406b8c-43b6-425c-a6eb-9a80f075af1e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("88b3b367-0d97-44fa-a1fb-08f9a1c43378"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ac0db189-841d-45b4-81e1-6e9300b5d305"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b3d1e73b-f1e8-4e99-bf46-bb35762158e6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bccc34a8-b507-4102-90e5-90e22daec76f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c06534ae-8269-4063-adbc-0321a3e98e64"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c2179c54-738a-4a33-b4a6-37cc791836ad"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("010063ba-f338-4cc0-b7f6-f47aeae66b28"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("011bf308-6adf-49e1-86e2-28fb86fafaa4"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("015e955a-b9db-488b-a9ae-a678798df1f2"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("02394b47-cacc-4f39-9b44-411a5583d6a7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("02babe69-e5bb-494c-893d-0ecfdc41e0d0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("03f55550-d819-46a2-9c21-23c4470dde76"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("046e56db-6bf1-4f4e-8f1e-7b26fdac47a5"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("051a5f80-e009-40c8-8c45-72152fffff7e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("05808884-423e-42d0-bb4c-9f4360a6ad90"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("05f9a8f5-5a9e-41e5-b24d-3a901fdd704d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("06bdb555-d268-4ffb-ba56-56cd5933709c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("07738d2b-8b57-4e0a-8217-88557d6d7482"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("08e6f095-8393-477d-ad52-0243a6878355"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("0b1f5dfb-11d4-4bda-a44c-4150360688f2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("0b648da6-c362-462d-af7a-aeffa5dcd1c9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("0e6a1da9-2d5f-4e55-943d-a0ddd66bd409"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13b4633c-a106-4399-b11c-c72ee65e19c5"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13bdc807-55f4-4810-81ef-df8be25c8cff"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("13c82731-1027-4ba3-aec5-6b804efde4d0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("14c1a4c1-a9ec-48c5-8af6-97336351bbf9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("15a97d1a-c748-4ac7-90ae-98ace5bcb603"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("160bde93-83f2-4bb0-b000-b9af545c27a9"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("169ce779-cdac-4313-9439-9d3dc9f25a4b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("19709dc7-e459-4a38-b2e1-6382818dcb87"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("19c266cb-cb94-45ee-b024-57e1f86ba883"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1a6c3246-e723-41db-bc0d-944d5aaea79d"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1a9515ca-f451-4ffa-8748-b6d256463981"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1b1456c0-27e3-44e5-b2a6-6c982688aa45"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1c9f84b3-8886-4320-a5fd-d24d5d2b64c1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1cd07ac7-1712-4ae1-b8e7-cb38af6937a4"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1d8e15c5-a3c7-4c4b-a0ce-7b48dbcdd352"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("1df34348-e096-4ddd-88cc-089e3cf0e8e7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1ed60272-a370-4c3f-9804-27a0f038446b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("1fb51e0f-7f5d-40df-b8cc-a3feb437e5bc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("209d1773-9648-4daa-8625-84a907046aa3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("20d7f304-6b31-4c63-9f0c-bbc2c7d0109c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("215db5d4-282b-4741-9eaf-157c11731805"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2185e379-2788-4792-90f8-d98e96aa4fbc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("221b1135-fd11-480e-9a8d-e587083d054f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2329cd38-66a0-423e-a815-61d1d4215766"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2358c8b9-c3a7-4dfe-a391-1495327b5e95"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("249acb35-1062-4777-9c97-438cbb53c4fc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("24e14136-d63c-41a5-8ce1-b3a91578d458"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("264f52f0-da26-4d28-b175-40fcc1cf5020"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2866c0d8-a784-4019-a4d4-2439756d484e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("294a1992-864f-42b5-ade7-059ffabcdbb5"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("29ff579b-be97-4b42-a188-8621b3f8355d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2aae7465-ea3c-455f-b623-0052f8f1fd26"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2ae3bc3a-d2ef-4d60-bf4d-aac104dbaaf6"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2aee9843-ebec-4495-990c-aecbd94ce342"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2b38cf54-05da-4616-bdbf-b91ee27a036e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2bc9d71b-3e40-41eb-8623-92d6503c5838"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2c5ed516-c63e-439f-ba00-b6c860311172"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("2cd6e191-13cd-43a2-beb3-ba8f7b89bd0c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2dd4bf29-d587-4ef3-913b-ea492ebac8a7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("2e8b6c2e-a664-4b14-ab84-6c54bdb14e2c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("31d3a994-64d4-468b-ae28-bfb754aa3260"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("31d43fdf-0935-485f-8b33-52ae9da97986"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3203638e-2e9a-48ce-96fa-318d248a5a86"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("32b3a442-17ca-4daa-a1b1-a1ce5d4226de"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("32f389ee-d0c8-4078-bbcb-6da3b78d9aad"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("32f4254b-abe2-4a59-ac8b-d8c161a809d7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("32f6a05a-6b77-43de-9f9f-2560ebc75a60"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3376a52e-f746-49be-9798-8885161aedff"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("340fbaef-2852-449a-8ce6-0a0986da9634"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("34d8663f-a4e4-4c50-950c-12a4bbb625f3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3597193d-b7c8-4306-b838-fbd4c95df76e"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("395fb6de-a595-49d9-8a99-b95540531b25"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3a26569d-591b-49aa-aa62-c60623db1d1c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3b94183d-78a2-4dcb-80fd-6949f6a92cc3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3bd881fd-2ed2-4b31-a442-0aca43890567"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("3eb90adc-65aa-4cbe-9dc1-5953c44713b8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("3f5c17bc-275b-437d-8683-1778fd15fcb3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("416b6e1b-21e6-4fd4-bb77-81d1162db949"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4586c036-e84d-4b14-9b38-b4bed4c6d76e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("45d4663e-0e68-43ad-bfcc-f6a17fde5e9b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("46d85339-e7c2-40ca-8e38-ba46dd19a881"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("48f5bdc3-3b15-427e-b0e4-06e5d461667c"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4aba4bcd-bc04-46ad-88f1-443a3d0c7127"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4b5653c9-5427-490e-9cd2-989046b98f43"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4c93f1b0-dbcd-4ad9-beae-ec2f47b354bf"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4d59e2b7-363a-4710-ad35-00f7164734fd"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4db3f927-bbdd-4765-bccb-4109cda20688"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4e854a37-9460-45be-aea9-a95a20929f0e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("4ea38cb1-6314-475e-89e8-9429caacc688"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4ebb03ba-3303-41c7-aceb-c7bbba3918db"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4f08eace-b92e-4b0c-bce6-1a0e6b7820fc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("4fedb4d5-1de2-49cd-9901-642cf87bdb3d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("502017f9-f1fb-41d0-891c-a182e880586f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("511a7878-c8d9-4fc3-92e5-c28822a6439f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5146a4b1-4db1-4cb6-8925-b7f8639dedf0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("514cafc8-bee8-4a03-a868-e40a1bb063db"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("54233085-b0b5-4a7f-b80e-a1385c94d1f4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("546f072d-c1a2-4cda-abcf-588e3af8bbf5"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5471da5b-e4bb-43bc-a7aa-6592c8d40815"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("54fa7808-d74a-4115-adb6-248647068a3d"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("554ea3b0-8c73-433d-9d30-3892f06b0933"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("567b14c0-783b-4a92-a1d2-06398ab635f2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("57128d1f-3ff8-4c91-baeb-45e73fcb47b4"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("59344681-70b9-424f-9da8-dc02bb857aa6"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("59f170b3-93af-4701-9f68-7c0b2d403c01"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5b995ec0-fad6-4ba4-86a9-d84d28442ccb"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5c9b4032-8dec-4c60-942a-d2cdf48d69f0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5de89bae-8fe0-491b-a511-92563cb29dab"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("5e082451-e65e-48d4-9049-4882eb8585d1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5e18c728-564c-45b0-a56d-058f146032fe"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("5f2270c5-6157-4dea-8184-844662d760db"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("602862b5-879b-4c23-85d6-49f8abde4b44"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("61e1320e-067b-40fe-b803-39bd9cd6d888"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("62837e09-b5d2-473c-9c17-30632547bda1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6395a2a2-a7b6-48e7-ad39-da788e146e6e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("64faeda8-4204-468d-a899-d34aeb86dca0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("650e92a9-3aa5-4ba8-a947-9dc348c782c1"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("65a284b6-7d54-4db3-8434-eb589d8e0a0b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("65fa6437-2c13-48d6-ac40-d590e00be46a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("68bfa52e-687b-4d0f-aad9-b353492d6ec8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("690eda91-7abd-45df-9615-4c31ca2a2cfb"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b22464b-c6d7-4037-9aa0-285aebdc7f44"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b22a652-0a5d-4330-8ac9-d2a18c07ea0c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("6b9b9a34-9ff6-47ec-aa15-f1a8b5e55960"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6c0c680a-7964-425b-b0ed-f01ece09a456"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6e304fa6-d7b5-43b2-bed7-2e9c1b066ff8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("6e36f5d4-557c-417e-bdf5-2a6a73d54953"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("709f911f-a968-4125-835d-ffe4b4b98ecd"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("70a6a4df-d7dc-4a34-8ba8-a5ee75a853d9"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("718e63a7-2f4f-4a33-a612-fb3b33af7559"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("724f8bf6-fe87-43b0-882c-e53d0a7939b7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("725d5aa1-b2c7-4367-a346-a84d9add12df"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("725e09ea-97dc-4692-93c0-9344d5179141"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("74351f15-1cc2-4fe1-b763-dd00f446c12a"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("75246b6a-7f64-456e-8211-1405ebeb208c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("75f24b5a-0e18-4674-8eb5-28c62a2f8a42"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("780bb2d4-01fe-4056-823d-5afd53ae3481"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("783b092d-731f-4291-82e0-960e6be33fd5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("78cd4754-1534-48eb-96af-26d0a07671f7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7afe2599-3618-451a-b48d-20ef65c69699"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("7be03017-81c9-4250-adea-08a87d7ac073"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7eb502df-8647-4153-876b-50bca0feb6fa"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("7f464736-eff5-4de5-acc4-8a4aae5c7f03"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("7f5bcf75-1fc7-436c-ac3b-5bc9890db3bf"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("81fb14fb-0722-4fbc-ae30-bdb28615260c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8360c0cd-7d3c-43c0-b28e-26417aac8afa"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("83d3004b-0518-4b3e-b413-2febe1d92957"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("845903cb-cfbc-46b1-ba46-26f144aad291"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("84763256-7150-46e9-b5b1-e6cb583e48cc"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("84e529ca-bd6d-4bd8-a93c-df12bea40322"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("84e9dddd-bdbb-4de1-bdd9-acbb35980697"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("85cbdb71-9813-4484-a043-6d5146454d2d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("86216c8e-041c-4ddd-ae57-b35bc2b31749"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8677522a-ad46-4ba7-ae8a-72da3fb3f172"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8736e70e-d5e4-49c1-b653-2e918d3c6a32"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8ac6d5d0-4e0f-4932-add9-e7487718e5ef"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8bf4d337-fd32-4cf6-a475-739546ccd293"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8d0bed17-50ba-48d4-ad02-d8e4f1663481"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("8d62541c-eee5-4043-9e51-b30a2ca29b9f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("8e730d04-d424-4bd5-b8e3-3e2a3daa2015"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("90de9b53-fa5f-49ee-ba02-1c69aade3a45"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("910c52cc-4dd4-4d79-a19b-30d167af1ba8"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9190e247-9d8d-498e-b9f4-6889b69aee57"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("92a667e5-00ce-47bc-8f7e-e01e6cad4d15"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("92e59758-1efd-485c-b7a8-8a50ad9d18b5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("946ebe00-c4da-4db6-8c0f-f8d044f987ca"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("94b58af9-ad5d-43b8-b012-040399a81d55"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("97832fdd-72d4-4930-9619-6e65a7ff2ca4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9821eba8-241b-4c09-b085-19613e4853f3"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("99238e0d-e33b-4848-ae57-bde04bfe43a0"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("999f6fd5-53ab-433f-91f8-487a16176c21"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("99e7c724-209a-4f28-905f-844a2cfe45ef"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9ab3182a-bd85-44a6-a9fb-ab6376d820b7"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9acf3af8-c5eb-45c0-af2b-c9cc00e0e6a2"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("9b8575d7-2c01-485b-8ba9-fc40f8308c16"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("9ef3dce8-20fe-4449-9da2-62354c0eb1a6"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a051a374-b603-435b-a1a6-a42e77f05a06"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("a2d1af8e-1424-4bc1-9a27-b2d6e7d818c2"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a479208d-9682-4cdb-ba83-330bcdc137d3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a4f29ec3-8e74-4653-ac69-8d64d12768bb"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("a6ac9307-2881-4dd4-a194-ee696cae4fe7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("a7c5698b-e452-4092-92b8-47123d3aa849"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ab3f616f-3edd-4b79-80aa-a9700e2b71e8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ab6a7ce5-f139-4b6a-8266-d9e183b2c152"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("abaa4eff-41c3-4d9b-821c-2cb939de846d"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ad17605b-0423-4e19-93d9-74452c1e00d7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ada29700-eceb-409d-8a81-7dae63c9a1c8"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("aeff94e8-ef3b-4a85-91f2-3349a45d1c88"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("af428d6e-7811-46dd-a704-6c29b79b2337"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b1590fea-5433-4364-a6e9-9c06db8d043a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b16d176e-3791-4d79-8a28-39aa404e6d79"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("b29936af-36b9-4278-8f3c-95b7608d8cca"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b352b12e-36aa-4b1a-9c5d-eb425348e6ca"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b5d35a90-37b5-40dc-97f5-f65a79314bcc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b8d28c88-0cb1-4855-974d-c0cc0f999a1f"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("b9635b71-2084-4ad7-8537-8fcbe344ccd4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ba6921a9-2812-4606-ba71-0f97731ef36d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("babf2c01-91dc-4935-a57d-b6f3880550d5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bb6dd75f-95fb-47c6-9b94-670f01f5b44e"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bd3ade66-821f-4b56-90b9-4cb3a0b958e7"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("be1f6600-5689-4a39-a172-ef62a6af953c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("be2dd774-7704-4e9c-a3bf-291420c07809"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bf0682ad-d81d-464f-ac90-6e86a954b01b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("bf6af70e-77a6-479c-9549-628a2bc15dd5"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c0eb93b9-fcca-4b83-ab01-e43dd1a914e1"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c169f3d3-c5bf-4f2d-890d-56a38af8b188"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c3348430-7881-40fa-8c21-9d36f920c413"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c3befd58-b7c2-4a45-a04a-d09e5e75241c"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c4d82628-28a9-4c98-abc0-fcddbad9bfcc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c5650dde-1787-4935-b09d-13d1db0e48dc"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c566cb76-a78d-423c-8a05-89a3b8904d9f"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c5b5a70b-abc6-446f-8d9c-c44e7181a425"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("c6125b6e-87ba-4b64-9cca-c492f18c0730"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c8d279bc-cd68-4186-b7a6-d8dcea1fbecf"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c927254b-8e33-43a2-ac03-1d19bdc128da"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("c9ebd9ed-12f7-4844-9abc-51f349508577"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ca441910-5da0-4535-9141-5bdd7830e57f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ca748afc-898f-4a51-9430-66f9fc47aa76"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("cc710dce-1b23-40e2-8556-964644e2035b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("cd805de8-809c-4534-b9aa-819fa405ca5b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ce487146-4a3c-4832-9c03-65048b2131c1"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ce5525d0-2706-426f-b140-d7b7fd22358a"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ce5aadfd-de68-4f4d-b80d-83a11d0ee23a"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d24ef46f-a51a-4c1d-a27c-8691e3212886"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d450c7ac-063c-439f-8ecc-0f74b1d1b941"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("d50c025f-9b43-4d82-b9f1-82780b778eb2"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d5e4d67e-96b0-4518-a7dc-dad60b1bbbf8"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("d67178e3-1e97-4588-aabd-cd22640b958f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d959d5a3-bfa8-4222-a67d-e9c222b7ce28"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("d9a0553e-a29a-43b9-a987-266b3a5e9cd0"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("db633429-e985-4812-969b-c0d7403b724e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("dbdd260e-1ab6-44bf-9526-08f93d718f16"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("dc9bb667-9825-4039-9618-b63b5b8bd17a"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("dd497af1-5b2b-43aa-bf6e-9ef65fb6debd"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("df7fc3d4-24b3-4d85-a93a-0ece11a7e8a7"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e090027b-a00e-4cd1-8907-0d4d344dce70"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e0c1184a-8128-4f04-8ccf-52afddddf303"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e1756edb-2a4d-4d7e-b649-bf296455948e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e19c7336-cfe8-43f8-947a-8e5951e07335"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e1ada6ce-8132-4769-8553-ff8d3e4b9084"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e246ee72-f3e4-4d74-b4c4-0b8b83239ab8"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e47784fd-d07a-4990-9aaa-bd1d76a7de9d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e66f984d-364d-4ea4-8f89-ebf67d01047e"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("e6fa656f-3998-413d-9bce-c1bb0870aa2b"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e80d2669-511f-4f69-a16f-7bcea33fc249"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e822b620-1543-40e2-9e4c-bf07a4b26822"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e8bd007a-ecc0-4a0b-8279-187904beebcd"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("e9ef8d93-ca57-4326-9bff-b0af3424ede3"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("ea55ef1c-172f-431a-8125-0c88a978711f"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("eb6077e0-5065-44cd-a029-eec737a088b0"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ed9680cf-a43f-4d92-843d-85475e521d85"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ee51284c-cf5c-4564-8cd2-ce6ea2c07415"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ee77c4d2-a371-426f-936b-597bc2946607"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ef8e5353-d525-4cbc-8187-58391b8a8201"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("ef9ea9b5-fa52-4bf2-8ae7-26a9d09da17e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("efbfe94b-6e59-4690-8132-1a1088c459af"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f01075f2-8f11-46d6-a0d0-0af13505a30d"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f012c342-75f6-4698-9cd9-ff1a4615dc05"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f0275619-7af4-4136-884b-1e1f4cc1d95c"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f07395dd-8221-4510-861d-751d85b94a2b"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f1c632f0-10c1-4caa-b323-9aab8f53465e"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f3717b77-c225-40a4-a1a4-f34c2db61221"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f44530af-459c-4431-aee6-55bd938b4c63"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("f56c76a0-ff11-4e19-b901-fe18b612aa02"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f5970877-3a11-402c-9cc7-f5bcfadc50c0"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("f99a2270-e49c-4f1a-b905-90105090549b"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("fad2c712-c744-4720-b0ac-8ad29b12be60"), new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("fc2f5708-ee70-4dc1-a747-6154ad6f21ea"), new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"), new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"), new Guid("fdf5326a-78c4-49ce-ab15-b627e04de8c4"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("121eed25-e734-41d2-9dd8-236935218f29"), new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"), new Guid("fe655877-1272-481c-a664-f37e58f20e3a"), new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("3147e6e4-0913-498e-af09-52845dfdecad"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("63fae38c-7b3f-4389-a7ed-b226e56386a2"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("8e5d23d0-469c-483d-a384-0823474367d5"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b10f8a93-faca-4588-ba8d-048a85b37f4d"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("43eecc9c-17bd-4e17-b2ec-7603644b8f27"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("96ee85d6-0e3f-4bb4-8767-341a4c210593"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("b5725057-d217-44c8-a133-8dadb5691754"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("bbb510f2-a5ab-4a78-a4c5-293138f6f970"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1995c4d1-dc60-42a1-9821-39e21e65e00f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1d57fb53-cb24-4731-8c83-753f70dc5f2a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f853a386-dbb3-4e13-8e71-3ee0d0d676ca"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("121eed25-e734-41d2-9dd8-236935218f29"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("85219f71-df2e-44e3-8b45-162474c88e8c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e5d40795-5093-4f1f-874f-39928c51afc5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f0f31aba-733c-4f56-b81c-386747fbd135"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("010063ba-f338-4cc0-b7f6-f47aeae66b28"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("011bf308-6adf-49e1-86e2-28fb86fafaa4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("015e955a-b9db-488b-a9ae-a678798df1f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02394b47-cacc-4f39-9b44-411a5583d6a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02babe69-e5bb-494c-893d-0ecfdc41e0d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03f55550-d819-46a2-9c21-23c4470dde76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("046e56db-6bf1-4f4e-8f1e-7b26fdac47a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("051a5f80-e009-40c8-8c45-72152fffff7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05808884-423e-42d0-bb4c-9f4360a6ad90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05f9a8f5-5a9e-41e5-b24d-3a901fdd704d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06bdb555-d268-4ffb-ba56-56cd5933709c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07738d2b-8b57-4e0a-8217-88557d6d7482"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08e6f095-8393-477d-ad52-0243a6878355"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b1f5dfb-11d4-4bda-a44c-4150360688f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b648da6-c362-462d-af7a-aeffa5dcd1c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e6a1da9-2d5f-4e55-943d-a0ddd66bd409"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13b4633c-a106-4399-b11c-c72ee65e19c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13bdc807-55f4-4810-81ef-df8be25c8cff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13c82731-1027-4ba3-aec5-6b804efde4d0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14c1a4c1-a9ec-48c5-8af6-97336351bbf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15a97d1a-c748-4ac7-90ae-98ace5bcb603"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("160bde93-83f2-4bb0-b000-b9af545c27a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("169ce779-cdac-4313-9439-9d3dc9f25a4b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19709dc7-e459-4a38-b2e1-6382818dcb87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19c266cb-cb94-45ee-b024-57e1f86ba883"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a6c3246-e723-41db-bc0d-944d5aaea79d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a9515ca-f451-4ffa-8748-b6d256463981"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b1456c0-27e3-44e5-b2a6-6c982688aa45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c9f84b3-8886-4320-a5fd-d24d5d2b64c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1cd07ac7-1712-4ae1-b8e7-cb38af6937a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d8e15c5-a3c7-4c4b-a0ce-7b48dbcdd352"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1df34348-e096-4ddd-88cc-089e3cf0e8e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ed60272-a370-4c3f-9804-27a0f038446b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1fb51e0f-7f5d-40df-b8cc-a3feb437e5bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("209d1773-9648-4daa-8625-84a907046aa3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20d7f304-6b31-4c63-9f0c-bbc2c7d0109c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("215db5d4-282b-4741-9eaf-157c11731805"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2185e379-2788-4792-90f8-d98e96aa4fbc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("221b1135-fd11-480e-9a8d-e587083d054f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2329cd38-66a0-423e-a815-61d1d4215766"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2358c8b9-c3a7-4dfe-a391-1495327b5e95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("249acb35-1062-4777-9c97-438cbb53c4fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24e14136-d63c-41a5-8ce1-b3a91578d458"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("264f52f0-da26-4d28-b175-40fcc1cf5020"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2866c0d8-a784-4019-a4d4-2439756d484e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("294a1992-864f-42b5-ade7-059ffabcdbb5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("29ff579b-be97-4b42-a188-8621b3f8355d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2aae7465-ea3c-455f-b623-0052f8f1fd26"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ae3bc3a-d2ef-4d60-bf4d-aac104dbaaf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2aee9843-ebec-4495-990c-aecbd94ce342"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b38cf54-05da-4616-bdbf-b91ee27a036e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bc9d71b-3e40-41eb-8623-92d6503c5838"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c5ed516-c63e-439f-ba00-b6c860311172"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cd6e191-13cd-43a2-beb3-ba8f7b89bd0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2dd4bf29-d587-4ef3-913b-ea492ebac8a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e8b6c2e-a664-4b14-ab84-6c54bdb14e2c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31d3a994-64d4-468b-ae28-bfb754aa3260"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("31d43fdf-0935-485f-8b33-52ae9da97986"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3203638e-2e9a-48ce-96fa-318d248a5a86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32b3a442-17ca-4daa-a1b1-a1ce5d4226de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32f389ee-d0c8-4078-bbcb-6da3b78d9aad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32f4254b-abe2-4a59-ac8b-d8c161a809d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32f6a05a-6b77-43de-9f9f-2560ebc75a60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3376a52e-f746-49be-9798-8885161aedff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("340fbaef-2852-449a-8ce6-0a0986da9634"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34d8663f-a4e4-4c50-950c-12a4bbb625f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3597193d-b7c8-4306-b838-fbd4c95df76e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("395fb6de-a595-49d9-8a99-b95540531b25"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a26569d-591b-49aa-aa62-c60623db1d1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b94183d-78a2-4dcb-80fd-6949f6a92cc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bd881fd-2ed2-4b31-a442-0aca43890567"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3eb90adc-65aa-4cbe-9dc1-5953c44713b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f5c17bc-275b-437d-8683-1778fd15fcb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("416b6e1b-21e6-4fd4-bb77-81d1162db949"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4586c036-e84d-4b14-9b38-b4bed4c6d76e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45d4663e-0e68-43ad-bfcc-f6a17fde5e9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46d85339-e7c2-40ca-8e38-ba46dd19a881"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48f5bdc3-3b15-427e-b0e4-06e5d461667c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4aba4bcd-bc04-46ad-88f1-443a3d0c7127"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b5653c9-5427-490e-9cd2-989046b98f43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c93f1b0-dbcd-4ad9-beae-ec2f47b354bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d59e2b7-363a-4710-ad35-00f7164734fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4db3f927-bbdd-4765-bccb-4109cda20688"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e854a37-9460-45be-aea9-a95a20929f0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ea38cb1-6314-475e-89e8-9429caacc688"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ebb03ba-3303-41c7-aceb-c7bbba3918db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f08eace-b92e-4b0c-bce6-1a0e6b7820fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fedb4d5-1de2-49cd-9901-642cf87bdb3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("502017f9-f1fb-41d0-891c-a182e880586f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("511a7878-c8d9-4fc3-92e5-c28822a6439f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5146a4b1-4db1-4cb6-8925-b7f8639dedf0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("514cafc8-bee8-4a03-a868-e40a1bb063db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54233085-b0b5-4a7f-b80e-a1385c94d1f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("546f072d-c1a2-4cda-abcf-588e3af8bbf5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5471da5b-e4bb-43bc-a7aa-6592c8d40815"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54fa7808-d74a-4115-adb6-248647068a3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("554ea3b0-8c73-433d-9d30-3892f06b0933"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("567b14c0-783b-4a92-a1d2-06398ab635f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57128d1f-3ff8-4c91-baeb-45e73fcb47b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59344681-70b9-424f-9da8-dc02bb857aa6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59f170b3-93af-4701-9f68-7c0b2d403c01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b995ec0-fad6-4ba4-86a9-d84d28442ccb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5c9b4032-8dec-4c60-942a-d2cdf48d69f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5de89bae-8fe0-491b-a511-92563cb29dab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e082451-e65e-48d4-9049-4882eb8585d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e18c728-564c-45b0-a56d-058f146032fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f2270c5-6157-4dea-8184-844662d760db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("602862b5-879b-4c23-85d6-49f8abde4b44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61e1320e-067b-40fe-b803-39bd9cd6d888"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62837e09-b5d2-473c-9c17-30632547bda1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6395a2a2-a7b6-48e7-ad39-da788e146e6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64faeda8-4204-468d-a899-d34aeb86dca0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("650e92a9-3aa5-4ba8-a947-9dc348c782c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65a284b6-7d54-4db3-8434-eb589d8e0a0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65fa6437-2c13-48d6-ac40-d590e00be46a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68bfa52e-687b-4d0f-aad9-b353492d6ec8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("690eda91-7abd-45df-9615-4c31ca2a2cfb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b22464b-c6d7-4037-9aa0-285aebdc7f44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b22a652-0a5d-4330-8ac9-d2a18c07ea0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b9b9a34-9ff6-47ec-aa15-f1a8b5e55960"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c0c680a-7964-425b-b0ed-f01ece09a456"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e304fa6-d7b5-43b2-bed7-2e9c1b066ff8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e36f5d4-557c-417e-bdf5-2a6a73d54953"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("709f911f-a968-4125-835d-ffe4b4b98ecd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70a6a4df-d7dc-4a34-8ba8-a5ee75a853d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("718e63a7-2f4f-4a33-a612-fb3b33af7559"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("724f8bf6-fe87-43b0-882c-e53d0a7939b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("725d5aa1-b2c7-4367-a346-a84d9add12df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("725e09ea-97dc-4692-93c0-9344d5179141"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74351f15-1cc2-4fe1-b763-dd00f446c12a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75246b6a-7f64-456e-8211-1405ebeb208c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75f24b5a-0e18-4674-8eb5-28c62a2f8a42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("780bb2d4-01fe-4056-823d-5afd53ae3481"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("783b092d-731f-4291-82e0-960e6be33fd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78cd4754-1534-48eb-96af-26d0a07671f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7afe2599-3618-451a-b48d-20ef65c69699"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7be03017-81c9-4250-adea-08a87d7ac073"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7eb502df-8647-4153-876b-50bca0feb6fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f464736-eff5-4de5-acc4-8a4aae5c7f03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f5bcf75-1fc7-436c-ac3b-5bc9890db3bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81fb14fb-0722-4fbc-ae30-bdb28615260c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8360c0cd-7d3c-43c0-b28e-26417aac8afa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83d3004b-0518-4b3e-b413-2febe1d92957"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("845903cb-cfbc-46b1-ba46-26f144aad291"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84763256-7150-46e9-b5b1-e6cb583e48cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84e529ca-bd6d-4bd8-a93c-df12bea40322"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84e9dddd-bdbb-4de1-bdd9-acbb35980697"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85cbdb71-9813-4484-a043-6d5146454d2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86216c8e-041c-4ddd-ae57-b35bc2b31749"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8677522a-ad46-4ba7-ae8a-72da3fb3f172"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8736e70e-d5e4-49c1-b653-2e918d3c6a32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ac6d5d0-4e0f-4932-add9-e7487718e5ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8bf4d337-fd32-4cf6-a475-739546ccd293"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d0bed17-50ba-48d4-ad02-d8e4f1663481"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d62541c-eee5-4043-9e51-b30a2ca29b9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e730d04-d424-4bd5-b8e3-3e2a3daa2015"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90de9b53-fa5f-49ee-ba02-1c69aade3a45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("910c52cc-4dd4-4d79-a19b-30d167af1ba8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9190e247-9d8d-498e-b9f4-6889b69aee57"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92a667e5-00ce-47bc-8f7e-e01e6cad4d15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92e59758-1efd-485c-b7a8-8a50ad9d18b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("946ebe00-c4da-4db6-8c0f-f8d044f987ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94b58af9-ad5d-43b8-b012-040399a81d55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97832fdd-72d4-4930-9619-6e65a7ff2ca4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9821eba8-241b-4c09-b085-19613e4853f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99238e0d-e33b-4848-ae57-bde04bfe43a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("999f6fd5-53ab-433f-91f8-487a16176c21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99e7c724-209a-4f28-905f-844a2cfe45ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ab3182a-bd85-44a6-a9fb-ab6376d820b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9acf3af8-c5eb-45c0-af2b-c9cc00e0e6a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b8575d7-2c01-485b-8ba9-fc40f8308c16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ef3dce8-20fe-4449-9da2-62354c0eb1a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a051a374-b603-435b-a1a6-a42e77f05a06"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2d1af8e-1424-4bc1-9a27-b2d6e7d818c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a479208d-9682-4cdb-ba83-330bcdc137d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4f29ec3-8e74-4653-ac69-8d64d12768bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6ac9307-2881-4dd4-a194-ee696cae4fe7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7c5698b-e452-4092-92b8-47123d3aa849"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab3f616f-3edd-4b79-80aa-a9700e2b71e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab6a7ce5-f139-4b6a-8266-d9e183b2c152"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abaa4eff-41c3-4d9b-821c-2cb939de846d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad17605b-0423-4e19-93d9-74452c1e00d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ada29700-eceb-409d-8a81-7dae63c9a1c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aeff94e8-ef3b-4a85-91f2-3349a45d1c88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af428d6e-7811-46dd-a704-6c29b79b2337"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1590fea-5433-4364-a6e9-9c06db8d043a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b16d176e-3791-4d79-8a28-39aa404e6d79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b29936af-36b9-4278-8f3c-95b7608d8cca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b352b12e-36aa-4b1a-9c5d-eb425348e6ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5d35a90-37b5-40dc-97f5-f65a79314bcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8d28c88-0cb1-4855-974d-c0cc0f999a1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9635b71-2084-4ad7-8537-8fcbe344ccd4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba6921a9-2812-4606-ba71-0f97731ef36d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("babf2c01-91dc-4935-a57d-b6f3880550d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb6dd75f-95fb-47c6-9b94-670f01f5b44e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd3ade66-821f-4b56-90b9-4cb3a0b958e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be1f6600-5689-4a39-a172-ef62a6af953c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be2dd774-7704-4e9c-a3bf-291420c07809"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf0682ad-d81d-464f-ac90-6e86a954b01b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf6af70e-77a6-479c-9549-628a2bc15dd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0eb93b9-fcca-4b83-ab01-e43dd1a914e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c169f3d3-c5bf-4f2d-890d-56a38af8b188"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3348430-7881-40fa-8c21-9d36f920c413"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3befd58-b7c2-4a45-a04a-d09e5e75241c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4d82628-28a9-4c98-abc0-fcddbad9bfcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5650dde-1787-4935-b09d-13d1db0e48dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c566cb76-a78d-423c-8a05-89a3b8904d9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5b5a70b-abc6-446f-8d9c-c44e7181a425"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6125b6e-87ba-4b64-9cca-c492f18c0730"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8d279bc-cd68-4186-b7a6-d8dcea1fbecf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c927254b-8e33-43a2-ac03-1d19bdc128da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9ebd9ed-12f7-4844-9abc-51f349508577"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca441910-5da0-4535-9141-5bdd7830e57f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca748afc-898f-4a51-9430-66f9fc47aa76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc710dce-1b23-40e2-8556-964644e2035b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd805de8-809c-4534-b9aa-819fa405ca5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce487146-4a3c-4832-9c03-65048b2131c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce5525d0-2706-426f-b140-d7b7fd22358a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce5aadfd-de68-4f4d-b80d-83a11d0ee23a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d24ef46f-a51a-4c1d-a27c-8691e3212886"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d450c7ac-063c-439f-8ecc-0f74b1d1b941"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d50c025f-9b43-4d82-b9f1-82780b778eb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5e4d67e-96b0-4518-a7dc-dad60b1bbbf8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d67178e3-1e97-4588-aabd-cd22640b958f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d959d5a3-bfa8-4222-a67d-e9c222b7ce28"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9a0553e-a29a-43b9-a987-266b3a5e9cd0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db633429-e985-4812-969b-c0d7403b724e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbdd260e-1ab6-44bf-9526-08f93d718f16"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc9bb667-9825-4039-9618-b63b5b8bd17a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd497af1-5b2b-43aa-bf6e-9ef65fb6debd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df7fc3d4-24b3-4d85-a93a-0ece11a7e8a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e090027b-a00e-4cd1-8907-0d4d344dce70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e0c1184a-8128-4f04-8ccf-52afddddf303"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1756edb-2a4d-4d7e-b649-bf296455948e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e19c7336-cfe8-43f8-947a-8e5951e07335"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1ada6ce-8132-4769-8553-ff8d3e4b9084"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e246ee72-f3e4-4d74-b4c4-0b8b83239ab8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e47784fd-d07a-4990-9aaa-bd1d76a7de9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e66f984d-364d-4ea4-8f89-ebf67d01047e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6fa656f-3998-413d-9bce-c1bb0870aa2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e80d2669-511f-4f69-a16f-7bcea33fc249"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e822b620-1543-40e2-9e4c-bf07a4b26822"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8bd007a-ecc0-4a0b-8279-187904beebcd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9ef8d93-ca57-4326-9bff-b0af3424ede3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea55ef1c-172f-431a-8125-0c88a978711f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb6077e0-5065-44cd-a029-eec737a088b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed9680cf-a43f-4d92-843d-85475e521d85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee51284c-cf5c-4564-8cd2-ce6ea2c07415"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee77c4d2-a371-426f-936b-597bc2946607"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef8e5353-d525-4cbc-8187-58391b8a8201"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef9ea9b5-fa52-4bf2-8ae7-26a9d09da17e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efbfe94b-6e59-4690-8132-1a1088c459af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f01075f2-8f11-46d6-a0d0-0af13505a30d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f012c342-75f6-4698-9cd9-ff1a4615dc05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0275619-7af4-4136-884b-1e1f4cc1d95c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f07395dd-8221-4510-861d-751d85b94a2b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1c632f0-10c1-4caa-b323-9aab8f53465e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3717b77-c225-40a4-a1a4-f34c2db61221"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f44530af-459c-4431-aee6-55bd938b4c63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f56c76a0-ff11-4e19-b901-fe18b612aa02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5970877-3a11-402c-9cc7-f5bcfadc50c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f99a2270-e49c-4f1a-b905-90105090549b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fad2c712-c744-4720-b0ac-8ad29b12be60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc2f5708-ee70-4dc1-a747-6154ad6f21ea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdf5326a-78c4-49ce-ab15-b627e04de8c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe655877-1272-481c-a664-f37e58f20e3a"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("27682abe-8423-4ce2-bc88-194f7bafd94a"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("755999d9-15d2-4592-bda6-6f34b9f37dbe"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("d0640f1f-2f2e-4bbf-ac5d-f9bc7915dae6"));

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7b34ae4b-e62f-4fcb-a9ed-a85063ac1189"), "Productor Ejecutivo" },
                    { new Guid("6da3e38a-a5ee-4af9-8d32-9733e8097ddf"), "Técnico de Sonido" },
                    { new Guid("fae7cdce-365f-4dbe-8670-4a3ef202b8ae"), "Diseñador de Vestuario" },
                    { new Guid("65a936aa-9ce1-4c83-a328-355406017839"), "Guionista" },
                    { new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Actor" },
                    { new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Director" },
                    { new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"), "Productor" },
                    { new Guid("f670e960-cfc1-45da-9483-a882d24b8256"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre}", "1999" },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f9021ba7-04a3-4fd1-b264-d47e38b7d6a4"), "Erótico" },
                    { new Guid("e813597c-5b2a-4fcc-8ce5-0f3b8df02d8d"), "Musical" },
                    { new Guid("c495322f-d153-4d8d-8fdc-e7c61d036226"), "Aventura" },
                    { new Guid("3a349cf2-4957-44b3-b0cf-4ddd982a6157"), "Ficción" },
                    { new Guid("bf16b858-84c9-434b-b4ce-05b1f905266d"), "Documental" },
                    { new Guid("3da69ea0-63d1-43dd-b21c-66913c1f0888"), "Hístorico" },
                    { new Guid("5f20c8b2-c09e-4ece-9a7b-add2d74079de"), "Ciencia Ficción" },
                    { new Guid("3fc8ef17-5cb2-4a23-96ea-0dbe48eab391"), "Terror" },
                    { new Guid("eee0a661-86ee-4375-a488-7274433897cc"), "Suspenso" },
                    { new Guid("5e76a5e4-2b44-4642-8545-e5e0fa5acd48"), "Romántica" },
                    { new Guid("9dbf95da-76f2-4f03-8d1f-d665f25894fe"), "Comedia" },
                    { new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc"), "Drama" },
                    { new Guid("c385fe14-bdbb-4f27-b8a9-db78636143ee"), "Tragicomedia" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), "Platea Baja", 10 },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a45da717-ff84-4e52-965f-551808807281"), "Sala 1" },
                    { new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), "Sala 2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("99ebafb6-61ec-4a22-881a-cc1191339d5a"), "C2" },
                    { new Guid("4cc7ae11-3487-487b-a6f3-dbc956a854a3"), "C1" },
                    { new Guid("3dafb1c0-df8e-403f-b441-658449f87e3e"), "B3" },
                    { new Guid("9e157974-cc7b-4c39-b528-2c7c94d0430d"), "B2" },
                    { new Guid("4d7341f4-4571-46b7-8ac7-6b67d140af21"), "B1" },
                    { new Guid("8c52baf4-b5c3-45c0-b017-57efe31ca1dc"), "A3" },
                    { new Guid("6c71e427-86fb-4af6-bb5c-d9ebfa040797"), "G2" },
                    { new Guid("a877204c-5b6f-4d60-9820-60b43adb34c0"), "A1" },
                    { new Guid("370cd6a7-967b-430e-af37-b6bb1f91a894"), "H2" },
                    { new Guid("a07febfe-b80b-49e7-a36d-e45f18c78ed0"), "H1" },
                    { new Guid("6f73f930-baf0-4e19-ae18-3fe30e92c050"), "G1" },
                    { new Guid("575d6a4a-900a-489e-bb55-b1a3f708bbc0"), "C3" },
                    { new Guid("244ff7d9-5b58-4c15-8c46-fa67666297b1"), "A2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("ba247d83-c39c-4428-aaac-2afb623e775e"), "D1" },
                    { new Guid("d4e01fb4-ac66-4f68-a28b-72c4b66d2b3f"), "A1" },
                    { new Guid("d52263f5-ce69-4cc4-bf0b-d47566461a97"), "D3" },
                    { new Guid("24101bd1-2a53-4a72-96fc-41280e6b512d"), "E1" },
                    { new Guid("a0b194a5-e8e6-4d96-97f3-cba0d918f09b"), "E2" },
                    { new Guid("2d436f74-8db0-49c7-aa33-2d8e08c1f094"), "E3" },
                    { new Guid("1871dbcb-b2bb-437f-991c-0a0b2148bc46"), "F1" },
                    { new Guid("844a53f1-af9f-48b4-aa82-45192d7d0c46"), "F2" },
                    { new Guid("9907c0c7-165d-4f8a-a6b3-c47fa69b3023"), "F3" },
                    { new Guid("2cf58beb-b675-449b-997e-cbc32bea9d88"), "G1" },
                    { new Guid("a128f2d2-a218-4a14-ac68-692b1d387106"), "G2" },
                    { new Guid("edbe4a72-21c6-4886-997d-c1af8cc55b4b"), "G3" },
                    { new Guid("dec0a4c2-5609-41d6-a2e2-f80a27afc3a0"), "H1" },
                    { new Guid("e1f29c5c-08c2-4273-b981-d6249cd3d460"), "H2" },
                    { new Guid("785b03ae-06e6-47c3-94f6-e250309cb04e"), "H3" },
                    { new Guid("ee808d18-5f9a-4d84-a6a8-fe2ce47bfce0"), "F2" },
                    { new Guid("2054bd72-67b1-4578-bc09-0374c144711a"), "D2" },
                    { new Guid("30e87983-e9be-4b8a-b1e0-75a89f2ad7aa"), "F1" },
                    { new Guid("c4cbce54-9219-45e0-9d76-618778d7d291"), "G2" },
                    { new Guid("e6368075-91a2-4c31-ab5f-9579bad574bb"), "E1" },
                    { new Guid("b0279fbb-a07c-4bcb-8d48-a7581bf8f38f"), "A3" },
                    { new Guid("10672adf-5d7e-45d0-969c-2957d26d91c9"), "B1" },
                    { new Guid("eea054dc-c6b9-4620-a762-7cadfd196f17"), "B2" },
                    { new Guid("cba0188f-a52e-43f5-bb8d-e4e7d52e7acb"), "B3" },
                    { new Guid("00432ef2-088e-43a2-8baf-b186bfd84b7f"), "C1" },
                    { new Guid("f67046a1-c288-4f8a-af24-11cdcf1c09be"), "C2" },
                    { new Guid("8403b7fb-cc20-44eb-af2b-253181ba149d"), "C3" },
                    { new Guid("f0e780b5-95b7-4b2d-9f28-74c694ae865b"), "D1" },
                    { new Guid("442391a4-62fb-429a-8f51-70834c7b8503"), "D2" },
                    { new Guid("afdce0a2-026c-4035-87ef-2392a4e27ad9"), "D3" },
                    { new Guid("4ea6b390-45a7-4053-8ec2-45126c5c35df"), "E1" },
                    { new Guid("c98b80e6-9df1-4509-a74f-1e1611cf48bd"), "E2" },
                    { new Guid("4fcbf7a1-ae8f-4c38-8f71-330ef9b20bc7"), "E3" },
                    { new Guid("1b5fb473-8195-4412-a4af-186899e70876"), "F1" },
                    { new Guid("19406d11-30ec-4881-afb0-a09491cb4333"), "E2" },
                    { new Guid("2c284d80-3342-4f30-9887-d5142753ac84"), "F2" },
                    { new Guid("63d27235-79e8-473c-8023-7ee264bad0e4"), "G1" },
                    { new Guid("ef3be4d6-d570-4eeb-b1b7-120bfcd3f000"), "B1" },
                    { new Guid("9281c7fa-b385-4c03-a90b-6b07aac2a3b2"), "G3" },
                    { new Guid("f4b25cb6-abec-4ca2-9560-94044a0c2875"), "H1" },
                    { new Guid("edd279be-70d7-4489-93e6-128044438138"), "H2" },
                    { new Guid("a46b06e0-b27c-46e5-b46c-277ef8fb1322"), "H3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("6158a7b7-405c-4541-a60e-c697cbc00e40"), "A1" },
                    { new Guid("abf866af-ad40-4785-99c4-89d85408054a"), "A2" },
                    { new Guid("551cb569-3e50-45f5-857b-bd278c3243d5"), "B1" },
                    { new Guid("e9941d54-e792-47ee-b2a8-11b124762b7c"), "B2" },
                    { new Guid("7646058b-4555-401a-bf5b-2db32d222b56"), "C1" },
                    { new Guid("7296d736-9182-4c87-aa38-527c26a30adf"), "C2" },
                    { new Guid("17fd0d2f-452e-40c3-bbce-18cb0dfef214"), "D1" },
                    { new Guid("34722c4d-3ca0-4e82-aafb-ea9df94c3b77"), "D2" },
                    { new Guid("3616171c-65ae-41b3-bd24-29d03a250de4"), "F3" },
                    { new Guid("7b88df97-e1e6-4c80-9194-deba186ac065"), "B2" },
                    { new Guid("0133e8e7-decd-4b4b-a148-ece9dc780b47"), "F3" },
                    { new Guid("7a449214-90d2-4d76-b504-745491be7686"), "C2" },
                    { new Guid("182d85a6-8797-4243-920c-07f3786f5c2d"), "D1" },
                    { new Guid("8ec7a52d-2504-4b36-bb34-cb2161874b1c"), "D2" },
                    { new Guid("0dbd79b8-90bf-4bc8-a89b-8d9fcb247ad5"), "D3" },
                    { new Guid("23cf0c91-d52e-4dc6-94c6-acd45a2e0953"), "D4" },
                    { new Guid("09b5cce1-938a-4f20-8c67-c4042ef47f10"), "E1" },
                    { new Guid("2868e558-fd55-48b7-8719-b51842fa37cc"), "E2" },
                    { new Guid("65754412-17f8-46f9-b52a-1fe292ae66b2"), "E3" },
                    { new Guid("70f57103-9f9f-44c4-947d-1fe8c48282ee"), "F1" },
                    { new Guid("fdd5aa0a-b920-4e61-b0a2-5af241d6eadf"), "F2" },
                    { new Guid("4415688f-d35b-46e5-bad5-34f657a9ffdf"), "A1" },
                    { new Guid("7729e4b5-da1b-4e38-92fe-d51356cbdbb7"), "B1" },
                    { new Guid("a2ec14d2-7b6a-40d0-97c7-4db1cdf810e6"), "B2" },
                    { new Guid("f6a41e30-380d-4183-b172-b6bb18be1ffd"), "C1" },
                    { new Guid("03143780-1c95-4d64-bf14-a6dd507c0edf"), "C2" },
                    { new Guid("6352a14e-818b-4879-bd6d-5e4ac0761402"), "C5" },
                    { new Guid("65e5c79a-5f8c-4828-bb15-73abc66e39a5"), "C3" },
                    { new Guid("8e629068-722c-41bb-9534-816235f1e78c"), "D2" },
                    { new Guid("3fbd66e3-ef43-4174-ae5f-213639c18972"), "D3" },
                    { new Guid("7c25c2a0-5e37-4ca0-9eeb-8fe3eb516afd"), "D4" },
                    { new Guid("369121fa-31a6-4960-b321-2c9950b21bae"), "E1" },
                    { new Guid("58307a0f-ec77-4a5c-ad81-8a221a560390"), "E2" },
                    { new Guid("4cfb293c-dbd4-4639-a7a7-940d8a951ca4"), "E3" },
                    { new Guid("94919cf9-f4c9-4bac-a367-2e7a489d2485"), "E4" },
                    { new Guid("b368360f-7dc8-4f84-903d-a997efbef40f"), "E5" },
                    { new Guid("dc47df41-9d47-4696-8787-9c7e4713aa3e"), "F1" },
                    { new Guid("3d8f50a5-c34f-4ca1-a6b5-e2305e8d2f3b"), "F2" },
                    { new Guid("150a96d3-a322-4a20-88dc-7a2ba8009f35"), "F3" },
                    { new Guid("1e721155-7dba-49e3-a6f4-b3b99eff44b7"), "F4" },
                    { new Guid("8237cc30-c12f-4188-8ef2-5c9c60afe9b3"), "F5" },
                    { new Guid("78dd8376-a0e6-43d2-bcb5-c21574f3f5f2"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("f193b70c-a067-4c4d-ac65-92557ee0ca7e"), "D1" },
                    { new Guid("80046ef2-ded1-43ea-a6bd-3a59b7c848ac"), "C1" },
                    { new Guid("a8de2e4d-21f1-43fc-9257-779eca04133a"), "C4" },
                    { new Guid("bdb1b465-e7c3-42b8-81f0-a3e310a65197"), "C2" },
                    { new Guid("08c8683d-d0dd-4997-83c6-92784edab4f1"), "C3" },
                    { new Guid("97c8c104-b7f6-4786-ab22-4d8ea7ba55b1"), "D1" },
                    { new Guid("db4cd2c4-d3b1-4422-8190-f4788cc60e6c"), "D2" },
                    { new Guid("2559cfbe-f89a-4b84-bd9a-2a8de3bde292"), "D3" },
                    { new Guid("6c365ffc-9e77-49a3-a62a-91dc63991b13"), "D4" },
                    { new Guid("b1a73ebc-fc7f-428a-9b02-1c59005bc4f9"), "E1" },
                    { new Guid("d862a774-8fed-4788-a468-04ba89d39103"), "E2" },
                    { new Guid("233bff50-9ba2-4bdc-ab7c-0a2677d60019"), "E3" },
                    { new Guid("5a1ead09-6a16-478b-bc31-64dacd0b04b4"), "E4" },
                    { new Guid("d2f0bf3e-34ec-4ce1-b9bd-24f0365e2760"), "E5" },
                    { new Guid("b5c68b7f-fc6c-40d8-96cd-0d0328693a3c"), "F1" },
                    { new Guid("7f5b9f88-2b39-406a-94fb-1512ef84025a"), "F2" },
                    { new Guid("5dfc5b03-2e0a-462d-8db7-a1417554eb62"), "A2" },
                    { new Guid("d9190a4e-489a-4ad7-9187-bd5d44cc49ad"), "F4" },
                    { new Guid("73917595-af22-42c9-a781-509efa65fd1b"), "C3" },
                    { new Guid("a5cb3161-11dd-4e6c-b2c3-1ef368e182fc"), "F5" },
                    { new Guid("6c5e6340-4da8-49af-8920-a67f16ee9081"), "A1" },
                    { new Guid("91921245-9c34-449b-a66f-ee2e6e9df209"), "A2" },
                    { new Guid("28cf4d2c-8f47-49ac-921f-667cb7cb604b"), "A3" },
                    { new Guid("c9abfcf4-331e-44d1-867c-72785440386f"), "A4" },
                    { new Guid("5e0b67eb-b276-4339-b6da-221224d165b8"), "A5" },
                    { new Guid("37a092ee-e5f4-4cc9-9cd6-11211119dfc1"), "A6" },
                    { new Guid("7db80942-d91d-4502-9641-e3d0fdeba707"), "A7" },
                    { new Guid("a5c871f8-99d5-42aa-8067-2fb7c8f1a1d6"), "B1" },
                    { new Guid("7c122bf2-8edc-4526-aead-0eefb1ea28ea"), "B2" },
                    { new Guid("b377cb28-c123-4c8c-95c1-d90683967df3"), "B3" },
                    { new Guid("4e874e00-ffa3-41c2-877e-4eca7ae8b218"), "B4" },
                    { new Guid("ed8c0e8f-d956-4ffa-a9b7-e18030113f14"), "B5" },
                    { new Guid("40e323d0-ff33-492e-b6e9-f52b58efc79a"), "B6" },
                    { new Guid("27613d9e-a87d-4858-8452-722d3ce0ff5c"), "C1" },
                    { new Guid("60a79ecd-e961-4397-80b7-50e104796d2c"), "F6" },
                    { new Guid("d825af1e-9fd5-4c20-90b6-4da954df94e7"), "A1" },
                    { new Guid("0605f8a2-1f67-4b50-bcc5-d02da74a6ea8"), "D2" },
                    { new Guid("64294ee6-6915-470d-936e-a3256da9ab32"), "F5" },
                    { new Guid("1059fdd7-6fe4-4545-bcb2-8399b86cfb79"), "F1" },
                    { new Guid("ccc7c81f-0228-4d0f-89f7-f1202a41e172"), "F2" },
                    { new Guid("d1a04c09-13bd-4cf2-862b-00f9eb37b4fb"), "G1" },
                    { new Guid("53ab115c-4459-44a2-b0c0-bd84fc9e9e38"), "G2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("facd1e00-3333-4153-9f68-2c15aeb238bb"), "H1" },
                    { new Guid("4df50643-ede0-4354-9aa1-2c61c827588f"), "H2" },
                    { new Guid("443dc906-743a-468c-b437-4c9ef7b5e979"), "A1" },
                    { new Guid("6c429853-32b4-4644-a544-b4cb886d4b0a"), "A2" },
                    { new Guid("643511ee-d36a-47bc-9d54-b619f9125171"), "A3" },
                    { new Guid("69b364a6-6227-438e-b40d-31b610795f6a"), "B1" },
                    { new Guid("6efb5a9f-0cad-4d6a-a989-a7326ae81e34"), "B2" },
                    { new Guid("2e95a812-f5bf-4873-9ba1-a027b2ffdce0"), "B3" },
                    { new Guid("3aeed818-b994-4aba-bab7-edd0ce9d907a"), "C1" },
                    { new Guid("e6a2f8b9-e36f-40b1-80c8-970ed5f7caed"), "C2" },
                    { new Guid("f0fffe19-e1b7-49d7-9266-fd52d985f145"), "C3" },
                    { new Guid("2c83dbd3-2fe5-4bd9-bc12-94689cac1ae4"), "D1" },
                    { new Guid("ab2298f8-0f1f-478b-aabf-84fe9f8dd351"), "D2" },
                    { new Guid("fb6358a6-fb27-4a35-96e8-1bb2a3ed8a7c"), "D3" },
                    { new Guid("721b55fc-2659-413b-a330-0134fecbd996"), "E1" },
                    { new Guid("c3d03cea-5f2e-42aa-9f8d-5519c7b94ad0"), "E2" },
                    { new Guid("5bb35ab7-741d-45e1-bc11-9e04fc97e81b"), "E3" },
                    { new Guid("1f8a5589-4e4f-43b0-9289-1bcca848505a"), "F1" },
                    { new Guid("388e143b-e5b6-469c-bd55-e7d2a1ba4589"), "F2" },
                    { new Guid("a895efc0-7d65-434c-b89a-a5dafa041190"), "F3" },
                    { new Guid("bf94fbaa-f3c9-423b-b866-3b4d84da6087"), "G1" },
                    { new Guid("5eb19684-9cc6-4357-9ae8-adede88f6be7"), "G2" },
                    { new Guid("b79ef6de-4756-4a18-ac09-174269fae8da"), "G3" },
                    { new Guid("6d8cbc67-721b-45e9-aed2-d08708a0e6e4"), "H1" },
                    { new Guid("721502e5-49ff-4be2-9e97-145f656c647b"), "H2" },
                    { new Guid("6b3fbbd9-00e7-40d1-a9e1-c92c16dbd5d6"), "E2" },
                    { new Guid("9ce12b09-bb74-4000-a566-f09547c88a73"), "E1" },
                    { new Guid("d84bca31-bb8a-4920-9f29-843f7e768ef0"), "D2" },
                    { new Guid("3c0dd811-7d45-4b42-bf63-a9233b1a7982"), "D1" },
                    { new Guid("d151d233-5dcb-4e8d-ab9e-efed54ad994b"), "A1" },
                    { new Guid("a3760256-d899-40bb-8581-a4a3ae30189c"), "A2" },
                    { new Guid("e26a29ea-b77b-4d7f-bdee-c42a9e235af2"), "A3" },
                    { new Guid("daf97bd7-e20f-4396-b0f1-b26f18fc0d20"), "B1" },
                    { new Guid("193bae54-71ba-4010-a5b6-8f81ae753b3b"), "B2" },
                    { new Guid("d36022af-3f82-4369-8c68-da77339369b8"), "B3" },
                    { new Guid("7f954ec2-39d9-43e8-8fe6-4f11572471ac"), "C1" },
                    { new Guid("035e3b7d-5bae-4f2e-b3ed-d11b54a95427"), "C2" },
                    { new Guid("181dcb03-4eac-4253-8615-111d1155c1ca"), "C3" },
                    { new Guid("6faa88f9-e28b-452d-a1b6-7cae2275b1b4"), "D1" },
                    { new Guid("77ef747f-c3c9-4e53-82ef-04098c26d07e"), "D2" },
                    { new Guid("61868607-e76b-41e3-bdd5-f2083e7ebd1b"), "D3" },
                    { new Guid("5a8362b8-2961-4dc3-93d9-b73f9760a550"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("91889ae0-0cfb-40af-a66d-db920d53106d"), "E2" },
                    { new Guid("8a4c0c92-d0c8-4644-a595-affc1b5b26aa"), "H3" },
                    { new Guid("1e40e6c3-b015-4a7b-99dd-498a64db1f5b"), "E3" },
                    { new Guid("af5c55e9-1ba5-48a5-bf30-251edf20ad01"), "F2" },
                    { new Guid("cf1b0046-7f40-42d1-b5c8-193dd97505b1"), "F3" },
                    { new Guid("cbe1816d-a2d0-4677-b1ad-b2d117091aaf"), "G1" },
                    { new Guid("4f7bdc31-4ff0-4681-b006-f63517ad37b5"), "G2" },
                    { new Guid("7fad7ccb-594a-45ba-b8d1-febe9bc9891c"), "G3" },
                    { new Guid("fb26fbc3-7e6e-4143-8f61-941e0942e55a"), "H1" },
                    { new Guid("160317a3-80e0-49c8-a188-8cf893855463"), "H2" },
                    { new Guid("800094f9-b7a9-4f7e-8338-484908174ff9"), "H3" },
                    { new Guid("bd281f00-3a81-4fc8-be80-c928b2eb8a7b"), "A1" },
                    { new Guid("caeab8c2-c328-4a65-93cf-f46fc7bd3cd5"), "A2" },
                    { new Guid("d138c33d-1571-46b2-a8ec-12a3fa3836d3"), "B1" },
                    { new Guid("8828fb88-50f3-49f9-af47-4073a5ee0de0"), "B2" },
                    { new Guid("7469d933-78b8-4aa3-a0eb-274c4ab30295"), "C1" },
                    { new Guid("9433e939-ee17-4586-a5cd-88f38246606c"), "C2" },
                    { new Guid("0b779e47-bff3-45b4-9a65-11cea0fdad6f"), "F1" },
                    { new Guid("eb6641ed-9220-4129-9f4a-0b3499b8759f"), "F6" },
                    { new Guid("bac54cab-4cb7-48e5-8edb-66c1acb62a10"), "A1" },
                    { new Guid("026743b0-bbf1-44b2-9902-7749f1f1cd3f"), "B2" },
                    { new Guid("23a0649d-f363-4fe5-9261-3bf2c23ee4fd"), "C4" },
                    { new Guid("1713aae2-63cb-4fce-bc11-f0f2956c4cce"), "C5" },
                    { new Guid("4bb84527-6244-487f-ae53-dcc8f2eb9ab1"), "D1" },
                    { new Guid("97e7bd21-c58b-4b6c-a072-374d8548d28d"), "D2" },
                    { new Guid("48b33000-4d25-466f-8ed2-4be2c698e808"), "D3" },
                    { new Guid("ab44ca2f-1e6d-4ee1-a76b-6fd3158fb69d"), "D4" },
                    { new Guid("b142e0f6-c483-4b6b-89f5-4d746ca8464d"), "E1" },
                    { new Guid("e0b3bfdc-a678-499d-a8bd-739da9f7948e"), "E2" },
                    { new Guid("c7d660f8-f331-41d5-8ed5-90769fa09553"), "E3" },
                    { new Guid("c2ab188c-07f6-4a8f-9150-036c632c005c"), "F1" },
                    { new Guid("a41e3f2b-0b45-4a6c-8cc6-145679c6a983"), "F2" },
                    { new Guid("85fc36b9-acc8-4ffe-9e97-bd7598b80c95"), "A1" },
                    { new Guid("8670da08-cb23-44e2-98de-fd9fa39972e6"), "B1" },
                    { new Guid("1733e0c0-21ca-4b75-a90c-a94cf580ece4"), "B2" },
                    { new Guid("38b027d9-2bd7-4b5a-bfdb-ae2bfa1bcb68"), "C1" },
                    { new Guid("fed88963-2989-4d35-93c1-eaf390740ed5"), "C2" },
                    { new Guid("7cff8c31-e22e-4698-941f-5e34729ebe63"), "C3" },
                    { new Guid("f1c17a1f-ef48-47fd-9905-4fbbd7b91667"), "D1" },
                    { new Guid("c1f6ea87-2b23-460e-91ae-3e7e88eab785"), "D3" },
                    { new Guid("b23b35f1-9a07-4393-9a6b-2595303b2e9e"), "D4" },
                    { new Guid("6d3db07f-4d56-4f05-ac1a-0bee9f6a88fd"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("9b6db61b-a98c-4f77-bb0d-a86b7589751c"), "E2" },
                    { new Guid("480dc732-7cbc-40f5-a55a-c7c9b82676d4"), "E3" },
                    { new Guid("d1daaf9d-8f6c-4350-9b31-821d0369288a"), "E4" },
                    { new Guid("3cee8ac5-10e5-40f8-bba9-db62692741c0"), "E5" },
                    { new Guid("bd4c56eb-1116-4454-aed5-07e47e73eb59"), "F1" },
                    { new Guid("cc6914d2-4cfd-467c-a911-33c716d1b6b2"), "F2" },
                    { new Guid("0bb44680-72ae-4c4f-b42a-ac327806ef0f"), "F3" },
                    { new Guid("667415fe-1b80-4beb-93e2-84013a35b888"), "F4" },
                    { new Guid("b19cc3c8-4114-43fa-95b9-c098b3c68543"), "C3" },
                    { new Guid("f1c3a15e-e945-46b2-aaaa-6b0c6cda6c0a"), "B1" },
                    { new Guid("64927317-9cee-4fb4-adbc-ce7c9a5eb09a"), "C2" },
                    { new Guid("37691600-2f8d-45c3-9a0a-6b740242d923"), "B6" },
                    { new Guid("d250f083-d2d3-4658-832e-fe616ea143ea"), "C1" },
                    { new Guid("5dd2b23e-f5df-4824-8d29-35cd8971051f"), "C2" },
                    { new Guid("06315f81-28cd-4b63-8936-7c358fb79b01"), "C3" },
                    { new Guid("816a3b9b-8ccc-42dd-b444-eda0dae736c8"), "D1" },
                    { new Guid("34349ba1-953f-41bb-ad41-2b2fe2b715a1"), "D2" },
                    { new Guid("416f0e4d-4ffa-43c1-af54-d16f744d217d"), "D3" },
                    { new Guid("9394fac9-a801-4cc9-84b4-d24caac3bc68"), "D4" },
                    { new Guid("b8da3d92-84c4-41a0-a02e-64e5aba0e729"), "E1" },
                    { new Guid("9df37d62-7bb7-43e8-9fc2-98ec06d0d1ff"), "E2" },
                    { new Guid("1f6bd54b-c227-414d-90a4-2923eaa56f12"), "E3" },
                    { new Guid("e0c266a5-6850-4e6e-b7ca-c6ed43c81794"), "E4" },
                    { new Guid("389519cb-5bab-4b96-bced-7699dde87e0c"), "E5" },
                    { new Guid("e9d4fe2d-eb65-4181-9343-265474af7df0"), "F1" },
                    { new Guid("b2aa3b9c-c531-4489-b0c7-81529d07b17b"), "C1" },
                    { new Guid("71dc5e36-8ede-4d7f-b10c-ab4b3e7e74e2"), "F3" },
                    { new Guid("b50c4687-e455-4b84-9573-9d38defc6c30"), "F2" },
                    { new Guid("269a23eb-4792-468e-aafd-ed605ab1edb9"), "F5" },
                    { new Guid("0e0557c5-63e9-4f7d-a196-4898dd15561d"), "B5" },
                    { new Guid("00b9c31e-473f-4c6c-957a-84b2fa181b69"), "B4" },
                    { new Guid("bfce8105-3ba7-4db9-839c-01ce47a57e59"), "B3" },
                    { new Guid("0bf3518b-1b81-403e-9988-5cbe4effa4c3"), "B2" },
                    { new Guid("355069ba-2fb4-47fd-9ec4-2a4d231a5f85"), "B1" },
                    { new Guid("aee3b5df-1e8c-452e-9022-d0b177c0fb68"), "A7" },
                    { new Guid("efb20c2d-2c40-4a1b-a49d-49502bae1c14"), "F4" },
                    { new Guid("d1d15c68-6785-4b96-812a-009690d505b0"), "A6" },
                    { new Guid("8c2e7174-6c1e-4742-a443-e975b1392ed1"), "A4" },
                    { new Guid("6fbab38f-223d-4bc5-9010-a7e272bdb73c"), "A3" },
                    { new Guid("a7c6b4ec-6616-4cca-8c33-72b50145ffc0"), "A2" },
                    { new Guid("9e20262a-31f4-4a43-8e4a-d304a3c53db1"), "A1" },
                    { new Guid("4bcb44e0-650f-4308-8162-fead4e3454e4"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[] { new Guid("720371ae-ed2f-4b7c-9bef-a0af75a2b795"), "A5" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc"), "Sección 2" },
                    { new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d"), "Sección 1" },
                    { new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Cecilia Roth" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("fae7cdce-365f-4dbe-8670-4a3ef202b8ae"), "Mary Sweeny" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"), "Roger Avary" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("165c17bb-4990-44e2-9119-6dc05ef80ba6"), "Quentin Tarantino" },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Robert Zemeckis" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Quentin Tarantino" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "David Lynch" },
                    { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("50d0926b-89a4-48ef-8a4d-1c487eda5819"), "Pedro Almodovar" },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Robin Wright" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Samuel Jackson" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Una Thurman" },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "John Travolta" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Justin Theroux" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Laura Harring" },
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Naomi Watts" },
                    { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Penélope Cruz" },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("3749d1e4-adcd-436e-8f2c-c3ef03d68aea"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("7efdb4b3-875d-4d00-ab43-b01e1e01df84"), new Guid("eee0a661-86ee-4375-a488-7274433897cc") },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("5e76a5e4-2b44-4642-8545-e5e0fa5acd48") },
                    { new Guid("2eb8198e-d35a-475f-83c8-b746337ad8e9"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") },
                    { new Guid("7faeb1f7-21aa-4fe6-9d5a-931819a4c700"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") },
                    { new Guid("3e078075-04fe-46c0-99ac-94dadbda150b"), new Guid("cfbb1906-754b-4659-88ec-78c99554c5fc") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6efb5a9f-0cad-4d6a-a989-a7326ae81e34"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8ec7a52d-2504-4b36-bb34-cb2161874b1c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("0dbd79b8-90bf-4bc8-a89b-8d9fcb247ad5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("23cf0c91-d52e-4dc6-94c6-acd45a2e0953"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("09b5cce1-938a-4f20-8c67-c4042ef47f10"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2868e558-fd55-48b7-8719-b51842fa37cc"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("65754412-17f8-46f9-b52a-1fe292ae66b2"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("70f57103-9f9f-44c4-947d-1fe8c48282ee"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("fdd5aa0a-b920-4e61-b0a2-5af241d6eadf"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("443dc906-743a-468c-b437-4c9ef7b5e979"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6c429853-32b4-4644-a544-b4cb886d4b0a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("643511ee-d36a-47bc-9d54-b619f9125171"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("69b364a6-6227-438e-b40d-31b610795f6a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("2e95a812-f5bf-4873-9ba1-a027b2ffdce0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("388e143b-e5b6-469c-bd55-e7d2a1ba4589"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e6a2f8b9-e36f-40b1-80c8-970ed5f7caed"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f0fffe19-e1b7-49d7-9266-fd52d985f145"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("2c83dbd3-2fe5-4bd9-bc12-94689cac1ae4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ab2298f8-0f1f-478b-aabf-84fe9f8dd351"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fb6358a6-fb27-4a35-96e8-1bb2a3ed8a7c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("721b55fc-2659-413b-a330-0134fecbd996"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c3d03cea-5f2e-42aa-9f8d-5519c7b94ad0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5bb35ab7-741d-45e1-bc11-9e04fc97e81b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1f8a5589-4e4f-43b0-9289-1bcca848505a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("182d85a6-8797-4243-920c-07f3786f5c2d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a895efc0-7d65-434c-b89a-a5dafa041190"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bf94fbaa-f3c9-423b-b866-3b4d84da6087"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5eb19684-9cc6-4357-9ae8-adede88f6be7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b79ef6de-4756-4a18-ac09-174269fae8da"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3aeed818-b994-4aba-bab7-edd0ce9d907a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6352a14e-818b-4879-bd6d-5e4ac0761402"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7db80942-d91d-4502-9641-e3d0fdeba707"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("73917595-af22-42c9-a781-509efa65fd1b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("abf866af-ad40-4785-99c4-89d85408054a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("551cb569-3e50-45f5-857b-bd278c3243d5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e9941d54-e792-47ee-b2a8-11b124762b7c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7646058b-4555-401a-bf5b-2db32d222b56"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7296d736-9182-4c87-aa38-527c26a30adf"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("17fd0d2f-452e-40c3-bbce-18cb0dfef214"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("34722c4d-3ca0-4e82-aafb-ea9df94c3b77"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e6368075-91a2-4c31-ab5f-9579bad574bb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("19406d11-30ec-4881-afb0-a09491cb4333"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("30e87983-e9be-4b8a-b1e0-75a89f2ad7aa"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ee808d18-5f9a-4d84-a6a8-fe2ce47bfce0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6f73f930-baf0-4e19-ae18-3fe30e92c050"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c71e427-86fb-4af6-bb5c-d9ebfa040797"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a07febfe-b80b-49e7-a36d-e45f18c78ed0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a8de2e4d-21f1-43fc-9257-779eca04133a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("370cd6a7-967b-430e-af37-b6bb1f91a894"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("91921245-9c34-449b-a66f-ee2e6e9df209"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("28cf4d2c-8f47-49ac-921f-667cb7cb604b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c9abfcf4-331e-44d1-867c-72785440386f"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5e0b67eb-b276-4339-b6da-221224d165b8"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("37a092ee-e5f4-4cc9-9cd6-11211119dfc1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6d8cbc67-721b-45e9-aed2-d08708a0e6e4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a5c871f8-99d5-42aa-8067-2fb7c8f1a1d6"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7c122bf2-8edc-4526-aead-0eefb1ea28ea"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b377cb28-c123-4c8c-95c1-d90683967df3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4e874e00-ffa3-41c2-877e-4eca7ae8b218"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ed8c0e8f-d956-4ffa-a9b7-e18030113f14"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("40e323d0-ff33-492e-b6e9-f52b58efc79a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("27613d9e-a87d-4858-8452-722d3ce0ff5c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("bdb1b465-e7c3-42b8-81f0-a3e310a65197"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c5e6340-4da8-49af-8920-a67f16ee9081"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("721502e5-49ff-4be2-9e97-145f656c647b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b23b35f1-9a07-4393-9a6b-2595303b2e9e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("85fc36b9-acc8-4ffe-9e97-bd7598b80c95"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2d436f74-8db0-49c7-aa33-2d8e08c1f094"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1871dbcb-b2bb-437f-991c-0a0b2148bc46"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("844a53f1-af9f-48b4-aa82-45192d7d0c46"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9907c0c7-165d-4f8a-a6b3-c47fa69b3023"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2cf58beb-b675-449b-997e-cbc32bea9d88"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a128f2d2-a218-4a14-ac68-692b1d387106"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("edbe4a72-21c6-4886-997d-c1af8cc55b4b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("dec0a4c2-5609-41d6-a2e2-f80a27afc3a0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("e1f29c5c-08c2-4273-b981-d6249cd3d460"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("785b03ae-06e6-47c3-94f6-e250309cb04e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4415688f-d35b-46e5-bad5-34f657a9ffdf"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7729e4b5-da1b-4e38-92fe-d51356cbdbb7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a2ec14d2-7b6a-40d0-97c7-4db1cdf810e6"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f6a41e30-380d-4183-b172-b6bb18be1ffd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("03143780-1c95-4d64-bf14-a6dd507c0edf"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("65e5c79a-5f8c-4828-bb15-73abc66e39a5"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f193b70c-a067-4c4d-ac65-92557ee0ca7e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8e629068-722c-41bb-9534-816235f1e78c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3fbd66e3-ef43-4174-ae5f-213639c18972"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7c25c2a0-5e37-4ca0-9eeb-8fe3eb516afd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("369121fa-31a6-4960-b321-2c9950b21bae"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("58307a0f-ec77-4a5c-ad81-8a221a560390"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4cfb293c-dbd4-4639-a7a7-940d8a951ca4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("94919cf9-f4c9-4bac-a367-2e7a489d2485"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b368360f-7dc8-4f84-903d-a997efbef40f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("dc47df41-9d47-4696-8787-9c7e4713aa3e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3d8f50a5-c34f-4ca1-a6b5-e2305e8d2f3b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("150a96d3-a322-4a20-88dc-7a2ba8009f35"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1e721155-7dba-49e3-a6f4-b3b99eff44b7"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a0b194a5-e8e6-4d96-97f3-cba0d918f09b"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("24101bd1-2a53-4a72-96fc-41280e6b512d"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d52263f5-ce69-4cc4-bf0b-d47566461a97"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2054bd72-67b1-4578-bc09-0374c144711a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8670da08-cb23-44e2-98de-fd9fa39972e6"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1733e0c0-21ca-4b75-a90c-a94cf580ece4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("38b027d9-2bd7-4b5a-bfdb-ae2bfa1bcb68"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fed88963-2989-4d35-93c1-eaf390740ed5"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7cff8c31-e22e-4698-941f-5e34729ebe63"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f1c17a1f-ef48-47fd-9905-4fbbd7b91667"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0605f8a2-1f67-4b50-bcc5-d02da74a6ea8"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c1f6ea87-2b23-460e-91ae-3e7e88eab785"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6158a7b7-405c-4541-a60e-c697cbc00e40"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6d3db07f-4d56-4f05-ac1a-0bee9f6a88fd"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9b6db61b-a98c-4f77-bb0d-a86b7589751c"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("480dc732-7cbc-40f5-a55a-c7c9b82676d4"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1daaf9d-8f6c-4350-9b31-821d0369288a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3cee8ac5-10e5-40f8-bba9-db62692741c0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8a4c0c92-d0c8-4644-a595-affc1b5b26aa"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bd4c56eb-1116-4454-aed5-07e47e73eb59"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0bb44680-72ae-4c4f-b42a-ac327806ef0f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("667415fe-1b80-4beb-93e2-84013a35b888"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("64294ee6-6915-470d-936e-a3256da9ab32"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("eb6641ed-9220-4129-9f4a-0b3499b8759f"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a877204c-5b6f-4d60-9820-60b43adb34c0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("244ff7d9-5b58-4c15-8c46-fa67666297b1"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8c52baf4-b5c3-45c0-b017-57efe31ca1dc"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4d7341f4-4571-46b7-8ac7-6b67d140af21"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9e157974-cc7b-4c39-b528-2c7c94d0430d"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3dafb1c0-df8e-403f-b441-658449f87e3e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4cc7ae11-3487-487b-a6f3-dbc956a854a3"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("99ebafb6-61ec-4a22-881a-cc1191339d5a"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("575d6a4a-900a-489e-bb55-b1a3f708bbc0"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ba247d83-c39c-4428-aaac-2afb623e775e"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cc6914d2-4cfd-467c-a911-33c716d1b6b2"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a41e3f2b-0b45-4a6c-8cc6-145679c6a983"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b19cc3c8-4114-43fa-95b9-c098b3c68543"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c7d660f8-f331-41d5-8ed5-90769fa09553"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b8da3d92-84c4-41a0-a02e-64e5aba0e729"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9df37d62-7bb7-43e8-9fc2-98ec06d0d1ff"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1f6bd54b-c227-414d-90a4-2923eaa56f12"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e0c266a5-6850-4e6e-b7ca-c6ed43c81794"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("389519cb-5bab-4b96-bced-7699dde87e0c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e9d4fe2d-eb65-4181-9343-265474af7df0"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b50c4687-e455-4b84-9573-9d38defc6c30"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("71dc5e36-8ede-4d7f-b10c-ab4b3e7e74e2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("efb20c2d-2c40-4a1b-a49d-49502bae1c14"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("269a23eb-4792-468e-aafd-ed605ab1edb9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4bcb44e0-650f-4308-8162-fead4e3454e4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d825af1e-9fd5-4c20-90b6-4da954df94e7"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5dfc5b03-2e0a-462d-8db7-a1417554eb62"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b0279fbb-a07c-4bcb-8d48-a7581bf8f38f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("10672adf-5d7e-45d0-969c-2957d26d91c9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("eea054dc-c6b9-4620-a762-7cadfd196f17"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("cba0188f-a52e-43f5-bb8d-e4e7d52e7acb"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("00432ef2-088e-43a2-8baf-b186bfd84b7f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f67046a1-c288-4f8a-af24-11cdcf1c09be"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8403b7fb-cc20-44eb-af2b-253181ba149d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f0e780b5-95b7-4b2d-9f28-74c694ae865b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("442391a4-62fb-429a-8f51-70834c7b8503"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("afdce0a2-026c-4035-87ef-2392a4e27ad9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4ea6b390-45a7-4053-8ec2-45126c5c35df"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c98b80e6-9df1-4509-a74f-1e1611cf48bd"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("4fcbf7a1-ae8f-4c38-8f71-330ef9b20bc7"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("1b5fb473-8195-4412-a4af-186899e70876"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2c284d80-3342-4f30-9887-d5142753ac84"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("3616171c-65ae-41b3-bd24-29d03a250de4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9394fac9-a801-4cc9-84b4-d24caac3bc68"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("416f0e4d-4ffa-43c1-af54-d16f744d217d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("34349ba1-953f-41bb-ad41-2b2fe2b715a1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("816a3b9b-8ccc-42dd-b444-eda0dae736c8"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d151d233-5dcb-4e8d-ab9e-efed54ad994b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a3760256-d899-40bb-8581-a4a3ae30189c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e26a29ea-b77b-4d7f-bdee-c42a9e235af2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("daf97bd7-e20f-4396-b0f1-b26f18fc0d20"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("193bae54-71ba-4010-a5b6-8f81ae753b3b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d36022af-3f82-4369-8c68-da77339369b8"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7f954ec2-39d9-43e8-8fe6-4f11572471ac"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("035e3b7d-5bae-4f2e-b3ed-d11b54a95427"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("181dcb03-4eac-4253-8615-111d1155c1ca"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6faa88f9-e28b-452d-a1b6-7cae2275b1b4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("77ef747f-c3c9-4e53-82ef-04098c26d07e"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("61868607-e76b-41e3-bdd5-f2083e7ebd1b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5a8362b8-2961-4dc3-93d9-b73f9760a550"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("91889ae0-0cfb-40af-a66d-db920d53106d"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("63d27235-79e8-473c-8023-7ee264bad0e4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1e40e6c3-b015-4a7b-99dd-498a64db1f5b"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("af5c55e9-1ba5-48a5-bf30-251edf20ad01"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cf1b0046-7f40-42d1-b5c8-193dd97505b1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("cbe1816d-a2d0-4677-b1ad-b2d117091aaf"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4f7bdc31-4ff0-4681-b006-f63517ad37b5"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7fad7ccb-594a-45ba-b8d1-febe9bc9891c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("fb26fbc3-7e6e-4143-8f61-941e0942e55a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("160317a3-80e0-49c8-a188-8cf893855463"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("800094f9-b7a9-4f7e-8338-484908174ff9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bac54cab-4cb7-48e5-8edb-66c1acb62a10"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("f1c3a15e-e945-46b2-aaaa-6b0c6cda6c0a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("026743b0-bbf1-44b2-9902-7749f1f1cd3f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d250f083-d2d3-4658-832e-fe616ea143ea"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("5dd2b23e-f5df-4824-8d29-35cd8971051f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("06315f81-28cd-4b63-8936-7c358fb79b01"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0b779e47-bff3-45b4-9a65-11cea0fdad6f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("c2ab188c-07f6-4a8f-9150-036c632c005c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("c4cbce54-9219-45e0-9d76-618778d7d291"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("f4b25cb6-abec-4ca2-9560-94044a0c2875"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ccc7c81f-0228-4d0f-89f7-f1202a41e172"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1a04c09-13bd-4cf2-862b-00f9eb37b4fb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("53ab115c-4459-44a2-b0c0-bd84fc9e9e38"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("facd1e00-3333-4153-9f68-2c15aeb238bb"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4df50643-ede0-4354-9aa1-2c61c827588f"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9e20262a-31f4-4a43-8e4a-d304a3c53db1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("a7c6b4ec-6616-4cca-8c33-72b50145ffc0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6fbab38f-223d-4bc5-9010-a7e272bdb73c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8c2e7174-6c1e-4742-a443-e975b1392ed1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("720371ae-ed2f-4b7c-9bef-a0af75a2b795"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d1d15c68-6785-4b96-812a-009690d505b0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("aee3b5df-1e8c-452e-9022-d0b177c0fb68"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("355069ba-2fb4-47fd-9ec4-2a4d231a5f85"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0bf3518b-1b81-403e-9988-5cbe4effa4c3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bfce8105-3ba7-4db9-839c-01ce47a57e59"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("00b9c31e-473f-4c6c-957a-84b2fa181b69"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("0e0557c5-63e9-4f7d-a196-4898dd15561d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("37691600-2f8d-45c3-9a0a-6b740242d923"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b2aa3b9c-c531-4489-b0c7-81529d07b17b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("64927317-9cee-4fb4-adbc-ce7c9a5eb09a"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("8237cc30-c12f-4188-8ef2-5c9c60afe9b3"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("23a0649d-f363-4fe5-9261-3bf2c23ee4fd"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1713aae2-63cb-4fce-bc11-f0f2956c4cce"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("4bb84527-6244-487f-ae53-dcc8f2eb9ab1"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("97e7bd21-c58b-4b6c-a072-374d8548d28d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("48b33000-4d25-466f-8ed2-4be2c698e808"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("ab44ca2f-1e6d-4ee1-a76b-6fd3158fb69d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("b142e0f6-c483-4b6b-89f5-4d746ca8464d"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("e0b3bfdc-a678-499d-a8bd-739da9f7948e"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("1059fdd7-6fe4-4545-bcb2-8399b86cfb79"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("6b3fbbd9-00e7-40d1-a9e1-c92c16dbd5d6"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9ce12b09-bb74-4000-a566-f09547c88a73"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d84bca31-bb8a-4920-9f29-843f7e768ef0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("edd279be-70d7-4489-93e6-128044438138"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a46b06e0-b27c-46e5-b46c-277ef8fb1322"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d4e01fb4-ac66-4f68-a28b-72c4b66d2b3f"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("ef3be4d6-d570-4eeb-b1b7-120bfcd3f000"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7b88df97-e1e6-4c80-9194-deba186ac065"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("80046ef2-ded1-43ea-a6bd-3a59b7c848ac"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7a449214-90d2-4d76-b504-745491be7686"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("08c8683d-d0dd-4997-83c6-92784edab4f1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("97c8c104-b7f6-4786-ab22-4d8ea7ba55b1"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("db4cd2c4-d3b1-4422-8190-f4788cc60e6c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("2559cfbe-f89a-4b84-bd9a-2a8de3bde292"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("6c365ffc-9e77-49a3-a62a-91dc63991b13"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b1a73ebc-fc7f-428a-9b02-1c59005bc4f9"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d862a774-8fed-4788-a468-04ba89d39103"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("9281c7fa-b385-4c03-a90b-6b07aac2a3b2"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("233bff50-9ba2-4bdc-ab7c-0a2677d60019"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d2f0bf3e-34ec-4ce1-b9bd-24f0365e2760"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("b5c68b7f-fc6c-40d8-96cd-0d0328693a3c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("7f5b9f88-2b39-406a-94fb-1512ef84025a"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("0133e8e7-decd-4b4b-a148-ece9dc780b47"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("d9190a4e-489a-4ad7-9187-bd5d44cc49ad"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("a5cb3161-11dd-4e6c-b2c3-1ef368e182fc"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("60a79ecd-e961-4397-80b7-50e104796d2c"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("bd281f00-3a81-4fc8-be80-c928b2eb8a7b"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("caeab8c2-c328-4a65-93cf-f46fc7bd3cd5"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("d138c33d-1571-46b2-a8ec-12a3fa3836d3"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("8828fb88-50f3-49f9-af47-4073a5ee0de0"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("7469d933-78b8-4aa3-a0eb-274c4ab30295"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("9433e939-ee17-4586-a5cd-88f38246606c"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("bad73f16-4c56-499f-a6cd-ea5de0aa0e30"), new Guid("a45da717-ff84-4e52-965f-551808807281"), new Guid("3c0dd811-7d45-4b42-bf63-a9233b1a7982"), new Guid("95180e98-9c9b-49bc-998f-7ee2882907dc") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("5a1ead09-6a16-478b-bc31-64dacd0b04b4"), new Guid("9989b3e5-e84a-4dd5-b330-ca97156b276d") },
                    { new Guid("a4e4bf32-f386-48e0-860a-cae62cff8369"), new Guid("f6461d42-d2d8-4069-9613-796d7b59a0e1"), new Guid("78dd8376-a0e6-43d2-bcb5-c21574f3f5f2"), new Guid("0b2240c2-e2a7-4299-9656-07ceacedc852") }
                });
        }
    }
}
