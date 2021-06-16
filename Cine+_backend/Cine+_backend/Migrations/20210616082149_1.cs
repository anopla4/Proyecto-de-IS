using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_FilmScreenings_FilmSreeningId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("a0fad8e6-a3b3-4cd6-9022-ba8dd1839d2f"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("f9ae8b3a-d842-4238-b128-26867e9a5b0d") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("e4f4fdc8-5de5-4df7-90e7-40f0c253d2b8") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("032a9eb0-7de7-4190-b52f-bbacbc79d6e2"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("32d638d0-2170-47df-b002-2b2b2dab9f15"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b85078ac-324b-4b6a-8cdb-916b98bf3d2e"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("fdcb77c8-b037-4283-953b-8944ebac7a5c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0518539d-e628-40a7-bbde-a4913e40c4e9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("35d74d6f-e521-4f67-ba07-09877bad73ad"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("83197658-952b-40f2-9a84-adace39e0ec7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9cf1da66-27a5-42ce-be2c-52cb4cef1156"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8864805-969d-4af2-801a-59f227ec8d47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c3334688-a005-4684-ae32-dd0fb19ec842"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf1c422a-cb42-47d7-b8d3-c16d43a06c9a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dae44179-99cf-49e1-971f-75287b8be015"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f008ece1-45b9-4cf6-9c41-7227266eb8b3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f691bfcf-5c43-41a3-8553-57bc7d816bc0"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("1745a668-b48f-482d-84c2-624b2da2174c"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("781b8743-6851-49d2-8f3d-e94208c577ac"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("c1469966-f4d9-4e9f-a9dd-09139871caf3"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("008e259b-1169-4e44-9152-86f5d9668027"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("01e6ed83-8916-425d-8221-3f9d16b14d51"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("02d7d69d-c8cf-48f9-a750-d8d6aab06aed"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("03df8fce-55a3-48e9-9563-3b0ff086eda7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0407177b-3749-4fda-9351-8a80fc28f3f2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0499e325-472e-4056-91ab-f1743abce5e5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("06175735-ca8b-4aea-9eea-3a5969dd876d"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0619d98b-4e5e-4c1b-9156-121906f73308"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0888b147-3e15-411b-a080-c764163ed723"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("09e14b4f-f95a-497f-9c92-ab82a471c8e2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0af5f958-fe24-408b-8546-74f47af627c3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0c197c03-d57b-4ee9-b97b-b37ce6da6a3e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0ca3fd06-54d5-4b54-ab80-3ffc267db02b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0d58c1df-435a-448e-a37f-008fce9f8e60"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0d925e65-97f1-4578-befa-b329b964d48e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0dbf698d-a5d1-49f8-8fa8-b62197e738cb"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0ffc1313-5f69-4902-ac5b-8fde63c94d75"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1025b7c2-640d-4053-b09e-f733d83f5b87"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("106bd050-0206-48eb-82b9-31e11515c056"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("10ceb6e0-3807-4c84-8391-dcebdd23700f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("119f9568-aaa7-4b95-b40f-b24a37d9588b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1235805f-7f52-4434-b596-597f04fcfcd6"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1278a3cf-923e-49ba-9e74-029f1cda016a"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1297b0c3-fd29-4ede-9668-d2b55cb7f037"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("139e5d66-e045-479a-8cc5-6836f183cfb4"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("13e1c470-ae0f-4a9f-9b4b-7dc88031b08e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("15d90e30-f234-4268-8d02-a7e8d7f7cb08"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("15fcb6f9-63e5-4eac-8fde-00332334c11a"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("16a9451c-b70c-4952-b5c3-05e83cda9284"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("16ff5768-ee1a-49fa-9681-299b3dc652e4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("17c9441b-4a33-4a76-9b68-3fd7596976c0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("191a4552-2d99-49ea-8b17-dda45452241e"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("19b42427-2614-4b91-8ce8-bc7986b5e7b1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("19e991d7-e478-43c5-9857-0bf0cbad211c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1a1515f5-4af7-4898-929a-4c5baad27068"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1a84a405-7050-4f72-b48b-e8f1341d884e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1b6a9361-4441-4ac1-aff6-778db1326113"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1b97f3de-e6fd-4355-8cca-ede2a4fbaccd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1bf10d1a-51ea-4551-9948-d7100a4e0578"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1dc41a12-dccd-489c-96a3-c55dd8bf4efa"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1e6e1d57-ef8f-4729-b98d-5ec9fd957f78"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1e8b8da3-7c9a-4d82-b145-aee85203be12"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1f25dcc9-06db-4559-bbbb-0e0a8cec236f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1f9c8645-f39b-48db-be50-8ebed83a4a85"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("204f3ad4-9ae8-42d7-901e-abfef45e5a37"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("215325c8-9294-422a-bdb1-e3af1580ff92"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("22eae95f-b2a9-4b01-8f63-2d7dc883f24d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("24498877-7f5a-49e8-830a-257a1d1e3af7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("246dee1a-ed15-463f-bc9e-34f5e7f7b0b3"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2500b196-4067-46d0-b901-27d3dbade68b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2644a1cf-7410-4ef0-b281-0316fc9d17be"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("26f483ed-d47f-4a63-9496-b39855741d33"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2896456a-3df7-4b91-ba2f-3af608bde325"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2955a1b5-c0ae-4a77-b815-0a40ffa858a1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2bf8a249-49fb-43a9-ba76-4512ec9cb435"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2dc31237-cb15-44b1-8d3f-ffb3290a86c0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2e0a3383-a28f-4d40-beac-6503af862e66"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2ee96e75-c3b6-4a6c-a3e3-cec95a9cc2aa"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2eeab7b5-f5a8-48e1-9919-af7a42d9335e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2eeac228-4375-4dea-aa8e-1dee29d90763"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2f8d2ab5-6e47-4f54-8120-1f4c9bca503b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("30c44f9f-8a40-45af-8a67-f8dd2405e944"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("315f32f3-4103-4b26-803a-b3bb97211cd1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("34e36a61-3788-4f9f-b009-02a697b634eb"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("3667d572-75fa-4dde-91ea-e0718856ce86"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("36febbf0-edc4-43c6-936a-dbdb6a5ebb89"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("37c74fab-baf9-44ff-929a-61d575d8ba92"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("38141f38-7804-47e0-b43e-1108a5f29973"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("3a8f71b3-cedd-4e2b-a50b-75eced598b89"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("3ca70a5d-9e8c-41c1-8afb-dc92e352a78c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("406ffac9-ce63-40be-b809-6bb99f5325ad"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("40c26e41-2af8-4ce7-970d-ea9d1e0ade45"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("410a5a1c-b2f8-47e4-8dab-4a699710bda9"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("44c56800-b80a-41e8-adb8-6088447e0517"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("44ecce74-8517-40c3-8697-9ac469ab8d35"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4502f0f8-3e62-421b-9500-d2676e233a02"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4569f73d-b89f-4867-a34d-086fc2c8fdb3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("46dffd1e-392f-4678-b883-94a4f39294a8"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("472719cc-2d8f-4340-82db-06e8ed206c35"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("47a2cf06-dc19-49d5-b016-9d5339eeb83e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("47b83f1c-66d0-4f90-adad-a3bc31655311"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("47df26ea-3dc2-4e5b-8c92-688aff1c3ff6"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("487bf4ae-46bd-4969-99b0-94ba2e352467"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("48ddc1c9-dd00-4113-b595-263ba13fa5bb"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("49325d85-ccfb-4ad8-8846-95c6296822cd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("49418229-d9d0-4eb2-9ece-34f635bea727"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("49ab40d2-a845-426d-870f-57326b03725f"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4a1ece9e-ade0-4e3b-85d0-08da37d5f3d4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4a67d2cb-ff4c-4307-be49-5520babc4d86"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4abbaad6-8d6d-464c-958c-897e4707e7c2"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4b8734e4-eaec-4610-a6a5-be260edcadd2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4d963744-39a0-41bf-b144-4a4354d0a171"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("500c3084-1df0-4c7d-b0c7-e46b94b0c707"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("50c2b83a-d5cb-4073-8237-b6764e0b9c69"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5208ecac-cec1-4faf-8612-53bfb0bd6bbf"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("531af91a-dfef-4474-b8ac-3581e3b41abd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5356c9aa-8a40-4104-b8f7-53871d6b8cf2"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("537e98a9-43cc-46f3-b872-eb0ed495a064"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("53b8e131-72e5-46f7-bb67-ad415e53000c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("546a1aec-30ea-4593-8c76-39da586a0036"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("547d875a-eed4-4ba2-be70-694cb225296c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5505e22a-4361-4cc3-a7ac-eb29f4567ec2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5729bdbe-c9a1-4719-bc10-d6758a8c371c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5888e7ee-cbaa-466b-b6b5-86fb0b605c79"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("59fed05e-e523-42d3-8a21-c1f216c3545c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5dae03e2-f435-4cad-b674-7f6b01f2794c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5ee5f438-9425-4ae5-b808-d07f0f37e543"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6040660e-33f1-4f2c-a641-ef280b23a851"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("60ce2cd8-e39e-4368-82b8-b3b8206b8b42"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6129da45-9371-4276-a7e7-f6522d0c4f0c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("61a65669-89a2-42c8-a759-84542511d2c4"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("61b42e96-8a68-43ed-9ab8-369d67da735b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6204c4b1-cd3c-45fd-993c-b2e83f954248"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("64657280-e79d-4d35-bf4a-7298e6fd618c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("646e3f61-648c-4085-807e-e450b01f6900"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("64d14d7c-08b6-4fac-96ac-6bc3e8530d12"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("661574ec-f0d3-4323-8ee1-98fb3f77caa3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("66913e8c-a36c-486a-beb8-94767d02bef1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("66a0461e-4963-4374-b799-1bb8e916252e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("686676a9-b6f0-49e9-bb27-d4c72f19c4aa"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6ac8c63c-d3d4-4146-a464-7d0cb9cd1556"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6ac8d492-7931-4e9a-a85b-783c30d68fe7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6c814d73-d311-4a38-ad60-0d4ce2d1e85c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6e5294f7-a2fe-4a01-abf9-8bcfaeb78bec"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6e6d3f1b-735d-43e2-aa40-ad30148b9a1b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6e9c2708-1437-4496-a5a3-e65efec75fa5"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("70200362-d22d-489a-8483-806caa079787"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("709c0bcd-d7fa-473a-9822-26310066d004"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("70f80669-9e6c-4372-a222-ed6620883311"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("71b94996-ced4-432c-a059-7a0f874e9b60"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("73d966c7-ba70-46ad-9ae9-b8b265b504b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("76a4a0ae-b13d-413d-8c66-e82e76cbc74d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77070837-c327-4268-b4af-67b7f0a9ea4e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("77301813-91f7-49db-a769-37fe5a288347"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77a76966-8d23-4acf-9a0e-e6861b114419"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77c4ace5-a49e-464b-883e-89237c80f449"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("78c5584a-04c4-4c04-af87-0860981bcd36"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7967419a-2603-4bed-a3da-57a0688dd2ca"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("79ec0820-d803-401d-b8de-5bc02044dd61"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7c1dbbbd-dacd-48d5-9638-d62a248889a8"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7e50215d-75bd-4d7c-82a6-4fb190ad1cdb"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("7f2de3d3-4383-481a-906c-097877b41479"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("807aa9e5-a7d0-4c24-b2fc-49ebca9da749"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("807fb03f-1e48-44ce-95dd-2fcae1e659e5"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("81a08857-6265-4233-ad3f-5f90f989cfb6"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("820a6a9d-1425-480a-816d-154deaea6d2e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8214254e-0a05-4767-b504-5d5a359f2af9"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("840a8187-54c2-45bd-9c40-fd920f4da333"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("844707b5-b00b-46ae-962e-3cf6b5098726"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("85d3fa27-2364-4da8-995e-d4c7d1516c55"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("882fac87-1c13-47df-8828-2347c20a71f4"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("886bc452-da63-4298-b387-4fff619b7e5c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8aa60f69-55a5-441a-94e4-b9b639d922e5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8aab1d80-64ae-44b5-ae86-ddb7e14c46d6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("8c9fa9d6-49ab-4f94-827a-02f3d3320c1f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8e42a6c6-9bb6-4ed6-8be8-f57ea3faf7ec"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("907a17b6-de34-421f-9ef3-30adc7329028"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("90a4b5f6-5409-45f3-8b8c-3a6c2ca0fb25"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("90c26617-9181-4f38-a2b9-631695982b47"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9141b8c4-3077-446a-8000-84fea8804807"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9339b6fd-d5ed-43b3-8614-07f83371ab85"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("934fdf4c-e06c-4c20-ab7a-d64e87edd156"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("939aa012-783a-4181-b273-6ac955231146"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("942d8c8d-a63a-4752-83af-ad11ce987b78"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("945149b6-76f5-4817-94d2-f1d38a29c7a0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("94d9cdee-affd-426f-ae29-82584bc91de5"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("957f6c0b-7beb-420f-b944-56f83237fe8b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9710b537-147e-429d-954e-ccfbda12e1c6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("97352b9b-c27d-4a47-9ae0-46aac9c65f43"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("98e48abb-bded-47f9-86cd-cba2c4ff0036"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("98e543a2-16d7-4927-bcda-609e1307d302"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("993e3c71-c710-4348-a515-1dd023d713f6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("99aa4b1e-c0eb-4153-b426-9b9a66919266"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("99bd43fd-337a-4cd6-9b69-df24a0e5cde0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9aa8ad84-b51b-4d3c-a720-991a135d5e1e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9b6cdff3-0969-4f1f-a51c-80ff11e2cb81"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9d1d5f2b-01ce-4d93-939a-bdf0860e8b83"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9eda6903-da5d-4bad-82b8-232408fce870"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a161bcba-81d0-43c0-8be4-7eaf4bdfcc75"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a25a6fd1-c452-485e-b0c6-b7a24a0ead27"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a3446e17-664b-4987-8a5a-a98a26eff41e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a4a0a06c-683c-4c1a-b604-6a21955882a5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a506610c-ea08-43cc-a930-069274a0aa8b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a59234c8-1b14-4dac-88e9-a4b7d60beca4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a99e1890-2fd6-4613-90df-f33d78b3fe98"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("aa5330c4-01c4-4cea-953e-f61b9a554c48"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("abf7fb22-e06d-4e57-bf6b-0dec53bf8cd7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("acc6872f-70f4-4dd6-9d7e-c6eaaa7f8f50"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ad90caa6-3c79-47de-b6b8-49bc71bb8dda"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b0dfc923-7f40-4dae-8775-a1d749e525f3"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b11dfeb9-6fe7-4273-9f3a-df46a0f408b3"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b12b8606-3482-4f86-99e7-a5997aca998c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b181584b-179d-429a-8771-633d55fd3886"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b2248285-f43e-4b9c-9cfa-ee00b260c786"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b44113e9-de40-4f6e-8ae9-ac925caf0d02"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b4ae5760-850a-45b9-83ea-70caaef488cd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b53cba38-703e-453f-9431-82cf6bfb8df2"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b5762b59-68cf-4654-a605-eab1d804c50e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b5cfa03f-111e-43be-b871-1090576a93fe"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b6f4035b-81f4-465b-8277-53e79a09f75c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b81b8a6b-ce52-4b11-b6c0-12f3aeed0c4e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b873c3d0-8b9e-4fc0-817e-06f89313668b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b9f5bd6b-4675-49ff-9b12-0a985c25a12e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("be05b3c4-7057-487e-8d3c-20e2ce5c3e79"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("befdace8-523b-4fd7-97a7-b4b4aaa56814"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c00ee0a9-6793-4de8-b196-4fdedd8d21d8"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c0b09b19-3165-4b17-88c9-08a3a8e95fcc"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c2240ba0-eba0-4f6b-8b4c-8a95c7f7a3a7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c4ad235a-6839-4770-8c0c-0464e48722c1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c54d1cfe-7600-4437-80bd-02a8bdc2e3ad"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c785d2a0-8c2d-4069-b6b6-b9601a787c92"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c7ee8bb2-1b78-44d4-a6a5-71b88a27a655"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c8375ecc-7e84-411b-9d68-72c112dacd30"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c8e6fc84-d73c-4ac8-90ae-1142bfd22ad3"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c953e9d3-90fa-48e9-b146-a037df561de7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c96677b6-d909-47ea-afa9-d51baebb326b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ca5e9ff9-f13f-4f41-8823-fd5708f4e6bd"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("cf4b49fe-2905-4364-a216-95329f9f1b88"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("cfcc6af0-c8be-4d16-be1e-b3ab891648c2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d451be8f-1ba4-4120-ac75-3987549fd332"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d55798ad-5f76-418f-9f00-d1def52caedf"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d65210a2-6e44-4b16-9f07-07d248f92316"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d6625b3a-4363-4d1f-a5cc-50fb297f7d1d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d666983d-b873-4cff-afbe-329990186d94"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d7554ced-897e-4e1b-8a4e-4d02ebf90a34"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d7fd8286-dc43-45d9-8deb-f46d76af8fa9"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d888c9d8-345b-47fe-be69-fecb851ed6b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d958f206-ecd8-4e7b-baf1-d35ae84c05ab"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("dae1b4f3-ea28-4d9f-a4da-9e12b8714f1f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("db7a3b3d-0d4b-4bb4-83c5-f659b903da23"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("dbf345b0-047d-4432-9daa-f92a96fcbe97"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("dd88b7eb-1733-4554-8671-c51bcf7df29e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e043bc89-4079-4a20-8be8-1f60959a18a0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e2a74aac-c739-4c0f-ad95-a655c3667c4b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e3220225-cd78-47f0-b926-e3685c32679f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e3c89890-d632-47bd-8bb2-c3db0594a54e"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e3f3b0e4-6e3e-4712-b864-a87bb1fd8c74"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e448299c-1e62-4701-aeac-b68e143ec585"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e5345ea5-e6dd-4146-9722-35bfe7b22398"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e77d17b6-b595-4752-a927-28b00ac922fa"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ea0fff09-d9ae-4b99-b836-4e7fc3c7f605"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eb226a36-96b6-42ab-91d4-f4115815599c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eb8f8188-7dc7-4115-9bfa-a25d4b31a594"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("eca1cc5a-2480-472e-8097-7d9ade95e9a0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("ed9e70b3-c1f6-4876-b79c-6071cc74eab1"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eda244ca-938e-4da7-8867-e52ae4543ff7"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("edd553fd-913b-4915-b1fa-7c401a75c613"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ee5ccb76-072d-477a-ace1-c0efd8068bdf"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ef298b0f-a89e-4135-b143-bc4a332976ba"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f13d726c-f8fb-4b12-b9a5-40bb74d2fe7a"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f1f22a81-81fa-4104-9318-f1446c28883b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f24b737e-187d-4d29-9a76-6a787c6bb1b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f26d678f-61bf-410b-8b01-5b5deedc6e30"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f2db955e-a6b5-4314-a3e2-6246ce4d9a9f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f3ed4cab-45cb-486e-a8a5-87829b328edd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f6c94150-39ba-432b-a5af-fd0afee5f2a1"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f6f4cf5e-d2a9-47fa-a094-ea028186cefe"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f6f7ca8f-d890-4faf-b1ae-cfd9ea31339f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f862b2bd-e56f-46bb-be55-744f344361dd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f86a61ed-908b-468f-b298-b8fbaf8c15bb"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f8855258-3ee1-4f75-b427-f277ea1bfd04"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("fa917ab1-135d-4268-b3d0-25bf94784f6a"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("faa260bd-26d2-46df-a02e-21cad7f75b46"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("fe14d12a-ff97-44aa-a005-ef1580b82136"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ff814ad8-43d2-47e4-b395-cbbc3878863f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ffcc8c05-4d48-4d3b-9021-87dfa4c91f14"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("a0fad8e6-a3b3-4cd6-9022-ba8dd1839d2f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("029c837c-8a76-4507-ba76-e80612044738"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4f4fdc8-5de5-4df7-90e7-40f0c253d2b8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f9ae8b3a-d842-4238-b128-26867e9a5b0d"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("008e259b-1169-4e44-9152-86f5d9668027"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01e6ed83-8916-425d-8221-3f9d16b14d51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02d7d69d-c8cf-48f9-a750-d8d6aab06aed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03df8fce-55a3-48e9-9563-3b0ff086eda7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0407177b-3749-4fda-9351-8a80fc28f3f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0499e325-472e-4056-91ab-f1743abce5e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06175735-ca8b-4aea-9eea-3a5969dd876d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0619d98b-4e5e-4c1b-9156-121906f73308"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0888b147-3e15-411b-a080-c764163ed723"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09e14b4f-f95a-497f-9c92-ab82a471c8e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0af5f958-fe24-408b-8546-74f47af627c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c197c03-d57b-4ee9-b97b-b37ce6da6a3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ca3fd06-54d5-4b54-ab80-3ffc267db02b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d58c1df-435a-448e-a37f-008fce9f8e60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d925e65-97f1-4578-befa-b329b964d48e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0dbf698d-a5d1-49f8-8fa8-b62197e738cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ffc1313-5f69-4902-ac5b-8fde63c94d75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1025b7c2-640d-4053-b09e-f733d83f5b87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("106bd050-0206-48eb-82b9-31e11515c056"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10ceb6e0-3807-4c84-8391-dcebdd23700f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("119f9568-aaa7-4b95-b40f-b24a37d9588b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1235805f-7f52-4434-b596-597f04fcfcd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1278a3cf-923e-49ba-9e74-029f1cda016a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1297b0c3-fd29-4ede-9668-d2b55cb7f037"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("139e5d66-e045-479a-8cc5-6836f183cfb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13e1c470-ae0f-4a9f-9b4b-7dc88031b08e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15d90e30-f234-4268-8d02-a7e8d7f7cb08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15fcb6f9-63e5-4eac-8fde-00332334c11a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16a9451c-b70c-4952-b5c3-05e83cda9284"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16ff5768-ee1a-49fa-9681-299b3dc652e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17c9441b-4a33-4a76-9b68-3fd7596976c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("191a4552-2d99-49ea-8b17-dda45452241e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19b42427-2614-4b91-8ce8-bc7986b5e7b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19e991d7-e478-43c5-9857-0bf0cbad211c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a1515f5-4af7-4898-929a-4c5baad27068"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a84a405-7050-4f72-b48b-e8f1341d884e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b6a9361-4441-4ac1-aff6-778db1326113"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b97f3de-e6fd-4355-8cca-ede2a4fbaccd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1bf10d1a-51ea-4551-9948-d7100a4e0578"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1dc41a12-dccd-489c-96a3-c55dd8bf4efa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e6e1d57-ef8f-4729-b98d-5ec9fd957f78"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e8b8da3-7c9a-4d82-b145-aee85203be12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f25dcc9-06db-4559-bbbb-0e0a8cec236f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f9c8645-f39b-48db-be50-8ebed83a4a85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("204f3ad4-9ae8-42d7-901e-abfef45e5a37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("215325c8-9294-422a-bdb1-e3af1580ff92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22eae95f-b2a9-4b01-8f63-2d7dc883f24d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24498877-7f5a-49e8-830a-257a1d1e3af7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("246dee1a-ed15-463f-bc9e-34f5e7f7b0b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2500b196-4067-46d0-b901-27d3dbade68b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2644a1cf-7410-4ef0-b281-0316fc9d17be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26f483ed-d47f-4a63-9496-b39855741d33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2896456a-3df7-4b91-ba2f-3af608bde325"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2955a1b5-c0ae-4a77-b815-0a40ffa858a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bf8a249-49fb-43a9-ba76-4512ec9cb435"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2dc31237-cb15-44b1-8d3f-ffb3290a86c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e0a3383-a28f-4d40-beac-6503af862e66"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ee96e75-c3b6-4a6c-a3e3-cec95a9cc2aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2eeab7b5-f5a8-48e1-9919-af7a42d9335e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2eeac228-4375-4dea-aa8e-1dee29d90763"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f8d2ab5-6e47-4f54-8120-1f4c9bca503b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30c44f9f-8a40-45af-8a67-f8dd2405e944"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("315f32f3-4103-4b26-803a-b3bb97211cd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34e36a61-3788-4f9f-b009-02a697b634eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3667d572-75fa-4dde-91ea-e0718856ce86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36febbf0-edc4-43c6-936a-dbdb6a5ebb89"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37c74fab-baf9-44ff-929a-61d575d8ba92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38141f38-7804-47e0-b43e-1108a5f29973"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a8f71b3-cedd-4e2b-a50b-75eced598b89"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ca70a5d-9e8c-41c1-8afb-dc92e352a78c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("406ffac9-ce63-40be-b809-6bb99f5325ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40c26e41-2af8-4ce7-970d-ea9d1e0ade45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("410a5a1c-b2f8-47e4-8dab-4a699710bda9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44c56800-b80a-41e8-adb8-6088447e0517"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44ecce74-8517-40c3-8697-9ac469ab8d35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4502f0f8-3e62-421b-9500-d2676e233a02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4569f73d-b89f-4867-a34d-086fc2c8fdb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46dffd1e-392f-4678-b883-94a4f39294a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("472719cc-2d8f-4340-82db-06e8ed206c35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47a2cf06-dc19-49d5-b016-9d5339eeb83e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47b83f1c-66d0-4f90-adad-a3bc31655311"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47df26ea-3dc2-4e5b-8c92-688aff1c3ff6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("487bf4ae-46bd-4969-99b0-94ba2e352467"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48ddc1c9-dd00-4113-b595-263ba13fa5bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49325d85-ccfb-4ad8-8846-95c6296822cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49418229-d9d0-4eb2-9ece-34f635bea727"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49ab40d2-a845-426d-870f-57326b03725f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a1ece9e-ade0-4e3b-85d0-08da37d5f3d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a67d2cb-ff4c-4307-be49-5520babc4d86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4abbaad6-8d6d-464c-958c-897e4707e7c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b8734e4-eaec-4610-a6a5-be260edcadd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d963744-39a0-41bf-b144-4a4354d0a171"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("500c3084-1df0-4c7d-b0c7-e46b94b0c707"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50c2b83a-d5cb-4073-8237-b6764e0b9c69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5208ecac-cec1-4faf-8612-53bfb0bd6bbf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("531af91a-dfef-4474-b8ac-3581e3b41abd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5356c9aa-8a40-4104-b8f7-53871d6b8cf2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("537e98a9-43cc-46f3-b872-eb0ed495a064"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53b8e131-72e5-46f7-bb67-ad415e53000c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("546a1aec-30ea-4593-8c76-39da586a0036"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("547d875a-eed4-4ba2-be70-694cb225296c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5505e22a-4361-4cc3-a7ac-eb29f4567ec2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5729bdbe-c9a1-4719-bc10-d6758a8c371c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5888e7ee-cbaa-466b-b6b5-86fb0b605c79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59fed05e-e523-42d3-8a21-c1f216c3545c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5dae03e2-f435-4cad-b674-7f6b01f2794c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ee5f438-9425-4ae5-b808-d07f0f37e543"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6040660e-33f1-4f2c-a641-ef280b23a851"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60ce2cd8-e39e-4368-82b8-b3b8206b8b42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6129da45-9371-4276-a7e7-f6522d0c4f0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61a65669-89a2-42c8-a759-84542511d2c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61b42e96-8a68-43ed-9ab8-369d67da735b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6204c4b1-cd3c-45fd-993c-b2e83f954248"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64657280-e79d-4d35-bf4a-7298e6fd618c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("646e3f61-648c-4085-807e-e450b01f6900"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64d14d7c-08b6-4fac-96ac-6bc3e8530d12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("661574ec-f0d3-4323-8ee1-98fb3f77caa3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66913e8c-a36c-486a-beb8-94767d02bef1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66a0461e-4963-4374-b799-1bb8e916252e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("686676a9-b6f0-49e9-bb27-d4c72f19c4aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ac8c63c-d3d4-4146-a464-7d0cb9cd1556"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ac8d492-7931-4e9a-a85b-783c30d68fe7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c814d73-d311-4a38-ad60-0d4ce2d1e85c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e5294f7-a2fe-4a01-abf9-8bcfaeb78bec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e6d3f1b-735d-43e2-aa40-ad30148b9a1b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e9c2708-1437-4496-a5a3-e65efec75fa5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70200362-d22d-489a-8483-806caa079787"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("709c0bcd-d7fa-473a-9822-26310066d004"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70f80669-9e6c-4372-a222-ed6620883311"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71b94996-ced4-432c-a059-7a0f874e9b60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73d966c7-ba70-46ad-9ae9-b8b265b504b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76a4a0ae-b13d-413d-8c66-e82e76cbc74d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77070837-c327-4268-b4af-67b7f0a9ea4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77301813-91f7-49db-a769-37fe5a288347"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77a76966-8d23-4acf-9a0e-e6861b114419"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77c4ace5-a49e-464b-883e-89237c80f449"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78c5584a-04c4-4c04-af87-0860981bcd36"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7967419a-2603-4bed-a3da-57a0688dd2ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79ec0820-d803-401d-b8de-5bc02044dd61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c1dbbbd-dacd-48d5-9638-d62a248889a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e50215d-75bd-4d7c-82a6-4fb190ad1cdb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f2de3d3-4383-481a-906c-097877b41479"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("807aa9e5-a7d0-4c24-b2fc-49ebca9da749"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("807fb03f-1e48-44ce-95dd-2fcae1e659e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81a08857-6265-4233-ad3f-5f90f989cfb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("820a6a9d-1425-480a-816d-154deaea6d2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8214254e-0a05-4767-b504-5d5a359f2af9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("840a8187-54c2-45bd-9c40-fd920f4da333"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("844707b5-b00b-46ae-962e-3cf6b5098726"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85d3fa27-2364-4da8-995e-d4c7d1516c55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("882fac87-1c13-47df-8828-2347c20a71f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("886bc452-da63-4298-b387-4fff619b7e5c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8aa60f69-55a5-441a-94e4-b9b639d922e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8aab1d80-64ae-44b5-ae86-ddb7e14c46d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c9fa9d6-49ab-4f94-827a-02f3d3320c1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e42a6c6-9bb6-4ed6-8be8-f57ea3faf7ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("907a17b6-de34-421f-9ef3-30adc7329028"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90a4b5f6-5409-45f3-8b8c-3a6c2ca0fb25"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("90c26617-9181-4f38-a2b9-631695982b47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9141b8c4-3077-446a-8000-84fea8804807"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9339b6fd-d5ed-43b3-8614-07f83371ab85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("934fdf4c-e06c-4c20-ab7a-d64e87edd156"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("939aa012-783a-4181-b273-6ac955231146"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("942d8c8d-a63a-4752-83af-ad11ce987b78"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("945149b6-76f5-4817-94d2-f1d38a29c7a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94d9cdee-affd-426f-ae29-82584bc91de5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("957f6c0b-7beb-420f-b944-56f83237fe8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9710b537-147e-429d-954e-ccfbda12e1c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97352b9b-c27d-4a47-9ae0-46aac9c65f43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98e48abb-bded-47f9-86cd-cba2c4ff0036"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98e543a2-16d7-4927-bcda-609e1307d302"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("993e3c71-c710-4348-a515-1dd023d713f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99aa4b1e-c0eb-4153-b426-9b9a66919266"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99bd43fd-337a-4cd6-9b69-df24a0e5cde0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9aa8ad84-b51b-4d3c-a720-991a135d5e1e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b6cdff3-0969-4f1f-a51c-80ff11e2cb81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d1d5f2b-01ce-4d93-939a-bdf0860e8b83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9eda6903-da5d-4bad-82b8-232408fce870"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a161bcba-81d0-43c0-8be4-7eaf4bdfcc75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a25a6fd1-c452-485e-b0c6-b7a24a0ead27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3446e17-664b-4987-8a5a-a98a26eff41e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4a0a06c-683c-4c1a-b604-6a21955882a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a506610c-ea08-43cc-a930-069274a0aa8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a59234c8-1b14-4dac-88e9-a4b7d60beca4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a99e1890-2fd6-4613-90df-f33d78b3fe98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa5330c4-01c4-4cea-953e-f61b9a554c48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("abf7fb22-e06d-4e57-bf6b-0dec53bf8cd7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("acc6872f-70f4-4dd6-9d7e-c6eaaa7f8f50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad90caa6-3c79-47de-b6b8-49bc71bb8dda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0dfc923-7f40-4dae-8775-a1d749e525f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b11dfeb9-6fe7-4273-9f3a-df46a0f408b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b12b8606-3482-4f86-99e7-a5997aca998c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b181584b-179d-429a-8771-633d55fd3886"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2248285-f43e-4b9c-9cfa-ee00b260c786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b44113e9-de40-4f6e-8ae9-ac925caf0d02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4ae5760-850a-45b9-83ea-70caaef488cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b53cba38-703e-453f-9431-82cf6bfb8df2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5762b59-68cf-4654-a605-eab1d804c50e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5cfa03f-111e-43be-b871-1090576a93fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6f4035b-81f4-465b-8277-53e79a09f75c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b81b8a6b-ce52-4b11-b6c0-12f3aeed0c4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b873c3d0-8b9e-4fc0-817e-06f89313668b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9f5bd6b-4675-49ff-9b12-0a985c25a12e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be05b3c4-7057-487e-8d3c-20e2ce5c3e79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("befdace8-523b-4fd7-97a7-b4b4aaa56814"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c00ee0a9-6793-4de8-b196-4fdedd8d21d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0b09b19-3165-4b17-88c9-08a3a8e95fcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2240ba0-eba0-4f6b-8b4c-8a95c7f7a3a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c4ad235a-6839-4770-8c0c-0464e48722c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c54d1cfe-7600-4437-80bd-02a8bdc2e3ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c785d2a0-8c2d-4069-b6b6-b9601a787c92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7ee8bb2-1b78-44d4-a6a5-71b88a27a655"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8375ecc-7e84-411b-9d68-72c112dacd30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8e6fc84-d73c-4ac8-90ae-1142bfd22ad3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c953e9d3-90fa-48e9-b146-a037df561de7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c96677b6-d909-47ea-afa9-d51baebb326b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca5e9ff9-f13f-4f41-8823-fd5708f4e6bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf4b49fe-2905-4364-a216-95329f9f1b88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfcc6af0-c8be-4d16-be1e-b3ab891648c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d451be8f-1ba4-4120-ac75-3987549fd332"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d55798ad-5f76-418f-9f00-d1def52caedf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d65210a2-6e44-4b16-9f07-07d248f92316"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6625b3a-4363-4d1f-a5cc-50fb297f7d1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d666983d-b873-4cff-afbe-329990186d94"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7554ced-897e-4e1b-8a4e-4d02ebf90a34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7fd8286-dc43-45d9-8deb-f46d76af8fa9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d888c9d8-345b-47fe-be69-fecb851ed6b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d958f206-ecd8-4e7b-baf1-d35ae84c05ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dae1b4f3-ea28-4d9f-a4da-9e12b8714f1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db7a3b3d-0d4b-4bb4-83c5-f659b903da23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dbf345b0-047d-4432-9daa-f92a96fcbe97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd88b7eb-1733-4554-8671-c51bcf7df29e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e043bc89-4079-4a20-8be8-1f60959a18a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2a74aac-c739-4c0f-ad95-a655c3667c4b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3220225-cd78-47f0-b926-e3685c32679f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3c89890-d632-47bd-8bb2-c3db0594a54e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3f3b0e4-6e3e-4712-b864-a87bb1fd8c74"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e448299c-1e62-4701-aeac-b68e143ec585"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5345ea5-e6dd-4146-9722-35bfe7b22398"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e77d17b6-b595-4752-a927-28b00ac922fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea0fff09-d9ae-4b99-b836-4e7fc3c7f605"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb226a36-96b6-42ab-91d4-f4115815599c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb8f8188-7dc7-4115-9bfa-a25d4b31a594"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eca1cc5a-2480-472e-8097-7d9ade95e9a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed9e70b3-c1f6-4876-b79c-6071cc74eab1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eda244ca-938e-4da7-8867-e52ae4543ff7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("edd553fd-913b-4915-b1fa-7c401a75c613"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee5ccb76-072d-477a-ace1-c0efd8068bdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef298b0f-a89e-4135-b143-bc4a332976ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f13d726c-f8fb-4b12-b9a5-40bb74d2fe7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1f22a81-81fa-4104-9318-f1446c28883b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f24b737e-187d-4d29-9a76-6a787c6bb1b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f26d678f-61bf-410b-8b01-5b5deedc6e30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f2db955e-a6b5-4314-a3e2-6246ce4d9a9f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3ed4cab-45cb-486e-a8a5-87829b328edd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6c94150-39ba-432b-a5af-fd0afee5f2a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6f4cf5e-d2a9-47fa-a094-ea028186cefe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6f7ca8f-d890-4faf-b1ae-cfd9ea31339f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f862b2bd-e56f-46bb-be55-744f344361dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f86a61ed-908b-468f-b298-b8fbaf8c15bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8855258-3ee1-4f75-b427-f277ea1bfd04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa917ab1-135d-4268-b3d0-25bf94784f6a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("faa260bd-26d2-46df-a02e-21cad7f75b46"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe14d12a-ff97-44aa-a005-ef1580b82136"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff814ad8-43d2-47e4-b395-cbbc3878863f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ffcc8c05-4d48-4d3b-9021-87dfa4c91f14"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4"));

            migrationBuilder.RenameColumn(
                name: "FilmSreeningId",
                table: "Items",
                newName: "FilmScreeningId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_FilmSreeningId",
                table: "Items",
                newName: "IX_Items_FilmScreeningId");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "FilmScreenings",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5452a684-8c37-4c79-93f2-7076ff214453"), "Productor Ejecutivo" },
                    { new Guid("705ac51a-0a7b-48f2-baf4-951ba5cf5440"), "Técnico de Sonido" },
                    { new Guid("4ca8d303-dff6-408d-ba3a-697a5c2f17ee"), "Diseñador de Vestuario" },
                    { new Guid("4b928c9b-fd7f-4f98-a550-bbee5e0efb1a"), "Guionista" },
                    { new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Actor" },
                    { new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Director" },
                    { new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"), "Productor" },
                    { new Guid("c2831323-7581-47ca-8646-f79985a70371"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre", "1999" },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22c8252d-5087-4cd1-b952-6884e3dff31d"), "Erótico" },
                    { new Guid("df83884f-3e15-4e8f-905e-871d674aa522"), "Musical" },
                    { new Guid("a7082017-1e04-4c2d-9d23-78a66972fabc"), "Aventura" },
                    { new Guid("78035d02-4c54-4954-83a2-cda28613ac7d"), "Ciencia Ficción" },
                    { new Guid("e813ec7a-fb73-4a40-b7b3-118f140ad755"), "Ficción" },
                    { new Guid("de5bd9d7-79e1-4033-adf9-b32a6ccfc4c9"), "Documental" },
                    { new Guid("08dd8650-1ac7-4bfd-ad10-b67b6af94523"), "Romántica" },
                    { new Guid("6e1761c6-e233-4b2a-a2c6-58cb1d2b6aa9"), "Tragicomedia" },
                    { new Guid("d625d02b-7372-4ac7-8a45-d316467a82db"), "Terror" },
                    { new Guid("ffc67afb-a336-45df-b927-ce0b45fe99bc"), "Suspenso" },
                    { new Guid("dba1222d-210e-4758-8bc5-30860d65f40d"), "Comedia" },
                    { new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989"), "Drama" },
                    { new Guid("456712f2-3244-4f47-90d4-c95415b7104c"), "Histórico" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), "Platea Baja", 10 },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "PriceModifications",
                columns: new[] { "Id", "Description", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("f397cfaf-ad43-4f5b-bb56-c877dbebfcd8"), "Descuento por el día de las madres.", "Madres", "Descuento", 10 },
                    { new Guid("2406a3a2-ce26-49d9-a787-623df6147808"), "Descuento del 10% para estudiantes que muestren el carnet.", "Estudiante", "Descuento", 10 },
                    { new Guid("43733fae-dd40-4e69-ac3d-1127ddec9d2c"), "Descuento decidido por la dirección del cine..", "Descuento del Director", "Descuento", 10 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), "Sala 2" },
                    { new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), "Sala 1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("f823f81c-2469-4814-bf53-64bfd31b4868"), "F2" },
                    { new Guid("89d4a5f7-92e9-42fa-b7f2-299eeb97acac"), "G1" },
                    { new Guid("7d9d3783-3e7e-4997-aa83-3f04fc61a3aa"), "G2" },
                    { new Guid("24cf357d-3008-4723-9cb5-0ff2553d1307"), "H1" },
                    { new Guid("9c3bc052-2a6a-408d-9034-2c0ae8965483"), "H2" },
                    { new Guid("f8f0bf34-30e4-428f-a4f8-c7e8ab63f735"), "A1" },
                    { new Guid("08271696-f523-44c2-9fdc-7c117f21ab15"), "A2" },
                    { new Guid("06ba34ab-6779-47de-bb8c-daf53d88e223"), "A3" },
                    { new Guid("ed21557d-f654-41af-bf5e-3b499d4e8132"), "B1" },
                    { new Guid("7c6191a7-91bf-4aac-b67d-f6fea4dae904"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("134611ce-18f7-4950-aff3-31c641f2a8b5"), "B3" },
                    { new Guid("f5b88807-d567-49fc-bdfd-cfcb54f8c444"), "C1" },
                    { new Guid("fb813e8f-e21d-49f3-8686-6e8a19ecbd95"), "C2" },
                    { new Guid("04ef72d7-88cb-4c02-859e-a9bc84751d59"), "C3" },
                    { new Guid("1ee8670d-7ff1-4890-8173-c04339b37a25"), "D1" },
                    { new Guid("9c888afc-b2bd-482d-8472-e580ea0ecec1"), "D2" },
                    { new Guid("0ae5b952-6b26-4be4-bc9c-6e7e5f94cb29"), "E1" },
                    { new Guid("e9e6b71a-e87a-45f9-91f6-e2467f08c830"), "E2" },
                    { new Guid("9ba11fd9-108b-4a8b-8c8e-ee790dfafaff"), "E3" },
                    { new Guid("93c459f6-b639-460b-9a49-1d16a186111e"), "F1" },
                    { new Guid("35e9cbcc-61d6-4cdc-b660-50aeff6c5d91"), "F2" },
                    { new Guid("286dc4b9-b1ab-4530-8b81-06607a675754"), "F3" },
                    { new Guid("84ae1085-46ad-43b3-834e-7901fb144006"), "G1" },
                    { new Guid("e8abe0dc-4dab-496e-b971-3c9b6e1de6eb"), "G2" },
                    { new Guid("6dd16957-be71-40ff-ae70-5b4482c71cd2"), "G3" },
                    { new Guid("95a3d4c1-f90f-4089-bf8f-d9543345609e"), "H1" },
                    { new Guid("239f64d3-e342-4149-9bf4-1fc4ad40a9f8"), "H2" },
                    { new Guid("638e1b18-5c6a-4a0e-b8fb-487f00bce3d7"), "H3" },
                    { new Guid("5bb393fe-2831-4235-9de4-794bea9e8901"), "A1" },
                    { new Guid("aace7863-4a56-4df6-8d29-05178cd3733b"), "D3" },
                    { new Guid("6aaa6280-74db-46fc-9609-6052c682de60"), "F1" },
                    { new Guid("65eaea37-7f81-48b6-ac71-3248596af00b"), "G1" },
                    { new Guid("85e3dc30-40e7-4ffa-bd54-febf65868cca"), "E1" },
                    { new Guid("3aa13bc9-5b31-4ca8-bd63-0a21fda7c963"), "A3" },
                    { new Guid("2263883a-c11e-4cef-a080-71f48c0d2e9c"), "B1" },
                    { new Guid("e335dfff-a9f4-49ec-ba6e-a36b955106e1"), "B2" },
                    { new Guid("e53a6c7b-9918-4f67-8119-1d5c1df84346"), "B3" },
                    { new Guid("5927d566-800e-4101-87d0-48e5249c4cd9"), "C1" },
                    { new Guid("be4b8fe1-b851-469a-a2bd-5f2529a49c55"), "C2" },
                    { new Guid("2a02eff3-5d4e-4241-b7c9-4c0a77da2196"), "C3" },
                    { new Guid("04b57aca-b833-4520-a7ee-0894b75d987a"), "D1" },
                    { new Guid("e87ae393-4d9c-4dff-ad9d-4e30b6600fa8"), "D2" },
                    { new Guid("49ffa2f9-3e36-4bbf-87db-bc0055000da8"), "D3" },
                    { new Guid("b188afcf-9a47-4e90-a4ef-eff4c453094f"), "E1" },
                    { new Guid("98df2520-53ca-488f-8bb0-c4dd48e401fa"), "E2" },
                    { new Guid("f6a60d5d-d088-4db5-82b2-a6706e74de7d"), "E3" },
                    { new Guid("e201a649-e16a-4960-9d4a-8bde0f1ab155"), "F1" },
                    { new Guid("b7625780-c673-407b-a703-32d0498a5b0b"), "E2" },
                    { new Guid("cc218517-c1e6-492b-b6f4-e0c65668551c"), "F2" },
                    { new Guid("b16889c5-c8c5-4f01-a203-8916fdaae98d"), "B1" },
                    { new Guid("836a7521-4122-4c2a-91d1-7f08cfb36ff9"), "G2" },
                    { new Guid("d736827d-0ced-46d3-90ca-b9bc14330b0f"), "G3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("ee5854c0-96f6-4d4a-8613-b8366db9e5cc"), "H1" },
                    { new Guid("4d96f704-3a7f-4825-8530-7e0fc9ae720c"), "H2" },
                    { new Guid("882cad48-3185-4b4b-b12d-c8858fa87951"), "H3" },
                    { new Guid("7bb7152c-7d77-4bce-8301-d8af30e68a43"), "A1" },
                    { new Guid("a23908d6-394e-49c9-b13d-a2f208dfbc0b"), "A2" },
                    { new Guid("dc7d23d9-af23-4242-8abf-1395290f4dcd"), "B1" },
                    { new Guid("3b8020c3-6bc4-4129-8428-cb1827158a17"), "B2" },
                    { new Guid("d3b79e1f-b122-4cf2-bb88-1abc1ac8b098"), "C1" },
                    { new Guid("f6be647d-b4b2-411a-91e8-b202e893d417"), "C2" },
                    { new Guid("a6f08daf-dfa8-4362-ac1c-bbbc4d1e0452"), "D1" },
                    { new Guid("3d156e5b-03e8-4302-8d0e-201c692e07fa"), "D2" },
                    { new Guid("236014a1-0219-46c0-8eb3-1867ac20ff20"), "F3" },
                    { new Guid("69807a31-f7ea-47e5-afae-5d7fddd474c3"), "B2" },
                    { new Guid("46963e8b-01c5-4c5c-8143-7f257eff56f4"), "F4" },
                    { new Guid("aaa64563-3cd3-4341-9669-4d0b29f5660e"), "C2" },
                    { new Guid("b0c71c90-4d6d-40f2-90a4-ed44a75ed472"), "D1" },
                    { new Guid("699b6828-d53d-42dc-beaa-550b94de2ca0"), "D2" },
                    { new Guid("7bd2d1e2-1273-42f8-9686-da2a2aa481d2"), "D3" },
                    { new Guid("03fca8ac-4fb4-4f24-89fb-d4aa679cf826"), "D4" },
                    { new Guid("8e1c0ea6-e7e7-4498-99c7-dc1d23b662b6"), "E1" },
                    { new Guid("41f64d8d-ad1c-4782-a853-1a49f6b5bc1a"), "E2" },
                    { new Guid("8e2770bd-a08b-46e9-b90c-f86b23b93fa1"), "E3" },
                    { new Guid("9c75553c-8fb0-4351-8457-37c090e5b90e"), "F1" },
                    { new Guid("da8838fb-b8eb-4519-baa6-ebd50f94c23d"), "F2" },
                    { new Guid("7aa6884b-ac43-4843-a3d5-14cca7e43ca6"), "A1" },
                    { new Guid("081bf461-f815-44bf-bd39-a6da77247a77"), "B1" },
                    { new Guid("da4e032f-63d2-435d-9e15-52135d2b89fa"), "B2" },
                    { new Guid("378e005c-dec0-4d58-93d9-2109f5928fe4"), "C1" },
                    { new Guid("94708d83-d243-419a-a83a-a7c3405e76fe"), "C2" },
                    { new Guid("3bd99a8d-ee02-40cb-b169-47308face6ac"), "C5" },
                    { new Guid("77500cdf-b578-46df-b909-6290e239440f"), "C3" },
                    { new Guid("d799fbd5-9364-4a7c-9b29-ea4ce5b2ec31"), "D2" },
                    { new Guid("a05abe5f-caba-4126-89ee-1d50f9ff81da"), "D3" },
                    { new Guid("4f4c9a97-c925-48ac-a1af-69f9eaf57c58"), "D4" },
                    { new Guid("bef35c44-5b57-416e-a1ca-4b99e4cc4871"), "E1" },
                    { new Guid("2cb9a855-e181-455f-b2f8-a20024f5776a"), "E2" },
                    { new Guid("7585bc37-5fb2-48e2-b5cc-1fe1ad5dd182"), "E3" },
                    { new Guid("32ae90b0-1c97-4a2b-9d9f-f6908471c808"), "E4" },
                    { new Guid("5b3d29ab-42b1-436f-b354-32256fe68c31"), "E5" },
                    { new Guid("69420043-e4fe-4b5b-877e-77417e553a97"), "F1" },
                    { new Guid("39dbdba4-0121-44f6-8f70-8ec20924e9e7"), "F2" },
                    { new Guid("11ee1642-8883-47ed-901d-d7f2f77e8cf9"), "F3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("5d2d1f84-e17c-46c8-879a-6ef97890cc07"), "F4" },
                    { new Guid("01e312e9-09e0-45ce-82f8-57e76904f69e"), "F5" },
                    { new Guid("56fad215-3688-4c13-8b3e-e6f436f95781"), "F6" },
                    { new Guid("38c0e16f-58bc-424b-b6d5-b9bd03a32d53"), "D1" },
                    { new Guid("e7f96a09-1c51-4a4e-ad63-5b95cacde62c"), "C1" },
                    { new Guid("183990b4-6e41-450c-be86-a592c71ca4d4"), "C4" },
                    { new Guid("5904f07d-f022-40e0-9f30-1a42d717050f"), "C2" },
                    { new Guid("df578954-b0a2-4cb7-a89e-5ea5e2be0113"), "C3" },
                    { new Guid("b3006f87-b46f-4419-871b-e3eca7b904ce"), "D1" },
                    { new Guid("a5a77876-c592-4b85-8b43-cdada2facecf"), "D2" },
                    { new Guid("775f8974-bf9d-4a10-8586-72370143bf58"), "D3" },
                    { new Guid("e95160e2-dffe-4716-8bc1-a3175932794f"), "D4" },
                    { new Guid("3bc86d21-8600-4a54-8a1a-18b7286ae114"), "E1" },
                    { new Guid("b5cbb3c7-6513-4dc4-855a-f962754dff9b"), "E2" },
                    { new Guid("efd86dfb-f6ac-4c78-935c-f179f7de0303"), "E3" },
                    { new Guid("a27d88bd-eb93-48dc-a506-bf83741c923d"), "E4" },
                    { new Guid("7682f218-419a-4d3e-ab9a-5a5b9a9b8dc3"), "E5" },
                    { new Guid("cc2710bf-bb56-4d75-bf28-0183521e3a8e"), "F1" },
                    { new Guid("d62daf61-875c-4d5e-b7ce-7353901c91a4"), "F2" },
                    { new Guid("61caae62-5bc6-4005-97a8-9222ed9972f0"), "F3" },
                    { new Guid("3f46cee2-f7d3-4bb1-bb0e-14fe577e5071"), "A2" },
                    { new Guid("8c034a3d-1c53-4a49-8c19-4e349fc70ec3"), "C3" },
                    { new Guid("3130c244-3511-4bba-875c-746aeec5fc84"), "F5" },
                    { new Guid("d5243165-5ad2-4f00-b602-90f6e3bacc40"), "A1" },
                    { new Guid("e06857de-afa2-44c9-8dbb-5938454fbae6"), "A2" },
                    { new Guid("e8e838c1-4348-45f1-8ff4-f22a421d53b2"), "A3" },
                    { new Guid("f7d2d75e-8460-4789-beac-26bb7297aecc"), "A4" },
                    { new Guid("2028cde3-3c68-490f-9562-aac94b88515b"), "A5" },
                    { new Guid("33b0bd32-b9ec-497a-ae61-c446c82b71ac"), "A6" },
                    { new Guid("840a6838-a7a9-429a-acb3-2e92d9dacfbc"), "A7" },
                    { new Guid("3351391d-a904-498a-bf4c-54c073a191c5"), "B1" },
                    { new Guid("f8fa33a7-59f5-4fe2-970f-751610a54695"), "B2" },
                    { new Guid("d84b24ef-e327-4d26-a9d4-16da6edccf2f"), "B3" },
                    { new Guid("369e1519-8623-4938-a9bd-6145a2c8f0e0"), "B4" },
                    { new Guid("4cf1bb79-8268-458b-ad83-a2a82f506039"), "B5" },
                    { new Guid("48b8cd1a-c643-40e9-a4ff-d8c8b930d3ff"), "B6" },
                    { new Guid("0b5d4ced-68a7-48a4-82d9-f2596d2a37d7"), "C1" },
                    { new Guid("b3920fe8-1acc-4028-a75a-1d38ade26b68"), "F6" },
                    { new Guid("8d3aa89f-184d-4f8c-b0bf-ef8f6d625243"), "A1" },
                    { new Guid("af41d9a2-1cfb-4ebe-b7d1-e37417929170"), "D1" },
                    { new Guid("7abdd739-80cc-48f7-b780-38e3ab08596a"), "F5" },
                    { new Guid("b6e87dda-bceb-48f4-b9f3-f22a32adb292"), "F1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("2c5dde44-ed74-4720-9223-55db66ef3b19"), "F2" },
                    { new Guid("a24ad273-7459-426c-bd8f-32f84c16fc49"), "G1" },
                    { new Guid("0bffaa80-7d70-42b9-969c-d801343ffe75"), "G2" },
                    { new Guid("7d2a04a8-2172-41c1-a4d4-84c4776b834d"), "H1" },
                    { new Guid("fecba904-8e80-4ad0-aa24-e64cbe6539db"), "H2" },
                    { new Guid("2bc35507-6cfe-422b-90ad-15d2dbe89efe"), "A1" },
                    { new Guid("400d73e1-2171-43ba-9eea-6fbe2586f84e"), "A2" },
                    { new Guid("7658c167-4479-4110-aff5-e4ac5af8c224"), "A3" },
                    { new Guid("f3d4e51a-1d1d-492d-8fb3-29de77e7e6ca"), "B1" },
                    { new Guid("feb13dd8-6810-4eee-802c-9deaa855c014"), "B2" },
                    { new Guid("e1228792-27bc-4132-bd19-4c6f313b647a"), "B3" },
                    { new Guid("0c1207ef-c0e7-437f-8566-461f64c4f2a7"), "C1" },
                    { new Guid("128ddf64-4299-4d5b-816f-5736a01bd10e"), "C2" },
                    { new Guid("119190ba-93d6-48cf-b64b-f90d7bda6edf"), "C3" },
                    { new Guid("81538962-06b4-43df-8522-a0aec6c06c4c"), "D1" },
                    { new Guid("28b7826b-aeb2-403e-822e-c36d7df26cad"), "D2" },
                    { new Guid("d6759e30-5f02-497a-8141-ca2d2f9596f9"), "D3" },
                    { new Guid("bcc867a9-297e-40d3-aa65-23573b02324b"), "E1" },
                    { new Guid("6897e036-20f3-4b93-adec-5b7681775fae"), "E2" },
                    { new Guid("18e2e982-1cf0-47cc-8fba-4d75bbaad001"), "E3" },
                    { new Guid("299d900f-63b1-4b5d-a6a4-84f314614f82"), "F1" },
                    { new Guid("1f73f5f2-81a7-4f24-aa49-92ffacd398e5"), "F2" },
                    { new Guid("b0607701-fd88-45b4-8a51-fd3591c7951a"), "F3" },
                    { new Guid("4fde48b8-064c-43e5-83f1-bc215226ab8f"), "G1" },
                    { new Guid("903cbdd9-63c1-4fb9-8945-19f04c25308b"), "G2" },
                    { new Guid("76e817b2-6f03-4c6d-8019-07c712745309"), "G3" },
                    { new Guid("4c060b94-8d39-44fe-a673-de600681fa46"), "H1" },
                    { new Guid("dc6cb4d3-10f6-45bc-bb36-e819f83a1769"), "H2" },
                    { new Guid("02c9c1ce-2395-49fe-b5d4-32d8e43f6b95"), "E2" },
                    { new Guid("80dc81fb-fce2-4505-b251-d7ff1ce21fa7"), "E1" },
                    { new Guid("ce30c948-8109-4932-ae05-6702a379f41e"), "D2" },
                    { new Guid("097ba25f-e2d2-4715-8de1-c1c6f98b24a7"), "D1" },
                    { new Guid("ec71467f-cac0-4fc9-8e60-c4722693c325"), "A1" },
                    { new Guid("339e1580-4a62-4f8f-9c85-fbb537a9bc71"), "A2" },
                    { new Guid("65215be7-54fc-4940-b24e-53f9d69732ff"), "A3" },
                    { new Guid("81f244ba-ba43-49cf-8aad-985b8e94e64b"), "B1" },
                    { new Guid("1483eb64-b105-4b77-b5c1-476c1ef45660"), "B2" },
                    { new Guid("aa77f1ac-904e-40d4-a35b-5fa9b4942b69"), "B3" },
                    { new Guid("fc85d3b7-42c0-451e-bb53-8abc03f342bc"), "C1" },
                    { new Guid("25ab41ea-1dc3-41d9-996e-a8a5e0ad0864"), "C2" },
                    { new Guid("de8c0cab-0026-4814-a7e9-403ffe0765e4"), "C3" },
                    { new Guid("bd220dfd-9400-416f-b101-98499df8b5cc"), "D1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("9d27faef-a2db-496f-8094-60d1b5f378e6"), "D2" },
                    { new Guid("2ab38ae6-4550-4ceb-95fa-c596509b1b96"), "D3" },
                    { new Guid("78a73ed9-e947-4354-aff0-e4025e1a9776"), "E1" },
                    { new Guid("ed9af4b8-119c-46a3-81a6-eae76ec48521"), "E2" },
                    { new Guid("7867645a-f8ba-4de6-b639-bbbaf94d423c"), "H3" },
                    { new Guid("19af65ee-ac1c-48be-a90a-e7ec85bf76b9"), "E3" },
                    { new Guid("5e939756-128e-489e-8799-35de91535f85"), "F2" },
                    { new Guid("f861f58d-eae9-4d44-937c-7be72523f522"), "F3" },
                    { new Guid("2db852c8-fa46-46ae-bf62-5ab22953a59b"), "G1" },
                    { new Guid("75d949f5-52b7-4127-8aff-54775bf8f8c6"), "G2" },
                    { new Guid("c1299cc4-dc53-4989-a395-c486d885d640"), "G3" },
                    { new Guid("f125e1b1-5ce9-482a-974a-0e72b295b079"), "H1" },
                    { new Guid("7f848060-7007-4d8b-a704-f4902025458f"), "H2" },
                    { new Guid("36b620a6-f049-49dd-9275-5669d02d21bf"), "H3" },
                    { new Guid("0f9c7045-5c4a-442a-8641-f61a072fe986"), "A1" },
                    { new Guid("24b68663-df78-4ede-aa59-b8db6338ab6e"), "A2" },
                    { new Guid("de553466-2619-4754-ac42-1c178d3e7202"), "B1" },
                    { new Guid("c1f72efd-7492-4289-b64e-f69e36557133"), "B2" },
                    { new Guid("dfec322b-df5d-453d-9eb4-8e551843442a"), "C1" },
                    { new Guid("1b707723-bba2-4682-a3bc-6c7d1349aef8"), "C2" },
                    { new Guid("00c52c11-8912-4015-9333-637b065f5e63"), "F1" },
                    { new Guid("0913a94f-0fdd-4140-b2f8-908051e59d0f"), "F6" },
                    { new Guid("f11bbcfa-6b43-416a-a939-feb8537add3f"), "A1" },
                    { new Guid("7222dc9a-98d4-4f74-b22d-bc7166796175"), "B2" },
                    { new Guid("d5c39193-67c6-4a51-9c52-08fcb67b0b00"), "C4" },
                    { new Guid("9ca29b35-0672-49ca-8d80-5d9e32c5adbe"), "C5" },
                    { new Guid("7400762c-c6de-4464-82e1-eaa7460ecf81"), "D1" },
                    { new Guid("3f71f4e1-8fb9-4869-948e-3ff14354bfc9"), "D2" },
                    { new Guid("fedd86a8-f19a-469c-b164-5faa3762d87d"), "D3" },
                    { new Guid("e11f58e5-29b5-47f6-a49a-5b75e69be22e"), "D4" },
                    { new Guid("d6c8dcf9-6b5a-4ce0-b897-026e97b7ef82"), "E1" },
                    { new Guid("faefeb88-b8c1-437a-ab96-418c22995900"), "E2" },
                    { new Guid("98808f8e-0b6e-4dea-af04-937fceacb7ef"), "E3" },
                    { new Guid("fe7f6a63-873d-416c-8588-aab0d42c96fe"), "F1" },
                    { new Guid("57bd71a1-3044-423e-b932-2c48d94e0192"), "F2" },
                    { new Guid("99f0adee-02a3-4302-8f47-120c83ec426b"), "A1" },
                    { new Guid("2dc29e5b-bb23-47ea-8caa-05e386805f45"), "B1" },
                    { new Guid("504d5dee-d1fa-4dfd-a882-dddaadcaf0b5"), "B2" },
                    { new Guid("786c2287-08ad-43ef-9545-3cb040f3a8d1"), "C1" },
                    { new Guid("6f465db1-4c87-4960-82fa-cccc9e0923b8"), "C2" },
                    { new Guid("bdb100d8-28ed-4180-9b76-b501b2c10c9b"), "C3" },
                    { new Guid("8c603168-f30c-4235-aa6c-526deac9f2d3"), "D2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("ef2da966-3665-481c-a6dd-9a1bb33b920d"), "D3" },
                    { new Guid("430d2a31-8f43-41f2-89d5-4c0a25209055"), "D4" },
                    { new Guid("07740689-9638-4eda-ad43-467811ae8185"), "E1" },
                    { new Guid("c1dffef7-c0b6-4db3-b848-8ffd5b642fa0"), "E2" },
                    { new Guid("9079ca63-6e7e-47be-9dd3-c5d357d7062a"), "E3" },
                    { new Guid("7fc2aaa9-4db6-4116-8e71-2d5d5bebee17"), "E4" },
                    { new Guid("cbdc9072-fb85-425b-88ec-888e2d1eee91"), "E5" },
                    { new Guid("0b1406a1-1230-430d-a8a4-cb3fe74a3ed1"), "F1" },
                    { new Guid("1a77c6f8-c99b-4a2e-8b1c-2e10e5e3675a"), "F2" },
                    { new Guid("6c0f7570-f87c-423c-a7b2-7b82b3335f0d"), "F3" },
                    { new Guid("9ca6f6ee-d2ee-43ba-9ad6-5db4856c7666"), "F4" },
                    { new Guid("3b682099-2a7d-4606-a3f5-5d576b89b192"), "C3" },
                    { new Guid("1e8d5799-3cb2-4ab3-b8d6-d2dab2f67576"), "B1" },
                    { new Guid("1020f852-6744-49ff-a1bb-f2bcc7a04d82"), "C2" },
                    { new Guid("94adfb4e-0d7e-4de1-ad8b-d3674048e81d"), "B6" },
                    { new Guid("4b2fab71-22bc-46b5-89df-8cd4e2a4dacb"), "C1" },
                    { new Guid("dcb6aa09-9a3f-4daa-bc9b-80dbf5a607b0"), "C2" },
                    { new Guid("5685b8b0-31d4-4580-9f20-f503c836b588"), "C3" },
                    { new Guid("b15be5bf-9f39-4cbf-ac36-9c3fe558a788"), "D1" },
                    { new Guid("b057a1b2-29b4-4434-8caa-e9231cfea487"), "D2" },
                    { new Guid("fdaab96c-d4ae-4ee3-bebe-5dee773fe237"), "D3" },
                    { new Guid("cce16485-32c7-4b0a-87be-df844cc7c4d9"), "D4" },
                    { new Guid("2eb5e11d-5256-4050-b27d-9d616f1fcb59"), "E1" },
                    { new Guid("6d4b1ccb-ab48-48b3-a044-64ab41a1529b"), "E2" },
                    { new Guid("8d72ceef-d49f-4e53-9a4d-d7630fabf289"), "E3" },
                    { new Guid("5f3b0865-811a-4a2c-b080-62ceb67c497b"), "E4" },
                    { new Guid("2e065182-c5de-4426-a894-935a59930e69"), "E5" },
                    { new Guid("821f52f3-0d5d-42a7-b174-b1dfe377b227"), "F1" },
                    { new Guid("ed0a3247-bfae-4b6f-947b-e8fd46369a2d"), "C1" },
                    { new Guid("08bd65c5-28f9-430a-bfce-e8278be66ab5"), "F3" },
                    { new Guid("cfd575e3-e86f-43c1-97a2-8c95640c6941"), "F2" },
                    { new Guid("e37b34ec-72bb-4c63-9520-26c1b062d9ed"), "F5" },
                    { new Guid("59f9d7ec-abc5-4174-bc37-495ddf7628ff"), "B5" },
                    { new Guid("0c9f1462-6d79-4f7e-8989-446609c77260"), "B4" },
                    { new Guid("0e88880e-70a1-449f-a745-b216c3e77ff6"), "B3" },
                    { new Guid("9bf5ab22-23bc-4e39-943d-a960dbd9f9fc"), "B2" },
                    { new Guid("28b64af6-87ca-440f-a6ca-0df732d7645d"), "B1" },
                    { new Guid("237664de-9a03-42f0-8fa9-6af6fb90e5b6"), "A7" },
                    { new Guid("2104ee8b-e36c-418c-b8e4-d48d14fac844"), "F4" },
                    { new Guid("2717f0bb-1f80-476b-9fab-e771a0980a76"), "A6" },
                    { new Guid("53d4bfa4-1af8-45e5-a380-2c01f40fabc4"), "A4" },
                    { new Guid("5f7db26c-03f5-4db8-b795-089b007a237f"), "A3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("2ca1c2a6-370e-4f5a-a860-ceda57de47bc"), "A2" },
                    { new Guid("3d94298f-e2c8-47f0-9d7a-f2aa03dd04b9"), "A1" },
                    { new Guid("75cb8aae-3001-4ff2-a3c3-f45ea636c7a7"), "F6" },
                    { new Guid("753e8fa6-dfc7-4e51-bfa0-ccf91a3961b9"), "A5" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("da916e27-72f5-4560-8634-80192e56f4fd"), "Sección 2" },
                    { new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c"), "Sección 1" },
                    { new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Cecilia Roth" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("4ca8d303-dff6-408d-ba3a-697a5c2f17ee"), "Mary Sweeny" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"), "Roger Avary" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"), "Quentin Tarantino" },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Robert Zemeckis" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Quentin Tarantino" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "David Lynch" },
                    { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Pedro Almodovar" },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Robin Wright" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Samuel Jackson" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Una Thurman" },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "John Travolta" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Justin Theroux" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Laura Harring" },
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Naomi Watts" },
                    { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Penélope Cruz" },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("ffc67afb-a336-45df-b927-ce0b45fe99bc") },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("08dd8650-1ac7-4bfd-ad10-b67b6af94523") },
                    { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") },
                    { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") },
                    { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("feb13dd8-6810-4eee-802c-9deaa855c014"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("699b6828-d53d-42dc-beaa-550b94de2ca0"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7bd2d1e2-1273-42f8-9686-da2a2aa481d2"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("03fca8ac-4fb4-4f24-89fb-d4aa679cf826"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8e1c0ea6-e7e7-4498-99c7-dc1d23b662b6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("41f64d8d-ad1c-4782-a853-1a49f6b5bc1a"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8e2770bd-a08b-46e9-b90c-f86b23b93fa1"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c75553c-8fb0-4351-8457-37c090e5b90e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("da8838fb-b8eb-4519-baa6-ebd50f94c23d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2bc35507-6cfe-422b-90ad-15d2dbe89efe"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("400d73e1-2171-43ba-9eea-6fbe2586f84e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7658c167-4479-4110-aff5-e4ac5af8c224"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f3d4e51a-1d1d-492d-8fb3-29de77e7e6ca"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e1228792-27bc-4132-bd19-4c6f313b647a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1f73f5f2-81a7-4f24-aa49-92ffacd398e5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("128ddf64-4299-4d5b-816f-5736a01bd10e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("119190ba-93d6-48cf-b64b-f90d7bda6edf"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("81538962-06b4-43df-8522-a0aec6c06c4c"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("28b7826b-aeb2-403e-822e-c36d7df26cad"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d6759e30-5f02-497a-8141-ca2d2f9596f9"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bcc867a9-297e-40d3-aa65-23573b02324b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6897e036-20f3-4b93-adec-5b7681775fae"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("18e2e982-1cf0-47cc-8fba-4d75bbaad001"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("299d900f-63b1-4b5d-a6a4-84f314614f82"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b0c71c90-4d6d-40f2-90a4-ed44a75ed472"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b0607701-fd88-45b4-8a51-fd3591c7951a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4fde48b8-064c-43e5-83f1-bc215226ab8f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("903cbdd9-63c1-4fb9-8945-19f04c25308b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("76e817b2-6f03-4c6d-8019-07c712745309"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0c1207ef-c0e7-437f-8566-461f64c4f2a7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3bd99a8d-ee02-40cb-b169-47308face6ac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("840a6838-a7a9-429a-acb3-2e92d9dacfbc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8c034a3d-1c53-4a49-8c19-4e349fc70ec3"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a23908d6-394e-49c9-b13d-a2f208dfbc0b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("dc7d23d9-af23-4242-8abf-1395290f4dcd"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3b8020c3-6bc4-4129-8428-cb1827158a17"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d3b79e1f-b122-4cf2-bb88-1abc1ac8b098"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f6be647d-b4b2-411a-91e8-b202e893d417"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a6f08daf-dfa8-4362-ac1c-bbbc4d1e0452"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3d156e5b-03e8-4302-8d0e-201c692e07fa"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("85e3dc30-40e7-4ffa-bd54-febf65868cca"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b7625780-c673-407b-a703-32d0498a5b0b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("6aaa6280-74db-46fc-9609-6052c682de60"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f823f81c-2469-4814-bf53-64bfd31b4868"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("89d4a5f7-92e9-42fa-b7f2-299eeb97acac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7d9d3783-3e7e-4997-aa83-3f04fc61a3aa"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("24cf357d-3008-4723-9cb5-0ff2553d1307"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("183990b4-6e41-450c-be86-a592c71ca4d4"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c3bc052-2a6a-408d-9034-2c0ae8965483"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e06857de-afa2-44c9-8dbb-5938454fbae6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e8e838c1-4348-45f1-8ff4-f22a421d53b2"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f7d2d75e-8460-4789-beac-26bb7297aecc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2028cde3-3c68-490f-9562-aac94b88515b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("33b0bd32-b9ec-497a-ae61-c446c82b71ac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4c060b94-8d39-44fe-a673-de600681fa46"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3351391d-a904-498a-bf4c-54c073a191c5"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f8fa33a7-59f5-4fe2-970f-751610a54695"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d84b24ef-e327-4d26-a9d4-16da6edccf2f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("369e1519-8623-4938-a9bd-6145a2c8f0e0"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4cf1bb79-8268-458b-ad83-a2a82f506039"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("48b8cd1a-c643-40e9-a4ff-d8c8b930d3ff"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("0b5d4ced-68a7-48a4-82d9-f2596d2a37d7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5904f07d-f022-40e0-9f30-1a42d717050f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d5243165-5ad2-4f00-b602-90f6e3bacc40"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dc6cb4d3-10f6-45bc-bb36-e819f83a1769"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("430d2a31-8f43-41f2-89d5-4c0a25209055"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("99f0adee-02a3-4302-8f47-120c83ec426b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9ba11fd9-108b-4a8b-8c8e-ee790dfafaff"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("93c459f6-b639-460b-9a49-1d16a186111e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("35e9cbcc-61d6-4cdc-b660-50aeff6c5d91"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("286dc4b9-b1ab-4530-8b81-06607a675754"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("84ae1085-46ad-43b3-834e-7901fb144006"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e8abe0dc-4dab-496e-b971-3c9b6e1de6eb"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("6dd16957-be71-40ff-ae70-5b4482c71cd2"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("95a3d4c1-f90f-4089-bf8f-d9543345609e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("239f64d3-e342-4149-9bf4-1fc4ad40a9f8"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("638e1b18-5c6a-4a0e-b8fb-487f00bce3d7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7aa6884b-ac43-4843-a3d5-14cca7e43ca6"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("081bf461-f815-44bf-bd39-a6da77247a77"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("da4e032f-63d2-435d-9e15-52135d2b89fa"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("378e005c-dec0-4d58-93d9-2109f5928fe4"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("94708d83-d243-419a-a83a-a7c3405e76fe"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("77500cdf-b578-46df-b909-6290e239440f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("38c0e16f-58bc-424b-b6d5-b9bd03a32d53"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d799fbd5-9364-4a7c-9b29-ea4ce5b2ec31"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a05abe5f-caba-4126-89ee-1d50f9ff81da"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4f4c9a97-c925-48ac-a1af-69f9eaf57c58"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("bef35c44-5b57-416e-a1ca-4b99e4cc4871"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2cb9a855-e181-455f-b2f8-a20024f5776a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7585bc37-5fb2-48e2-b5cc-1fe1ad5dd182"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("32ae90b0-1c97-4a2b-9d9f-f6908471c808"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5b3d29ab-42b1-436f-b354-32256fe68c31"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("69420043-e4fe-4b5b-877e-77417e553a97"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("39dbdba4-0121-44f6-8f70-8ec20924e9e7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("11ee1642-8883-47ed-901d-d7f2f77e8cf9"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5d2d1f84-e17c-46c8-879a-6ef97890cc07"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e9e6b71a-e87a-45f9-91f6-e2467f08c830"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("0ae5b952-6b26-4be4-bc9c-6e7e5f94cb29"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("aace7863-4a56-4df6-8d29-05178cd3733b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c888afc-b2bd-482d-8472-e580ea0ecec1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2dc29e5b-bb23-47ea-8caa-05e386805f45"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("504d5dee-d1fa-4dfd-a882-dddaadcaf0b5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("786c2287-08ad-43ef-9545-3cb040f3a8d1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6f465db1-4c87-4960-82fa-cccc9e0923b8"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bdb100d8-28ed-4180-9b76-b501b2c10c9b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("af41d9a2-1cfb-4ebe-b7d1-e37417929170"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("8c603168-f30c-4235-aa6c-526deac9f2d3"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ef2da966-3665-481c-a6dd-9a1bb33b920d"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7bb7152c-7d77-4bce-8301-d8af30e68a43"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("07740689-9638-4eda-ad43-467811ae8185"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1dffef7-c0b6-4db3-b848-8ffd5b642fa0"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9079ca63-6e7e-47be-9dd3-c5d357d7062a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7fc2aaa9-4db6-4116-8e71-2d5d5bebee17"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cbdc9072-fb85-425b-88ec-888e2d1eee91"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7867645a-f8ba-4de6-b639-bbbaf94d423c"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0b1406a1-1230-430d-a8a4-cb3fe74a3ed1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6c0f7570-f87c-423c-a7b2-7b82b3335f0d"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9ca6f6ee-d2ee-43ba-9ad6-5db4856c7666"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7abdd739-80cc-48f7-b780-38e3ab08596a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0913a94f-0fdd-4140-b2f8-908051e59d0f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f8f0bf34-30e4-428f-a4f8-c7e8ab63f735"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("08271696-f523-44c2-9fdc-7c117f21ab15"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("06ba34ab-6779-47de-bb8c-daf53d88e223"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("ed21557d-f654-41af-bf5e-3b499d4e8132"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7c6191a7-91bf-4aac-b67d-f6fea4dae904"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("134611ce-18f7-4950-aff3-31c641f2a8b5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f5b88807-d567-49fc-bdfd-cfcb54f8c444"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("fb813e8f-e21d-49f3-8686-6e8a19ecbd95"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("04ef72d7-88cb-4c02-859e-a9bc84751d59"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("1ee8670d-7ff1-4890-8173-c04339b37a25"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1a77c6f8-c99b-4a2e-8b1c-2e10e5e3675a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("57bd71a1-3044-423e-b932-2c48d94e0192"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3b682099-2a7d-4606-a3f5-5d576b89b192"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("98808f8e-0b6e-4dea-af04-937fceacb7ef"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2eb5e11d-5256-4050-b27d-9d616f1fcb59"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6d4b1ccb-ab48-48b3-a044-64ab41a1529b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("8d72ceef-d49f-4e53-9a4d-d7630fabf289"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5f3b0865-811a-4a2c-b080-62ceb67c497b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2e065182-c5de-4426-a894-935a59930e69"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("821f52f3-0d5d-42a7-b174-b1dfe377b227"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cfd575e3-e86f-43c1-97a2-8c95640c6941"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("08bd65c5-28f9-430a-bfce-e8278be66ab5"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2104ee8b-e36c-418c-b8e4-d48d14fac844"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e37b34ec-72bb-4c63-9520-26c1b062d9ed"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("75cb8aae-3001-4ff2-a3c3-f45ea636c7a7"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8d3aa89f-184d-4f8c-b0bf-ef8f6d625243"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3f46cee2-f7d3-4bb1-bb0e-14fe577e5071"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3aa13bc9-5b31-4ca8-bd63-0a21fda7c963"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2263883a-c11e-4cef-a080-71f48c0d2e9c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e335dfff-a9f4-49ec-ba6e-a36b955106e1"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e53a6c7b-9918-4f67-8119-1d5c1df84346"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5927d566-800e-4101-87d0-48e5249c4cd9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("be4b8fe1-b851-469a-a2bd-5f2529a49c55"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2a02eff3-5d4e-4241-b7c9-4c0a77da2196"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("04b57aca-b833-4520-a7ee-0894b75d987a"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e87ae393-4d9c-4dff-ad9d-4e30b6600fa8"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("49ffa2f9-3e36-4bbf-87db-bc0055000da8"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b188afcf-9a47-4e90-a4ef-eff4c453094f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("98df2520-53ca-488f-8bb0-c4dd48e401fa"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f6a60d5d-d088-4db5-82b2-a6706e74de7d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e201a649-e16a-4960-9d4a-8bde0f1ab155"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("cc218517-c1e6-492b-b6f4-e0c65668551c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("236014a1-0219-46c0-8eb3-1867ac20ff20"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cce16485-32c7-4b0a-87be-df844cc7c4d9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fdaab96c-d4ae-4ee3-bebe-5dee773fe237"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b057a1b2-29b4-4434-8caa-e9231cfea487"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b15be5bf-9f39-4cbf-ac36-9c3fe558a788"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ec71467f-cac0-4fc9-8e60-c4722693c325"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("339e1580-4a62-4f8f-9c85-fbb537a9bc71"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("65215be7-54fc-4940-b24e-53f9d69732ff"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("81f244ba-ba43-49cf-8aad-985b8e94e64b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1483eb64-b105-4b77-b5c1-476c1ef45660"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("aa77f1ac-904e-40d4-a35b-5fa9b4942b69"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fc85d3b7-42c0-451e-bb53-8abc03f342bc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("25ab41ea-1dc3-41d9-996e-a8a5e0ad0864"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("de8c0cab-0026-4814-a7e9-403ffe0765e4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bd220dfd-9400-416f-b101-98499df8b5cc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9d27faef-a2db-496f-8094-60d1b5f378e6"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2ab38ae6-4550-4ceb-95fa-c596509b1b96"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("78a73ed9-e947-4354-aff0-e4025e1a9776"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ed9af4b8-119c-46a3-81a6-eae76ec48521"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("65eaea37-7f81-48b6-ac71-3248596af00b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("19af65ee-ac1c-48be-a90a-e7ec85bf76b9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5e939756-128e-489e-8799-35de91535f85"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f861f58d-eae9-4d44-937c-7be72523f522"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2db852c8-fa46-46ae-bf62-5ab22953a59b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("75d949f5-52b7-4127-8aff-54775bf8f8c6"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1299cc4-dc53-4989-a395-c486d885d640"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f125e1b1-5ce9-482a-974a-0e72b295b079"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7f848060-7007-4d8b-a704-f4902025458f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("36b620a6-f049-49dd-9275-5669d02d21bf"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f11bbcfa-6b43-416a-a939-feb8537add3f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1e8d5799-3cb2-4ab3-b8d6-d2dab2f67576"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7222dc9a-98d4-4f74-b22d-bc7166796175"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4b2fab71-22bc-46b5-89df-8cd4e2a4dacb"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dcb6aa09-9a3f-4daa-bc9b-80dbf5a607b0"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5685b8b0-31d4-4580-9f20-f503c836b588"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("00c52c11-8912-4015-9333-637b065f5e63"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fe7f6a63-873d-416c-8588-aab0d42c96fe"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("836a7521-4122-4c2a-91d1-7f08cfb36ff9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("ee5854c0-96f6-4d4a-8613-b8366db9e5cc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2c5dde44-ed74-4720-9223-55db66ef3b19"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("a24ad273-7459-426c-bd8f-32f84c16fc49"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0bffaa80-7d70-42b9-969c-d801343ffe75"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7d2a04a8-2172-41c1-a4d4-84c4776b834d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fecba904-8e80-4ad0-aa24-e64cbe6539db"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3d94298f-e2c8-47f0-9d7a-f2aa03dd04b9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2ca1c2a6-370e-4f5a-a860-ceda57de47bc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5f7db26c-03f5-4db8-b795-089b007a237f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("53d4bfa4-1af8-45e5-a380-2c01f40fabc4"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("753e8fa6-dfc7-4e51-bfa0-ccf91a3961b9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2717f0bb-1f80-476b-9fab-e771a0980a76"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("237664de-9a03-42f0-8fa9-6af6fb90e5b6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("28b64af6-87ca-440f-a6ca-0df732d7645d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9bf5ab22-23bc-4e39-943d-a960dbd9f9fc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0e88880e-70a1-449f-a745-b216c3e77ff6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0c9f1462-6d79-4f7e-8989-446609c77260"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("59f9d7ec-abc5-4174-bc37-495ddf7628ff"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("94adfb4e-0d7e-4de1-ad8b-d3674048e81d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ed0a3247-bfae-4b6f-947b-e8fd46369a2d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1020f852-6744-49ff-a1bb-f2bcc7a04d82"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("01e312e9-09e0-45ce-82f8-57e76904f69e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d5c39193-67c6-4a51-9c52-08fcb67b0b00"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9ca29b35-0672-49ca-8d80-5d9e32c5adbe"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7400762c-c6de-4464-82e1-eaa7460ecf81"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3f71f4e1-8fb9-4869-948e-3ff14354bfc9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fedd86a8-f19a-469c-b164-5faa3762d87d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e11f58e5-29b5-47f6-a49a-5b75e69be22e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d6c8dcf9-6b5a-4ce0-b897-026e97b7ef82"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("faefeb88-b8c1-437a-ab96-418c22995900"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b6e87dda-bceb-48f4-b9f3-f22a32adb292"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("02c9c1ce-2395-49fe-b5d4-32d8e43f6b95"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("80dc81fb-fce2-4505-b251-d7ff1ce21fa7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ce30c948-8109-4932-ae05-6702a379f41e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4d96f704-3a7f-4825-8530-7e0fc9ae720c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("882cad48-3185-4b4b-b12d-c8858fa87951"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5bb393fe-2831-4235-9de4-794bea9e8901"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b16889c5-c8c5-4f01-a203-8916fdaae98d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("69807a31-f7ea-47e5-afae-5d7fddd474c3"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e7f96a09-1c51-4a4e-ad63-5b95cacde62c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("aaa64563-3cd3-4341-9669-4d0b29f5660e"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("df578954-b0a2-4cb7-a89e-5ea5e2be0113"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b3006f87-b46f-4419-871b-e3eca7b904ce"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a5a77876-c592-4b85-8b43-cdada2facecf"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("775f8974-bf9d-4a10-8586-72370143bf58"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e95160e2-dffe-4716-8bc1-a3175932794f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3bc86d21-8600-4a54-8a1a-18b7286ae114"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b5cbb3c7-6513-4dc4-855a-f962754dff9b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d736827d-0ced-46d3-90ca-b9bc14330b0f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("efd86dfb-f6ac-4c78-935c-f179f7de0303"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7682f218-419a-4d3e-ab9a-5a5b9a9b8dc3"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("cc2710bf-bb56-4d75-bf28-0183521e3a8e"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d62daf61-875c-4d5e-b7ce-7353901c91a4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("61caae62-5bc6-4005-97a8-9222ed9972f0"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("46963e8b-01c5-4c5c-8143-7f257eff56f4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3130c244-3511-4bba-875c-746aeec5fc84"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b3920fe8-1acc-4028-a75a-1d38ade26b68"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0f9c7045-5c4a-442a-8641-f61a072fe986"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("24b68663-df78-4ede-aa59-b8db6338ab6e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("de553466-2619-4754-ac42-1c178d3e7202"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1f72efd-7492-4289-b64e-f69e36557133"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dfec322b-df5d-453d-9eb4-8e551843442a"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1b707723-bba2-4682-a3bc-6c7d1349aef8"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("097ba25f-e2d2-4715-8de1-c1c6f98b24a7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a27d88bd-eb93-48dc-a506-bf83741c923d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") },
                    { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("56fad215-3688-4c13-8b3e-e6f436f95781"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_FilmScreenings_FilmScreeningId",
                table: "Items",
                column: "FilmScreeningId",
                principalTable: "FilmScreenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_FilmScreenings_FilmScreeningId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("4ca8d303-dff6-408d-ba3a-697a5c2f17ee"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("15b0d369-a509-43c0-89e6-f375df796958"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("08dd8650-1ac7-4bfd-ad10-b67b6af94523") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"), new Guid("ffc67afb-a336-45df-b927-ce0b45fe99bc") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"), new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("4b928c9b-fd7f-4f98-a550-bbee5e0efb1a"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("5452a684-8c37-4c79-93f2-7076ff214453"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("705ac51a-0a7b-48f2-baf4-951ba5cf5440"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c2831323-7581-47ca-8646-f79985a70371"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("22c8252d-5087-4cd1-b952-6884e3dff31d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("456712f2-3244-4f47-90d4-c95415b7104c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6e1761c6-e233-4b2a-a2c6-58cb1d2b6aa9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("78035d02-4c54-4954-83a2-cda28613ac7d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a7082017-1e04-4c2d-9d23-78a66972fabc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d625d02b-7372-4ac7-8a45-d316467a82db"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dba1222d-210e-4758-8bc5-30860d65f40d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("de5bd9d7-79e1-4033-adf9-b32a6ccfc4c9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("df83884f-3e15-4e8f-905e-871d674aa522"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e813ec7a-fb73-4a40-b7b3-118f140ad755"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("2406a3a2-ce26-49d9-a787-623df6147808"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("43733fae-dd40-4e69-ac3d-1127ddec9d2c"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("f397cfaf-ad43-4f5b-bb56-c877dbebfcd8"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("00c52c11-8912-4015-9333-637b065f5e63"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("01e312e9-09e0-45ce-82f8-57e76904f69e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("02c9c1ce-2395-49fe-b5d4-32d8e43f6b95"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("03fca8ac-4fb4-4f24-89fb-d4aa679cf826"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("04b57aca-b833-4520-a7ee-0894b75d987a"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("04ef72d7-88cb-4c02-859e-a9bc84751d59"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("06ba34ab-6779-47de-bb8c-daf53d88e223"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("07740689-9638-4eda-ad43-467811ae8185"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("081bf461-f815-44bf-bd39-a6da77247a77"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("08271696-f523-44c2-9fdc-7c117f21ab15"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("08bd65c5-28f9-430a-bfce-e8278be66ab5"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0913a94f-0fdd-4140-b2f8-908051e59d0f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("097ba25f-e2d2-4715-8de1-c1c6f98b24a7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("0ae5b952-6b26-4be4-bc9c-6e7e5f94cb29"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0b1406a1-1230-430d-a8a4-cb3fe74a3ed1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("0b5d4ced-68a7-48a4-82d9-f2596d2a37d7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0bffaa80-7d70-42b9-969c-d801343ffe75"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0c1207ef-c0e7-437f-8566-461f64c4f2a7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0c9f1462-6d79-4f7e-8989-446609c77260"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0e88880e-70a1-449f-a745-b216c3e77ff6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("0f9c7045-5c4a-442a-8641-f61a072fe986"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1020f852-6744-49ff-a1bb-f2bcc7a04d82"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("119190ba-93d6-48cf-b64b-f90d7bda6edf"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("11ee1642-8883-47ed-901d-d7f2f77e8cf9"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("128ddf64-4299-4d5b-816f-5736a01bd10e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("134611ce-18f7-4950-aff3-31c641f2a8b5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1483eb64-b105-4b77-b5c1-476c1ef45660"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("183990b4-6e41-450c-be86-a592c71ca4d4"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("18e2e982-1cf0-47cc-8fba-4d75bbaad001"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("19af65ee-ac1c-48be-a90a-e7ec85bf76b9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1a77c6f8-c99b-4a2e-8b1c-2e10e5e3675a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1b707723-bba2-4682-a3bc-6c7d1349aef8"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1e8d5799-3cb2-4ab3-b8d6-d2dab2f67576"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("1ee8670d-7ff1-4890-8173-c04339b37a25"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("1f73f5f2-81a7-4f24-aa49-92ffacd398e5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2028cde3-3c68-490f-9562-aac94b88515b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2104ee8b-e36c-418c-b8e4-d48d14fac844"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2263883a-c11e-4cef-a080-71f48c0d2e9c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("236014a1-0219-46c0-8eb3-1867ac20ff20"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("237664de-9a03-42f0-8fa9-6af6fb90e5b6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("239f64d3-e342-4149-9bf4-1fc4ad40a9f8"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("24b68663-df78-4ede-aa59-b8db6338ab6e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("24cf357d-3008-4723-9cb5-0ff2553d1307"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("25ab41ea-1dc3-41d9-996e-a8a5e0ad0864"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2717f0bb-1f80-476b-9fab-e771a0980a76"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("286dc4b9-b1ab-4530-8b81-06607a675754"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("28b64af6-87ca-440f-a6ca-0df732d7645d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("28b7826b-aeb2-403e-822e-c36d7df26cad"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("299d900f-63b1-4b5d-a6a4-84f314614f82"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2a02eff3-5d4e-4241-b7c9-4c0a77da2196"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2ab38ae6-4550-4ceb-95fa-c596509b1b96"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2bc35507-6cfe-422b-90ad-15d2dbe89efe"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2c5dde44-ed74-4720-9223-55db66ef3b19"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2ca1c2a6-370e-4f5a-a860-ceda57de47bc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("2cb9a855-e181-455f-b2f8-a20024f5776a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2db852c8-fa46-46ae-bf62-5ab22953a59b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2dc29e5b-bb23-47ea-8caa-05e386805f45"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2e065182-c5de-4426-a894-935a59930e69"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("2eb5e11d-5256-4050-b27d-9d616f1fcb59"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3130c244-3511-4bba-875c-746aeec5fc84"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("32ae90b0-1c97-4a2b-9d9f-f6908471c808"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3351391d-a904-498a-bf4c-54c073a191c5"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("339e1580-4a62-4f8f-9c85-fbb537a9bc71"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("33b0bd32-b9ec-497a-ae61-c446c82b71ac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("35e9cbcc-61d6-4cdc-b660-50aeff6c5d91"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("369e1519-8623-4938-a9bd-6145a2c8f0e0"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("36b620a6-f049-49dd-9275-5669d02d21bf"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("378e005c-dec0-4d58-93d9-2109f5928fe4"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("38c0e16f-58bc-424b-b6d5-b9bd03a32d53"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("39dbdba4-0121-44f6-8f70-8ec20924e9e7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3aa13bc9-5b31-4ca8-bd63-0a21fda7c963"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3b682099-2a7d-4606-a3f5-5d576b89b192"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3b8020c3-6bc4-4129-8428-cb1827158a17"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3bc86d21-8600-4a54-8a1a-18b7286ae114"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3bd99a8d-ee02-40cb-b169-47308face6ac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3d156e5b-03e8-4302-8d0e-201c692e07fa"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3d94298f-e2c8-47f0-9d7a-f2aa03dd04b9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("3f46cee2-f7d3-4bb1-bb0e-14fe577e5071"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("3f71f4e1-8fb9-4869-948e-3ff14354bfc9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("400d73e1-2171-43ba-9eea-6fbe2586f84e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("41f64d8d-ad1c-4782-a853-1a49f6b5bc1a"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("430d2a31-8f43-41f2-89d5-4c0a25209055"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("46963e8b-01c5-4c5c-8143-7f257eff56f4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("48b8cd1a-c643-40e9-a4ff-d8c8b930d3ff"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("49ffa2f9-3e36-4bbf-87db-bc0055000da8"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4b2fab71-22bc-46b5-89df-8cd4e2a4dacb"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4c060b94-8d39-44fe-a673-de600681fa46"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4cf1bb79-8268-458b-ad83-a2a82f506039"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4d96f704-3a7f-4825-8530-7e0fc9ae720c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("4f4c9a97-c925-48ac-a1af-69f9eaf57c58"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("4fde48b8-064c-43e5-83f1-bc215226ab8f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("504d5dee-d1fa-4dfd-a882-dddaadcaf0b5"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("53d4bfa4-1af8-45e5-a380-2c01f40fabc4"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5685b8b0-31d4-4580-9f20-f503c836b588"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("56fad215-3688-4c13-8b3e-e6f436f95781"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("57bd71a1-3044-423e-b932-2c48d94e0192"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5904f07d-f022-40e0-9f30-1a42d717050f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5927d566-800e-4101-87d0-48e5249c4cd9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("59f9d7ec-abc5-4174-bc37-495ddf7628ff"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5b3d29ab-42b1-436f-b354-32256fe68c31"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5bb393fe-2831-4235-9de4-794bea9e8901"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("5d2d1f84-e17c-46c8-879a-6ef97890cc07"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5e939756-128e-489e-8799-35de91535f85"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5f3b0865-811a-4a2c-b080-62ceb67c497b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("5f7db26c-03f5-4db8-b795-089b007a237f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("61caae62-5bc6-4005-97a8-9222ed9972f0"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("638e1b18-5c6a-4a0e-b8fb-487f00bce3d7"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("65215be7-54fc-4940-b24e-53f9d69732ff"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("65eaea37-7f81-48b6-ac71-3248596af00b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6897e036-20f3-4b93-adec-5b7681775fae"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("69420043-e4fe-4b5b-877e-77417e553a97"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("69807a31-f7ea-47e5-afae-5d7fddd474c3"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("699b6828-d53d-42dc-beaa-550b94de2ca0"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("6aaa6280-74db-46fc-9609-6052c682de60"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6c0f7570-f87c-423c-a7b2-7b82b3335f0d"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6d4b1ccb-ab48-48b3-a044-64ab41a1529b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("6dd16957-be71-40ff-ae70-5b4482c71cd2"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("6f465db1-4c87-4960-82fa-cccc9e0923b8"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7222dc9a-98d4-4f74-b22d-bc7166796175"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7400762c-c6de-4464-82e1-eaa7460ecf81"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("753e8fa6-dfc7-4e51-bfa0-ccf91a3961b9"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7585bc37-5fb2-48e2-b5cc-1fe1ad5dd182"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("75cb8aae-3001-4ff2-a3c3-f45ea636c7a7"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("75d949f5-52b7-4127-8aff-54775bf8f8c6"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7658c167-4479-4110-aff5-e4ac5af8c224"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7682f218-419a-4d3e-ab9a-5a5b9a9b8dc3"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("76e817b2-6f03-4c6d-8019-07c712745309"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("77500cdf-b578-46df-b909-6290e239440f"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("775f8974-bf9d-4a10-8586-72370143bf58"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7867645a-f8ba-4de6-b639-bbbaf94d423c"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("786c2287-08ad-43ef-9545-3cb040f3a8d1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("78a73ed9-e947-4354-aff0-e4025e1a9776"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7aa6884b-ac43-4843-a3d5-14cca7e43ca6"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7abdd739-80cc-48f7-b780-38e3ab08596a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7bb7152c-7d77-4bce-8301-d8af30e68a43"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7bd2d1e2-1273-42f8-9686-da2a2aa481d2"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7c6191a7-91bf-4aac-b67d-f6fea4dae904"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7d2a04a8-2172-41c1-a4d4-84c4776b834d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("7d9d3783-3e7e-4997-aa83-3f04fc61a3aa"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7f848060-7007-4d8b-a704-f4902025458f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("7fc2aaa9-4db6-4116-8e71-2d5d5bebee17"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("80dc81fb-fce2-4505-b251-d7ff1ce21fa7"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("81538962-06b4-43df-8522-a0aec6c06c4c"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("81f244ba-ba43-49cf-8aad-985b8e94e64b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("821f52f3-0d5d-42a7-b174-b1dfe377b227"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("836a7521-4122-4c2a-91d1-7f08cfb36ff9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("840a6838-a7a9-429a-acb3-2e92d9dacfbc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("84ae1085-46ad-43b3-834e-7901fb144006"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("85e3dc30-40e7-4ffa-bd54-febf65868cca"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("882cad48-3185-4b4b-b12d-c8858fa87951"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("89d4a5f7-92e9-42fa-b7f2-299eeb97acac"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8c034a3d-1c53-4a49-8c19-4e349fc70ec3"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("8c603168-f30c-4235-aa6c-526deac9f2d3"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8d3aa89f-184d-4f8c-b0bf-ef8f6d625243"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("8d72ceef-d49f-4e53-9a4d-d7630fabf289"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8e1c0ea6-e7e7-4498-99c7-dc1d23b662b6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("8e2770bd-a08b-46e9-b90c-f86b23b93fa1"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("903cbdd9-63c1-4fb9-8945-19f04c25308b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9079ca63-6e7e-47be-9dd3-c5d357d7062a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("93c459f6-b639-460b-9a49-1d16a186111e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("94708d83-d243-419a-a83a-a7c3405e76fe"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("94adfb4e-0d7e-4de1-ad8b-d3674048e81d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("95a3d4c1-f90f-4089-bf8f-d9543345609e"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("98808f8e-0b6e-4dea-af04-937fceacb7ef"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("98df2520-53ca-488f-8bb0-c4dd48e401fa"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("99f0adee-02a3-4302-8f47-120c83ec426b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9ba11fd9-108b-4a8b-8c8e-ee790dfafaff"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9bf5ab22-23bc-4e39-943d-a960dbd9f9fc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c3bc052-2a6a-408d-9034-2c0ae8965483"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c75553c-8fb0-4351-8457-37c090e5b90e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("9c888afc-b2bd-482d-8472-e580ea0ecec1"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9ca29b35-0672-49ca-8d80-5d9e32c5adbe"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9ca6f6ee-d2ee-43ba-9ad6-5db4856c7666"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("9d27faef-a2db-496f-8094-60d1b5f378e6"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a05abe5f-caba-4126-89ee-1d50f9ff81da"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a23908d6-394e-49c9-b13d-a2f208dfbc0b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("a24ad273-7459-426c-bd8f-32f84c16fc49"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a27d88bd-eb93-48dc-a506-bf83741c923d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a5a77876-c592-4b85-8b43-cdada2facecf"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("a6f08daf-dfa8-4362-ac1c-bbbc4d1e0452"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("aa77f1ac-904e-40d4-a35b-5fa9b4942b69"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("aaa64563-3cd3-4341-9669-4d0b29f5660e"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("aace7863-4a56-4df6-8d29-05178cd3733b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("af41d9a2-1cfb-4ebe-b7d1-e37417929170"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b057a1b2-29b4-4434-8caa-e9231cfea487"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b0607701-fd88-45b4-8a51-fd3591c7951a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b0c71c90-4d6d-40f2-90a4-ed44a75ed472"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b15be5bf-9f39-4cbf-ac36-9c3fe558a788"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b16889c5-c8c5-4f01-a203-8916fdaae98d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b188afcf-9a47-4e90-a4ef-eff4c453094f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b3006f87-b46f-4419-871b-e3eca7b904ce"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b3920fe8-1acc-4028-a75a-1d38ade26b68"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b5cbb3c7-6513-4dc4-855a-f962754dff9b"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("b6e87dda-bceb-48f4-b9f3-f22a32adb292"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("b7625780-c673-407b-a703-32d0498a5b0b"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bcc867a9-297e-40d3-aa65-23573b02324b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bd220dfd-9400-416f-b101-98499df8b5cc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("bdb100d8-28ed-4180-9b76-b501b2c10c9b"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("be4b8fe1-b851-469a-a2bd-5f2529a49c55"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("bef35c44-5b57-416e-a1ca-4b99e4cc4871"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1299cc4-dc53-4989-a395-c486d885d640"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1dffef7-c0b6-4db3-b848-8ffd5b642fa0"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("c1f72efd-7492-4289-b64e-f69e36557133"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cbdc9072-fb85-425b-88ec-888e2d1eee91"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("cc218517-c1e6-492b-b6f4-e0c65668551c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("cc2710bf-bb56-4d75-bf28-0183521e3a8e"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cce16485-32c7-4b0a-87be-df844cc7c4d9"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ce30c948-8109-4932-ae05-6702a379f41e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("cfd575e3-e86f-43c1-97a2-8c95640c6941"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d3b79e1f-b122-4cf2-bb88-1abc1ac8b098"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d5243165-5ad2-4f00-b602-90f6e3bacc40"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d5c39193-67c6-4a51-9c52-08fcb67b0b00"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d62daf61-875c-4d5e-b7ce-7353901c91a4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d6759e30-5f02-497a-8141-ca2d2f9596f9"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("d6c8dcf9-6b5a-4ce0-b897-026e97b7ef82"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d736827d-0ced-46d3-90ca-b9bc14330b0f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d799fbd5-9364-4a7c-9b29-ea4ce5b2ec31"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("d84b24ef-e327-4d26-a9d4-16da6edccf2f"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("da4e032f-63d2-435d-9e15-52135d2b89fa"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("da8838fb-b8eb-4519-baa6-ebd50f94c23d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dc6cb4d3-10f6-45bc-bb36-e819f83a1769"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("dc7d23d9-af23-4242-8abf-1395290f4dcd"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dcb6aa09-9a3f-4daa-bc9b-80dbf5a607b0"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("de553466-2619-4754-ac42-1c178d3e7202"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("de8c0cab-0026-4814-a7e9-403ffe0765e4"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("df578954-b0a2-4cb7-a89e-5ea5e2be0113"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("dfec322b-df5d-453d-9eb4-8e551843442a"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e06857de-afa2-44c9-8dbb-5938454fbae6"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e11f58e5-29b5-47f6-a49a-5b75e69be22e"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e1228792-27bc-4132-bd19-4c6f313b647a"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e201a649-e16a-4960-9d4a-8bde0f1ab155"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e335dfff-a9f4-49ec-ba6e-a36b955106e1"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("e37b34ec-72bb-4c63-9520-26c1b062d9ed"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e53a6c7b-9918-4f67-8119-1d5c1df84346"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e7f96a09-1c51-4a4e-ad63-5b95cacde62c"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e87ae393-4d9c-4dff-ad9d-4e30b6600fa8"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e8abe0dc-4dab-496e-b971-3c9b6e1de6eb"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e8e838c1-4348-45f1-8ff4-f22a421d53b2"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e95160e2-dffe-4716-8bc1-a3175932794f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("e9e6b71a-e87a-45f9-91f6-e2467f08c830"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ec71467f-cac0-4fc9-8e60-c4722693c325"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ed0a3247-bfae-4b6f-947b-e8fd46369a2d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("ed21557d-f654-41af-bf5e-3b499d4e8132"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ed9af4b8-119c-46a3-81a6-eae76ec48521"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("ee5854c0-96f6-4d4a-8613-b8366db9e5cc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("ef2da966-3665-481c-a6dd-9a1bb33b920d"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("efd86dfb-f6ac-4c78-935c-f179f7de0303"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f11bbcfa-6b43-416a-a939-feb8537add3f"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f125e1b1-5ce9-482a-974a-0e72b295b079"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f3d4e51a-1d1d-492d-8fb3-29de77e7e6ca"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f5b88807-d567-49fc-bdfd-cfcb54f8c444"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f6a60d5d-d088-4db5-82b2-a6706e74de7d"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f6be647d-b4b2-411a-91e8-b202e893d417"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f7d2d75e-8460-4789-beac-26bb7297aecc"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f823f81c-2469-4814-bf53-64bfd31b4868"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("f861f58d-eae9-4d44-937c-7be72523f522"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f8f0bf34-30e4-428f-a4f8-c7e8ab63f735"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("f8fa33a7-59f5-4fe2-970f-751610a54695"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("faefeb88-b8c1-437a-ab96-418c22995900"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"), new Guid("fb813e8f-e21d-49f3-8686-6e8a19ecbd95"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fc85d3b7-42c0-451e-bb53-8abc03f342bc"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fdaab96c-d4ae-4ee3-bebe-5dee773fe237"), new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fe7f6a63-873d-416c-8588-aab0d42c96fe"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("feb13dd8-6810-4eee-802c-9deaa855c014"), new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fecba904-8e80-4ad0-aa24-e64cbe6539db"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"), new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"), new Guid("fedd86a8-f19a-469c-b164-5faa3762d87d"), new Guid("da916e27-72f5-4560-8634-80192e56f4fd") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("0cdf5db6-cc14-4a6b-8aee-490162d7b7d8"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("4ca8d303-dff6-408d-ba3a-697a5c2f17ee"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("7b66766b-4f6f-4936-9bb3-dc3ac47fecb3"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("92fc9474-0d59-42a0-ba04-882bddc9d078"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("15b0d369-a509-43c0-89e6-f375df796958"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("520bab8b-7c07-46ec-a48e-36f00fb6d13b"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("6df99c3f-9f0c-4831-8657-c208802b8f4a"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("e5ebdde4-1bf7-4e28-b1ee-3a22e9af1875"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("08dd8650-1ac7-4bfd-ad10-b67b6af94523"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("82dbaf55-589a-4aa0-bc36-58a9281b0989"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ffc67afb-a336-45df-b927-ce0b45fe99bc"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("8046259c-a5d6-4be2-9662-1e2c403e728a"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("c920dce1-b4e0-49fd-83dc-b83a1e91fb30"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("80e82cf3-d538-4c7f-8a18-972dbb2eabc9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ac6947b8-fe66-4689-a108-35b579b2052c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00c52c11-8912-4015-9333-637b065f5e63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01e312e9-09e0-45ce-82f8-57e76904f69e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02c9c1ce-2395-49fe-b5d4-32d8e43f6b95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03fca8ac-4fb4-4f24-89fb-d4aa679cf826"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04b57aca-b833-4520-a7ee-0894b75d987a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04ef72d7-88cb-4c02-859e-a9bc84751d59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06ba34ab-6779-47de-bb8c-daf53d88e223"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07740689-9638-4eda-ad43-467811ae8185"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("081bf461-f815-44bf-bd39-a6da77247a77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08271696-f523-44c2-9fdc-7c117f21ab15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08bd65c5-28f9-430a-bfce-e8278be66ab5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0913a94f-0fdd-4140-b2f8-908051e59d0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("097ba25f-e2d2-4715-8de1-c1c6f98b24a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ae5b952-6b26-4be4-bc9c-6e7e5f94cb29"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b1406a1-1230-430d-a8a4-cb3fe74a3ed1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b5d4ced-68a7-48a4-82d9-f2596d2a37d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bffaa80-7d70-42b9-969c-d801343ffe75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c1207ef-c0e7-437f-8566-461f64c4f2a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c9f1462-6d79-4f7e-8989-446609c77260"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e88880e-70a1-449f-a745-b216c3e77ff6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f9c7045-5c4a-442a-8641-f61a072fe986"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1020f852-6744-49ff-a1bb-f2bcc7a04d82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("119190ba-93d6-48cf-b64b-f90d7bda6edf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11ee1642-8883-47ed-901d-d7f2f77e8cf9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("128ddf64-4299-4d5b-816f-5736a01bd10e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("134611ce-18f7-4950-aff3-31c641f2a8b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1483eb64-b105-4b77-b5c1-476c1ef45660"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("183990b4-6e41-450c-be86-a592c71ca4d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18e2e982-1cf0-47cc-8fba-4d75bbaad001"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19af65ee-ac1c-48be-a90a-e7ec85bf76b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a77c6f8-c99b-4a2e-8b1c-2e10e5e3675a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1b707723-bba2-4682-a3bc-6c7d1349aef8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e8d5799-3cb2-4ab3-b8d6-d2dab2f67576"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ee8670d-7ff1-4890-8173-c04339b37a25"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f73f5f2-81a7-4f24-aa49-92ffacd398e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2028cde3-3c68-490f-9562-aac94b88515b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2104ee8b-e36c-418c-b8e4-d48d14fac844"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2263883a-c11e-4cef-a080-71f48c0d2e9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("236014a1-0219-46c0-8eb3-1867ac20ff20"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("237664de-9a03-42f0-8fa9-6af6fb90e5b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("239f64d3-e342-4149-9bf4-1fc4ad40a9f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24b68663-df78-4ede-aa59-b8db6338ab6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24cf357d-3008-4723-9cb5-0ff2553d1307"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25ab41ea-1dc3-41d9-996e-a8a5e0ad0864"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2717f0bb-1f80-476b-9fab-e771a0980a76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("286dc4b9-b1ab-4530-8b81-06607a675754"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28b64af6-87ca-440f-a6ca-0df732d7645d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28b7826b-aeb2-403e-822e-c36d7df26cad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("299d900f-63b1-4b5d-a6a4-84f314614f82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a02eff3-5d4e-4241-b7c9-4c0a77da2196"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ab38ae6-4550-4ceb-95fa-c596509b1b96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bc35507-6cfe-422b-90ad-15d2dbe89efe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c5dde44-ed74-4720-9223-55db66ef3b19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ca1c2a6-370e-4f5a-a860-ceda57de47bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cb9a855-e181-455f-b2f8-a20024f5776a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2db852c8-fa46-46ae-bf62-5ab22953a59b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2dc29e5b-bb23-47ea-8caa-05e386805f45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e065182-c5de-4426-a894-935a59930e69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2eb5e11d-5256-4050-b27d-9d616f1fcb59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3130c244-3511-4bba-875c-746aeec5fc84"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32ae90b0-1c97-4a2b-9d9f-f6908471c808"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3351391d-a904-498a-bf4c-54c073a191c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("339e1580-4a62-4f8f-9c85-fbb537a9bc71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33b0bd32-b9ec-497a-ae61-c446c82b71ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35e9cbcc-61d6-4cdc-b660-50aeff6c5d91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("369e1519-8623-4938-a9bd-6145a2c8f0e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36b620a6-f049-49dd-9275-5669d02d21bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("378e005c-dec0-4d58-93d9-2109f5928fe4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38c0e16f-58bc-424b-b6d5-b9bd03a32d53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39dbdba4-0121-44f6-8f70-8ec20924e9e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aa13bc9-5b31-4ca8-bd63-0a21fda7c963"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b682099-2a7d-4606-a3f5-5d576b89b192"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b8020c3-6bc4-4129-8428-cb1827158a17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bc86d21-8600-4a54-8a1a-18b7286ae114"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bd99a8d-ee02-40cb-b169-47308face6ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d156e5b-03e8-4302-8d0e-201c692e07fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d94298f-e2c8-47f0-9d7a-f2aa03dd04b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f46cee2-f7d3-4bb1-bb0e-14fe577e5071"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f71f4e1-8fb9-4869-948e-3ff14354bfc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("400d73e1-2171-43ba-9eea-6fbe2586f84e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41f64d8d-ad1c-4782-a853-1a49f6b5bc1a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("430d2a31-8f43-41f2-89d5-4c0a25209055"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46963e8b-01c5-4c5c-8143-7f257eff56f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48b8cd1a-c643-40e9-a4ff-d8c8b930d3ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49ffa2f9-3e36-4bbf-87db-bc0055000da8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b2fab71-22bc-46b5-89df-8cd4e2a4dacb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c060b94-8d39-44fe-a673-de600681fa46"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cf1bb79-8268-458b-ad83-a2a82f506039"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d96f704-3a7f-4825-8530-7e0fc9ae720c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f4c9a97-c925-48ac-a1af-69f9eaf57c58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fde48b8-064c-43e5-83f1-bc215226ab8f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("504d5dee-d1fa-4dfd-a882-dddaadcaf0b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53d4bfa4-1af8-45e5-a380-2c01f40fabc4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5685b8b0-31d4-4580-9f20-f503c836b588"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56fad215-3688-4c13-8b3e-e6f436f95781"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57bd71a1-3044-423e-b932-2c48d94e0192"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5904f07d-f022-40e0-9f30-1a42d717050f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5927d566-800e-4101-87d0-48e5249c4cd9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59f9d7ec-abc5-4174-bc37-495ddf7628ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b3d29ab-42b1-436f-b354-32256fe68c31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bb393fe-2831-4235-9de4-794bea9e8901"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d2d1f84-e17c-46c8-879a-6ef97890cc07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e939756-128e-489e-8799-35de91535f85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f3b0865-811a-4a2c-b080-62ceb67c497b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f7db26c-03f5-4db8-b795-089b007a237f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61caae62-5bc6-4005-97a8-9222ed9972f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("638e1b18-5c6a-4a0e-b8fb-487f00bce3d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65215be7-54fc-4940-b24e-53f9d69732ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("65eaea37-7f81-48b6-ac71-3248596af00b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6897e036-20f3-4b93-adec-5b7681775fae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69420043-e4fe-4b5b-877e-77417e553a97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69807a31-f7ea-47e5-afae-5d7fddd474c3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("699b6828-d53d-42dc-beaa-550b94de2ca0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6aaa6280-74db-46fc-9609-6052c682de60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c0f7570-f87c-423c-a7b2-7b82b3335f0d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d4b1ccb-ab48-48b3-a044-64ab41a1529b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6dd16957-be71-40ff-ae70-5b4482c71cd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f465db1-4c87-4960-82fa-cccc9e0923b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7222dc9a-98d4-4f74-b22d-bc7166796175"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7400762c-c6de-4464-82e1-eaa7460ecf81"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("753e8fa6-dfc7-4e51-bfa0-ccf91a3961b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7585bc37-5fb2-48e2-b5cc-1fe1ad5dd182"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75cb8aae-3001-4ff2-a3c3-f45ea636c7a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75d949f5-52b7-4127-8aff-54775bf8f8c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7658c167-4479-4110-aff5-e4ac5af8c224"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7682f218-419a-4d3e-ab9a-5a5b9a9b8dc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76e817b2-6f03-4c6d-8019-07c712745309"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77500cdf-b578-46df-b909-6290e239440f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("775f8974-bf9d-4a10-8586-72370143bf58"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7867645a-f8ba-4de6-b639-bbbaf94d423c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("786c2287-08ad-43ef-9545-3cb040f3a8d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78a73ed9-e947-4354-aff0-e4025e1a9776"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7aa6884b-ac43-4843-a3d5-14cca7e43ca6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7abdd739-80cc-48f7-b780-38e3ab08596a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7bb7152c-7d77-4bce-8301-d8af30e68a43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7bd2d1e2-1273-42f8-9686-da2a2aa481d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c6191a7-91bf-4aac-b67d-f6fea4dae904"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d2a04a8-2172-41c1-a4d4-84c4776b834d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d9d3783-3e7e-4997-aa83-3f04fc61a3aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f848060-7007-4d8b-a704-f4902025458f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fc2aaa9-4db6-4116-8e71-2d5d5bebee17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80dc81fb-fce2-4505-b251-d7ff1ce21fa7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81538962-06b4-43df-8522-a0aec6c06c4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81f244ba-ba43-49cf-8aad-985b8e94e64b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("821f52f3-0d5d-42a7-b174-b1dfe377b227"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("836a7521-4122-4c2a-91d1-7f08cfb36ff9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("840a6838-a7a9-429a-acb3-2e92d9dacfbc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84ae1085-46ad-43b3-834e-7901fb144006"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85e3dc30-40e7-4ffa-bd54-febf65868cca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("882cad48-3185-4b4b-b12d-c8858fa87951"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89d4a5f7-92e9-42fa-b7f2-299eeb97acac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c034a3d-1c53-4a49-8c19-4e349fc70ec3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c603168-f30c-4235-aa6c-526deac9f2d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d3aa89f-184d-4f8c-b0bf-ef8f6d625243"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d72ceef-d49f-4e53-9a4d-d7630fabf289"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e1c0ea6-e7e7-4498-99c7-dc1d23b662b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e2770bd-a08b-46e9-b90c-f86b23b93fa1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("903cbdd9-63c1-4fb9-8945-19f04c25308b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9079ca63-6e7e-47be-9dd3-c5d357d7062a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93c459f6-b639-460b-9a49-1d16a186111e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94708d83-d243-419a-a83a-a7c3405e76fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94adfb4e-0d7e-4de1-ad8b-d3674048e81d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95a3d4c1-f90f-4089-bf8f-d9543345609e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98808f8e-0b6e-4dea-af04-937fceacb7ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98df2520-53ca-488f-8bb0-c4dd48e401fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99f0adee-02a3-4302-8f47-120c83ec426b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ba11fd9-108b-4a8b-8c8e-ee790dfafaff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bf5ab22-23bc-4e39-943d-a960dbd9f9fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c3bc052-2a6a-408d-9034-2c0ae8965483"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c75553c-8fb0-4351-8457-37c090e5b90e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c888afc-b2bd-482d-8472-e580ea0ecec1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ca29b35-0672-49ca-8d80-5d9e32c5adbe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ca6f6ee-d2ee-43ba-9ad6-5db4856c7666"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d27faef-a2db-496f-8094-60d1b5f378e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a05abe5f-caba-4126-89ee-1d50f9ff81da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a23908d6-394e-49c9-b13d-a2f208dfbc0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a24ad273-7459-426c-bd8f-32f84c16fc49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a27d88bd-eb93-48dc-a506-bf83741c923d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5a77876-c592-4b85-8b43-cdada2facecf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6f08daf-dfa8-4362-ac1c-bbbc4d1e0452"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa77f1ac-904e-40d4-a35b-5fa9b4942b69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aaa64563-3cd3-4341-9669-4d0b29f5660e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aace7863-4a56-4df6-8d29-05178cd3733b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af41d9a2-1cfb-4ebe-b7d1-e37417929170"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b057a1b2-29b4-4434-8caa-e9231cfea487"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0607701-fd88-45b4-8a51-fd3591c7951a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0c71c90-4d6d-40f2-90a4-ed44a75ed472"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b15be5bf-9f39-4cbf-ac36-9c3fe558a788"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b16889c5-c8c5-4f01-a203-8916fdaae98d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b188afcf-9a47-4e90-a4ef-eff4c453094f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3006f87-b46f-4419-871b-e3eca7b904ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3920fe8-1acc-4028-a75a-1d38ade26b68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5cbb3c7-6513-4dc4-855a-f962754dff9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6e87dda-bceb-48f4-b9f3-f22a32adb292"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7625780-c673-407b-a703-32d0498a5b0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bcc867a9-297e-40d3-aa65-23573b02324b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd220dfd-9400-416f-b101-98499df8b5cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdb100d8-28ed-4180-9b76-b501b2c10c9b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be4b8fe1-b851-469a-a2bd-5f2529a49c55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bef35c44-5b57-416e-a1ca-4b99e4cc4871"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1299cc4-dc53-4989-a395-c486d885d640"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1dffef7-c0b6-4db3-b848-8ffd5b642fa0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1f72efd-7492-4289-b64e-f69e36557133"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbdc9072-fb85-425b-88ec-888e2d1eee91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc218517-c1e6-492b-b6f4-e0c65668551c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc2710bf-bb56-4d75-bf28-0183521e3a8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cce16485-32c7-4b0a-87be-df844cc7c4d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce30c948-8109-4932-ae05-6702a379f41e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfd575e3-e86f-43c1-97a2-8c95640c6941"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3b79e1f-b122-4cf2-bb88-1abc1ac8b098"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5243165-5ad2-4f00-b602-90f6e3bacc40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5c39193-67c6-4a51-9c52-08fcb67b0b00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d62daf61-875c-4d5e-b7ce-7353901c91a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6759e30-5f02-497a-8141-ca2d2f9596f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6c8dcf9-6b5a-4ce0-b897-026e97b7ef82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d736827d-0ced-46d3-90ca-b9bc14330b0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d799fbd5-9364-4a7c-9b29-ea4ce5b2ec31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d84b24ef-e327-4d26-a9d4-16da6edccf2f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da4e032f-63d2-435d-9e15-52135d2b89fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da8838fb-b8eb-4519-baa6-ebd50f94c23d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc6cb4d3-10f6-45bc-bb36-e819f83a1769"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc7d23d9-af23-4242-8abf-1395290f4dcd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcb6aa09-9a3f-4daa-bc9b-80dbf5a607b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de553466-2619-4754-ac42-1c178d3e7202"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de8c0cab-0026-4814-a7e9-403ffe0765e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df578954-b0a2-4cb7-a89e-5ea5e2be0113"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dfec322b-df5d-453d-9eb4-8e551843442a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e06857de-afa2-44c9-8dbb-5938454fbae6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e11f58e5-29b5-47f6-a49a-5b75e69be22e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1228792-27bc-4132-bd19-4c6f313b647a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e201a649-e16a-4960-9d4a-8bde0f1ab155"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e335dfff-a9f4-49ec-ba6e-a36b955106e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e37b34ec-72bb-4c63-9520-26c1b062d9ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e53a6c7b-9918-4f67-8119-1d5c1df84346"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7f96a09-1c51-4a4e-ad63-5b95cacde62c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e87ae393-4d9c-4dff-ad9d-4e30b6600fa8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8abe0dc-4dab-496e-b971-3c9b6e1de6eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8e838c1-4348-45f1-8ff4-f22a421d53b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e95160e2-dffe-4716-8bc1-a3175932794f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9e6b71a-e87a-45f9-91f6-e2467f08c830"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec71467f-cac0-4fc9-8e60-c4722693c325"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed0a3247-bfae-4b6f-947b-e8fd46369a2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed21557d-f654-41af-bf5e-3b499d4e8132"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed9af4b8-119c-46a3-81a6-eae76ec48521"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee5854c0-96f6-4d4a-8613-b8366db9e5cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef2da966-3665-481c-a6dd-9a1bb33b920d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efd86dfb-f6ac-4c78-935c-f179f7de0303"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f11bbcfa-6b43-416a-a939-feb8537add3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f125e1b1-5ce9-482a-974a-0e72b295b079"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3d4e51a-1d1d-492d-8fb3-29de77e7e6ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5b88807-d567-49fc-bdfd-cfcb54f8c444"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6a60d5d-d088-4db5-82b2-a6706e74de7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6be647d-b4b2-411a-91e8-b202e893d417"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7d2d75e-8460-4789-beac-26bb7297aecc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f823f81c-2469-4814-bf53-64bfd31b4868"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f861f58d-eae9-4d44-937c-7be72523f522"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8f0bf34-30e4-428f-a4f8-c7e8ab63f735"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8fa33a7-59f5-4fe2-970f-751610a54695"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("faefeb88-b8c1-437a-ab96-418c22995900"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb813e8f-e21d-49f3-8686-6e8a19ecbd95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc85d3b7-42c0-451e-bb53-8abc03f342bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fdaab96c-d4ae-4ee3-bebe-5dee773fe237"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe7f6a63-873d-416c-8588-aab0d42c96fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("feb13dd8-6810-4eee-802c-9deaa855c014"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fecba904-8e80-4ad0-aa24-e64cbe6539db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fedd86a8-f19a-469c-b164-5faa3762d87d"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("1af42618-2316-4e2d-93ad-0071a4f5c03c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("1ef258dc-a12b-4d69-81e4-c07aa63662a8"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("da916e27-72f5-4560-8634-80192e56f4fd"));

            migrationBuilder.RenameColumn(
                name: "FilmScreeningId",
                table: "Items",
                newName: "FilmSreeningId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_FilmScreeningId",
                table: "Items",
                newName: "IX_Items_FilmSreeningId");

            migrationBuilder.AlterColumn<double>(
                name: "Points",
                table: "FilmScreenings",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b85078ac-324b-4b6a-8cdb-916b98bf3d2e"), "Productor Ejecutivo" },
                    { new Guid("fdcb77c8-b037-4283-953b-8944ebac7a5c"), "Técnico de Sonido" },
                    { new Guid("a0fad8e6-a3b3-4cd6-9022-ba8dd1839d2f"), "Diseñador de Vestuario" },
                    { new Guid("032a9eb0-7de7-4190-b52f-bbacbc79d6e2"), "Guionista" },
                    { new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Actor" },
                    { new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Director" },
                    { new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"), "Productor" },
                    { new Guid("32d638d0-2170-47df-b002-2b2b2dab9f15"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre", "1999" },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f008ece1-45b9-4cf6-9c41-7227266eb8b3"), "Erótico" },
                    { new Guid("cf1c422a-cb42-47d7-b8d3-c16d43a06c9a"), "Musical" },
                    { new Guid("c3334688-a005-4684-ae32-dd0fb19ec842"), "Aventura" },
                    { new Guid("83197658-952b-40f2-9a84-adace39e0ec7"), "Ciencia Ficción" },
                    { new Guid("a8864805-969d-4af2-801a-59f227ec8d47"), "Ficción" },
                    { new Guid("9cf1da66-27a5-42ce-be2c-52cb4cef1156"), "Documental" },
                    { new Guid("f9ae8b3a-d842-4238-b128-26867e9a5b0d"), "Romántica" },
                    { new Guid("f691bfcf-5c43-41a3-8553-57bc7d816bc0"), "Tragicomedia" },
                    { new Guid("35d74d6f-e521-4f67-ba07-09877bad73ad"), "Terror" },
                    { new Guid("e4f4fdc8-5de5-4df7-90e7-40f0c253d2b8"), "Suspenso" },
                    { new Guid("dae44179-99cf-49e1-971f-75287b8be015"), "Comedia" },
                    { new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f"), "Drama" },
                    { new Guid("0518539d-e628-40a7-bbde-a4913e40c4e9"), "Hístorico" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), "Platea Baja", 10 },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "PriceModifications",
                columns: new[] { "Id", "Description", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("c1469966-f4d9-4e9f-a9dd-09139871caf3"), "Descuento por el día de las madres.", "Madres", "Descuento", 10 },
                    { new Guid("781b8743-6851-49d2-8f3d-e94208c577ac"), "Descuento del 10% para estudiantes que muestren el carnet.", "Estudiante", "Descuento", 10 },
                    { new Guid("1745a668-b48f-482d-84c2-624b2da2174c"), "Descuento decidido por la direccion del cine por un motivo que surja.", "Descuento del Director", "Descuento", 10 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), "Sala 2" },
                    { new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), "Sala 1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("03df8fce-55a3-48e9-9563-3b0ff086eda7"), "F2" },
                    { new Guid("f6f4cf5e-d2a9-47fa-a094-ea028186cefe"), "G1" },
                    { new Guid("c785d2a0-8c2d-4069-b6b6-b9601a787c92"), "G2" },
                    { new Guid("47b83f1c-66d0-4f90-adad-a3bc31655311"), "H1" },
                    { new Guid("02d7d69d-c8cf-48f9-a750-d8d6aab06aed"), "H2" },
                    { new Guid("1025b7c2-640d-4053-b09e-f733d83f5b87"), "A1" },
                    { new Guid("315f32f3-4103-4b26-803a-b3bb97211cd1"), "A2" },
                    { new Guid("79ec0820-d803-401d-b8de-5bc02044dd61"), "A3" },
                    { new Guid("9141b8c4-3077-446a-8000-84fea8804807"), "B1" },
                    { new Guid("0619d98b-4e5e-4c1b-9156-121906f73308"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("e043bc89-4079-4a20-8be8-1f60959a18a0"), "B3" },
                    { new Guid("2500b196-4067-46d0-b901-27d3dbade68b"), "C1" },
                    { new Guid("907a17b6-de34-421f-9ef3-30adc7329028"), "C2" },
                    { new Guid("a25a6fd1-c452-485e-b0c6-b7a24a0ead27"), "C3" },
                    { new Guid("5208ecac-cec1-4faf-8612-53bfb0bd6bbf"), "D1" },
                    { new Guid("0407177b-3749-4fda-9351-8a80fc28f3f2"), "D2" },
                    { new Guid("70200362-d22d-489a-8483-806caa079787"), "E1" },
                    { new Guid("3a8f71b3-cedd-4e2b-a50b-75eced598b89"), "E2" },
                    { new Guid("53b8e131-72e5-46f7-bb67-ad415e53000c"), "E3" },
                    { new Guid("06175735-ca8b-4aea-9eea-3a5969dd876d"), "F1" },
                    { new Guid("215325c8-9294-422a-bdb1-e3af1580ff92"), "F2" },
                    { new Guid("c7ee8bb2-1b78-44d4-a6a5-71b88a27a655"), "F3" },
                    { new Guid("e3f3b0e4-6e3e-4712-b864-a87bb1fd8c74"), "G1" },
                    { new Guid("4502f0f8-3e62-421b-9500-d2676e233a02"), "G2" },
                    { new Guid("97352b9b-c27d-4a47-9ae0-46aac9c65f43"), "G3" },
                    { new Guid("6ac8c63c-d3d4-4146-a464-7d0cb9cd1556"), "H1" },
                    { new Guid("19b42427-2614-4b91-8ce8-bc7986b5e7b1"), "H2" },
                    { new Guid("500c3084-1df0-4c7d-b0c7-e46b94b0c707"), "H3" },
                    { new Guid("945149b6-76f5-4817-94d2-f1d38a29c7a0"), "A1" },
                    { new Guid("eb8f8188-7dc7-4115-9bfa-a25d4b31a594"), "D3" },
                    { new Guid("b5cfa03f-111e-43be-b871-1090576a93fe"), "F1" },
                    { new Guid("1a1515f5-4af7-4898-929a-4c5baad27068"), "G1" },
                    { new Guid("44c56800-b80a-41e8-adb8-6088447e0517"), "E1" },
                    { new Guid("4569f73d-b89f-4867-a34d-086fc2c8fdb3"), "A3" },
                    { new Guid("b53cba38-703e-453f-9431-82cf6bfb8df2"), "B1" },
                    { new Guid("8aab1d80-64ae-44b5-ae86-ddb7e14c46d6"), "B2" },
                    { new Guid("2dc31237-cb15-44b1-8d3f-ffb3290a86c0"), "B3" },
                    { new Guid("2eeac228-4375-4dea-aa8e-1dee29d90763"), "C1" },
                    { new Guid("2955a1b5-c0ae-4a77-b815-0a40ffa858a1"), "C2" },
                    { new Guid("0af5f958-fe24-408b-8546-74f47af627c3"), "C3" },
                    { new Guid("befdace8-523b-4fd7-97a7-b4b4aaa56814"), "D1" },
                    { new Guid("d958f206-ecd8-4e7b-baf1-d35ae84c05ab"), "D2" },
                    { new Guid("f86a61ed-908b-468f-b298-b8fbaf8c15bb"), "D3" },
                    { new Guid("f6f7ca8f-d890-4faf-b1ae-cfd9ea31339f"), "E1" },
                    { new Guid("15fcb6f9-63e5-4eac-8fde-00332334c11a"), "E2" },
                    { new Guid("f862b2bd-e56f-46bb-be55-744f344361dd"), "E3" },
                    { new Guid("0dbf698d-a5d1-49f8-8fa8-b62197e738cb"), "F1" },
                    { new Guid("49325d85-ccfb-4ad8-8846-95c6296822cd"), "E2" },
                    { new Guid("e77d17b6-b595-4752-a927-28b00ac922fa"), "F2" },
                    { new Guid("98e543a2-16d7-4927-bcda-609e1307d302"), "B1" },
                    { new Guid("40c26e41-2af8-4ce7-970d-ea9d1e0ade45"), "G2" },
                    { new Guid("6204c4b1-cd3c-45fd-993c-b2e83f954248"), "G3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("2ee96e75-c3b6-4a6c-a3e3-cec95a9cc2aa"), "H1" },
                    { new Guid("60ce2cd8-e39e-4368-82b8-b3b8206b8b42"), "H2" },
                    { new Guid("993e3c71-c710-4348-a515-1dd023d713f6"), "H3" },
                    { new Guid("ed9e70b3-c1f6-4876-b79c-6071cc74eab1"), "A1" },
                    { new Guid("eb226a36-96b6-42ab-91d4-f4115815599c"), "A2" },
                    { new Guid("99aa4b1e-c0eb-4153-b426-9b9a66919266"), "B1" },
                    { new Guid("a506610c-ea08-43cc-a930-069274a0aa8b"), "B2" },
                    { new Guid("8e42a6c6-9bb6-4ed6-8be8-f57ea3faf7ec"), "C1" },
                    { new Guid("191a4552-2d99-49ea-8b17-dda45452241e"), "C2" },
                    { new Guid("c54d1cfe-7600-4437-80bd-02a8bdc2e3ad"), "D1" },
                    { new Guid("1e8b8da3-7c9a-4d82-b145-aee85203be12"), "D2" },
                    { new Guid("106bd050-0206-48eb-82b9-31e11515c056"), "F3" },
                    { new Guid("50c2b83a-d5cb-4073-8237-b6764e0b9c69"), "B2" },
                    { new Guid("410a5a1c-b2f8-47e4-8dab-4a699710bda9"), "F4" },
                    { new Guid("38141f38-7804-47e0-b43e-1108a5f29973"), "C2" },
                    { new Guid("e3c89890-d632-47bd-8bb2-c3db0594a54e"), "D1" },
                    { new Guid("49418229-d9d0-4eb2-9ece-34f635bea727"), "D2" },
                    { new Guid("487bf4ae-46bd-4969-99b0-94ba2e352467"), "D3" },
                    { new Guid("939aa012-783a-4181-b273-6ac955231146"), "D4" },
                    { new Guid("b0dfc923-7f40-4dae-8775-a1d749e525f3"), "E1" },
                    { new Guid("be05b3c4-7057-487e-8d3c-20e2ce5c3e79"), "E2" },
                    { new Guid("1278a3cf-923e-49ba-9e74-029f1cda016a"), "E3" },
                    { new Guid("c2240ba0-eba0-4f6b-8b4c-8a95c7f7a3a7"), "F1" },
                    { new Guid("c00ee0a9-6793-4de8-b196-4fdedd8d21d8"), "F2" },
                    { new Guid("8aa60f69-55a5-441a-94e4-b9b639d922e5"), "A1" },
                    { new Guid("b9f5bd6b-4675-49ff-9b12-0a985c25a12e"), "B1" },
                    { new Guid("8214254e-0a05-4767-b504-5d5a359f2af9"), "B2" },
                    { new Guid("942d8c8d-a63a-4752-83af-ad11ce987b78"), "C1" },
                    { new Guid("0c197c03-d57b-4ee9-b97b-b37ce6da6a3e"), "C2" },
                    { new Guid("1235805f-7f52-4434-b596-597f04fcfcd6"), "C5" },
                    { new Guid("19e991d7-e478-43c5-9857-0bf0cbad211c"), "C3" },
                    { new Guid("7e50215d-75bd-4d7c-82a6-4fb190ad1cdb"), "D2" },
                    { new Guid("d65210a2-6e44-4b16-9f07-07d248f92316"), "D3" },
                    { new Guid("c8e6fc84-d73c-4ac8-90ae-1142bfd22ad3"), "D4" },
                    { new Guid("a4a0a06c-683c-4c1a-b604-6a21955882a5"), "E1" },
                    { new Guid("85d3fa27-2364-4da8-995e-d4c7d1516c55"), "E2" },
                    { new Guid("09e14b4f-f95a-497f-9c92-ab82a471c8e2"), "E3" },
                    { new Guid("cfcc6af0-c8be-4d16-be1e-b3ab891648c2"), "E4" },
                    { new Guid("faa260bd-26d2-46df-a02e-21cad7f75b46"), "E5" },
                    { new Guid("4b8734e4-eaec-4610-a6a5-be260edcadd2"), "F1" },
                    { new Guid("7c1dbbbd-dacd-48d5-9638-d62a248889a8"), "F2" },
                    { new Guid("c4ad235a-6839-4770-8c0c-0464e48722c1"), "F3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("0499e325-472e-4056-91ab-f1743abce5e5"), "F4" },
                    { new Guid("5dae03e2-f435-4cad-b674-7f6b01f2794c"), "F5" },
                    { new Guid("1a84a405-7050-4f72-b48b-e8f1341d884e"), "F6" },
                    { new Guid("81a08857-6265-4233-ad3f-5f90f989cfb6"), "D1" },
                    { new Guid("9b6cdff3-0969-4f1f-a51c-80ff11e2cb81"), "C1" },
                    { new Guid("807fb03f-1e48-44ce-95dd-2fcae1e659e5"), "C4" },
                    { new Guid("94d9cdee-affd-426f-ae29-82584bc91de5"), "C2" },
                    { new Guid("77301813-91f7-49db-a769-37fe5a288347"), "C3" },
                    { new Guid("5729bdbe-c9a1-4719-bc10-d6758a8c371c"), "D1" },
                    { new Guid("820a6a9d-1425-480a-816d-154deaea6d2e"), "D2" },
                    { new Guid("76a4a0ae-b13d-413d-8c66-e82e76cbc74d"), "D3" },
                    { new Guid("acc6872f-70f4-4dd6-9d7e-c6eaaa7f8f50"), "D4" },
                    { new Guid("7967419a-2603-4bed-a3da-57a0688dd2ca"), "E1" },
                    { new Guid("9eda6903-da5d-4bad-82b8-232408fce870"), "E2" },
                    { new Guid("957f6c0b-7beb-420f-b944-56f83237fe8b"), "E3" },
                    { new Guid("d6625b3a-4363-4d1f-a5cc-50fb297f7d1d"), "E4" },
                    { new Guid("d7fd8286-dc43-45d9-8deb-f46d76af8fa9"), "E5" },
                    { new Guid("661574ec-f0d3-4323-8ee1-98fb3f77caa3"), "F1" },
                    { new Guid("b44113e9-de40-4f6e-8ae9-ac925caf0d02"), "F2" },
                    { new Guid("eda244ca-938e-4da7-8867-e52ae4543ff7"), "F3" },
                    { new Guid("6e9c2708-1437-4496-a5a3-e65efec75fa5"), "A2" },
                    { new Guid("c953e9d3-90fa-48e9-b146-a037df561de7"), "C3" },
                    { new Guid("d55798ad-5f76-418f-9f00-d1def52caedf"), "F5" },
                    { new Guid("1bf10d1a-51ea-4551-9948-d7100a4e0578"), "A1" },
                    { new Guid("531af91a-dfef-4474-b8ac-3581e3b41abd"), "A2" },
                    { new Guid("686676a9-b6f0-49e9-bb27-d4c72f19c4aa"), "A3" },
                    { new Guid("807aa9e5-a7d0-4c24-b2fc-49ebca9da749"), "A4" },
                    { new Guid("6c814d73-d311-4a38-ad60-0d4ce2d1e85c"), "A5" },
                    { new Guid("cf4b49fe-2905-4364-a216-95329f9f1b88"), "A6" },
                    { new Guid("0ca3fd06-54d5-4b54-ab80-3ffc267db02b"), "A7" },
                    { new Guid("fe14d12a-ff97-44aa-a005-ef1580b82136"), "B1" },
                    { new Guid("64d14d7c-08b6-4fac-96ac-6bc3e8530d12"), "B2" },
                    { new Guid("2bf8a249-49fb-43a9-ba76-4512ec9cb435"), "B3" },
                    { new Guid("6040660e-33f1-4f2c-a641-ef280b23a851"), "B4" },
                    { new Guid("dae1b4f3-ea28-4d9f-a4da-9e12b8714f1f"), "B5" },
                    { new Guid("0ffc1313-5f69-4902-ac5b-8fde63c94d75"), "B6" },
                    { new Guid("546a1aec-30ea-4593-8c76-39da586a0036"), "C1" },
                    { new Guid("73d966c7-ba70-46ad-9ae9-b8b265b504b1"), "F6" },
                    { new Guid("fa917ab1-135d-4268-b3d0-25bf94784f6a"), "A1" },
                    { new Guid("1f9c8645-f39b-48db-be50-8ebed83a4a85"), "D1" },
                    { new Guid("15d90e30-f234-4268-8d02-a7e8d7f7cb08"), "F5" },
                    { new Guid("4a67d2cb-ff4c-4307-be49-5520babc4d86"), "F1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("48ddc1c9-dd00-4113-b595-263ba13fa5bb"), "F2" },
                    { new Guid("0d58c1df-435a-448e-a37f-008fce9f8e60"), "G1" },
                    { new Guid("2f8d2ab5-6e47-4f54-8120-1f4c9bca503b"), "G2" },
                    { new Guid("90c26617-9181-4f38-a2b9-631695982b47"), "H1" },
                    { new Guid("9339b6fd-d5ed-43b3-8614-07f83371ab85"), "H2" },
                    { new Guid("b181584b-179d-429a-8771-633d55fd3886"), "A1" },
                    { new Guid("77070837-c327-4268-b4af-67b7f0a9ea4e"), "A2" },
                    { new Guid("47df26ea-3dc2-4e5b-8c92-688aff1c3ff6"), "A3" },
                    { new Guid("ef298b0f-a89e-4135-b143-bc4a332976ba"), "B1" },
                    { new Guid("886bc452-da63-4298-b387-4fff619b7e5c"), "B2" },
                    { new Guid("36febbf0-edc4-43c6-936a-dbdb6a5ebb89"), "B3" },
                    { new Guid("ffcc8c05-4d48-4d3b-9021-87dfa4c91f14"), "C1" },
                    { new Guid("ca5e9ff9-f13f-4f41-8823-fd5708f4e6bd"), "C2" },
                    { new Guid("1b6a9361-4441-4ac1-aff6-778db1326113"), "C3" },
                    { new Guid("30c44f9f-8a40-45af-8a67-f8dd2405e944"), "D1" },
                    { new Guid("d7554ced-897e-4e1b-8a4e-4d02ebf90a34"), "D2" },
                    { new Guid("f26d678f-61bf-410b-8b01-5b5deedc6e30"), "D3" },
                    { new Guid("99bd43fd-337a-4cd6-9b69-df24a0e5cde0"), "E1" },
                    { new Guid("3667d572-75fa-4dde-91ea-e0718856ce86"), "E2" },
                    { new Guid("61a65669-89a2-42c8-a759-84542511d2c4"), "E3" },
                    { new Guid("77a76966-8d23-4acf-9a0e-e6861b114419"), "F1" },
                    { new Guid("2e0a3383-a28f-4d40-beac-6503af862e66"), "F2" },
                    { new Guid("c96677b6-d909-47ea-afa9-d51baebb326b"), "F3" },
                    { new Guid("b11dfeb9-6fe7-4273-9f3a-df46a0f408b3"), "G1" },
                    { new Guid("edd553fd-913b-4915-b1fa-7c401a75c613"), "G2" },
                    { new Guid("61b42e96-8a68-43ed-9ab8-369d67da735b"), "G3" },
                    { new Guid("2896456a-3df7-4b91-ba2f-3af608bde325"), "H1" },
                    { new Guid("008e259b-1169-4e44-9152-86f5d9668027"), "H2" },
                    { new Guid("6ac8d492-7931-4e9a-a85b-783c30d68fe7"), "E2" },
                    { new Guid("abf7fb22-e06d-4e57-bf6b-0dec53bf8cd7"), "E1" },
                    { new Guid("d666983d-b873-4cff-afbe-329990186d94"), "D2" },
                    { new Guid("16ff5768-ee1a-49fa-9681-299b3dc652e4"), "D1" },
                    { new Guid("b2248285-f43e-4b9c-9cfa-ee00b260c786"), "A1" },
                    { new Guid("1e6e1d57-ef8f-4729-b98d-5ec9fd957f78"), "A2" },
                    { new Guid("406ffac9-ce63-40be-b809-6bb99f5325ad"), "A3" },
                    { new Guid("70f80669-9e6c-4372-a222-ed6620883311"), "B1" },
                    { new Guid("547d875a-eed4-4ba2-be70-694cb225296c"), "B2" },
                    { new Guid("139e5d66-e045-479a-8cc5-6836f183cfb4"), "B3" },
                    { new Guid("1297b0c3-fd29-4ede-9668-d2b55cb7f037"), "C1" },
                    { new Guid("b873c3d0-8b9e-4fc0-817e-06f89313668b"), "C2" },
                    { new Guid("5ee5f438-9425-4ae5-b808-d07f0f37e543"), "C3" },
                    { new Guid("646e3f61-648c-4085-807e-e450b01f6900"), "D1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("882fac87-1c13-47df-8828-2347c20a71f4"), "D2" },
                    { new Guid("9710b537-147e-429d-954e-ccfbda12e1c6"), "D3" },
                    { new Guid("537e98a9-43cc-46f3-b872-eb0ed495a064"), "E1" },
                    { new Guid("934fdf4c-e06c-4c20-ab7a-d64e87edd156"), "E2" },
                    { new Guid("17c9441b-4a33-4a76-9b68-3fd7596976c0"), "H3" },
                    { new Guid("9aa8ad84-b51b-4d3c-a720-991a135d5e1e"), "E3" },
                    { new Guid("f8855258-3ee1-4f75-b427-f277ea1bfd04"), "F2" },
                    { new Guid("10ceb6e0-3807-4c84-8391-dcebdd23700f"), "F3" },
                    { new Guid("b12b8606-3482-4f86-99e7-a5997aca998c"), "G1" },
                    { new Guid("22eae95f-b2a9-4b01-8f63-2d7dc883f24d"), "G2" },
                    { new Guid("ea0fff09-d9ae-4b99-b836-4e7fc3c7f605"), "G3" },
                    { new Guid("f3ed4cab-45cb-486e-a8a5-87829b328edd"), "H1" },
                    { new Guid("f24b737e-187d-4d29-9a76-6a787c6bb1b1"), "H2" },
                    { new Guid("77c4ace5-a49e-464b-883e-89237c80f449"), "H3" },
                    { new Guid("64657280-e79d-4d35-bf4a-7298e6fd618c"), "A1" },
                    { new Guid("4a1ece9e-ade0-4e3b-85d0-08da37d5f3d4"), "A2" },
                    { new Guid("5356c9aa-8a40-4104-b8f7-53871d6b8cf2"), "B1" },
                    { new Guid("3ca70a5d-9e8c-41c1-8afb-dc92e352a78c"), "B2" },
                    { new Guid("dbf345b0-047d-4432-9daa-f92a96fcbe97"), "C1" },
                    { new Guid("b4ae5760-850a-45b9-83ea-70caaef488cd"), "C2" },
                    { new Guid("eca1cc5a-2480-472e-8097-7d9ade95e9a0"), "F1" },
                    { new Guid("db7a3b3d-0d4b-4bb4-83c5-f659b903da23"), "F6" },
                    { new Guid("b5762b59-68cf-4654-a605-eab1d804c50e"), "A1" },
                    { new Guid("a99e1890-2fd6-4613-90df-f33d78b3fe98"), "B2" },
                    { new Guid("e3220225-cd78-47f0-b926-e3685c32679f"), "C4" },
                    { new Guid("f13d726c-f8fb-4b12-b9a5-40bb74d2fe7a"), "C5" },
                    { new Guid("f6c94150-39ba-432b-a5af-fd0afee5f2a1"), "D1" },
                    { new Guid("d451be8f-1ba4-4120-ac75-3987549fd332"), "D2" },
                    { new Guid("246dee1a-ed15-463f-bc9e-34f5e7f7b0b3"), "D3" },
                    { new Guid("a59234c8-1b14-4dac-88e9-a4b7d60beca4"), "D4" },
                    { new Guid("24498877-7f5a-49e8-830a-257a1d1e3af7"), "E1" },
                    { new Guid("1dc41a12-dccd-489c-96a3-c55dd8bf4efa"), "E2" },
                    { new Guid("4abbaad6-8d6d-464c-958c-897e4707e7c2"), "E3" },
                    { new Guid("01e6ed83-8916-425d-8221-3f9d16b14d51"), "F1" },
                    { new Guid("9d1d5f2b-01ce-4d93-939a-bdf0860e8b83"), "F2" },
                    { new Guid("47a2cf06-dc19-49d5-b016-9d5339eeb83e"), "A1" },
                    { new Guid("2eeab7b5-f5a8-48e1-9919-af7a42d9335e"), "B1" },
                    { new Guid("a161bcba-81d0-43c0-8be4-7eaf4bdfcc75"), "B2" },
                    { new Guid("dd88b7eb-1733-4554-8671-c51bcf7df29e"), "C1" },
                    { new Guid("5505e22a-4361-4cc3-a7ac-eb29f4567ec2"), "C2" },
                    { new Guid("b81b8a6b-ce52-4b11-b6c0-12f3aeed0c4e"), "C3" },
                    { new Guid("49ab40d2-a845-426d-870f-57326b03725f"), "D2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("e5345ea5-e6dd-4146-9722-35bfe7b22398"), "D3" },
                    { new Guid("46dffd1e-392f-4678-b883-94a4f39294a8"), "D4" },
                    { new Guid("119f9568-aaa7-4b95-b40f-b24a37d9588b"), "E1" },
                    { new Guid("c8375ecc-7e84-411b-9d68-72c112dacd30"), "E2" },
                    { new Guid("709c0bcd-d7fa-473a-9822-26310066d004"), "E3" },
                    { new Guid("204f3ad4-9ae8-42d7-901e-abfef45e5a37"), "E4" },
                    { new Guid("a3446e17-664b-4987-8a5a-a98a26eff41e"), "E5" },
                    { new Guid("16a9451c-b70c-4952-b5c3-05e83cda9284"), "F1" },
                    { new Guid("44ecce74-8517-40c3-8697-9ac469ab8d35"), "F2" },
                    { new Guid("90a4b5f6-5409-45f3-8b8c-3a6c2ca0fb25"), "F3" },
                    { new Guid("59fed05e-e523-42d3-8a21-c1f216c3545c"), "F4" },
                    { new Guid("ad90caa6-3c79-47de-b6b8-49bc71bb8dda"), "C3" },
                    { new Guid("13e1c470-ae0f-4a9f-9b4b-7dc88031b08e"), "B1" },
                    { new Guid("b6f4035b-81f4-465b-8277-53e79a09f75c"), "C2" },
                    { new Guid("844707b5-b00b-46ae-962e-3cf6b5098726"), "B6" },
                    { new Guid("37c74fab-baf9-44ff-929a-61d575d8ba92"), "C1" },
                    { new Guid("66a0461e-4963-4374-b799-1bb8e916252e"), "C2" },
                    { new Guid("ee5ccb76-072d-477a-ace1-c0efd8068bdf"), "C3" },
                    { new Guid("0d925e65-97f1-4578-befa-b329b964d48e"), "D1" },
                    { new Guid("2644a1cf-7410-4ef0-b281-0316fc9d17be"), "D2" },
                    { new Guid("1b97f3de-e6fd-4355-8cca-ede2a4fbaccd"), "D3" },
                    { new Guid("ff814ad8-43d2-47e4-b395-cbbc3878863f"), "D4" },
                    { new Guid("f1f22a81-81fa-4104-9318-f1446c28883b"), "E1" },
                    { new Guid("8c9fa9d6-49ab-4f94-827a-02f3d3320c1f"), "E2" },
                    { new Guid("e2a74aac-c739-4c0f-ad95-a655c3667c4b"), "E3" },
                    { new Guid("66913e8c-a36c-486a-beb8-94767d02bef1"), "E4" },
                    { new Guid("1f25dcc9-06db-4559-bbbb-0e0a8cec236f"), "E5" },
                    { new Guid("71b94996-ced4-432c-a059-7a0f874e9b60"), "F1" },
                    { new Guid("aa5330c4-01c4-4cea-953e-f61b9a554c48"), "C1" },
                    { new Guid("26f483ed-d47f-4a63-9496-b39855741d33"), "F3" },
                    { new Guid("d888c9d8-345b-47fe-be69-fecb851ed6b1"), "F2" },
                    { new Guid("6e6d3f1b-735d-43e2-aa40-ad30148b9a1b"), "F5" },
                    { new Guid("f2db955e-a6b5-4314-a3e2-6246ce4d9a9f"), "B5" },
                    { new Guid("5888e7ee-cbaa-466b-b6b5-86fb0b605c79"), "B4" },
                    { new Guid("840a8187-54c2-45bd-9c40-fd920f4da333"), "B3" },
                    { new Guid("4d963744-39a0-41bf-b144-4a4354d0a171"), "B2" },
                    { new Guid("472719cc-2d8f-4340-82db-06e8ed206c35"), "B1" },
                    { new Guid("0888b147-3e15-411b-a080-c764163ed723"), "A7" },
                    { new Guid("e448299c-1e62-4701-aeac-b68e143ec585"), "F4" },
                    { new Guid("7f2de3d3-4383-481a-906c-097877b41479"), "A6" },
                    { new Guid("6e5294f7-a2fe-4a01-abf9-8bcfaeb78bec"), "A4" },
                    { new Guid("6129da45-9371-4276-a7e7-f6522d0c4f0c"), "A3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("34e36a61-3788-4f9f-b009-02a697b634eb"), "A2" },
                    { new Guid("c0b09b19-3165-4b17-88c9-08a3a8e95fcc"), "A1" },
                    { new Guid("98e48abb-bded-47f9-86cd-cba2c4ff0036"), "F6" },
                    { new Guid("78c5584a-04c4-4c04-af87-0860981bcd36"), "A5" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b"), "Sección 2" },
                    { new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4"), "Sección 1" },
                    { new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Cecilia Roth" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("a0fad8e6-a3b3-4cd6-9022-ba8dd1839d2f"), "Mary Sweeny" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"), "Roger Avary" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("8f2d7af0-eb1d-4926-882f-4f53cfd5510c"), "Quentin Tarantino" },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Robert Zemeckis" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Quentin Tarantino" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "David Lynch" },
                    { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("ee83c474-5396-4bde-adcb-ebb2bc567477"), "Pedro Almodovar" },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Robin Wright" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Samuel Jackson" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Una Thurman" },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "John Travolta" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Justin Theroux" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Laura Harring" },
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Naomi Watts" },
                    { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Penélope Cruz" },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("7d478c1b-8760-40e0-8c70-88023d7a97c4"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("9b933396-ac6a-4f0f-a105-ee466c36eb65"), new Guid("e4f4fdc8-5de5-4df7-90e7-40f0c253d2b8") },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("f9ae8b3a-d842-4238-b128-26867e9a5b0d") },
                    { new Guid("01d8e4eb-dab2-4337-9b1b-5f0dd03c5b56"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") },
                    { new Guid("029c837c-8a76-4507-ba76-e80612044738"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") },
                    { new Guid("55a0be8f-d668-46e7-9929-87d84b094afa"), new Guid("55f30aed-c0e6-4832-9920-a28c4ccccb3f") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("886bc452-da63-4298-b387-4fff619b7e5c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("49418229-d9d0-4eb2-9ece-34f635bea727"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("487bf4ae-46bd-4969-99b0-94ba2e352467"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("939aa012-783a-4181-b273-6ac955231146"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b0dfc923-7f40-4dae-8775-a1d749e525f3"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("be05b3c4-7057-487e-8d3c-20e2ce5c3e79"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1278a3cf-923e-49ba-9e74-029f1cda016a"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c2240ba0-eba0-4f6b-8b4c-8a95c7f7a3a7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c00ee0a9-6793-4de8-b196-4fdedd8d21d8"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b181584b-179d-429a-8771-633d55fd3886"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77070837-c327-4268-b4af-67b7f0a9ea4e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("47df26ea-3dc2-4e5b-8c92-688aff1c3ff6"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ef298b0f-a89e-4135-b143-bc4a332976ba"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("36febbf0-edc4-43c6-936a-dbdb6a5ebb89"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2e0a3383-a28f-4d40-beac-6503af862e66"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ca5e9ff9-f13f-4f41-8823-fd5708f4e6bd"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1b6a9361-4441-4ac1-aff6-778db1326113"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("30c44f9f-8a40-45af-8a67-f8dd2405e944"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d7554ced-897e-4e1b-8a4e-4d02ebf90a34"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f26d678f-61bf-410b-8b01-5b5deedc6e30"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("99bd43fd-337a-4cd6-9b69-df24a0e5cde0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("3667d572-75fa-4dde-91ea-e0718856ce86"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("61a65669-89a2-42c8-a759-84542511d2c4"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77a76966-8d23-4acf-9a0e-e6861b114419"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e3c89890-d632-47bd-8bb2-c3db0594a54e"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c96677b6-d909-47ea-afa9-d51baebb326b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b11dfeb9-6fe7-4273-9f3a-df46a0f408b3"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("edd553fd-913b-4915-b1fa-7c401a75c613"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("61b42e96-8a68-43ed-9ab8-369d67da735b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ffcc8c05-4d48-4d3b-9021-87dfa4c91f14"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1235805f-7f52-4434-b596-597f04fcfcd6"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0ca3fd06-54d5-4b54-ab80-3ffc267db02b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c953e9d3-90fa-48e9-b146-a037df561de7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eb226a36-96b6-42ab-91d4-f4115815599c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("99aa4b1e-c0eb-4153-b426-9b9a66919266"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a506610c-ea08-43cc-a930-069274a0aa8b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8e42a6c6-9bb6-4ed6-8be8-f57ea3faf7ec"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("191a4552-2d99-49ea-8b17-dda45452241e"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c54d1cfe-7600-4437-80bd-02a8bdc2e3ad"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1e8b8da3-7c9a-4d82-b145-aee85203be12"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("44c56800-b80a-41e8-adb8-6088447e0517"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("49325d85-ccfb-4ad8-8846-95c6296822cd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b5cfa03f-111e-43be-b871-1090576a93fe"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("03df8fce-55a3-48e9-9563-3b0ff086eda7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f6f4cf5e-d2a9-47fa-a094-ea028186cefe"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c785d2a0-8c2d-4069-b6b6-b9601a787c92"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("47b83f1c-66d0-4f90-adad-a3bc31655311"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("807fb03f-1e48-44ce-95dd-2fcae1e659e5"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("02d7d69d-c8cf-48f9-a750-d8d6aab06aed"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("531af91a-dfef-4474-b8ac-3581e3b41abd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("686676a9-b6f0-49e9-bb27-d4c72f19c4aa"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("807aa9e5-a7d0-4c24-b2fc-49ebca9da749"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6c814d73-d311-4a38-ad60-0d4ce2d1e85c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("cf4b49fe-2905-4364-a216-95329f9f1b88"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2896456a-3df7-4b91-ba2f-3af608bde325"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("fe14d12a-ff97-44aa-a005-ef1580b82136"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("64d14d7c-08b6-4fac-96ac-6bc3e8530d12"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2bf8a249-49fb-43a9-ba76-4512ec9cb435"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6040660e-33f1-4f2c-a641-ef280b23a851"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("dae1b4f3-ea28-4d9f-a4da-9e12b8714f1f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0ffc1313-5f69-4902-ac5b-8fde63c94d75"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("546a1aec-30ea-4593-8c76-39da586a0036"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("94d9cdee-affd-426f-ae29-82584bc91de5"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1bf10d1a-51ea-4551-9948-d7100a4e0578"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("008e259b-1169-4e44-9152-86f5d9668027"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("46dffd1e-392f-4678-b883-94a4f39294a8"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("47a2cf06-dc19-49d5-b016-9d5339eeb83e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("53b8e131-72e5-46f7-bb67-ad415e53000c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("06175735-ca8b-4aea-9eea-3a5969dd876d"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("215325c8-9294-422a-bdb1-e3af1580ff92"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c7ee8bb2-1b78-44d4-a6a5-71b88a27a655"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e3f3b0e4-6e3e-4712-b864-a87bb1fd8c74"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4502f0f8-3e62-421b-9500-d2676e233a02"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("97352b9b-c27d-4a47-9ae0-46aac9c65f43"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6ac8c63c-d3d4-4146-a464-7d0cb9cd1556"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("19b42427-2614-4b91-8ce8-bc7986b5e7b1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("500c3084-1df0-4c7d-b0c7-e46b94b0c707"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8aa60f69-55a5-441a-94e4-b9b639d922e5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b9f5bd6b-4675-49ff-9b12-0a985c25a12e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8214254e-0a05-4767-b504-5d5a359f2af9"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("942d8c8d-a63a-4752-83af-ad11ce987b78"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0c197c03-d57b-4ee9-b97b-b37ce6da6a3e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("19e991d7-e478-43c5-9857-0bf0cbad211c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("81a08857-6265-4233-ad3f-5f90f989cfb6"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7e50215d-75bd-4d7c-82a6-4fb190ad1cdb"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d65210a2-6e44-4b16-9f07-07d248f92316"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c8e6fc84-d73c-4ac8-90ae-1142bfd22ad3"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a4a0a06c-683c-4c1a-b604-6a21955882a5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("85d3fa27-2364-4da8-995e-d4c7d1516c55"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("09e14b4f-f95a-497f-9c92-ab82a471c8e2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("cfcc6af0-c8be-4d16-be1e-b3ab891648c2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("faa260bd-26d2-46df-a02e-21cad7f75b46"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4b8734e4-eaec-4610-a6a5-be260edcadd2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7c1dbbbd-dacd-48d5-9638-d62a248889a8"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("c4ad235a-6839-4770-8c0c-0464e48722c1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0499e325-472e-4056-91ab-f1743abce5e5"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("3a8f71b3-cedd-4e2b-a50b-75eced598b89"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("70200362-d22d-489a-8483-806caa079787"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eb8f8188-7dc7-4115-9bfa-a25d4b31a594"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0407177b-3749-4fda-9351-8a80fc28f3f2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2eeab7b5-f5a8-48e1-9919-af7a42d9335e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a161bcba-81d0-43c0-8be4-7eaf4bdfcc75"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("dd88b7eb-1733-4554-8671-c51bcf7df29e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5505e22a-4361-4cc3-a7ac-eb29f4567ec2"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b81b8a6b-ce52-4b11-b6c0-12f3aeed0c4e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1f9c8645-f39b-48db-be50-8ebed83a4a85"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("49ab40d2-a845-426d-870f-57326b03725f"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e5345ea5-e6dd-4146-9722-35bfe7b22398"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("ed9e70b3-c1f6-4876-b79c-6071cc74eab1"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("119f9568-aaa7-4b95-b40f-b24a37d9588b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c8375ecc-7e84-411b-9d68-72c112dacd30"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("709c0bcd-d7fa-473a-9822-26310066d004"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("204f3ad4-9ae8-42d7-901e-abfef45e5a37"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a3446e17-664b-4987-8a5a-a98a26eff41e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("17c9441b-4a33-4a76-9b68-3fd7596976c0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("16a9451c-b70c-4952-b5c3-05e83cda9284"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("90a4b5f6-5409-45f3-8b8c-3a6c2ca0fb25"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("59fed05e-e523-42d3-8a21-c1f216c3545c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("15d90e30-f234-4268-8d02-a7e8d7f7cb08"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("db7a3b3d-0d4b-4bb4-83c5-f659b903da23"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1025b7c2-640d-4053-b09e-f733d83f5b87"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("315f32f3-4103-4b26-803a-b3bb97211cd1"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("79ec0820-d803-401d-b8de-5bc02044dd61"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9141b8c4-3077-446a-8000-84fea8804807"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0619d98b-4e5e-4c1b-9156-121906f73308"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e043bc89-4079-4a20-8be8-1f60959a18a0"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2500b196-4067-46d0-b901-27d3dbade68b"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("907a17b6-de34-421f-9ef3-30adc7329028"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("a25a6fd1-c452-485e-b0c6-b7a24a0ead27"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5208ecac-cec1-4faf-8612-53bfb0bd6bbf"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("44ecce74-8517-40c3-8697-9ac469ab8d35"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9d1d5f2b-01ce-4d93-939a-bdf0860e8b83"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ad90caa6-3c79-47de-b6b8-49bc71bb8dda"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4abbaad6-8d6d-464c-958c-897e4707e7c2"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f1f22a81-81fa-4104-9318-f1446c28883b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("8c9fa9d6-49ab-4f94-827a-02f3d3320c1f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e2a74aac-c739-4c0f-ad95-a655c3667c4b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("66913e8c-a36c-486a-beb8-94767d02bef1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1f25dcc9-06db-4559-bbbb-0e0a8cec236f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("71b94996-ced4-432c-a059-7a0f874e9b60"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d888c9d8-345b-47fe-be69-fecb851ed6b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("26f483ed-d47f-4a63-9496-b39855741d33"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e448299c-1e62-4701-aeac-b68e143ec585"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6e6d3f1b-735d-43e2-aa40-ad30148b9a1b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("98e48abb-bded-47f9-86cd-cba2c4ff0036"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("fa917ab1-135d-4268-b3d0-25bf94784f6a"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6e9c2708-1437-4496-a5a3-e65efec75fa5"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("4569f73d-b89f-4867-a34d-086fc2c8fdb3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b53cba38-703e-453f-9431-82cf6bfb8df2"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("8aab1d80-64ae-44b5-ae86-ddb7e14c46d6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2dc31237-cb15-44b1-8d3f-ffb3290a86c0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2eeac228-4375-4dea-aa8e-1dee29d90763"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2955a1b5-c0ae-4a77-b815-0a40ffa858a1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0af5f958-fe24-408b-8546-74f47af627c3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("befdace8-523b-4fd7-97a7-b4b4aaa56814"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d958f206-ecd8-4e7b-baf1-d35ae84c05ab"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f86a61ed-908b-468f-b298-b8fbaf8c15bb"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f6f7ca8f-d890-4faf-b1ae-cfd9ea31339f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("15fcb6f9-63e5-4eac-8fde-00332334c11a"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("f862b2bd-e56f-46bb-be55-744f344361dd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("0dbf698d-a5d1-49f8-8fa8-b62197e738cb"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("e77d17b6-b595-4752-a927-28b00ac922fa"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("106bd050-0206-48eb-82b9-31e11515c056"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ff814ad8-43d2-47e4-b395-cbbc3878863f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1b97f3de-e6fd-4355-8cca-ede2a4fbaccd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2644a1cf-7410-4ef0-b281-0316fc9d17be"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0d925e65-97f1-4578-befa-b329b964d48e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b2248285-f43e-4b9c-9cfa-ee00b260c786"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1e6e1d57-ef8f-4729-b98d-5ec9fd957f78"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("406ffac9-ce63-40be-b809-6bb99f5325ad"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("70f80669-9e6c-4372-a222-ed6620883311"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("547d875a-eed4-4ba2-be70-694cb225296c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("139e5d66-e045-479a-8cc5-6836f183cfb4"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1297b0c3-fd29-4ede-9668-d2b55cb7f037"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b873c3d0-8b9e-4fc0-817e-06f89313668b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5ee5f438-9425-4ae5-b808-d07f0f37e543"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("646e3f61-648c-4085-807e-e450b01f6900"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("882fac87-1c13-47df-8828-2347c20a71f4"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9710b537-147e-429d-954e-ccfbda12e1c6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("537e98a9-43cc-46f3-b872-eb0ed495a064"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("934fdf4c-e06c-4c20-ab7a-d64e87edd156"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1a1515f5-4af7-4898-929a-4c5baad27068"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9aa8ad84-b51b-4d3c-a720-991a135d5e1e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f8855258-3ee1-4f75-b427-f277ea1bfd04"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("10ceb6e0-3807-4c84-8391-dcebdd23700f"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b12b8606-3482-4f86-99e7-a5997aca998c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("22eae95f-b2a9-4b01-8f63-2d7dc883f24d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ea0fff09-d9ae-4b99-b836-4e7fc3c7f605"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f3ed4cab-45cb-486e-a8a5-87829b328edd"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f24b737e-187d-4d29-9a76-6a787c6bb1b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("77c4ace5-a49e-464b-883e-89237c80f449"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b5762b59-68cf-4654-a605-eab1d804c50e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("13e1c470-ae0f-4a9f-9b4b-7dc88031b08e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a99e1890-2fd6-4613-90df-f33d78b3fe98"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("37c74fab-baf9-44ff-929a-61d575d8ba92"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("66a0461e-4963-4374-b799-1bb8e916252e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("ee5ccb76-072d-477a-ace1-c0efd8068bdf"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("eca1cc5a-2480-472e-8097-7d9ade95e9a0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("01e6ed83-8916-425d-8221-3f9d16b14d51"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("40c26e41-2af8-4ce7-970d-ea9d1e0ade45"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("2ee96e75-c3b6-4a6c-a3e3-cec95a9cc2aa"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("48ddc1c9-dd00-4113-b595-263ba13fa5bb"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0d58c1df-435a-448e-a37f-008fce9f8e60"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("2f8d2ab5-6e47-4f54-8120-1f4c9bca503b"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("90c26617-9181-4f38-a2b9-631695982b47"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("9339b6fd-d5ed-43b3-8614-07f83371ab85"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("c0b09b19-3165-4b17-88c9-08a3a8e95fcc"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("34e36a61-3788-4f9f-b009-02a697b634eb"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6129da45-9371-4276-a7e7-f6522d0c4f0c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6e5294f7-a2fe-4a01-abf9-8bcfaeb78bec"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("78c5584a-04c4-4c04-af87-0860981bcd36"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("7f2de3d3-4383-481a-906c-097877b41479"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("0888b147-3e15-411b-a080-c764163ed723"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("472719cc-2d8f-4340-82db-06e8ed206c35"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4d963744-39a0-41bf-b144-4a4354d0a171"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("840a8187-54c2-45bd-9c40-fd920f4da333"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5888e7ee-cbaa-466b-b6b5-86fb0b605c79"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f2db955e-a6b5-4314-a3e2-6246ce4d9a9f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("844707b5-b00b-46ae-962e-3cf6b5098726"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("aa5330c4-01c4-4cea-953e-f61b9a554c48"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b6f4035b-81f4-465b-8277-53e79a09f75c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5dae03e2-f435-4cad-b674-7f6b01f2794c"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("e3220225-cd78-47f0-b926-e3685c32679f"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f13d726c-f8fb-4b12-b9a5-40bb74d2fe7a"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("f6c94150-39ba-432b-a5af-fd0afee5f2a1"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d451be8f-1ba4-4120-ac75-3987549fd332"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("246dee1a-ed15-463f-bc9e-34f5e7f7b0b3"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("a59234c8-1b14-4dac-88e9-a4b7d60beca4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("24498877-7f5a-49e8-830a-257a1d1e3af7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("1dc41a12-dccd-489c-96a3-c55dd8bf4efa"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4a67d2cb-ff4c-4307-be49-5520babc4d86"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("6ac8d492-7931-4e9a-a85b-783c30d68fe7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("abf7fb22-e06d-4e57-bf6b-0dec53bf8cd7"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("d666983d-b873-4cff-afbe-329990186d94"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("60ce2cd8-e39e-4368-82b8-b3b8206b8b42"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("993e3c71-c710-4348-a515-1dd023d713f6"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("945149b6-76f5-4817-94d2-f1d38a29c7a0"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("98e543a2-16d7-4927-bcda-609e1307d302"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("50c2b83a-d5cb-4073-8237-b6764e0b9c69"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9b6cdff3-0969-4f1f-a51c-80ff11e2cb81"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("38141f38-7804-47e0-b43e-1108a5f29973"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("77301813-91f7-49db-a769-37fe5a288347"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("5729bdbe-c9a1-4719-bc10-d6758a8c371c"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("820a6a9d-1425-480a-816d-154deaea6d2e"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("76a4a0ae-b13d-413d-8c66-e82e76cbc74d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("acc6872f-70f4-4dd6-9d7e-c6eaaa7f8f50"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("7967419a-2603-4bed-a3da-57a0688dd2ca"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("9eda6903-da5d-4bad-82b8-232408fce870"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("6204c4b1-cd3c-45fd-993c-b2e83f954248"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("957f6c0b-7beb-420f-b944-56f83237fe8b"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d7fd8286-dc43-45d9-8deb-f46d76af8fa9"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("661574ec-f0d3-4323-8ee1-98fb3f77caa3"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("b44113e9-de40-4f6e-8ae9-ac925caf0d02"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("eda244ca-938e-4da7-8867-e52ae4543ff7"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("410a5a1c-b2f8-47e4-8dab-4a699710bda9"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d55798ad-5f76-418f-9f00-d1def52caedf"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("73d966c7-ba70-46ad-9ae9-b8b265b504b1"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("64657280-e79d-4d35-bf4a-7298e6fd618c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("4a1ece9e-ade0-4e3b-85d0-08da37d5f3d4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("5356c9aa-8a40-4104-b8f7-53871d6b8cf2"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("3ca70a5d-9e8c-41c1-8afb-dc92e352a78c"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("dbf345b0-047d-4432-9daa-f92a96fcbe97"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("b4ae5760-850a-45b9-83ea-70caaef488cd"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("05d621c7-f00c-4af1-bfb8-dbed0afd4ec3"), new Guid("f1b788a8-1622-4de6-9ff0-a4cccec0357b"), new Guid("16ff5768-ee1a-49fa-9681-299b3dc652e4"), new Guid("9456ffd7-58ef-4fba-8bed-c1ae967c240b") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("d6625b3a-4363-4d1f-a5cc-50fb297f7d1d"), new Guid("d00330bc-c00f-4b8e-b3db-3b03d2ce99a4") },
                    { new Guid("b98eac1b-dc00-41ac-8ec5-2ed37e197060"), new Guid("9056ddf1-fa98-4e26-b56b-3c9b7ecde4f4"), new Guid("1a84a405-7050-4f72-b48b-e8f1341d884e"), new Guid("2b4c783a-7343-42d5-bf91-9c2131681cf3") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_FilmScreenings_FilmSreeningId",
                table: "Items",
                column: "FilmSreeningId",
                principalTable: "FilmScreenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
