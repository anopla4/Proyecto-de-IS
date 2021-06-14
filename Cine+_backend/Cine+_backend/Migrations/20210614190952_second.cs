using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("38f3c605-dd50-4dc2-9f41-83a7215d8cc7"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("5095b760-ae7b-49d4-b253-cdded888f732") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("7a2a8116-6cd9-4e2e-8570-961a682c62dd") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("64d13932-ee93-4fb5-8c70-4300ec7d75ff"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b81b683c-831d-49fb-a93f-979bf2d81c64"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("d5e34200-9cc9-46a3-a5fb-f3d52591eeb6"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e68d452c-21cd-4559-89f8-2f53f467d48c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("021de1ec-c588-4432-8ec6-12a0a5f7f47d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("47adfc7d-523d-45de-82d9-dd0b8a192b36"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4eb794c0-a35c-452a-b16f-d430ab07584c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("507d99b5-b812-48a1-ad61-fe3e0619dc9d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7c045dc2-efb6-44df-ab66-076dd8b0d22d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("86e7cb39-6d6d-4f86-a7b2-a1081ad937c9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9c2afa0f-b905-4e93-81ab-86d31fa499e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9d5f8777-617f-4af1-85e1-dedd45eb424b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e8092d94-d01f-4523-85a8-7dd965578cf6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fd02b93f-4368-41d0-b97f-d0bffdb0eb7c"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("004fd3b0-0383-4d30-af84-f30c4ac12db5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("00836ef4-52e9-4760-9cde-d1ccd9eda4f9"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0177b5b6-9501-4704-9f08-674c7d6a3df3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01a232a0-a7e2-433f-9f34-1de70121edd6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01e14cbf-8dc8-404c-8d7e-8ef4ff2467f9"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01ecc381-99d3-420c-b045-ebf906f5afd1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("038ab59e-70e9-4855-accc-c5c94371edf7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("044cf2c4-b4f5-4202-9a02-c36bfe098054"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("048c2a05-6583-407c-82aa-0bad58ff8ae4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("05b68ef4-c633-4cb8-9257-9cd211524516"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("05e21c51-ff66-4db6-b134-1d7aa4d5c9b7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0690bf3f-f79a-48b7-81ba-6882f7585bc2"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("07de84e5-16d3-4107-92c3-39b0f23d298e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("07e72dac-f981-461e-a1c1-35a986d07626"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("08ecf90b-9dea-4ec0-b0da-2a097349e0f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("09230f13-af04-4248-90ad-6b9fd1bdeaa5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0a25471e-a702-4a2d-a21b-e560906c0b5a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0c775ea0-72ba-410d-a54b-16f2852f26a6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0de69aad-0cce-4b22-8d00-8ffa0dfc9c8e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0e5e1f99-445e-4f57-8916-423d933927d4"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0e94e2de-3edd-4c6e-8d2f-2d22a80ebbce"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1089a825-96f5-4e18-bb29-f6eafb2f4013"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("12758ed8-4b40-46f4-8c08-e1dfe46addfc"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("12d6f215-3052-4b4c-98de-a9977a88369a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("12e896e7-4fa3-40f1-88c8-4bdb4546c03f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("13b71a85-5138-403a-b610-e988002f2a4f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("14535c15-4aa1-45aa-8a41-bf4eaa21788f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("14a42e87-a80f-407d-a11d-f30f865484e4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("159730ab-a75d-4637-b023-62d70d944c01"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("15c5301c-ad78-4d5f-95a1-289e330d7e8a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("16cf3277-a021-41b2-a96b-70544de23e7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("16f2643f-80f2-431f-b721-039c38c09c87"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("184a4c59-5ecf-42cd-a867-776d30804bba"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("18628c00-51ce-4c1f-8a59-d91ddaf9f0af"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1a03d7df-f6f5-46e6-bc4b-e5f9d0ea6941"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1bae0e83-c89d-4062-a1a2-55c1491b3909"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("1df24a12-6c2b-4df6-bea8-92a334a13f7e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("21a774cf-b82c-4ff7-a80e-4d9eb148d13d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("21c0fd63-bf6b-4ff5-a12c-a621a99d5e9c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("23837674-4658-4af2-816b-3453928927ad"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2412ecc9-002d-4879-b5fc-0b81ffa05c0e"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("24a01864-6cdb-47e7-a795-8cf3352fc133"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("24b4a48e-bab0-4bb2-a528-ec154a535b76"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("24f77f26-211a-4514-9904-585e5d5d2107"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("25a44c5d-43c2-4663-82cd-31a23a37e9ac"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("26d31416-b39e-4288-910a-9cb79866b741"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2789b5fc-01a1-4b01-94cd-53166533a2fa"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("27edbdf9-8fa0-4775-b864-f44e6450d063"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("288d2bf8-7a5c-41b2-8917-7989fcef0466"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2a209e28-4529-49ee-ae77-a724b45ce9c1"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2b57b282-4d3c-4f93-826a-a9efada78a9c"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2b993193-907e-40e5-9c81-44a6e6c3d938"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2c0dda33-2d71-43be-a6d9-e69df9eace22"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2db2bbd9-639e-473c-a191-f6622bdd573e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2de2b06c-1faf-4b5a-8f16-1e421de28e30"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2e1f6679-0f13-44d7-b571-b8d0890ce481"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("30dddb62-a550-46be-8ddd-0fa0debaf7d2"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3251e15c-89f9-4a90-bbc0-1320354cdd22"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3388bbec-dec6-4cbb-8df1-c0c5adf73c17"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("339044b7-f1ef-4304-9b88-d571f352b20f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("35385569-f563-4034-93f9-d8648d323ff7"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("36651366-5149-45f6-929e-fe3677aa826d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3738909e-78cd-47c0-94e2-0ddae5ae5f4f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("37c56d92-ff7f-4830-a762-d91c52e23813"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("37c7659c-f86d-4f03-aa90-92cbf163e15a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("38e63a18-e061-4e7b-b0af-d54b03c930c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3b6be2df-ca38-40f4-8e21-1aa118cd1537"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3bd9498c-2d0b-4303-954f-193c5dbc21ec"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3c2cedaf-2a89-4c28-90dd-885f504f1b77"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3db2dc43-8a22-4876-a8d7-8dd5f9f42a19"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e186b9e-29c7-485e-890f-401971b8ca27"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e955aca-da2c-4562-bd0a-af0731a3319d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e9edb84-17ab-4689-ab7c-8b7d9721cef5"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3f0484cf-b7e9-4679-975e-051f31e7e877"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3fb942ee-a5ff-45f5-9a98-29922f39b9a3"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3fecdca3-bfe0-4f15-969e-fd6f82f6b975"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4030541c-b86a-4451-ad02-deeae86c2484"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("42ea45ca-7afe-4ff4-a5a0-0d742e7299ad"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4424a65d-428f-4a69-bf02-2854554128d6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("44d7b8c1-3730-4d07-b388-be0ca08537fd"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("4513578a-f9ff-4464-95a3-3861c13acfc6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("452ff35a-6175-414e-8e9b-cea7f032b687"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("45918306-cf69-48a4-903d-7cc459c9fd31"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("45d948fc-451e-42ec-9c1e-d6c912006bf7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46a15f77-df36-49b5-a028-5f47c5f979a1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46d4063f-7788-4ab5-a3e8-5ebe3298e211"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46e4a303-7ae6-4b00-9cfe-24c0191b23c8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("46f3857c-8c0d-4330-b585-1c4124846d50"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("480214c1-6c8f-49d1-a63d-b0f682d1eeb1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("48c0f3ef-b18a-4c13-87a0-590e0fe0e258"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4b6181bf-9b54-4d8e-8ac8-9988c42c9101"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4cbace2b-7a86-4237-bc3c-1a93bf2467a6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4da25972-d73b-49ed-8a7d-f83f452dc932"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4e76ab6c-5297-4dce-b243-976d81456436"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4ee70687-9e36-424d-a265-6033baa94a34"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4ef25ca3-0e9b-47bf-848b-8a2e2167f10e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4f63ff35-4128-42a9-994f-24382a746763"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("4f71bab8-1207-49e3-937e-f32619e8973e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5280633c-aa81-4ccb-8ba1-ff27eb90700d"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("52cdfae3-4ac5-4409-b9bd-e1f7a3fb4b6f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5323936e-1fd1-4ece-a650-05568ea319ad"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("545c6f8e-a8a8-4ce5-91a7-f89d47f283c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("54f89f7a-55aa-4cb7-b29e-ed287f42f173"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("559b61a7-d537-4130-bfba-c0a04414da37"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5682f5eb-5c38-4f86-94fc-2209b9b3274b"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("576686fe-1437-4e60-9af9-cf9493cdfdf1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("59ce3c7e-5669-4bca-8f37-641f8de287f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5a47975a-9cbb-4aa1-9553-d3661d3f2233"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5b073ccd-3b07-42d0-83f9-61b26ac2fc71"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5b26925c-ff5b-4530-ab83-e5ba7018fd11"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5d66371e-457d-4fb4-a023-9b7448bf36fe"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5f85acf7-7c16-4439-9bfc-73f9faf5d5fc"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5fdc8e5b-f9e5-4399-826f-33b82f348bdf"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("60199a39-65b9-48c1-b760-c03cea799328"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("613ba02c-89a3-4671-98f7-f3557d0093de"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("624cd037-5f60-423d-b115-441c9d8c23f5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("647dffd0-e16a-4355-9d56-aefbcdd59074"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("64f5f6cd-bd19-4167-a2aa-60cb135e265c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("678e56ef-a9f3-4e11-ac73-d766ec234679"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("685a52cb-7b44-4142-b608-820d3913e29f"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("699f8ab9-0a6a-4201-ad1b-b9a528283667"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6a459744-3bb7-44fb-b70d-e7cbe968dca4"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("6c99cef0-556c-4eae-8634-913d5fd94a69"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6ca706db-997c-455e-ad1a-fb91b6d9b15c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6f0fbcab-2d74-48f1-be63-2b1964bff36a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("6f8ebd42-76d2-4403-aa3f-d6b570955980"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("70c23d17-e360-49b6-ae67-b081bc43f0fb"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("71c39e9b-dd23-4c83-8ee8-41d43d88e810"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("730aabcd-7292-4aae-898e-80896f54434e"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("74ea6568-f5d9-4bdb-99a9-8a55cbd70608"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("752d263c-2fd2-429c-8197-04e97eb66b75"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("765a1ee3-c287-4561-99b1-b62a640e256f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7a4daef2-9890-4c3a-bf8b-1492a274c43a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7afe1123-b40f-4f08-b75b-7b23cf63dd96"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7b537e91-cd5b-4513-82a4-06106bed196a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7d280986-6a43-4e54-aeae-8e6c4dffc2e9"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7e144958-f510-45c3-8780-63679a27187d"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7e627a17-1531-478c-9736-fc16d136778d"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7e96d44e-0ba2-47f4-96cb-e7eb5411ca7b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7edf4135-3377-4e76-9411-b87946863ee9"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7f995bf6-2b0b-44ca-b1dc-1eed8140303e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("80745992-f6c0-4422-a437-c7aad268a955"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("808bf77c-ae50-4a56-a368-9374c5fdaa7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("81ad44ab-f559-4d1d-86fb-f149c888f82c"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("86dd91b8-a523-4c5f-b192-76703b0eff1f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("884d063c-5118-4d1d-8010-59c82895b345"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8a3d45ff-c8ba-46ac-a87a-076412bb90bc"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8ac99b7e-ed71-4abc-8ed7-3ce5d38c7d63"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8b94abb9-6d06-4be9-b976-42caac852ddf"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8c4008bb-34a3-42c6-8545-e329ed91c7b5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8c5fb618-e509-4cd1-9f2b-dd60ac2216c8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8cc9a425-61cc-4b37-b153-6a5510164b01"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8d3eb601-f122-4cf3-a2d8-bde7ce09a49d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("904a7ff3-8c2c-4420-92b1-7657b8b3ad2e"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("914de060-bb62-465e-86d7-98c7b8824bf6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("92146dde-6431-4992-9a32-8db0aa0d7a79"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("93ba967c-98ea-40dc-aa09-613df24d2c26"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("94aeaa67-8786-46aa-8500-c51aa6c895f6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("94b6d51e-6a28-4741-9238-c1dd6c73bf72"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("94e7f59d-f94e-42ad-845e-872d37eb1376"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("962d411b-6655-4f39-9fa2-adfbf8c0eef5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9676ce9a-233e-4acf-8f9e-684fa7a1f537"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("985a0e3b-9756-4e2d-b323-10ae76523f3a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9a6c3d64-5d8d-4c08-a7fb-2dd4360ac341"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("9ccce858-6951-4351-b8a8-92de9b950d04"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9d4ab7c0-38ab-4588-8aca-75ac5e0af8c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a0636e88-5806-49a1-af98-2d3cfdb9b987"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a0ccbc18-aec9-4c17-9b51-47aca8a6cae2"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a1114b07-d426-43d5-9678-ac5eb6a7651b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a129c0bd-73e9-4452-bd77-be61d05b6dec"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a17f5c5f-287d-484d-8d50-972c387ceb14"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a4949a8a-cfd0-4abd-85a1-1768711a8ba0"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a4fca78e-79d9-49ff-8bba-4a3586624ca2"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a7c1a784-b5e2-4733-b734-d49785604f68"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a81931cc-b061-42a5-a76f-ce5c08be8857"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a8905592-9771-4429-99b3-cfabf0826d09"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a919b728-45c9-48b6-929b-f1a648b09f19"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("aa4d8d68-95d9-47ef-bded-99f691be09d1"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("adacf329-e78f-416b-932d-1d0b7e22f80b"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ae98e2aa-a164-4397-b8a7-1da4a57f14cb"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("af00b5df-fdeb-4dae-ae95-780d109beaee"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("af039cb0-ddd2-4a1d-a224-13fa67634789"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("af465664-96cb-4c0b-bb92-f8819215edae"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("afbb32b8-eada-47fb-90ee-a247b5baa11a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b040d9a7-8c05-48dd-9df5-ada32d483e3f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b117fd98-b022-46fa-8f69-2029ffdd32fb"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b16b0f3c-c9bc-4a38-9eb6-ed3a1aba9a7c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b366b72c-0e50-4373-8d14-243ba972afb4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b39f1704-d5f4-4225-b127-5bd82fdd2d7e"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b4392897-921a-40e0-9780-9bae3ad28b5f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b5aef9ad-54ac-4b91-9280-dc4efea0fa00"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b65885ff-a293-49b4-a419-c344787d3e5d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b7f4db74-c093-4333-b3b6-9c222aa23c5b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b7fd7c90-5869-4b29-8acc-4f836c1d45a3"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b8519432-95f5-446c-b46a-b04960901f85"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b96c5e79-c1de-4fbc-bc80-15e119f0d361"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b9b62c04-61a5-471e-b017-3a30446a255f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("bb643399-a51e-408f-bd1a-dffcf381df53"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("bd8ce683-fdea-46df-861a-768cfcd9ff0a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("c18a4964-365e-4b40-bb80-3d28e1871bde"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("c70787fb-b34b-4f39-9ad6-ce9277dfdb7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c839c731-e0f2-44dd-8244-f54e79c78805"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c8ba6fde-4f86-4c3e-831a-95da6fbd21f9"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c9847024-4686-46f0-a01a-3e9a148bb934"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ca35807b-1edf-4af3-81e1-83ab4bca98ac"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cac61171-b3d0-4797-8546-65e4b99f91fd"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cb598e9b-990f-483a-a2cc-33689deaeecb"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cb984a09-c87e-4d3e-bcd9-a6cd8676c50c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cc1d63c5-0a87-4563-95ee-2a40f9eceede"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cc2f35b8-5111-4e13-aa43-8072b920d4c6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cd2c297a-e6f7-4b31-82db-ba6b10e1cf33"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cdce0453-c971-4a16-baaa-5b4e5100f46f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ce4370a8-83ae-4331-8ca6-7de194fee3f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cf24c243-e68f-46f2-8345-4ba063562dcc"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cfa73cfe-4f87-4405-8787-4ad11ecb0adb"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d00b5261-af55-423b-b1f1-8ce299887181"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d1b694c4-05ff-407a-8876-caee46c5c04f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d2225a76-0199-415f-bc6b-a650de8d94d5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d2ead336-8e53-4604-9465-684c5797a605"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d3d466ec-d488-4e70-8384-59f4d31ebfbb"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d4f64f0b-8161-4364-86f6-5fb52198b14f"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d5fbad6f-876c-4b82-bcd4-bbdd3aebe762"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d661835a-796a-4163-8014-78e38a09a743"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d69f630a-b929-428c-b044-ac6b922102a3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d7ff1f45-e5c3-4c34-8f10-f58345589cf7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d8d94986-fe04-4f7f-9e49-40e269cb2e9e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d980d0b7-53a9-4aed-81b2-3d31a21dcd8b"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("db396f4d-9954-4c39-8376-3766705f90d7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("db4ae9d5-31b6-4844-a025-91c41ecb925e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc08360f-c2b7-47f3-a8cd-85a5bf5a0be8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc2cb226-bbc1-4fb3-b243-e31897d39801"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc52f1e4-bf8e-4b87-9453-8d3c5bd0c650"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc75b212-57de-4d87-9831-af798e2e14d3"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("dca470bf-fa2e-4bd9-a3ea-e92aaf23757f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("dcab1744-2c02-494d-aaae-348750b71c69"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dd6c4a04-912b-4269-b4cd-4b51b6034b5b"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("de3c7224-6b69-485b-af0d-23e964ecdf67"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e139bac0-65f2-427f-bf25-2c61badc9c9c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e19a0f8d-ac78-4a8f-905e-c5c30b9d7217"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e3499dd1-6301-492f-b2af-d8a8c4bf0e49"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e3e673c4-b047-43ad-944c-b857824eb682"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e4b83639-9269-4437-8b1a-dac3383b3632"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e4d8bbf0-c704-40b9-b376-a39eb5bfbdb0"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e6f98285-a028-40c6-92a1-b0c1995c11a5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e8690be8-3b29-4a3a-a3f0-a62b2ff2a506"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e98a4640-6dd9-4ef6-a558-dcf623404255"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("eb3d57e5-69a8-4296-8278-941dc734b277"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("eb9391c6-abd2-48a9-ae54-5211ee043ae0"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ec31c0d2-a84d-4970-a60f-2c24eb8dd8c9"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ed96ed02-cdbe-4f9f-9631-bb9bddf132df"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ef764574-c762-472c-a194-7b243ba09491"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f11af2df-e85d-4c37-959e-8a38ffc21632"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f11da012-f17f-4de6-96de-f18f16d43fe3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f4307691-9be2-44af-b578-2d720266d954"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f5b85ce6-d668-4ac6-8931-b25cb2bfe416"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f86e8ad7-f7d9-4a4f-a6e7-9ca908d13edc"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f8d430ec-f036-40a2-b2ce-bb6dc8284085"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9093282-4c85-43cb-ab4f-e26808e7f2e1"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9d52a0f-d4d5-46d3-8652-23dac8df06d3"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9da0ce0-1b34-4bee-bb20-d1525333578c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f9e365fa-e157-4f2f-afb6-cd396a755859"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("fc49ee96-8240-465d-a4e4-e0957b37ffd7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("fcf3398e-5aa0-4ed8-8940-b905812e0d2a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("fd8dc9b7-7afc-4520-ae71-ceeb4afd7c02"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("fe6bdef0-4cf2-4565-9226-2233a5deb2bf"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ff6fff9a-fd65-4e44-ae7e-c6edaab73f3c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("38f3c605-dd50-4dc2-9f41-83a7215d8cc7"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("75662171-4336-4311-8a16-730915068f77"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5095b760-ae7b-49d4-b253-cdded888f732"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7a2a8116-6cd9-4e2e-8570-961a682c62dd"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("88bda99c-21b3-4995-be49-5248a968f595"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("004fd3b0-0383-4d30-af84-f30c4ac12db5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00836ef4-52e9-4760-9cde-d1ccd9eda4f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0177b5b6-9501-4704-9f08-674c7d6a3df3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01a232a0-a7e2-433f-9f34-1de70121edd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01e14cbf-8dc8-404c-8d7e-8ef4ff2467f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01ecc381-99d3-420c-b045-ebf906f5afd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("038ab59e-70e9-4855-accc-c5c94371edf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("044cf2c4-b4f5-4202-9a02-c36bfe098054"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("048c2a05-6583-407c-82aa-0bad58ff8ae4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05b68ef4-c633-4cb8-9257-9cd211524516"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05e21c51-ff66-4db6-b134-1d7aa4d5c9b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0690bf3f-f79a-48b7-81ba-6882f7585bc2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07de84e5-16d3-4107-92c3-39b0f23d298e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07e72dac-f981-461e-a1c1-35a986d07626"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("08ecf90b-9dea-4ec0-b0da-2a097349e0f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09230f13-af04-4248-90ad-6b9fd1bdeaa5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a25471e-a702-4a2d-a21b-e560906c0b5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c775ea0-72ba-410d-a54b-16f2852f26a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0de69aad-0cce-4b22-8d00-8ffa0dfc9c8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e5e1f99-445e-4f57-8916-423d933927d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e94e2de-3edd-4c6e-8d2f-2d22a80ebbce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1089a825-96f5-4e18-bb29-f6eafb2f4013"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12758ed8-4b40-46f4-8c08-e1dfe46addfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12d6f215-3052-4b4c-98de-a9977a88369a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12e896e7-4fa3-40f1-88c8-4bdb4546c03f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13b71a85-5138-403a-b610-e988002f2a4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14535c15-4aa1-45aa-8a41-bf4eaa21788f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14a42e87-a80f-407d-a11d-f30f865484e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("159730ab-a75d-4637-b023-62d70d944c01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15c5301c-ad78-4d5f-95a1-289e330d7e8a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16cf3277-a021-41b2-a96b-70544de23e7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16f2643f-80f2-431f-b721-039c38c09c87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("184a4c59-5ecf-42cd-a867-776d30804bba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18628c00-51ce-4c1f-8a59-d91ddaf9f0af"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a03d7df-f6f5-46e6-bc4b-e5f9d0ea6941"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1bae0e83-c89d-4062-a1a2-55c1491b3909"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1df24a12-6c2b-4df6-bea8-92a334a13f7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21a774cf-b82c-4ff7-a80e-4d9eb148d13d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21c0fd63-bf6b-4ff5-a12c-a621a99d5e9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23837674-4658-4af2-816b-3453928927ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2412ecc9-002d-4879-b5fc-0b81ffa05c0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24a01864-6cdb-47e7-a795-8cf3352fc133"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24b4a48e-bab0-4bb2-a528-ec154a535b76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24f77f26-211a-4514-9904-585e5d5d2107"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25a44c5d-43c2-4663-82cd-31a23a37e9ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26d31416-b39e-4288-910a-9cb79866b741"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2789b5fc-01a1-4b01-94cd-53166533a2fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27edbdf9-8fa0-4775-b864-f44e6450d063"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("288d2bf8-7a5c-41b2-8917-7989fcef0466"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a209e28-4529-49ee-ae77-a724b45ce9c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b57b282-4d3c-4f93-826a-a9efada78a9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b993193-907e-40e5-9c81-44a6e6c3d938"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c0dda33-2d71-43be-a6d9-e69df9eace22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2db2bbd9-639e-473c-a191-f6622bdd573e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2de2b06c-1faf-4b5a-8f16-1e421de28e30"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e1f6679-0f13-44d7-b571-b8d0890ce481"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30dddb62-a550-46be-8ddd-0fa0debaf7d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3251e15c-89f9-4a90-bbc0-1320354cdd22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3388bbec-dec6-4cbb-8df1-c0c5adf73c17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("339044b7-f1ef-4304-9b88-d571f352b20f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35385569-f563-4034-93f9-d8648d323ff7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("36651366-5149-45f6-929e-fe3677aa826d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3738909e-78cd-47c0-94e2-0ddae5ae5f4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37c56d92-ff7f-4830-a762-d91c52e23813"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37c7659c-f86d-4f03-aa90-92cbf163e15a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38e63a18-e061-4e7b-b0af-d54b03c930c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b6be2df-ca38-40f4-8e21-1aa118cd1537"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bd9498c-2d0b-4303-954f-193c5dbc21ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c2cedaf-2a89-4c28-90dd-885f504f1b77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3db2dc43-8a22-4876-a8d7-8dd5f9f42a19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e186b9e-29c7-485e-890f-401971b8ca27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e955aca-da2c-4562-bd0a-af0731a3319d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e9edb84-17ab-4689-ab7c-8b7d9721cef5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f0484cf-b7e9-4679-975e-051f31e7e877"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fb942ee-a5ff-45f5-9a98-29922f39b9a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3fecdca3-bfe0-4f15-969e-fd6f82f6b975"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4030541c-b86a-4451-ad02-deeae86c2484"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42ea45ca-7afe-4ff4-a5a0-0d742e7299ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4424a65d-428f-4a69-bf02-2854554128d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44d7b8c1-3730-4d07-b388-be0ca08537fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4513578a-f9ff-4464-95a3-3861c13acfc6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("452ff35a-6175-414e-8e9b-cea7f032b687"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45918306-cf69-48a4-903d-7cc459c9fd31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45d948fc-451e-42ec-9c1e-d6c912006bf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46a15f77-df36-49b5-a028-5f47c5f979a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46d4063f-7788-4ab5-a3e8-5ebe3298e211"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46e4a303-7ae6-4b00-9cfe-24c0191b23c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("46f3857c-8c0d-4330-b585-1c4124846d50"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("480214c1-6c8f-49d1-a63d-b0f682d1eeb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48c0f3ef-b18a-4c13-87a0-590e0fe0e258"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b6181bf-9b54-4d8e-8ac8-9988c42c9101"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cbace2b-7a86-4237-bc3c-1a93bf2467a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4da25972-d73b-49ed-8a7d-f83f452dc932"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e76ab6c-5297-4dce-b243-976d81456436"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ee70687-9e36-424d-a265-6033baa94a34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ef25ca3-0e9b-47bf-848b-8a2e2167f10e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f63ff35-4128-42a9-994f-24382a746763"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f71bab8-1207-49e3-937e-f32619e8973e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5280633c-aa81-4ccb-8ba1-ff27eb90700d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("52cdfae3-4ac5-4409-b9bd-e1f7a3fb4b6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5323936e-1fd1-4ece-a650-05568ea319ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("545c6f8e-a8a8-4ce5-91a7-f89d47f283c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54f89f7a-55aa-4cb7-b29e-ed287f42f173"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("559b61a7-d537-4130-bfba-c0a04414da37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5682f5eb-5c38-4f86-94fc-2209b9b3274b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("576686fe-1437-4e60-9af9-cf9493cdfdf1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59ce3c7e-5669-4bca-8f37-641f8de287f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a47975a-9cbb-4aa1-9553-d3661d3f2233"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b073ccd-3b07-42d0-83f9-61b26ac2fc71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b26925c-ff5b-4530-ab83-e5ba7018fd11"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5d66371e-457d-4fb4-a023-9b7448bf36fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f85acf7-7c16-4439-9bfc-73f9faf5d5fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fdc8e5b-f9e5-4399-826f-33b82f348bdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60199a39-65b9-48c1-b760-c03cea799328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("613ba02c-89a3-4671-98f7-f3557d0093de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("624cd037-5f60-423d-b115-441c9d8c23f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("647dffd0-e16a-4355-9d56-aefbcdd59074"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64f5f6cd-bd19-4167-a2aa-60cb135e265c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("678e56ef-a9f3-4e11-ac73-d766ec234679"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("685a52cb-7b44-4142-b608-820d3913e29f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("699f8ab9-0a6a-4201-ad1b-b9a528283667"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6a459744-3bb7-44fb-b70d-e7cbe968dca4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6c99cef0-556c-4eae-8634-913d5fd94a69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ca706db-997c-455e-ad1a-fb91b6d9b15c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f0fbcab-2d74-48f1-be63-2b1964bff36a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f8ebd42-76d2-4403-aa3f-d6b570955980"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70c23d17-e360-49b6-ae67-b081bc43f0fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("71c39e9b-dd23-4c83-8ee8-41d43d88e810"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("730aabcd-7292-4aae-898e-80896f54434e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74ea6568-f5d9-4bdb-99a9-8a55cbd70608"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("752d263c-2fd2-429c-8197-04e97eb66b75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("765a1ee3-c287-4561-99b1-b62a640e256f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7a4daef2-9890-4c3a-bf8b-1492a274c43a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7afe1123-b40f-4f08-b75b-7b23cf63dd96"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b537e91-cd5b-4513-82a4-06106bed196a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d280986-6a43-4e54-aeae-8e6c4dffc2e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e144958-f510-45c3-8780-63679a27187d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e627a17-1531-478c-9736-fc16d136778d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7e96d44e-0ba2-47f4-96cb-e7eb5411ca7b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7edf4135-3377-4e76-9411-b87946863ee9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f995bf6-2b0b-44ca-b1dc-1eed8140303e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80745992-f6c0-4422-a437-c7aad268a955"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("808bf77c-ae50-4a56-a368-9374c5fdaa7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81ad44ab-f559-4d1d-86fb-f149c888f82c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86dd91b8-a523-4c5f-b192-76703b0eff1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("884d063c-5118-4d1d-8010-59c82895b345"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a3d45ff-c8ba-46ac-a87a-076412bb90bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ac99b7e-ed71-4abc-8ed7-3ce5d38c7d63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b94abb9-6d06-4be9-b976-42caac852ddf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c4008bb-34a3-42c6-8545-e329ed91c7b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c5fb618-e509-4cd1-9f2b-dd60ac2216c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cc9a425-61cc-4b37-b153-6a5510164b01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d3eb601-f122-4cf3-a2d8-bde7ce09a49d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("904a7ff3-8c2c-4420-92b1-7657b8b3ad2e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("914de060-bb62-465e-86d7-98c7b8824bf6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92146dde-6431-4992-9a32-8db0aa0d7a79"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93ba967c-98ea-40dc-aa09-613df24d2c26"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94aeaa67-8786-46aa-8500-c51aa6c895f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94b6d51e-6a28-4741-9238-c1dd6c73bf72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94e7f59d-f94e-42ad-845e-872d37eb1376"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("962d411b-6655-4f39-9fa2-adfbf8c0eef5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9676ce9a-233e-4acf-8f9e-684fa7a1f537"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("985a0e3b-9756-4e2d-b323-10ae76523f3a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a6c3d64-5d8d-4c08-a7fb-2dd4360ac341"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9ccce858-6951-4351-b8a8-92de9b950d04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d4ab7c0-38ab-4588-8aca-75ac5e0af8c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0636e88-5806-49a1-af98-2d3cfdb9b987"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0ccbc18-aec9-4c17-9b51-47aca8a6cae2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1114b07-d426-43d5-9678-ac5eb6a7651b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a129c0bd-73e9-4452-bd77-be61d05b6dec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a17f5c5f-287d-484d-8d50-972c387ceb14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4949a8a-cfd0-4abd-85a1-1768711a8ba0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4fca78e-79d9-49ff-8bba-4a3586624ca2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7c1a784-b5e2-4733-b734-d49785604f68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a81931cc-b061-42a5-a76f-ce5c08be8857"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8905592-9771-4429-99b3-cfabf0826d09"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a919b728-45c9-48b6-929b-f1a648b09f19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aa4d8d68-95d9-47ef-bded-99f691be09d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("adacf329-e78f-416b-932d-1d0b7e22f80b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae98e2aa-a164-4397-b8a7-1da4a57f14cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af00b5df-fdeb-4dae-ae95-780d109beaee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af039cb0-ddd2-4a1d-a224-13fa67634789"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af465664-96cb-4c0b-bb92-f8819215edae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afbb32b8-eada-47fb-90ee-a247b5baa11a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b040d9a7-8c05-48dd-9df5-ada32d483e3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b117fd98-b022-46fa-8f69-2029ffdd32fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b16b0f3c-c9bc-4a38-9eb6-ed3a1aba9a7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b366b72c-0e50-4373-8d14-243ba972afb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b39f1704-d5f4-4225-b127-5bd82fdd2d7e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4392897-921a-40e0-9780-9bae3ad28b5f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5aef9ad-54ac-4b91-9280-dc4efea0fa00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b65885ff-a293-49b4-a419-c344787d3e5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7f4db74-c093-4333-b3b6-9c222aa23c5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7fd7c90-5869-4b29-8acc-4f836c1d45a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8519432-95f5-446c-b46a-b04960901f85"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b96c5e79-c1de-4fbc-bc80-15e119f0d361"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9b62c04-61a5-471e-b017-3a30446a255f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb643399-a51e-408f-bd1a-dffcf381df53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bd8ce683-fdea-46df-861a-768cfcd9ff0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c18a4964-365e-4b40-bb80-3d28e1871bde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c70787fb-b34b-4f39-9ad6-ce9277dfdb7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c839c731-e0f2-44dd-8244-f54e79c78805"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8ba6fde-4f86-4c3e-831a-95da6fbd21f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9847024-4686-46f0-a01a-3e9a148bb934"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca35807b-1edf-4af3-81e1-83ab4bca98ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cac61171-b3d0-4797-8546-65e4b99f91fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb598e9b-990f-483a-a2cc-33689deaeecb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb984a09-c87e-4d3e-bcd9-a6cd8676c50c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc1d63c5-0a87-4563-95ee-2a40f9eceede"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc2f35b8-5111-4e13-aa43-8072b920d4c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd2c297a-e6f7-4b31-82db-ba6b10e1cf33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cdce0453-c971-4a16-baaa-5b4e5100f46f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce4370a8-83ae-4331-8ca6-7de194fee3f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf24c243-e68f-46f2-8345-4ba063562dcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfa73cfe-4f87-4405-8787-4ad11ecb0adb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d00b5261-af55-423b-b1f1-8ce299887181"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1b694c4-05ff-407a-8876-caee46c5c04f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2225a76-0199-415f-bc6b-a650de8d94d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2ead336-8e53-4604-9465-684c5797a605"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3d466ec-d488-4e70-8384-59f4d31ebfbb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d4f64f0b-8161-4364-86f6-5fb52198b14f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5fbad6f-876c-4b82-bcd4-bbdd3aebe762"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d661835a-796a-4163-8014-78e38a09a743"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d69f630a-b929-428c-b044-ac6b922102a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d7ff1f45-e5c3-4c34-8f10-f58345589cf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d8d94986-fe04-4f7f-9e49-40e269cb2e9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d980d0b7-53a9-4aed-81b2-3d31a21dcd8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db396f4d-9954-4c39-8376-3766705f90d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db4ae9d5-31b6-4844-a025-91c41ecb925e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc08360f-c2b7-47f3-a8cd-85a5bf5a0be8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc2cb226-bbc1-4fb3-b243-e31897d39801"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc52f1e4-bf8e-4b87-9453-8d3c5bd0c650"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc75b212-57de-4d87-9831-af798e2e14d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dca470bf-fa2e-4bd9-a3ea-e92aaf23757f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcab1744-2c02-494d-aaae-348750b71c69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd6c4a04-912b-4269-b4cd-4b51b6034b5b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de3c7224-6b69-485b-af0d-23e964ecdf67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e139bac0-65f2-427f-bf25-2c61badc9c9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e19a0f8d-ac78-4a8f-905e-c5c30b9d7217"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3499dd1-6301-492f-b2af-d8a8c4bf0e49"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3e673c4-b047-43ad-944c-b857824eb682"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4b83639-9269-4437-8b1a-dac3383b3632"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4d8bbf0-c704-40b9-b376-a39eb5bfbdb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e6f98285-a028-40c6-92a1-b0c1995c11a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8690be8-3b29-4a3a-a3f0-a62b2ff2a506"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e98a4640-6dd9-4ef6-a558-dcf623404255"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb3d57e5-69a8-4296-8278-941dc734b277"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb9391c6-abd2-48a9-ae54-5211ee043ae0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec31c0d2-a84d-4970-a60f-2c24eb8dd8c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed96ed02-cdbe-4f9f-9631-bb9bddf132df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef764574-c762-472c-a194-7b243ba09491"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f11af2df-e85d-4c37-959e-8a38ffc21632"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f11da012-f17f-4de6-96de-f18f16d43fe3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4307691-9be2-44af-b578-2d720266d954"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5b85ce6-d668-4ac6-8931-b25cb2bfe416"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f86e8ad7-f7d9-4a4f-a6e7-9ca908d13edc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f8d430ec-f036-40a2-b2ce-bb6dc8284085"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9093282-4c85-43cb-ab4f-e26808e7f2e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9d52a0f-d4d5-46d3-8652-23dac8df06d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9da0ce0-1b34-4bee-bb20-d1525333578c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9e365fa-e157-4f2f-afb6-cd396a755859"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc49ee96-8240-465d-a4e4-e0957b37ffd7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcf3398e-5aa0-4ed8-8940-b905812e0d2a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd8dc9b7-7afc-4520-ae71-ceeb4afd7c02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe6bdef0-4cf2-4565-9226-2233a5deb2bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff6fff9a-fd65-4e44-ae7e-c6edaab73f3c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("8232e888-9b19-4009-8f72-19ede5821309"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("f72b575c-3f5e-476b-89fd-c6267642651e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("64d13932-ee93-4fb5-8c70-4300ec7d75ff"), "Productor Ejecutivo" },
                    { new Guid("e68d452c-21cd-4559-89f8-2f53f467d48c"), "Técnico de Sonido" },
                    { new Guid("38f3c605-dd50-4dc2-9f41-83a7215d8cc7"), "Diseñador de Vestuario" },
                    { new Guid("b81b683c-831d-49fb-a93f-979bf2d81c64"), "Guionista" },
                    { new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Actor" },
                    { new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Director" },
                    { new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"), "Productor" },
                    { new Guid("d5e34200-9cc9-46a3-a5fb-f3d52591eeb6"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre}", "1999" },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("507d99b5-b812-48a1-ad61-fe3e0619dc9d"), "Erótico" },
                    { new Guid("7c045dc2-efb6-44df-ab66-076dd8b0d22d"), "Musical" },
                    { new Guid("021de1ec-c588-4432-8ec6-12a0a5f7f47d"), "Aventura" },
                    { new Guid("9c2afa0f-b905-4e93-81ab-86d31fa499e0"), "Ficción" },
                    { new Guid("47adfc7d-523d-45de-82d9-dd0b8a192b36"), "Documental" },
                    { new Guid("e8092d94-d01f-4523-85a8-7dd965578cf6"), "Hístorico" },
                    { new Guid("4eb794c0-a35c-452a-b16f-d430ab07584c"), "Ciencia Ficción" },
                    { new Guid("86e7cb39-6d6d-4f86-a7b2-a1081ad937c9"), "Terror" },
                    { new Guid("5095b760-ae7b-49d4-b253-cdded888f732"), "Suspenso" },
                    { new Guid("7a2a8116-6cd9-4e2e-8570-961a682c62dd"), "Romántica" },
                    { new Guid("9d5f8777-617f-4af1-85e1-dedd45eb424b"), "Comedia" },
                    { new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3"), "Drama" },
                    { new Guid("fd02b93f-4368-41d0-b97f-d0bffdb0eb7c"), "Tragicomedia" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), "Platea Baja", 10 },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), "Sala 1" },
                    { new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), "Sala 2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("0de69aad-0cce-4b22-8d00-8ffa0dfc9c8e"), "C2" },
                    { new Guid("9d4ab7c0-38ab-4588-8aca-75ac5e0af8c5"), "C1" },
                    { new Guid("07de84e5-16d3-4107-92c3-39b0f23d298e"), "B3" },
                    { new Guid("884d063c-5118-4d1d-8010-59c82895b345"), "B2" },
                    { new Guid("44d7b8c1-3730-4d07-b388-be0ca08537fd"), "B1" },
                    { new Guid("d2225a76-0199-415f-bc6b-a650de8d94d5"), "A3" },
                    { new Guid("f5b85ce6-d668-4ac6-8931-b25cb2bfe416"), "G2" },
                    { new Guid("962d411b-6655-4f39-9fa2-adfbf8c0eef5"), "A1" },
                    { new Guid("dc75b212-57de-4d87-9831-af798e2e14d3"), "H2" },
                    { new Guid("e4b83639-9269-4437-8b1a-dac3383b3632"), "H1" },
                    { new Guid("94e7f59d-f94e-42ad-845e-872d37eb1376"), "G1" },
                    { new Guid("e8690be8-3b29-4a3a-a3f0-a62b2ff2a506"), "C3" },
                    { new Guid("9a6c3d64-5d8d-4c08-a7fb-2dd4360ac341"), "A2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("d4f64f0b-8161-4364-86f6-5fb52198b14f"), "D1" },
                    { new Guid("f11af2df-e85d-4c37-959e-8a38ffc21632"), "A1" },
                    { new Guid("159730ab-a75d-4637-b023-62d70d944c01"), "D3" },
                    { new Guid("2db2bbd9-639e-473c-a191-f6622bdd573e"), "E1" },
                    { new Guid("12758ed8-4b40-46f4-8c08-e1dfe46addfc"), "E2" },
                    { new Guid("2789b5fc-01a1-4b01-94cd-53166533a2fa"), "E3" },
                    { new Guid("d69f630a-b929-428c-b044-ac6b922102a3"), "F1" },
                    { new Guid("f4307691-9be2-44af-b578-2d720266d954"), "F2" },
                    { new Guid("dc08360f-c2b7-47f3-a8cd-85a5bf5a0be8"), "F3" },
                    { new Guid("f9e365fa-e157-4f2f-afb6-cd396a755859"), "G1" },
                    { new Guid("af039cb0-ddd2-4a1d-a224-13fa67634789"), "G2" },
                    { new Guid("21a774cf-b82c-4ff7-a80e-4d9eb148d13d"), "G3" },
                    { new Guid("5b073ccd-3b07-42d0-83f9-61b26ac2fc71"), "H1" },
                    { new Guid("752d263c-2fd2-429c-8197-04e97eb66b75"), "H2" },
                    { new Guid("3e955aca-da2c-4562-bd0a-af0731a3319d"), "H3" },
                    { new Guid("f86e8ad7-f7d9-4a4f-a6e7-9ca908d13edc"), "F2" },
                    { new Guid("685a52cb-7b44-4142-b608-820d3913e29f"), "D2" },
                    { new Guid("00836ef4-52e9-4760-9cde-d1ccd9eda4f9"), "F1" },
                    { new Guid("b39f1704-d5f4-4225-b127-5bd82fdd2d7e"), "G2" },
                    { new Guid("cfa73cfe-4f87-4405-8787-4ad11ecb0adb"), "E1" },
                    { new Guid("3b6be2df-ca38-40f4-8e21-1aa118cd1537"), "A3" },
                    { new Guid("16f2643f-80f2-431f-b721-039c38c09c87"), "B1" },
                    { new Guid("a0ccbc18-aec9-4c17-9b51-47aca8a6cae2"), "B2" },
                    { new Guid("e4d8bbf0-c704-40b9-b376-a39eb5bfbdb0"), "B3" },
                    { new Guid("613ba02c-89a3-4671-98f7-f3557d0093de"), "C1" },
                    { new Guid("d1b694c4-05ff-407a-8876-caee46c5c04f"), "C2" },
                    { new Guid("cc2f35b8-5111-4e13-aa43-8072b920d4c6"), "C3" },
                    { new Guid("4513578a-f9ff-4464-95a3-3861c13acfc6"), "D1" },
                    { new Guid("b5aef9ad-54ac-4b91-9280-dc4efea0fa00"), "D2" },
                    { new Guid("9676ce9a-233e-4acf-8f9e-684fa7a1f537"), "D3" },
                    { new Guid("a4fca78e-79d9-49ff-8bba-4a3586624ca2"), "E1" },
                    { new Guid("904a7ff3-8c2c-4420-92b1-7657b8b3ad2e"), "E2" },
                    { new Guid("3db2dc43-8a22-4876-a8d7-8dd5f9f42a19"), "E3" },
                    { new Guid("cf24c243-e68f-46f2-8345-4ba063562dcc"), "F1" },
                    { new Guid("2412ecc9-002d-4879-b5fc-0b81ffa05c0e"), "E2" },
                    { new Guid("699f8ab9-0a6a-4201-ad1b-b9a528283667"), "F2" },
                    { new Guid("71c39e9b-dd23-4c83-8ee8-41d43d88e810"), "G1" },
                    { new Guid("dc52f1e4-bf8e-4b87-9453-8d3c5bd0c650"), "B1" },
                    { new Guid("afbb32b8-eada-47fb-90ee-a247b5baa11a"), "G3" },
                    { new Guid("ff6fff9a-fd65-4e44-ae7e-c6edaab73f3c"), "H1" },
                    { new Guid("3388bbec-dec6-4cbb-8df1-c0c5adf73c17"), "H2" },
                    { new Guid("01e14cbf-8dc8-404c-8d7e-8ef4ff2467f9"), "H3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("d7ff1f45-e5c3-4c34-8f10-f58345589cf7"), "A1" },
                    { new Guid("16cf3277-a021-41b2-a96b-70544de23e7a"), "A2" },
                    { new Guid("5a47975a-9cbb-4aa1-9553-d3661d3f2233"), "B1" },
                    { new Guid("45d948fc-451e-42ec-9c1e-d6c912006bf7"), "B2" },
                    { new Guid("b040d9a7-8c05-48dd-9df5-ada32d483e3f"), "C1" },
                    { new Guid("01ecc381-99d3-420c-b045-ebf906f5afd1"), "C2" },
                    { new Guid("7a4daef2-9890-4c3a-bf8b-1492a274c43a"), "D1" },
                    { new Guid("a919b728-45c9-48b6-929b-f1a648b09f19"), "D2" },
                    { new Guid("765a1ee3-c287-4561-99b1-b62a640e256f"), "F3" },
                    { new Guid("dc2cb226-bbc1-4fb3-b243-e31897d39801"), "B2" },
                    { new Guid("46f3857c-8c0d-4330-b585-1c4124846d50"), "F3" },
                    { new Guid("25a44c5d-43c2-4663-82cd-31a23a37e9ac"), "C2" },
                    { new Guid("a7c1a784-b5e2-4733-b734-d49785604f68"), "D1" },
                    { new Guid("05e21c51-ff66-4db6-b134-1d7aa4d5c9b7"), "D2" },
                    { new Guid("c18a4964-365e-4b40-bb80-3d28e1871bde"), "D3" },
                    { new Guid("480214c1-6c8f-49d1-a63d-b0f682d1eeb1"), "D4" },
                    { new Guid("8a3d45ff-c8ba-46ac-a87a-076412bb90bc"), "E1" },
                    { new Guid("92146dde-6431-4992-9a32-8db0aa0d7a79"), "E2" },
                    { new Guid("5682f5eb-5c38-4f86-94fc-2209b9b3274b"), "E3" },
                    { new Guid("01a232a0-a7e2-433f-9f34-1de70121edd6"), "F1" },
                    { new Guid("5b26925c-ff5b-4530-ab83-e5ba7018fd11"), "F2" },
                    { new Guid("db396f4d-9954-4c39-8376-3766705f90d7"), "A1" },
                    { new Guid("3fecdca3-bfe0-4f15-969e-fd6f82f6b975"), "B1" },
                    { new Guid("aa4d8d68-95d9-47ef-bded-99f691be09d1"), "B2" },
                    { new Guid("3e186b9e-29c7-485e-890f-401971b8ca27"), "C1" },
                    { new Guid("cc1d63c5-0a87-4563-95ee-2a40f9eceede"), "C2" },
                    { new Guid("339044b7-f1ef-4304-9b88-d571f352b20f"), "C5" },
                    { new Guid("8c5fb618-e509-4cd1-9f2b-dd60ac2216c8"), "C3" },
                    { new Guid("de3c7224-6b69-485b-af0d-23e964ecdf67"), "D2" },
                    { new Guid("b16b0f3c-c9bc-4a38-9eb6-ed3a1aba9a7c"), "D3" },
                    { new Guid("60199a39-65b9-48c1-b760-c03cea799328"), "D4" },
                    { new Guid("038ab59e-70e9-4855-accc-c5c94371edf7"), "E1" },
                    { new Guid("1df24a12-6c2b-4df6-bea8-92a334a13f7e"), "E2" },
                    { new Guid("4f71bab8-1207-49e3-937e-f32619e8973e"), "E3" },
                    { new Guid("7e96d44e-0ba2-47f4-96cb-e7eb5411ca7b"), "E4" },
                    { new Guid("a17f5c5f-287d-484d-8d50-972c387ceb14"), "E5" },
                    { new Guid("d8d94986-fe04-4f7f-9e49-40e269cb2e9e"), "F1" },
                    { new Guid("0690bf3f-f79a-48b7-81ba-6882f7585bc2"), "F2" },
                    { new Guid("6f8ebd42-76d2-4403-aa3f-d6b570955980"), "F3" },
                    { new Guid("8d3eb601-f122-4cf3-a2d8-bde7ce09a49d"), "F4" },
                    { new Guid("a1114b07-d426-43d5-9678-ac5eb6a7651b"), "F5" },
                    { new Guid("fcf3398e-5aa0-4ed8-8940-b905812e0d2a"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("ae98e2aa-a164-4397-b8a7-1da4a57f14cb"), "D1" },
                    { new Guid("8ac99b7e-ed71-4abc-8ed7-3ce5d38c7d63"), "C1" },
                    { new Guid("c70787fb-b34b-4f39-9ad6-ce9277dfdb7a"), "C4" },
                    { new Guid("730aabcd-7292-4aae-898e-80896f54434e"), "C2" },
                    { new Guid("ef764574-c762-472c-a194-7b243ba09491"), "C3" },
                    { new Guid("70c23d17-e360-49b6-ae67-b081bc43f0fb"), "D1" },
                    { new Guid("0e5e1f99-445e-4f57-8916-423d933927d4"), "D2" },
                    { new Guid("2e1f6679-0f13-44d7-b571-b8d0890ce481"), "D3" },
                    { new Guid("3738909e-78cd-47c0-94e2-0ddae5ae5f4f"), "D4" },
                    { new Guid("3fb942ee-a5ff-45f5-9a98-29922f39b9a3"), "E1" },
                    { new Guid("dd6c4a04-912b-4269-b4cd-4b51b6034b5b"), "E2" },
                    { new Guid("cb984a09-c87e-4d3e-bcd9-a6cd8676c50c"), "E3" },
                    { new Guid("80745992-f6c0-4422-a437-c7aad268a955"), "E4" },
                    { new Guid("e139bac0-65f2-427f-bf25-2c61badc9c9c"), "E5" },
                    { new Guid("5f85acf7-7c16-4439-9bfc-73f9faf5d5fc"), "F1" },
                    { new Guid("42ea45ca-7afe-4ff4-a5a0-0d742e7299ad"), "F2" },
                    { new Guid("bd8ce683-fdea-46df-861a-768cfcd9ff0a"), "A2" },
                    { new Guid("3251e15c-89f9-4a90-bbc0-1320354cdd22"), "F4" },
                    { new Guid("048c2a05-6583-407c-82aa-0bad58ff8ae4"), "C3" },
                    { new Guid("24f77f26-211a-4514-9904-585e5d5d2107"), "F5" },
                    { new Guid("14a42e87-a80f-407d-a11d-f30f865484e4"), "A1" },
                    { new Guid("30dddb62-a550-46be-8ddd-0fa0debaf7d2"), "A2" },
                    { new Guid("7d280986-6a43-4e54-aeae-8e6c4dffc2e9"), "A3" },
                    { new Guid("b8519432-95f5-446c-b46a-b04960901f85"), "A4" },
                    { new Guid("86dd91b8-a523-4c5f-b192-76703b0eff1f"), "A5" },
                    { new Guid("fd8dc9b7-7afc-4520-ae71-ceeb4afd7c02"), "A6" },
                    { new Guid("b4392897-921a-40e0-9780-9bae3ad28b5f"), "A7" },
                    { new Guid("808bf77c-ae50-4a56-a368-9374c5fdaa7a"), "B1" },
                    { new Guid("6c99cef0-556c-4eae-8634-913d5fd94a69"), "B2" },
                    { new Guid("d3d466ec-d488-4e70-8384-59f4d31ebfbb"), "B3" },
                    { new Guid("3e9edb84-17ab-4689-ab7c-8b7d9721cef5"), "B4" },
                    { new Guid("81ad44ab-f559-4d1d-86fb-f149c888f82c"), "B5" },
                    { new Guid("94b6d51e-6a28-4741-9238-c1dd6c73bf72"), "B6" },
                    { new Guid("576686fe-1437-4e60-9af9-cf9493cdfdf1"), "C1" },
                    { new Guid("2b993193-907e-40e5-9c81-44a6e6c3d938"), "F6" },
                    { new Guid("09230f13-af04-4248-90ad-6b9fd1bdeaa5"), "A1" },
                    { new Guid("48c0f3ef-b18a-4c13-87a0-590e0fe0e258"), "D2" },
                    { new Guid("21c0fd63-bf6b-4ff5-a12c-a621a99d5e9c"), "F5" },
                    { new Guid("914de060-bb62-465e-86d7-98c7b8824bf6"), "F1" },
                    { new Guid("37c56d92-ff7f-4830-a762-d91c52e23813"), "F2" },
                    { new Guid("b7fd7c90-5869-4b29-8acc-4f836c1d45a3"), "G1" },
                    { new Guid("7e627a17-1531-478c-9736-fc16d136778d"), "G2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("d2ead336-8e53-4604-9465-684c5797a605"), "H1" },
                    { new Guid("ed96ed02-cdbe-4f9f-9631-bb9bddf132df"), "H2" },
                    { new Guid("eb9391c6-abd2-48a9-ae54-5211ee043ae0"), "A1" },
                    { new Guid("f9093282-4c85-43cb-ab4f-e26808e7f2e1"), "A2" },
                    { new Guid("f8d430ec-f036-40a2-b2ce-bb6dc8284085"), "A3" },
                    { new Guid("545c6f8e-a8a8-4ce5-91a7-f89d47f283c5"), "B1" },
                    { new Guid("b65885ff-a293-49b4-a419-c344787d3e5d"), "B2" },
                    { new Guid("af465664-96cb-4c0b-bb92-f8819215edae"), "B3" },
                    { new Guid("46e4a303-7ae6-4b00-9cfe-24c0191b23c8"), "C1" },
                    { new Guid("af00b5df-fdeb-4dae-ae95-780d109beaee"), "C2" },
                    { new Guid("288d2bf8-7a5c-41b2-8917-7989fcef0466"), "C3" },
                    { new Guid("6a459744-3bb7-44fb-b70d-e7cbe968dca4"), "D1" },
                    { new Guid("b7f4db74-c093-4333-b3b6-9c222aa23c5b"), "D2" },
                    { new Guid("46d4063f-7788-4ab5-a3e8-5ebe3298e211"), "D3" },
                    { new Guid("ca35807b-1edf-4af3-81e1-83ab4bca98ac"), "E1" },
                    { new Guid("624cd037-5f60-423d-b115-441c9d8c23f5"), "E2" },
                    { new Guid("f9da0ce0-1b34-4bee-bb20-d1525333578c"), "E3" },
                    { new Guid("15c5301c-ad78-4d5f-95a1-289e330d7e8a"), "F1" },
                    { new Guid("4ef25ca3-0e9b-47bf-848b-8a2e2167f10e"), "F2" },
                    { new Guid("38e63a18-e061-4e7b-b0af-d54b03c930c5"), "F3" },
                    { new Guid("0177b5b6-9501-4704-9f08-674c7d6a3df3"), "G1" },
                    { new Guid("37c7659c-f86d-4f03-aa90-92cbf163e15a"), "G2" },
                    { new Guid("e3e673c4-b047-43ad-944c-b857824eb682"), "G3" },
                    { new Guid("452ff35a-6175-414e-8e9b-cea7f032b687"), "H1" },
                    { new Guid("7f995bf6-2b0b-44ca-b1dc-1eed8140303e"), "H2" },
                    { new Guid("adacf329-e78f-416b-932d-1d0b7e22f80b"), "E2" },
                    { new Guid("3f0484cf-b7e9-4679-975e-051f31e7e877"), "E1" },
                    { new Guid("05b68ef4-c633-4cb8-9257-9cd211524516"), "D2" },
                    { new Guid("13b71a85-5138-403a-b610-e988002f2a4f"), "D1" },
                    { new Guid("52cdfae3-4ac5-4409-b9bd-e1f7a3fb4b6f"), "A1" },
                    { new Guid("0a25471e-a702-4a2d-a21b-e560906c0b5a"), "A2" },
                    { new Guid("bb643399-a51e-408f-bd1a-dffcf381df53"), "A3" },
                    { new Guid("12e896e7-4fa3-40f1-88c8-4bdb4546c03f"), "B1" },
                    { new Guid("6ca706db-997c-455e-ad1a-fb91b6d9b15c"), "B2" },
                    { new Guid("4030541c-b86a-4451-ad02-deeae86c2484"), "B3" },
                    { new Guid("5280633c-aa81-4ccb-8ba1-ff27eb90700d"), "C1" },
                    { new Guid("cb598e9b-990f-483a-a2cc-33689deaeecb"), "C2" },
                    { new Guid("93ba967c-98ea-40dc-aa09-613df24d2c26"), "C3" },
                    { new Guid("2c0dda33-2d71-43be-a6d9-e69df9eace22"), "D1" },
                    { new Guid("64f5f6cd-bd19-4167-a2aa-60cb135e265c"), "D2" },
                    { new Guid("d5fbad6f-876c-4b82-bcd4-bbdd3aebe762"), "D3" },
                    { new Guid("e19a0f8d-ac78-4a8f-905e-c5c30b9d7217"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("a81931cc-b061-42a5-a76f-ce5c08be8857"), "E2" },
                    { new Guid("f11da012-f17f-4de6-96de-f18f16d43fe3"), "H3" },
                    { new Guid("8b94abb9-6d06-4be9-b976-42caac852ddf"), "E3" },
                    { new Guid("4424a65d-428f-4a69-bf02-2854554128d6"), "F2" },
                    { new Guid("c839c731-e0f2-44dd-8244-f54e79c78805"), "F3" },
                    { new Guid("f9d52a0f-d4d5-46d3-8652-23dac8df06d3"), "G1" },
                    { new Guid("12d6f215-3052-4b4c-98de-a9977a88369a"), "G2" },
                    { new Guid("678e56ef-a9f3-4e11-ac73-d766ec234679"), "G3" },
                    { new Guid("14535c15-4aa1-45aa-8a41-bf4eaa21788f"), "H1" },
                    { new Guid("2de2b06c-1faf-4b5a-8f16-1e421de28e30"), "H2" },
                    { new Guid("cac61171-b3d0-4797-8546-65e4b99f91fd"), "H3" },
                    { new Guid("7e144958-f510-45c3-8780-63679a27187d"), "A1" },
                    { new Guid("08ecf90b-9dea-4ec0-b0da-2a097349e0f0"), "A2" },
                    { new Guid("fe6bdef0-4cf2-4565-9226-2233a5deb2bf"), "B1" },
                    { new Guid("4b6181bf-9b54-4d8e-8ac8-9988c42c9101"), "B2" },
                    { new Guid("59ce3c7e-5669-4bca-8f37-641f8de287f0"), "C1" },
                    { new Guid("ce4370a8-83ae-4331-8ca6-7de194fee3f0"), "C2" },
                    { new Guid("0c775ea0-72ba-410d-a54b-16f2852f26a6"), "F1" },
                    { new Guid("3c2cedaf-2a89-4c28-90dd-885f504f1b77"), "F6" },
                    { new Guid("d980d0b7-53a9-4aed-81b2-3d31a21dcd8b"), "A1" },
                    { new Guid("c8ba6fde-4f86-4c3e-831a-95da6fbd21f9"), "B2" },
                    { new Guid("b366b72c-0e50-4373-8d14-243ba972afb4"), "C4" },
                    { new Guid("46a15f77-df36-49b5-a028-5f47c5f979a1"), "C5" },
                    { new Guid("dcab1744-2c02-494d-aaae-348750b71c69"), "D1" },
                    { new Guid("647dffd0-e16a-4355-9d56-aefbcdd59074"), "D2" },
                    { new Guid("5323936e-1fd1-4ece-a650-05568ea319ad"), "D3" },
                    { new Guid("7b537e91-cd5b-4513-82a4-06106bed196a"), "D4" },
                    { new Guid("184a4c59-5ecf-42cd-a867-776d30804bba"), "E1" },
                    { new Guid("74ea6568-f5d9-4bdb-99a9-8a55cbd70608"), "E2" },
                    { new Guid("24b4a48e-bab0-4bb2-a528-ec154a535b76"), "E3" },
                    { new Guid("044cf2c4-b4f5-4202-9a02-c36bfe098054"), "F1" },
                    { new Guid("54f89f7a-55aa-4cb7-b29e-ed287f42f173"), "F2" },
                    { new Guid("fc49ee96-8240-465d-a4e4-e0957b37ffd7"), "A1" },
                    { new Guid("a0636e88-5806-49a1-af98-2d3cfdb9b987"), "B1" },
                    { new Guid("45918306-cf69-48a4-903d-7cc459c9fd31"), "B2" },
                    { new Guid("1089a825-96f5-4e18-bb29-f6eafb2f4013"), "C1" },
                    { new Guid("4e76ab6c-5297-4dce-b243-976d81456436"), "C2" },
                    { new Guid("36651366-5149-45f6-929e-fe3677aa826d"), "C3" },
                    { new Guid("004fd3b0-0383-4d30-af84-f30c4ac12db5"), "D1" },
                    { new Guid("4da25972-d73b-49ed-8a7d-f83f452dc932"), "D3" },
                    { new Guid("7edf4135-3377-4e76-9411-b87946863ee9"), "D4" },
                    { new Guid("b117fd98-b022-46fa-8f69-2029ffdd32fb"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("6f0fbcab-2d74-48f1-be63-2b1964bff36a"), "E2" },
                    { new Guid("985a0e3b-9756-4e2d-b323-10ae76523f3a"), "E3" },
                    { new Guid("db4ae9d5-31b6-4844-a025-91c41ecb925e"), "E4" },
                    { new Guid("18628c00-51ce-4c1f-8a59-d91ddaf9f0af"), "E5" },
                    { new Guid("9ccce858-6951-4351-b8a8-92de9b950d04"), "F1" },
                    { new Guid("b96c5e79-c1de-4fbc-bc80-15e119f0d361"), "F2" },
                    { new Guid("ec31c0d2-a84d-4970-a60f-2c24eb8dd8c9"), "F3" },
                    { new Guid("d00b5261-af55-423b-b1f1-8ce299887181"), "F4" },
                    { new Guid("8cc9a425-61cc-4b37-b153-6a5510164b01"), "C3" },
                    { new Guid("e6f98285-a028-40c6-92a1-b0c1995c11a5"), "B1" },
                    { new Guid("5fdc8e5b-f9e5-4399-826f-33b82f348bdf"), "C2" },
                    { new Guid("559b61a7-d537-4130-bfba-c0a04414da37"), "B6" },
                    { new Guid("07e72dac-f981-461e-a1c1-35a986d07626"), "C1" },
                    { new Guid("3bd9498c-2d0b-4303-954f-193c5dbc21ec"), "C2" },
                    { new Guid("1bae0e83-c89d-4062-a1a2-55c1491b3909"), "C3" },
                    { new Guid("0e94e2de-3edd-4c6e-8d2f-2d22a80ebbce"), "D1" },
                    { new Guid("cd2c297a-e6f7-4b31-82db-ba6b10e1cf33"), "D2" },
                    { new Guid("7afe1123-b40f-4f08-b75b-7b23cf63dd96"), "D3" },
                    { new Guid("2a209e28-4529-49ee-ae77-a724b45ce9c1"), "D4" },
                    { new Guid("b9b62c04-61a5-471e-b017-3a30446a255f"), "E1" },
                    { new Guid("35385569-f563-4034-93f9-d8648d323ff7"), "E2" },
                    { new Guid("94aeaa67-8786-46aa-8500-c51aa6c895f6"), "E3" },
                    { new Guid("a4949a8a-cfd0-4abd-85a1-1768711a8ba0"), "E4" },
                    { new Guid("e3499dd1-6301-492f-b2af-d8a8c4bf0e49"), "E5" },
                    { new Guid("d661835a-796a-4163-8014-78e38a09a743"), "F1" },
                    { new Guid("4cbace2b-7a86-4237-bc3c-1a93bf2467a6"), "C1" },
                    { new Guid("dca470bf-fa2e-4bd9-a3ea-e92aaf23757f"), "F3" },
                    { new Guid("eb3d57e5-69a8-4296-8278-941dc734b277"), "F2" },
                    { new Guid("8c4008bb-34a3-42c6-8545-e329ed91c7b5"), "F5" },
                    { new Guid("a129c0bd-73e9-4452-bd77-be61d05b6dec"), "B5" },
                    { new Guid("1a03d7df-f6f5-46e6-bc4b-e5f9d0ea6941"), "B4" },
                    { new Guid("5d66371e-457d-4fb4-a023-9b7448bf36fe"), "B3" },
                    { new Guid("27edbdf9-8fa0-4775-b864-f44e6450d063"), "B2" },
                    { new Guid("a8905592-9771-4429-99b3-cfabf0826d09"), "B1" },
                    { new Guid("2b57b282-4d3c-4f93-826a-a9efada78a9c"), "A7" },
                    { new Guid("cdce0453-c971-4a16-baaa-5b4e5100f46f"), "F4" },
                    { new Guid("4f63ff35-4128-42a9-994f-24382a746763"), "A6" },
                    { new Guid("24a01864-6cdb-47e7-a795-8cf3352fc133"), "A4" },
                    { new Guid("e98a4640-6dd9-4ef6-a558-dcf623404255"), "A3" },
                    { new Guid("26d31416-b39e-4288-910a-9cb79866b741"), "A2" },
                    { new Guid("4ee70687-9e36-424d-a265-6033baa94a34"), "A1" },
                    { new Guid("c9847024-4686-46f0-a01a-3e9a148bb934"), "F6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[] { new Guid("23837674-4658-4af2-816b-3453928927ad"), "A5" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f72b575c-3f5e-476b-89fd-c6267642651e"), "Sección 2" },
                    { new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837"), "Sección 1" },
                    { new Guid("8232e888-9b19-4009-8f72-19ede5821309"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Cecilia Roth" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("38f3c605-dd50-4dc2-9f41-83a7215d8cc7"), "Mary Sweeny" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"), "Roger Avary" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("3baab5ba-8122-4fdd-962f-f86b59bcb4ef"), "Quentin Tarantino" },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Robert Zemeckis" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Quentin Tarantino" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "David Lynch" },
                    { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("5d29e930-6e91-45b8-8783-5be6e831f97f"), "Pedro Almodovar" },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Robin Wright" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Samuel Jackson" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Una Thurman" },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "John Travolta" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Justin Theroux" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Laura Harring" },
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Naomi Watts" },
                    { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Penélope Cruz" },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("8ac9c853-2655-4cc3-970a-227f1ff8c5e2"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("75662171-4336-4311-8a16-730915068f77"), new Guid("5095b760-ae7b-49d4-b253-cdded888f732") },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("7a2a8116-6cd9-4e2e-8570-961a682c62dd") },
                    { new Guid("1b26dba9-396a-4d85-9ad7-a766064b5fd6"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") },
                    { new Guid("6c2f96b6-1cd2-4694-80ed-25a6cc05df16"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") },
                    { new Guid("7916bf84-b7d5-477a-8a07-b67c4284ce2b"), new Guid("6dc6482a-f67c-4184-996a-9c95e60890b3") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b65885ff-a293-49b4-a419-c344787d3e5d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("05e21c51-ff66-4db6-b134-1d7aa4d5c9b7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("c18a4964-365e-4b40-bb80-3d28e1871bde"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("480214c1-6c8f-49d1-a63d-b0f682d1eeb1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8a3d45ff-c8ba-46ac-a87a-076412bb90bc"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("92146dde-6431-4992-9a32-8db0aa0d7a79"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5682f5eb-5c38-4f86-94fc-2209b9b3274b"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01a232a0-a7e2-433f-9f34-1de70121edd6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5b26925c-ff5b-4530-ab83-e5ba7018fd11"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("eb9391c6-abd2-48a9-ae54-5211ee043ae0"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9093282-4c85-43cb-ab4f-e26808e7f2e1"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f8d430ec-f036-40a2-b2ce-bb6dc8284085"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("545c6f8e-a8a8-4ce5-91a7-f89d47f283c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("af465664-96cb-4c0b-bb92-f8819215edae"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4ef25ca3-0e9b-47bf-848b-8a2e2167f10e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("af00b5df-fdeb-4dae-ae95-780d109beaee"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("288d2bf8-7a5c-41b2-8917-7989fcef0466"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6a459744-3bb7-44fb-b70d-e7cbe968dca4"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b7f4db74-c093-4333-b3b6-9c222aa23c5b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46d4063f-7788-4ab5-a3e8-5ebe3298e211"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ca35807b-1edf-4af3-81e1-83ab4bca98ac"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("624cd037-5f60-423d-b115-441c9d8c23f5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9da0ce0-1b34-4bee-bb20-d1525333578c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("15c5301c-ad78-4d5f-95a1-289e330d7e8a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a7c1a784-b5e2-4733-b734-d49785604f68"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("38e63a18-e061-4e7b-b0af-d54b03c930c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0177b5b6-9501-4704-9f08-674c7d6a3df3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("37c7659c-f86d-4f03-aa90-92cbf163e15a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e3e673c4-b047-43ad-944c-b857824eb682"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46e4a303-7ae6-4b00-9cfe-24c0191b23c8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("339044b7-f1ef-4304-9b88-d571f352b20f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b4392897-921a-40e0-9780-9bae3ad28b5f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("048c2a05-6583-407c-82aa-0bad58ff8ae4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("16cf3277-a021-41b2-a96b-70544de23e7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5a47975a-9cbb-4aa1-9553-d3661d3f2233"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("45d948fc-451e-42ec-9c1e-d6c912006bf7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b040d9a7-8c05-48dd-9df5-ada32d483e3f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01ecc381-99d3-420c-b045-ebf906f5afd1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7a4daef2-9890-4c3a-bf8b-1492a274c43a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a919b728-45c9-48b6-929b-f1a648b09f19"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cfa73cfe-4f87-4405-8787-4ad11ecb0adb"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2412ecc9-002d-4879-b5fc-0b81ffa05c0e"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("00836ef4-52e9-4760-9cde-d1ccd9eda4f9"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f86e8ad7-f7d9-4a4f-a6e7-9ca908d13edc"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("94e7f59d-f94e-42ad-845e-872d37eb1376"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f5b85ce6-d668-4ac6-8931-b25cb2bfe416"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e4b83639-9269-4437-8b1a-dac3383b3632"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("c70787fb-b34b-4f39-9ad6-ce9277dfdb7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc75b212-57de-4d87-9831-af798e2e14d3"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("30dddb62-a550-46be-8ddd-0fa0debaf7d2"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7d280986-6a43-4e54-aeae-8e6c4dffc2e9"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b8519432-95f5-446c-b46a-b04960901f85"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("86dd91b8-a523-4c5f-b192-76703b0eff1f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("fd8dc9b7-7afc-4520-ae71-ceeb4afd7c02"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("452ff35a-6175-414e-8e9b-cea7f032b687"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("808bf77c-ae50-4a56-a368-9374c5fdaa7a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("6c99cef0-556c-4eae-8634-913d5fd94a69"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d3d466ec-d488-4e70-8384-59f4d31ebfbb"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e9edb84-17ab-4689-ab7c-8b7d9721cef5"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("81ad44ab-f559-4d1d-86fb-f149c888f82c"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("94b6d51e-6a28-4741-9238-c1dd6c73bf72"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("576686fe-1437-4e60-9af9-cf9493cdfdf1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("730aabcd-7292-4aae-898e-80896f54434e"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("14a42e87-a80f-407d-a11d-f30f865484e4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7f995bf6-2b0b-44ca-b1dc-1eed8140303e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7edf4135-3377-4e76-9411-b87946863ee9"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("fc49ee96-8240-465d-a4e4-e0957b37ffd7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2789b5fc-01a1-4b01-94cd-53166533a2fa"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d69f630a-b929-428c-b044-ac6b922102a3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f4307691-9be2-44af-b578-2d720266d954"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc08360f-c2b7-47f3-a8cd-85a5bf5a0be8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f9e365fa-e157-4f2f-afb6-cd396a755859"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("af039cb0-ddd2-4a1d-a224-13fa67634789"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("21a774cf-b82c-4ff7-a80e-4d9eb148d13d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5b073ccd-3b07-42d0-83f9-61b26ac2fc71"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("752d263c-2fd2-429c-8197-04e97eb66b75"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e955aca-da2c-4562-bd0a-af0731a3319d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("db396f4d-9954-4c39-8376-3766705f90d7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3fecdca3-bfe0-4f15-969e-fd6f82f6b975"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("aa4d8d68-95d9-47ef-bded-99f691be09d1"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3e186b9e-29c7-485e-890f-401971b8ca27"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cc1d63c5-0a87-4563-95ee-2a40f9eceede"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8c5fb618-e509-4cd1-9f2b-dd60ac2216c8"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ae98e2aa-a164-4397-b8a7-1da4a57f14cb"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("de3c7224-6b69-485b-af0d-23e964ecdf67"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b16b0f3c-c9bc-4a38-9eb6-ed3a1aba9a7c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("60199a39-65b9-48c1-b760-c03cea799328"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("038ab59e-70e9-4855-accc-c5c94371edf7"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("1df24a12-6c2b-4df6-bea8-92a334a13f7e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("4f71bab8-1207-49e3-937e-f32619e8973e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("7e96d44e-0ba2-47f4-96cb-e7eb5411ca7b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a17f5c5f-287d-484d-8d50-972c387ceb14"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d8d94986-fe04-4f7f-9e49-40e269cb2e9e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0690bf3f-f79a-48b7-81ba-6882f7585bc2"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("6f8ebd42-76d2-4403-aa3f-d6b570955980"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8d3eb601-f122-4cf3-a2d8-bde7ce09a49d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("12758ed8-4b40-46f4-8c08-e1dfe46addfc"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2db2bbd9-639e-473c-a191-f6622bdd573e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("159730ab-a75d-4637-b023-62d70d944c01"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("685a52cb-7b44-4142-b608-820d3913e29f"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a0636e88-5806-49a1-af98-2d3cfdb9b987"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("45918306-cf69-48a4-903d-7cc459c9fd31"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1089a825-96f5-4e18-bb29-f6eafb2f4013"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4e76ab6c-5297-4dce-b243-976d81456436"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("36651366-5149-45f6-929e-fe3677aa826d"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("004fd3b0-0383-4d30-af84-f30c4ac12db5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("48c0f3ef-b18a-4c13-87a0-590e0fe0e258"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4da25972-d73b-49ed-8a7d-f83f452dc932"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d7ff1f45-e5c3-4c34-8f10-f58345589cf7"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b117fd98-b022-46fa-8f69-2029ffdd32fb"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6f0fbcab-2d74-48f1-be63-2b1964bff36a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("985a0e3b-9756-4e2d-b323-10ae76523f3a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("db4ae9d5-31b6-4844-a025-91c41ecb925e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("18628c00-51ce-4c1f-8a59-d91ddaf9f0af"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f11da012-f17f-4de6-96de-f18f16d43fe3"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("9ccce858-6951-4351-b8a8-92de9b950d04"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ec31c0d2-a84d-4970-a60f-2c24eb8dd8c9"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d00b5261-af55-423b-b1f1-8ce299887181"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("21c0fd63-bf6b-4ff5-a12c-a621a99d5e9c"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3c2cedaf-2a89-4c28-90dd-885f504f1b77"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("962d411b-6655-4f39-9fa2-adfbf8c0eef5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9a6c3d64-5d8d-4c08-a7fb-2dd4360ac341"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d2225a76-0199-415f-bc6b-a650de8d94d5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("44d7b8c1-3730-4d07-b388-be0ca08537fd"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("884d063c-5118-4d1d-8010-59c82895b345"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("07de84e5-16d3-4107-92c3-39b0f23d298e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9d4ab7c0-38ab-4588-8aca-75ac5e0af8c5"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0de69aad-0cce-4b22-8d00-8ffa0dfc9c8e"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e8690be8-3b29-4a3a-a3f0-a62b2ff2a506"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d4f64f0b-8161-4364-86f6-5fb52198b14f"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b96c5e79-c1de-4fbc-bc80-15e119f0d361"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("54f89f7a-55aa-4cb7-b29e-ed287f42f173"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8cc9a425-61cc-4b37-b153-6a5510164b01"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("24b4a48e-bab0-4bb2-a528-ec154a535b76"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b9b62c04-61a5-471e-b017-3a30446a255f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("35385569-f563-4034-93f9-d8648d323ff7"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("94aeaa67-8786-46aa-8500-c51aa6c895f6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a4949a8a-cfd0-4abd-85a1-1768711a8ba0"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e3499dd1-6301-492f-b2af-d8a8c4bf0e49"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d661835a-796a-4163-8014-78e38a09a743"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("eb3d57e5-69a8-4296-8278-941dc734b277"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("dca470bf-fa2e-4bd9-a3ea-e92aaf23757f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cdce0453-c971-4a16-baaa-5b4e5100f46f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8c4008bb-34a3-42c6-8545-e329ed91c7b5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c9847024-4686-46f0-a01a-3e9a148bb934"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("09230f13-af04-4248-90ad-6b9fd1bdeaa5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("bd8ce683-fdea-46df-861a-768cfcd9ff0a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3b6be2df-ca38-40f4-8e21-1aa118cd1537"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("16f2643f-80f2-431f-b721-039c38c09c87"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a0ccbc18-aec9-4c17-9b51-47aca8a6cae2"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e4d8bbf0-c704-40b9-b376-a39eb5bfbdb0"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("613ba02c-89a3-4671-98f7-f3557d0093de"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("d1b694c4-05ff-407a-8876-caee46c5c04f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cc2f35b8-5111-4e13-aa43-8072b920d4c6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("4513578a-f9ff-4464-95a3-3861c13acfc6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b5aef9ad-54ac-4b91-9280-dc4efea0fa00"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("9676ce9a-233e-4acf-8f9e-684fa7a1f537"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a4fca78e-79d9-49ff-8bba-4a3586624ca2"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("904a7ff3-8c2c-4420-92b1-7657b8b3ad2e"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3db2dc43-8a22-4876-a8d7-8dd5f9f42a19"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cf24c243-e68f-46f2-8345-4ba063562dcc"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("699f8ab9-0a6a-4201-ad1b-b9a528283667"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("765a1ee3-c287-4561-99b1-b62a640e256f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2a209e28-4529-49ee-ae77-a724b45ce9c1"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7afe1123-b40f-4f08-b75b-7b23cf63dd96"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cd2c297a-e6f7-4b31-82db-ba6b10e1cf33"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0e94e2de-3edd-4c6e-8d2f-2d22a80ebbce"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("52cdfae3-4ac5-4409-b9bd-e1f7a3fb4b6f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0a25471e-a702-4a2d-a21b-e560906c0b5a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("bb643399-a51e-408f-bd1a-dffcf381df53"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("12e896e7-4fa3-40f1-88c8-4bdb4546c03f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("6ca706db-997c-455e-ad1a-fb91b6d9b15c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4030541c-b86a-4451-ad02-deeae86c2484"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5280633c-aa81-4ccb-8ba1-ff27eb90700d"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cb598e9b-990f-483a-a2cc-33689deaeecb"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("93ba967c-98ea-40dc-aa09-613df24d2c26"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2c0dda33-2d71-43be-a6d9-e69df9eace22"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("64f5f6cd-bd19-4167-a2aa-60cb135e265c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d5fbad6f-876c-4b82-bcd4-bbdd3aebe762"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e19a0f8d-ac78-4a8f-905e-c5c30b9d7217"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a81931cc-b061-42a5-a76f-ce5c08be8857"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("71c39e9b-dd23-4c83-8ee8-41d43d88e810"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("8b94abb9-6d06-4be9-b976-42caac852ddf"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4424a65d-428f-4a69-bf02-2854554128d6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c839c731-e0f2-44dd-8244-f54e79c78805"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("f9d52a0f-d4d5-46d3-8652-23dac8df06d3"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("12d6f215-3052-4b4c-98de-a9977a88369a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("678e56ef-a9f3-4e11-ac73-d766ec234679"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("14535c15-4aa1-45aa-8a41-bf4eaa21788f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2de2b06c-1faf-4b5a-8f16-1e421de28e30"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("cac61171-b3d0-4797-8546-65e4b99f91fd"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d980d0b7-53a9-4aed-81b2-3d31a21dcd8b"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e6f98285-a028-40c6-92a1-b0c1995c11a5"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("c8ba6fde-4f86-4c3e-831a-95da6fbd21f9"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("07e72dac-f981-461e-a1c1-35a986d07626"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3bd9498c-2d0b-4303-954f-193c5dbc21ec"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1bae0e83-c89d-4062-a1a2-55c1491b3909"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("0c775ea0-72ba-410d-a54b-16f2852f26a6"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("044cf2c4-b4f5-4202-9a02-c36bfe098054"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("b39f1704-d5f4-4225-b127-5bd82fdd2d7e"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ff6fff9a-fd65-4e44-ae7e-c6edaab73f3c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("37c56d92-ff7f-4830-a762-d91c52e23813"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b7fd7c90-5869-4b29-8acc-4f836c1d45a3"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7e627a17-1531-478c-9736-fc16d136778d"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("d2ead336-8e53-4604-9465-684c5797a605"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ed96ed02-cdbe-4f9f-9631-bb9bddf132df"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4ee70687-9e36-424d-a265-6033baa94a34"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("26d31416-b39e-4288-910a-9cb79866b741"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("e98a4640-6dd9-4ef6-a558-dcf623404255"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("24a01864-6cdb-47e7-a795-8cf3352fc133"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("23837674-4658-4af2-816b-3453928927ad"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4f63ff35-4128-42a9-994f-24382a746763"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("2b57b282-4d3c-4f93-826a-a9efada78a9c"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a8905592-9771-4429-99b3-cfabf0826d09"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("27edbdf9-8fa0-4775-b864-f44e6450d063"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5d66371e-457d-4fb4-a023-9b7448bf36fe"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("1a03d7df-f6f5-46e6-bc4b-e5f9d0ea6941"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("a129c0bd-73e9-4452-bd77-be61d05b6dec"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("559b61a7-d537-4130-bfba-c0a04414da37"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4cbace2b-7a86-4237-bc3c-1a93bf2467a6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5fdc8e5b-f9e5-4399-826f-33b82f348bdf"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("a1114b07-d426-43d5-9678-ac5eb6a7651b"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("b366b72c-0e50-4373-8d14-243ba972afb4"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("46a15f77-df36-49b5-a028-5f47c5f979a1"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("dcab1744-2c02-494d-aaae-348750b71c69"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("647dffd0-e16a-4355-9d56-aefbcdd59074"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("5323936e-1fd1-4ece-a650-05568ea319ad"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7b537e91-cd5b-4513-82a4-06106bed196a"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("184a4c59-5ecf-42cd-a867-776d30804bba"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("74ea6568-f5d9-4bdb-99a9-8a55cbd70608"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("914de060-bb62-465e-86d7-98c7b8824bf6"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("adacf329-e78f-416b-932d-1d0b7e22f80b"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("3f0484cf-b7e9-4679-975e-051f31e7e877"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("05b68ef4-c633-4cb8-9257-9cd211524516"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3388bbec-dec6-4cbb-8df1-c0c5adf73c17"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("01e14cbf-8dc8-404c-8d7e-8ef4ff2467f9"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("f11af2df-e85d-4c37-959e-8a38ffc21632"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc52f1e4-bf8e-4b87-9453-8d3c5bd0c650"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dc2cb226-bbc1-4fb3-b243-e31897d39801"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("8ac99b7e-ed71-4abc-8ed7-3ce5d38c7d63"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("25a44c5d-43c2-4663-82cd-31a23a37e9ac"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("ef764574-c762-472c-a194-7b243ba09491"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("70c23d17-e360-49b6-ae67-b081bc43f0fb"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("0e5e1f99-445e-4f57-8916-423d933927d4"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2e1f6679-0f13-44d7-b571-b8d0890ce481"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3738909e-78cd-47c0-94e2-0ddae5ae5f4f"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3fb942ee-a5ff-45f5-9a98-29922f39b9a3"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("dd6c4a04-912b-4269-b4cd-4b51b6034b5b"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("afbb32b8-eada-47fb-90ee-a247b5baa11a"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("cb984a09-c87e-4d3e-bcd9-a6cd8676c50c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("e139bac0-65f2-427f-bf25-2c61badc9c9c"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("5f85acf7-7c16-4439-9bfc-73f9faf5d5fc"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("42ea45ca-7afe-4ff4-a5a0-0d742e7299ad"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("46f3857c-8c0d-4330-b585-1c4124846d50"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("3251e15c-89f9-4a90-bbc0-1320354cdd22"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("24f77f26-211a-4514-9904-585e5d5d2107"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("2b993193-907e-40e5-9c81-44a6e6c3d938"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("7e144958-f510-45c3-8780-63679a27187d"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("08ecf90b-9dea-4ec0-b0da-2a097349e0f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("fe6bdef0-4cf2-4565-9226-2233a5deb2bf"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("4b6181bf-9b54-4d8e-8ac8-9988c42c9101"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("59ce3c7e-5669-4bca-8f37-641f8de287f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("ce4370a8-83ae-4331-8ca6-7de194fee3f0"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("0038fb9f-993e-44c9-a1e2-44020231e25a"), new Guid("0e05b5c0-06db-45dc-aaee-c9843ce55960"), new Guid("13b71a85-5138-403a-b610-e988002f2a4f"), new Guid("f72b575c-3f5e-476b-89fd-c6267642651e") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("80745992-f6c0-4422-a437-c7aad268a955"), new Guid("2a5de568-edb3-4fe7-a4b7-f7dabbaa4837") },
                    { new Guid("88bda99c-21b3-4995-be49-5248a968f595"), new Guid("c8a55a14-634b-48db-b50b-809f5654d76d"), new Guid("fcf3398e-5aa0-4ed8-8940-b905812e0d2a"), new Guid("8232e888-9b19-4009-8f72-19ede5821309") }
                });
        }
    }
}
