using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class purchaseOrderChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bc89f149-2220-4012-b993-3d2c22e551d7"), "Productor Ejecutivo" },
                    { new Guid("df83f580-d4c9-4e1e-b17e-1a9b1025c530"), "Técnico de Sonido" },
                    { new Guid("a9fa7435-05b8-44f6-9e96-26a63631fa60"), "Diseñador de Vestuario" },
                    { new Guid("50bbe8d6-f0da-4530-9c47-3861c83708f5"), "Guionista" },
                    { new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Actor" },
                    { new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Director" },
                    { new Guid("d559a526-66bd-4af5-a871-e4431b428020"), "Productor" },
                    { new Guid("5521f5f4-32cc-42d1-b5b5-190aeec12ea3"), "Asistente de dirección" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "ImgPath", "Name", "Year" },
                values: new object[,]
                {
                    { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), "España", "Resources\\Images\\TodoSobreMiMadre.jpg", "Todo sobre mi madre", "1999" },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), "USA", "Resources\\Images\\Forrest.jpg", "Forrest Gump", "1994" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), "USA", "Resources\\Images\\PulpFiction.jpg", "Pulp Fiction", "1994" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), "USA", "Resources\\Images\\Mulholland.jpg", "Mulholland Drive", "2002" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a144467d-5bde-4215-a18e-bd469a5b0a19"), "Erótico" },
                    { new Guid("bb990033-8e39-4a07-80d7-a894c2589a06"), "Musical" },
                    { new Guid("e47452e3-fb27-4ddb-a1d3-57243effcb31"), "Aventura" },
                    { new Guid("8900c0e7-0c9f-4206-a9f2-3bccf8b90760"), "Ciencia Ficción" },
                    { new Guid("fc0acb80-e0eb-480e-b398-6003d5c1023e"), "Ficción" },
                    { new Guid("4223d3e3-9f2a-443d-af93-aa4509d6e6a9"), "Documental" },
                    { new Guid("0c152707-c111-4b46-99b3-f67af40f626d"), "Romántica" },
                    { new Guid("9b0d47a9-b5c5-4da9-8a87-ffea8c3c991a"), "Tragicomedia" },
                    { new Guid("d2354062-bafe-48f1-8854-e735244ec8cb"), "Terror" },
                    { new Guid("d7118649-a5cd-49f7-ad13-349250d923db"), "Suspenso" },
                    { new Guid("2f3467b5-dccd-4042-bcc3-0da5cb570088"), "Comedia" },
                    { new Guid("42911db9-3e60-4c14-81ad-b9acea96bead"), "Drama" },
                    { new Guid("e1cd48f8-4a30-4fcc-8dc6-84c4c3104494"), "Histórico" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), "Platea Baja", 10 },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "PriceModifications",
                columns: new[] { "Id", "Description", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("e5750eb3-2e7a-4b20-b6a0-5c9f86132adb"), "Descuento por el día de las madres.", "Madres", "Descuento", 10 },
                    { new Guid("d9701ace-55e8-46c2-bf7e-55dd40694255"), "Descuento del 10% para estudiantes que muestren el carnet.", "Estudiante", "Descuento", 10 },
                    { new Guid("c6eb1bef-6240-4c9b-9d21-c8f4a94cc0cc"), "Descuento decidido por la dirección del cine..", "Descuento del Director", "Descuento", 10 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e7842029-1662-44b2-b22d-797387f62299"), "Sala 2" },
                    { new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), "Sala 1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("3146f03d-c2d2-459d-b793-d5170eef8cc9"), "F2" },
                    { new Guid("4c543199-49fc-49f6-96aa-48a0f2c5d9f2"), "G1" },
                    { new Guid("73ca7dc0-238b-4d22-8c73-f37e2f8871ba"), "G2" },
                    { new Guid("902ee57b-19e0-419d-a35a-0ebccc12ee8d"), "H1" },
                    { new Guid("e1499785-1d7c-4410-b207-f1024fcede6f"), "H2" },
                    { new Guid("50db0553-21e5-460f-9b08-bf1fa234927d"), "A1" },
                    { new Guid("76428f87-07db-43db-9b11-946648aa63e2"), "A2" },
                    { new Guid("18e1b463-429b-4780-af46-6e872422fe6b"), "A3" },
                    { new Guid("124c56d6-a1dc-468f-aadb-0526fe1d45eb"), "B1" },
                    { new Guid("54bf6f4f-91e8-478a-9b15-9e7d43309b97"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("9c52dde3-c4d3-4f0e-8418-e3fc8809cc6f"), "B3" },
                    { new Guid("0b49cfeb-47dd-4b83-9603-8a7b2b4987d3"), "C1" },
                    { new Guid("0bffa5c5-529c-48c9-8c9c-d9ea4cf10c70"), "C2" },
                    { new Guid("ef5348d4-267b-40b9-844b-f756f643662a"), "C3" },
                    { new Guid("b0d95145-e319-4599-8630-faab91368af7"), "D1" },
                    { new Guid("8f15f7ab-3eef-431b-aa3f-83a84049e963"), "D2" },
                    { new Guid("659f1eab-4df4-4cef-9ad4-771ab78540f6"), "E1" },
                    { new Guid("95a74b72-2d97-4ea9-9c49-ba929ecd3df0"), "E2" },
                    { new Guid("58f2a2e9-b2a7-4227-b173-f9cf420d1553"), "E3" },
                    { new Guid("f6f50d42-a329-433f-9b9c-2ec8c769b5dc"), "F1" },
                    { new Guid("55c3fc29-f856-4232-a9ba-a954e26aed92"), "F2" },
                    { new Guid("c674b923-423f-4cb1-a0bf-f5cb968038c4"), "F3" },
                    { new Guid("f1e686fa-08dd-400f-96da-83f06bcd360d"), "G1" },
                    { new Guid("cf1f8909-ee93-450f-a1c0-9e7c103226b0"), "G2" },
                    { new Guid("9bf5a1e6-de9a-4d71-b653-a18b2598c87c"), "G3" },
                    { new Guid("a9ae6a66-af4f-460b-a7d5-198b28882831"), "H1" },
                    { new Guid("7b9e2c3c-8bdf-4ccc-b0aa-cb030caddde8"), "H2" },
                    { new Guid("c8e18f1a-7a4e-44a9-b4f0-4bd79c1f78b1"), "H3" },
                    { new Guid("33f3ee58-c423-4c9c-974d-03c492ae89e0"), "A1" },
                    { new Guid("69472373-69ad-4307-87b4-31f47645e64d"), "D3" },
                    { new Guid("07758518-11c4-4917-a798-75c947151c95"), "F1" },
                    { new Guid("d14e8a32-c404-4737-9a34-db93b1311bc2"), "G1" },
                    { new Guid("6350a1c0-4b61-4822-be70-84e7106b62e3"), "E1" },
                    { new Guid("4b455918-8c6e-472b-9c38-8425de0350bc"), "A3" },
                    { new Guid("e00ca3f0-6814-4d2d-b06e-3e1db6a3a8a5"), "B1" },
                    { new Guid("fe245245-263e-4a24-9aef-e4065afb1322"), "B2" },
                    { new Guid("baa3132f-7c1a-4e14-8773-acfac6ded9bf"), "B3" },
                    { new Guid("6cb73cb9-8e61-4f58-abdb-ff003572e832"), "C1" },
                    { new Guid("f866c2fc-e498-4432-8833-33d0e60c55d4"), "C2" },
                    { new Guid("126a4ce6-e822-4811-9fc0-a063b5ba4c14"), "C3" },
                    { new Guid("b707216a-5467-4b19-9061-7293296e1468"), "D1" },
                    { new Guid("ace3dc3f-6cb9-4eb8-988b-07ad08b9df7a"), "D2" },
                    { new Guid("d1f63dca-0019-411b-955e-9c0177c1158d"), "D3" },
                    { new Guid("95f9651a-859d-4642-aa90-2310b2161607"), "E1" },
                    { new Guid("efb0e400-b188-47a7-b5bb-6f8c1864b039"), "E2" },
                    { new Guid("044f58a7-53bf-4cc7-84aa-998da6620c56"), "E3" },
                    { new Guid("cb540183-5381-4611-afdb-0fae77381d88"), "F1" },
                    { new Guid("0bb9b7d6-f169-40d7-91d3-cd0133b9186e"), "E2" },
                    { new Guid("603727ec-4857-41b9-b751-3e2b6cfba669"), "F2" },
                    { new Guid("3aeb2cd0-8de5-426d-9445-266fcbdcbaec"), "B1" },
                    { new Guid("cf917ee6-203e-40bb-a2f1-6dc1edf25ae2"), "G2" },
                    { new Guid("34b0c9c4-3f8c-41d8-aa7e-e17609d2dcfb"), "G3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("25bbbf9e-18a2-4515-bba0-42c31cec9bfa"), "H1" },
                    { new Guid("ae5d395d-ede7-4692-9b8d-908ede5cdf40"), "H2" },
                    { new Guid("ddcaa82d-1aed-44dc-9273-6e914c04ea82"), "H3" },
                    { new Guid("ab0a05e9-5b5c-4507-9053-07f1f8451b9d"), "A1" },
                    { new Guid("07c593e2-cc75-4b11-bd87-d14a3243a6da"), "A2" },
                    { new Guid("6fcd090a-9be7-45da-90e9-f2cb25d2b919"), "B1" },
                    { new Guid("b284ebc9-57bc-4ddd-b6f7-43ce78d39fa3"), "B2" },
                    { new Guid("83fbd11c-da7a-41c0-823d-3b8d4289e676"), "C1" },
                    { new Guid("cf054698-d96a-4d04-9e29-3e4079c723e0"), "C2" },
                    { new Guid("86f4ea90-e98a-4c07-9fb3-209fbb8dfbe7"), "D1" },
                    { new Guid("fc71bbed-4c80-4611-a1f7-b82bb0913ecd"), "D2" },
                    { new Guid("05b97778-50b9-4945-8da6-702b60bc457d"), "F3" },
                    { new Guid("cbb9599c-598c-46e6-b0b8-049c3bb925f2"), "B2" },
                    { new Guid("3f68b4b0-24b2-47ee-841a-709191e12e76"), "F4" },
                    { new Guid("6abf3c65-4fe2-4aa5-8bbb-8a1280df92f1"), "C2" },
                    { new Guid("2fee958d-2ecc-496e-839f-7cc1640db3e9"), "D1" },
                    { new Guid("f155a0eb-e374-4a93-89dd-0b24831b71dd"), "D2" },
                    { new Guid("6cfd343e-a551-4e64-abc9-ccc488ce2aa5"), "D3" },
                    { new Guid("2b820449-ec05-4919-a17d-d9a47bda6530"), "D4" },
                    { new Guid("ca473881-3107-4a30-9736-f65bd4778f33"), "E1" },
                    { new Guid("cbd68dd6-f5d7-409b-8908-6f27df5df69a"), "E2" },
                    { new Guid("87d051cc-0e73-4721-ab8c-5960b61c4bc0"), "E3" },
                    { new Guid("b5e9fdc8-77a0-4331-ba63-1896fa1ab8f9"), "F1" },
                    { new Guid("3950527f-a436-40cd-a20f-1572dc72fe1c"), "F2" },
                    { new Guid("3c0f1e6f-406c-4cd0-b727-26bc65239321"), "A1" },
                    { new Guid("fafd18ea-6557-4b2b-a661-b5b9e0223517"), "B1" },
                    { new Guid("8de0189f-c645-43de-b7dd-a7d06fcbb161"), "B2" },
                    { new Guid("884f3276-8189-4ac9-90f1-25291758abb1"), "C1" },
                    { new Guid("16b8f3e3-1b98-42e6-b8b9-5cc6a5360b40"), "C2" },
                    { new Guid("4f68cf84-2c88-489b-827b-508a5d889e1f"), "C5" },
                    { new Guid("d174828a-df9e-420c-9d7d-06df2a0e0bd2"), "C3" },
                    { new Guid("db8a0a57-4b53-4698-9a3e-8cbf9558abb7"), "D2" },
                    { new Guid("0fd4e515-ab16-4238-9b60-7dd22fbb26d2"), "D3" },
                    { new Guid("82934dff-241e-4e89-a9ae-0c1e52024487"), "D4" },
                    { new Guid("b909e103-b1bb-437c-9023-b591a58bb0f9"), "E1" },
                    { new Guid("6fac600d-27b7-4124-9704-de228b982fd1"), "E2" },
                    { new Guid("89fd5733-b204-4d64-8de2-7d40353c686a"), "E3" },
                    { new Guid("ecbabae9-f98d-42fe-9c25-9bac6f68fe12"), "E4" },
                    { new Guid("2558d60b-da48-4da6-ac22-757510da31d9"), "E5" },
                    { new Guid("4a239efa-af3b-4a33-8f40-be3d49ecad8a"), "F1" },
                    { new Guid("c77d250c-6694-4bcf-a260-236b4cf9f174"), "F2" },
                    { new Guid("1cd06bef-0636-4ba7-9eb4-e263b3e4b1b9"), "F3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("361fa3d8-3cb2-477d-9d34-0f792bafc7b1"), "F4" },
                    { new Guid("84c1044c-4774-4c15-97e6-68bfc3e43769"), "F5" },
                    { new Guid("3bc55ca2-838a-47fd-abce-4b3a180fcb80"), "F6" },
                    { new Guid("de7858fa-6be7-4e87-aca3-c124805a5bea"), "D1" },
                    { new Guid("11112115-ca4a-41f5-8f91-035d4a19a17a"), "C1" },
                    { new Guid("c5f6b841-c4e4-4fdc-8535-03a2b370c443"), "C4" },
                    { new Guid("4a1dcc00-74cf-42d7-aa02-679f9fba3ff2"), "C2" },
                    { new Guid("43fb4345-da84-4b71-b38c-6c0f1f31a6a9"), "C3" },
                    { new Guid("5cc0b07d-d553-4314-b41f-0eb1aad605ef"), "D1" },
                    { new Guid("040f04d3-4ad6-4f32-ba60-2304d77e820e"), "D2" },
                    { new Guid("5aec0da1-a064-4bdc-a2b7-9df488a77072"), "D3" },
                    { new Guid("55f3a781-63c5-4404-8be3-7c2ca600d4e3"), "D4" },
                    { new Guid("9663a3af-fd15-4370-ad49-c790585cd339"), "E1" },
                    { new Guid("4bf4baf9-725a-479a-a9ba-ce7bba6bff97"), "E2" },
                    { new Guid("09adce4f-df2b-4621-bb3a-0a081a94c03b"), "E3" },
                    { new Guid("451644e7-6d28-47db-8376-f5fbb864df99"), "E4" },
                    { new Guid("2962ef9e-d3df-4261-bd17-1749551cb4e6"), "E5" },
                    { new Guid("d3d0a4f2-8cf5-48a8-b06f-f64936ecdd99"), "F1" },
                    { new Guid("a5ac3aa8-b787-4bf1-ae59-7e7ee07068a3"), "F2" },
                    { new Guid("c581468e-12dc-42fa-8a35-5217b014350b"), "F3" },
                    { new Guid("30de6f88-698d-4965-b1cf-49ad45cab072"), "A2" },
                    { new Guid("44afb2c9-50d5-4b03-8db8-488928cab96c"), "C3" },
                    { new Guid("d5d5697c-6f44-4bec-a2b2-2e4a55b90642"), "F5" },
                    { new Guid("f73f8b58-9e53-4f88-aa0a-76749b41705b"), "A1" },
                    { new Guid("d3d32611-7c7d-4851-9feb-a7c8d5f44ec5"), "A2" },
                    { new Guid("b4a8cbee-a60d-4d80-b57b-4a7f35120383"), "A3" },
                    { new Guid("f18846f6-9613-481c-b183-fe63f68682b3"), "A4" },
                    { new Guid("6f9262c3-a6b6-416e-8abf-824773b5e8ab"), "A5" },
                    { new Guid("2864ae5b-a0bd-4375-9aee-836848b4944c"), "A6" },
                    { new Guid("714a2713-99cf-427a-917c-668e69cab8aa"), "A7" },
                    { new Guid("9e8efc8a-a48c-4659-b312-434ce733a7fb"), "B1" },
                    { new Guid("64927abe-39b0-48cf-bc2c-62467e5a6450"), "B2" },
                    { new Guid("26470872-d5df-42b3-8551-010f9d7a3657"), "B3" },
                    { new Guid("5e6bb853-afa9-4002-8ebd-8ce6db3be4f3"), "B4" },
                    { new Guid("0120ed84-d1f4-412e-8fd0-a6755ba2236d"), "B5" },
                    { new Guid("dfc4d779-b296-4b19-bd70-a51955a26386"), "B6" },
                    { new Guid("04dd5d29-7f0b-4aa0-a778-364ae8741a71"), "C1" },
                    { new Guid("70a7b702-174b-4dd1-b248-b1267ceaf4e8"), "F6" },
                    { new Guid("c798944b-b3e5-40df-a7b9-83e14adb5e60"), "A1" },
                    { new Guid("ed77c5c5-ac9c-4f53-ae51-36a1344863f6"), "D1" },
                    { new Guid("8a358b97-1b95-4a21-a26f-ac8dd087468f"), "F5" },
                    { new Guid("9573982f-5a41-479a-9710-77001dd9b975"), "F1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("4bbf6b1e-1ed0-4146-98f1-3b1a46f5a759"), "F2" },
                    { new Guid("fd5e8c7a-ffe5-41da-8781-ba2ac6abeef1"), "G1" },
                    { new Guid("108522d3-9be2-4cba-aae4-9416d483d8fb"), "G2" },
                    { new Guid("503d5554-7e43-4125-860d-e3f8113d36f4"), "H1" },
                    { new Guid("d67d02b7-cc05-40ea-8ee9-14d559a24c6e"), "H2" },
                    { new Guid("4098c51a-026d-4854-95ab-d7008105d329"), "A1" },
                    { new Guid("2553b3d2-1ba6-42b8-8758-b8f1ac6db360"), "A2" },
                    { new Guid("924408c8-9fdb-41fe-99b4-779815f6cb95"), "A3" },
                    { new Guid("081a8397-8577-4455-b06f-67106b852489"), "B1" },
                    { new Guid("55177983-68cd-447a-9a04-21774dd9b6d7"), "B2" },
                    { new Guid("3f9cfb64-d04f-40e7-9fc1-fba8ac97dccf"), "B3" },
                    { new Guid("aadca6d6-d1a2-44e2-8f96-253f886415fb"), "C1" },
                    { new Guid("19da9781-3dd5-4aac-8035-2992491f0739"), "C2" },
                    { new Guid("d9c42d4d-4dd0-4815-b079-928c8482e03e"), "C3" },
                    { new Guid("e1da2164-00e0-43be-a68c-41595963066e"), "D1" },
                    { new Guid("0bbe95c0-b691-4838-8221-64b3472d521b"), "D2" },
                    { new Guid("7013d12b-0ec9-41ee-8b98-83f40bc90ca5"), "D3" },
                    { new Guid("27ec053e-a4ca-4724-9c7d-4cadafc6e264"), "E1" },
                    { new Guid("ab4d0c6f-3cf1-409d-af4f-d93026dd8553"), "E2" },
                    { new Guid("e3450db7-0c33-41db-b6cb-bb5405fe46b3"), "E3" },
                    { new Guid("0a44c6c5-dcb9-4957-8deb-dc419f28b999"), "F1" },
                    { new Guid("54c71883-cc12-46ee-804a-1e5db8f6251c"), "F2" },
                    { new Guid("fd95fac9-66cb-4473-9342-02b6d919e826"), "F3" },
                    { new Guid("7be211f8-935b-4b28-8ded-c51aecd86aa8"), "G1" },
                    { new Guid("5737961a-7ac6-4e56-8b4b-ff2d5c44d938"), "G2" },
                    { new Guid("f4369454-49b3-4163-83f6-b16658a0c7d9"), "G3" },
                    { new Guid("aaa220fc-ccf2-4b41-9975-e158dce906be"), "H1" },
                    { new Guid("c7d2e6b0-cce1-451f-981e-073c0c5409ff"), "H2" },
                    { new Guid("04fa07f8-d881-40ab-9b3f-6a2bc3cf3421"), "E2" },
                    { new Guid("d053734a-e24a-4f3e-854e-792d5bd97d2f"), "E1" },
                    { new Guid("ef63a46d-f91c-4512-9a22-d5f6e2862ccc"), "D2" },
                    { new Guid("07c679f4-31ee-4fff-8230-342a33553a48"), "D1" },
                    { new Guid("9a134027-7d58-4863-9ca0-fb9fead9448a"), "A1" },
                    { new Guid("a7914a6e-63d4-46d7-a4c2-d2b304c7460e"), "A2" },
                    { new Guid("bf5e3dea-db6f-4482-af3a-707cb594b9c2"), "A3" },
                    { new Guid("3332edf1-35d0-476e-9d59-e5667f13b7a0"), "B1" },
                    { new Guid("7ea93ba6-3b8b-47ed-9615-a928855ffa51"), "B2" },
                    { new Guid("b89e8534-c5a4-47ec-9dcc-15e65048ead1"), "B3" },
                    { new Guid("a95e7923-f80f-4284-a2ca-0453c271c59e"), "C1" },
                    { new Guid("28022469-d773-48a7-a3c7-c486a89536ac"), "C2" },
                    { new Guid("5b0cb3bb-b3fa-4971-acee-d9264fa2fc2d"), "C3" },
                    { new Guid("700d3914-0f69-4578-8d74-57a53c456c5e"), "D1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("5a1a7101-8c8c-4d7b-8f73-6d113f90682d"), "D2" },
                    { new Guid("19920320-e5d8-476d-b690-3b1668860f48"), "D3" },
                    { new Guid("5784d165-d8ed-4108-b696-96494d2607dd"), "E1" },
                    { new Guid("fae88cb8-2193-4a0b-894d-472bc530121c"), "E2" },
                    { new Guid("5131e662-a32c-46cd-97cc-5e634ed1e4c0"), "H3" },
                    { new Guid("390ae902-ef0a-46b7-9606-02fd870ef5e9"), "E3" },
                    { new Guid("57493160-5cbd-4ca9-b9dd-a56a5f9eec0b"), "F2" },
                    { new Guid("d42a3d61-511e-43a7-ac6a-0e7a4a269f7d"), "F3" },
                    { new Guid("4921e002-bd39-4e3d-babd-b26dc82ba0ae"), "G1" },
                    { new Guid("d2bb00c1-6512-4d52-95e3-eae0b2f53009"), "G2" },
                    { new Guid("efb02e3b-8303-49c7-bbdc-64e500c8affc"), "G3" },
                    { new Guid("7195ec6e-d8a0-4edd-b663-e1654aa07bc3"), "H1" },
                    { new Guid("39243733-4e99-44c9-b435-619b07e00ff6"), "H2" },
                    { new Guid("61255d28-1679-4a87-b391-55dd9886de29"), "H3" },
                    { new Guid("e7bb0d4e-8080-4946-bba2-e2e09f473c1f"), "A1" },
                    { new Guid("5ab27f05-054e-4b54-a0a0-5e2fc986f45d"), "A2" },
                    { new Guid("2a1ed7a9-a189-4626-8361-e8cdefd46836"), "B1" },
                    { new Guid("57eee6df-80c7-4665-81ac-09e06578314f"), "B2" },
                    { new Guid("5bd66bba-0d8d-4a73-b22f-74f4a94f707f"), "C1" },
                    { new Guid("0a9d7313-d574-4aa0-ab52-ea5743f19a82"), "C2" },
                    { new Guid("f3005176-2785-412d-bd36-33dea728d924"), "F1" },
                    { new Guid("06866108-ce52-4ad6-9738-d942b720ec65"), "F6" },
                    { new Guid("042e31bd-daf3-4133-9f9f-d671b0237855"), "A1" },
                    { new Guid("aab1b537-a1c8-4d07-80a1-7ffc97157858"), "B2" },
                    { new Guid("ae952063-e8d3-4fd3-934d-2f26b7c70a38"), "C4" },
                    { new Guid("1386bd53-e007-46b7-8e3a-c882e0c7114b"), "C5" },
                    { new Guid("bfe5c515-5df7-4eae-ba68-df7835062778"), "D1" },
                    { new Guid("cd1c5006-b506-49e6-9421-ae35dba6a3fe"), "D2" },
                    { new Guid("9d6624a3-b6fc-45f3-8845-3cb6537f8c1d"), "D3" },
                    { new Guid("c6d347d6-b618-4d0b-b732-842dc4fba6e3"), "D4" },
                    { new Guid("af07f7b1-ce01-4c05-aa23-a865027bd550"), "E1" },
                    { new Guid("d0ff8364-6867-48a0-9493-6ebfb9071bb4"), "E2" },
                    { new Guid("c2e54892-ee78-474b-bf19-5fdef1e80754"), "E3" },
                    { new Guid("5f7e8c20-ea11-4e39-a261-16e4815ca381"), "F1" },
                    { new Guid("38ea3b0f-6e3a-4a45-b76d-43dbf80234ae"), "F2" },
                    { new Guid("5feb9db2-5ca4-4bd6-9132-73cba1f72786"), "A1" },
                    { new Guid("c0743d3d-8c04-4224-b693-679db05ff2bb"), "B1" },
                    { new Guid("a5305283-a1ae-4006-85d2-b577d6b0ed00"), "B2" },
                    { new Guid("c63101cb-8343-47bc-bd50-3a383cf604ef"), "C1" },
                    { new Guid("ff0f7a6c-4cba-46ce-a475-0eceff901125"), "C2" },
                    { new Guid("81e1a6e1-af7d-4a38-a708-7f41456e13a3"), "C3" },
                    { new Guid("1e10a215-bae8-44a5-9625-9083c06e7440"), "D2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("754eed3d-1e16-4314-b363-719704d39adf"), "D3" },
                    { new Guid("281daf8a-c6c5-4dd7-825b-5745c33c6cd3"), "D4" },
                    { new Guid("245fc076-1fe1-4885-b931-4fd8c52c4438"), "E1" },
                    { new Guid("00ec5766-b3ba-4fed-8ed4-3e86959dde72"), "E2" },
                    { new Guid("5bc0927d-1efa-47d1-9078-ca3598bc2448"), "E3" },
                    { new Guid("1c79ffda-4e7f-4edf-ae5b-bba8dedefe04"), "E4" },
                    { new Guid("9f018d0b-cfbe-4dd7-8c27-9f2c6be8af6e"), "E5" },
                    { new Guid("0a0d7b85-c6f5-423c-a4da-7e471c77a9a6"), "F1" },
                    { new Guid("6f4ae073-68d4-40f6-8ab8-ba2a27c8b10a"), "F2" },
                    { new Guid("8aa62b78-1f94-43d5-989d-05b3fa7a965a"), "F3" },
                    { new Guid("fc051d3c-43bb-43ea-958e-b3d53fe51aae"), "F4" },
                    { new Guid("8ddb1d0a-3f7f-4dfe-a13c-f3d7de62549b"), "C3" },
                    { new Guid("85f1f8b0-983d-4e1e-a94b-98aa39cdd0e1"), "B1" },
                    { new Guid("d115ae55-ce71-446f-be0f-606a209063c2"), "C2" },
                    { new Guid("477cbc13-c56c-4870-a2bb-c997cdb483f7"), "B6" },
                    { new Guid("ccbc7367-6af7-4e5a-9f8c-b4bd1f02eef9"), "C1" },
                    { new Guid("dcd65a76-0243-49fa-9627-c8924da7523c"), "C2" },
                    { new Guid("9e2be97d-1ddb-41e8-8754-99386de29501"), "C3" },
                    { new Guid("ccd6333c-f499-47c1-af0f-0ee76ee11d77"), "D1" },
                    { new Guid("de77c760-b7c8-46c0-a2f9-41dd01d56bb0"), "D2" },
                    { new Guid("870a458b-509a-4c78-9552-54af263f62cc"), "D3" },
                    { new Guid("45adb2c1-4b0f-4ea6-9562-95c7fb812805"), "D4" },
                    { new Guid("a75dec22-e3d8-44c2-a3f9-0ece4da62a41"), "E1" },
                    { new Guid("73d5bd4e-6f4b-4e44-864a-c86c1e8f7804"), "E2" },
                    { new Guid("14631fb7-f3ba-41c2-9ab7-dc93699c06fa"), "E3" },
                    { new Guid("3717307f-2982-4b35-856a-91a5e37973f9"), "E4" },
                    { new Guid("910c7034-6a04-4983-9d69-209343184c68"), "E5" },
                    { new Guid("2f7ab287-8051-465e-8c64-6c3f92d0b1ab"), "F1" },
                    { new Guid("482c2b2a-cb47-41d7-a620-f04012887658"), "C1" },
                    { new Guid("a5bbe32d-5033-4f39-a27b-57ce80944d34"), "F3" },
                    { new Guid("ab3ad768-e3e2-4acb-bac1-6b19373054b0"), "F2" },
                    { new Guid("20342efa-8381-4601-8673-3ecd79873091"), "F5" },
                    { new Guid("0a8a29b4-3c56-40e7-8b43-334bd0d6a630"), "B5" },
                    { new Guid("afb06163-bdd8-48e9-a472-b9c32dc2711c"), "B4" },
                    { new Guid("ed99fc66-4a47-449a-bfc3-02caf83e97d5"), "B3" },
                    { new Guid("3f248027-5c7b-47af-906b-bc74f80aa401"), "B2" },
                    { new Guid("a42d7d4c-f759-4aa6-b1b4-87523eff09b0"), "B1" },
                    { new Guid("d469eb38-b8c9-4aa1-b116-4fcd1d29516d"), "A7" },
                    { new Guid("a984d835-4dd5-4eef-839d-10c8f6bbe2a3"), "F4" },
                    { new Guid("e21af0a3-8e3c-4985-a015-054a17a1e26f"), "A6" },
                    { new Guid("c3ea6ab6-70b8-4229-b731-d4151ae7652f"), "A4" },
                    { new Guid("9c7bdf68-37dc-49b7-a4c6-72f1a41773f5"), "A3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("92e463ae-c405-4a99-90ea-5f319f97348e"), "A2" },
                    { new Guid("60b6993c-efb0-46ba-bdd4-7ff97dbf81be"), "A1" },
                    { new Guid("6817d7f7-ae00-4d98-aee9-885ed67b2e93"), "F6" },
                    { new Guid("25d7ba2b-4206-4392-92b6-835725d951d2"), "A5" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5"), "Sección 2" },
                    { new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07"), "Sección 1" },
                    { new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "FilmFilmRols",
                columns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                values: new object[,]
                {
                    { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Cecilia Roth" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("a9fa7435-05b8-44f6-9e96-26a63631fa60"), "Mary Sweeny" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("d559a526-66bd-4af5-a871-e4431b428020"), "Roger Avary" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("d559a526-66bd-4af5-a871-e4431b428020"), "Quentin Tarantino" },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Robert Zemeckis" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Quentin Tarantino" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "David Lynch" },
                    { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Pedro Almodovar" },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Robin Wright" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Samuel Jackson" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Una Thurman" },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "John Travolta" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Justin Theroux" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Laura Harring" },
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Naomi Watts" },
                    { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Penélope Cruz" },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Tom Hancks" }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("d7118649-a5cd-49f7-ad13-349250d923db") },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("0c152707-c111-4b46-99b3-f67af40f626d") },
                    { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") },
                    { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") },
                    { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("55177983-68cd-447a-9a04-21774dd9b6d7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f155a0eb-e374-4a93-89dd-0b24831b71dd"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6cfd343e-a551-4e64-abc9-ccc488ce2aa5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2b820449-ec05-4919-a17d-d9a47bda6530"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ca473881-3107-4a30-9736-f65bd4778f33"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cbd68dd6-f5d7-409b-8908-6f27df5df69a"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("87d051cc-0e73-4721-ab8c-5960b61c4bc0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b5e9fdc8-77a0-4331-ba63-1896fa1ab8f9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3950527f-a436-40cd-a20f-1572dc72fe1c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4098c51a-026d-4854-95ab-d7008105d329"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2553b3d2-1ba6-42b8-8758-b8f1ac6db360"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("924408c8-9fdb-41fe-99b4-779815f6cb95"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("081a8397-8577-4455-b06f-67106b852489"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3f9cfb64-d04f-40e7-9fc1-fba8ac97dccf"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("54c71883-cc12-46ee-804a-1e5db8f6251c"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("19da9781-3dd5-4aac-8035-2992491f0739"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d9c42d4d-4dd0-4815-b079-928c8482e03e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e1da2164-00e0-43be-a68c-41595963066e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0bbe95c0-b691-4838-8221-64b3472d521b"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7013d12b-0ec9-41ee-8b98-83f40bc90ca5"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("27ec053e-a4ca-4724-9c7d-4cadafc6e264"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ab4d0c6f-3cf1-409d-af4f-d93026dd8553"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e3450db7-0c33-41db-b6cb-bb5405fe46b3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a44c6c5-dcb9-4957-8deb-dc419f28b999"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2fee958d-2ecc-496e-839f-7cc1640db3e9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fd95fac9-66cb-4473-9342-02b6d919e826"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7be211f8-935b-4b28-8ded-c51aecd86aa8"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5737961a-7ac6-4e56-8b4b-ff2d5c44d938"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("f4369454-49b3-4163-83f6-b16658a0c7d9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aadca6d6-d1a2-44e2-8f96-253f886415fb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4f68cf84-2c88-489b-827b-508a5d889e1f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("714a2713-99cf-427a-917c-668e69cab8aa"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("44afb2c9-50d5-4b03-8db8-488928cab96c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("07c593e2-cc75-4b11-bd87-d14a3243a6da"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6fcd090a-9be7-45da-90e9-f2cb25d2b919"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b284ebc9-57bc-4ddd-b6f7-43ce78d39fa3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("83fbd11c-da7a-41c0-823d-3b8d4289e676"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf054698-d96a-4d04-9e29-3e4079c723e0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("86f4ea90-e98a-4c07-9fb3-209fbb8dfbe7"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fc71bbed-4c80-4611-a1f7-b82bb0913ecd"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6350a1c0-4b61-4822-be70-84e7106b62e3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0bb9b7d6-f169-40d7-91d3-cd0133b9186e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("07758518-11c4-4917-a798-75c947151c95"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3146f03d-c2d2-459d-b793-d5170eef8cc9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4c543199-49fc-49f6-96aa-48a0f2c5d9f2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("73ca7dc0-238b-4d22-8c73-f37e2f8871ba"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("902ee57b-19e0-419d-a35a-0ebccc12ee8d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c5f6b841-c4e4-4fdc-8535-03a2b370c443"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("e1499785-1d7c-4410-b207-f1024fcede6f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d3d32611-7c7d-4851-9feb-a7c8d5f44ec5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b4a8cbee-a60d-4d80-b57b-4a7f35120383"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f18846f6-9613-481c-b183-fe63f68682b3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6f9262c3-a6b6-416e-8abf-824773b5e8ab"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2864ae5b-a0bd-4375-9aee-836848b4944c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aaa220fc-ccf2-4b41-9975-e158dce906be"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9e8efc8a-a48c-4659-b312-434ce733a7fb"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("64927abe-39b0-48cf-bc2c-62467e5a6450"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("26470872-d5df-42b3-8551-010f9d7a3657"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5e6bb853-afa9-4002-8ebd-8ce6db3be4f3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0120ed84-d1f4-412e-8fd0-a6755ba2236d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("dfc4d779-b296-4b19-bd70-a51955a26386"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("04dd5d29-7f0b-4aa0-a778-364ae8741a71"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4a1dcc00-74cf-42d7-aa02-679f9fba3ff2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f73f8b58-9e53-4f88-aa0a-76749b41705b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c7d2e6b0-cce1-451f-981e-073c0c5409ff"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("281daf8a-c6c5-4dd7-825b-5745c33c6cd3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5feb9db2-5ca4-4bd6-9132-73cba1f72786"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("58f2a2e9-b2a7-4227-b173-f9cf420d1553"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f6f50d42-a329-433f-9b9c-2ec8c769b5dc"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("55c3fc29-f856-4232-a9ba-a954e26aed92"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c674b923-423f-4cb1-a0bf-f5cb968038c4"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f1e686fa-08dd-400f-96da-83f06bcd360d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf1f8909-ee93-450f-a1c0-9e7c103226b0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9bf5a1e6-de9a-4d71-b653-a18b2598c87c"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("a9ae6a66-af4f-460b-a7d5-198b28882831"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("7b9e2c3c-8bdf-4ccc-b0aa-cb030caddde8"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c8e18f1a-7a4e-44a9-b4f0-4bd79c1f78b1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3c0f1e6f-406c-4cd0-b727-26bc65239321"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fafd18ea-6557-4b2b-a661-b5b9e0223517"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("8de0189f-c645-43de-b7dd-a7d06fcbb161"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("884f3276-8189-4ac9-90f1-25291758abb1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("16b8f3e3-1b98-42e6-b8b9-5cc6a5360b40"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d174828a-df9e-420c-9d7d-06df2a0e0bd2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("de7858fa-6be7-4e87-aca3-c124805a5bea"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("db8a0a57-4b53-4698-9a3e-8cbf9558abb7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0fd4e515-ab16-4238-9b60-7dd22fbb26d2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("82934dff-241e-4e89-a9ae-0c1e52024487"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b909e103-b1bb-437c-9023-b591a58bb0f9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6fac600d-27b7-4124-9704-de228b982fd1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("89fd5733-b204-4d64-8de2-7d40353c686a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ecbabae9-f98d-42fe-9c25-9bac6f68fe12"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2558d60b-da48-4da6-ac22-757510da31d9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4a239efa-af3b-4a33-8f40-be3d49ecad8a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c77d250c-6694-4bcf-a260-236b4cf9f174"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("1cd06bef-0636-4ba7-9eb4-e263b3e4b1b9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("361fa3d8-3cb2-477d-9d34-0f792bafc7b1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("95a74b72-2d97-4ea9-9c49-ba929ecd3df0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("659f1eab-4df4-4cef-9ad4-771ab78540f6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("69472373-69ad-4307-87b4-31f47645e64d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("8f15f7ab-3eef-431b-aa3f-83a84049e963"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c0743d3d-8c04-4224-b693-679db05ff2bb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a5305283-a1ae-4006-85d2-b577d6b0ed00"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c63101cb-8343-47bc-bd50-3a383cf604ef"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ff0f7a6c-4cba-46ce-a475-0eceff901125"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("81e1a6e1-af7d-4a38-a708-7f41456e13a3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ed77c5c5-ac9c-4f53-ae51-36a1344863f6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1e10a215-bae8-44a5-9625-9083c06e7440"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("754eed3d-1e16-4314-b363-719704d39adf"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ab0a05e9-5b5c-4507-9053-07f1f8451b9d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("245fc076-1fe1-4885-b931-4fd8c52c4438"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("00ec5766-b3ba-4fed-8ed4-3e86959dde72"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5bc0927d-1efa-47d1-9078-ca3598bc2448"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1c79ffda-4e7f-4edf-ae5b-bba8dedefe04"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9f018d0b-cfbe-4dd7-8c27-9f2c6be8af6e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5131e662-a32c-46cd-97cc-5e634ed1e4c0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a0d7b85-c6f5-423c-a4da-7e471c77a9a6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8aa62b78-1f94-43d5-989d-05b3fa7a965a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fc051d3c-43bb-43ea-958e-b3d53fe51aae"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8a358b97-1b95-4a21-a26f-ac8dd087468f"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("06866108-ce52-4ad6-9738-d942b720ec65"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("50db0553-21e5-460f-9b08-bf1fa234927d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("76428f87-07db-43db-9b11-946648aa63e2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("18e1b463-429b-4780-af46-6e872422fe6b"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("124c56d6-a1dc-468f-aadb-0526fe1d45eb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("54bf6f4f-91e8-478a-9b15-9e7d43309b97"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9c52dde3-c4d3-4f0e-8418-e3fc8809cc6f"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0b49cfeb-47dd-4b83-9603-8a7b2b4987d3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0bffa5c5-529c-48c9-8c9c-d9ea4cf10c70"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ef5348d4-267b-40b9-844b-f756f643662a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b0d95145-e319-4599-8630-faab91368af7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("6f4ae073-68d4-40f6-8ab8-ba2a27c8b10a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("38ea3b0f-6e3a-4a45-b76d-43dbf80234ae"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8ddb1d0a-3f7f-4dfe-a13c-f3d7de62549b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c2e54892-ee78-474b-bf19-5fdef1e80754"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a75dec22-e3d8-44c2-a3f9-0ece4da62a41"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("73d5bd4e-6f4b-4e44-864a-c86c1e8f7804"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("14631fb7-f3ba-41c2-9ab7-dc93699c06fa"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3717307f-2982-4b35-856a-91a5e37973f9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("910c7034-6a04-4983-9d69-209343184c68"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2f7ab287-8051-465e-8c64-6c3f92d0b1ab"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ab3ad768-e3e2-4acb-bac1-6b19373054b0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a5bbe32d-5033-4f39-a27b-57ce80944d34"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a984d835-4dd5-4eef-839d-10c8f6bbe2a3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("20342efa-8381-4601-8673-3ecd79873091"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("6817d7f7-ae00-4d98-aee9-885ed67b2e93"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c798944b-b3e5-40df-a7b9-83e14adb5e60"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("30de6f88-698d-4965-b1cf-49ad45cab072"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4b455918-8c6e-472b-9c38-8425de0350bc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("e00ca3f0-6814-4d2d-b06e-3e1db6a3a8a5"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fe245245-263e-4a24-9aef-e4065afb1322"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("baa3132f-7c1a-4e14-8773-acfac6ded9bf"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6cb73cb9-8e61-4f58-abdb-ff003572e832"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f866c2fc-e498-4432-8833-33d0e60c55d4"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("126a4ce6-e822-4811-9fc0-a063b5ba4c14"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b707216a-5467-4b19-9061-7293296e1468"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ace3dc3f-6cb9-4eb8-988b-07ad08b9df7a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d1f63dca-0019-411b-955e-9c0177c1158d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("95f9651a-859d-4642-aa90-2310b2161607"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("efb0e400-b188-47a7-b5bb-6f8c1864b039"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("044f58a7-53bf-4cc7-84aa-998da6620c56"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cb540183-5381-4611-afdb-0fae77381d88"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("603727ec-4857-41b9-b751-3e2b6cfba669"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("05b97778-50b9-4945-8da6-702b60bc457d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("45adb2c1-4b0f-4ea6-9562-95c7fb812805"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("870a458b-509a-4c78-9552-54af263f62cc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("de77c760-b7c8-46c0-a2f9-41dd01d56bb0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ccd6333c-f499-47c1-af0f-0ee76ee11d77"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9a134027-7d58-4863-9ca0-fb9fead9448a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a7914a6e-63d4-46d7-a4c2-d2b304c7460e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("bf5e3dea-db6f-4482-af3a-707cb594b9c2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3332edf1-35d0-476e-9d59-e5667f13b7a0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7ea93ba6-3b8b-47ed-9615-a928855ffa51"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("b89e8534-c5a4-47ec-9dcc-15e65048ead1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a95e7923-f80f-4284-a2ca-0453c271c59e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("28022469-d773-48a7-a3c7-c486a89536ac"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5b0cb3bb-b3fa-4971-acee-d9264fa2fc2d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("700d3914-0f69-4578-8d74-57a53c456c5e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5a1a7101-8c8c-4d7b-8f73-6d113f90682d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("19920320-e5d8-476d-b690-3b1668860f48"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5784d165-d8ed-4108-b696-96494d2607dd"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fae88cb8-2193-4a0b-894d-472bc530121c"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d14e8a32-c404-4737-9a34-db93b1311bc2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("390ae902-ef0a-46b7-9606-02fd870ef5e9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("57493160-5cbd-4ca9-b9dd-a56a5f9eec0b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d42a3d61-511e-43a7-ac6a-0e7a4a269f7d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4921e002-bd39-4e3d-babd-b26dc82ba0ae"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d2bb00c1-6512-4d52-95e3-eae0b2f53009"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("efb02e3b-8303-49c7-bbdc-64e500c8affc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7195ec6e-d8a0-4edd-b663-e1654aa07bc3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("39243733-4e99-44c9-b435-619b07e00ff6"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("61255d28-1679-4a87-b391-55dd9886de29"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("042e31bd-daf3-4133-9f9f-d671b0237855"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("85f1f8b0-983d-4e1e-a94b-98aa39cdd0e1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aab1b537-a1c8-4d07-80a1-7ffc97157858"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ccbc7367-6af7-4e5a-9f8c-b4bd1f02eef9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("dcd65a76-0243-49fa-9627-c8924da7523c"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9e2be97d-1ddb-41e8-8754-99386de29501"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("f3005176-2785-412d-bd36-33dea728d924"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5f7e8c20-ea11-4e39-a261-16e4815ca381"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf917ee6-203e-40bb-a2f1-6dc1edf25ae2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("25bbbf9e-18a2-4515-bba0-42c31cec9bfa"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4bbf6b1e-1ed0-4146-98f1-3b1a46f5a759"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fd5e8c7a-ffe5-41da-8781-ba2ac6abeef1"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("108522d3-9be2-4cba-aae4-9416d483d8fb"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("503d5554-7e43-4125-860d-e3f8113d36f4"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d67d02b7-cc05-40ea-8ee9-14d559a24c6e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("60b6993c-efb0-46ba-bdd4-7ff97dbf81be"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("92e463ae-c405-4a99-90ea-5f319f97348e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9c7bdf68-37dc-49b7-a4c6-72f1a41773f5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c3ea6ab6-70b8-4229-b731-d4151ae7652f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("25d7ba2b-4206-4392-92b6-835725d951d2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e21af0a3-8e3c-4985-a015-054a17a1e26f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d469eb38-b8c9-4aa1-b116-4fcd1d29516d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a42d7d4c-f759-4aa6-b1b4-87523eff09b0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3f248027-5c7b-47af-906b-bc74f80aa401"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ed99fc66-4a47-449a-bfc3-02caf83e97d5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("afb06163-bdd8-48e9-a472-b9c32dc2711c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a8a29b4-3c56-40e7-8b43-334bd0d6a630"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("477cbc13-c56c-4870-a2bb-c997cdb483f7"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("482c2b2a-cb47-41d7-a620-f04012887658"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d115ae55-ce71-446f-be0f-606a209063c2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("84c1044c-4774-4c15-97e6-68bfc3e43769"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ae952063-e8d3-4fd3-934d-2f26b7c70a38"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1386bd53-e007-46b7-8e3a-c882e0c7114b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("bfe5c515-5df7-4eae-ba68-df7835062778"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("cd1c5006-b506-49e6-9421-ae35dba6a3fe"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9d6624a3-b6fc-45f3-8845-3cb6537f8c1d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c6d347d6-b618-4d0b-b732-842dc4fba6e3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("af07f7b1-ce01-4c05-aa23-a865027bd550"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d0ff8364-6867-48a0-9493-6ebfb9071bb4"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9573982f-5a41-479a-9710-77001dd9b975"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("04fa07f8-d881-40ab-9b3f-6a2bc3cf3421"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d053734a-e24a-4f3e-854e-792d5bd97d2f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ef63a46d-f91c-4512-9a22-d5f6e2862ccc"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ae5d395d-ede7-4692-9b8d-908ede5cdf40"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ddcaa82d-1aed-44dc-9273-6e914c04ea82"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("33f3ee58-c423-4c9c-974d-03c492ae89e0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3aeb2cd0-8de5-426d-9445-266fcbdcbaec"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cbb9599c-598c-46e6-b0b8-049c3bb925f2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("11112115-ca4a-41f5-8f91-035d4a19a17a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6abf3c65-4fe2-4aa5-8bbb-8a1280df92f1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("43fb4345-da84-4b71-b38c-6c0f1f31a6a9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5cc0b07d-d553-4314-b41f-0eb1aad605ef"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("040f04d3-4ad6-4f32-ba60-2304d77e820e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5aec0da1-a064-4bdc-a2b7-9df488a77072"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("55f3a781-63c5-4404-8be3-7c2ca600d4e3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9663a3af-fd15-4370-ad49-c790585cd339"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4bf4baf9-725a-479a-a9ba-ce7bba6bff97"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("34b0c9c4-3f8c-41d8-aa7e-e17609d2dcfb"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("09adce4f-df2b-4621-bb3a-0a081a94c03b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2962ef9e-d3df-4261-bd17-1749551cb4e6"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d3d0a4f2-8cf5-48a8-b06f-f64936ecdd99"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("a5ac3aa8-b787-4bf1-ae59-7e7ee07068a3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c581468e-12dc-42fa-8a35-5217b014350b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3f68b4b0-24b2-47ee-841a-709191e12e76"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d5d5697c-6f44-4bec-a2b2-2e4a55b90642"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("70a7b702-174b-4dd1-b248-b1267ceaf4e8"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e7bb0d4e-8080-4946-bba2-e2e09f473c1f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5ab27f05-054e-4b54-a0a0-5e2fc986f45d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2a1ed7a9-a189-4626-8361-e8cdefd46836"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("57eee6df-80c7-4665-81ac-09e06578314f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5bd66bba-0d8d-4a73-b22f-74f4a94f707f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a9d7313-d574-4aa0-ab52-ea5743f19a82"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("07c679f4-31ee-4fff-8230-342a33553a48"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("451644e7-6d28-47db-8376-f5fbb864df99"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") },
                    { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3bc55ca2-838a-47fd-abce-4b3a180fcb80"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "John Travolta" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Samuel Jackson" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Una Thurman" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("d559a526-66bd-4af5-a871-e4431b428020"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("d559a526-66bd-4af5-a871-e4431b428020"), "Roger Avary" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Quentin Tarantino" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Justin Theroux" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Laura Harring" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Naomi Watts" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("a9fa7435-05b8-44f6-9e96-26a63631fa60"), "Mary Sweeny" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "David Lynch" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Robin Wright" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Tom Hancks" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Robert Zemeckis" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Cecilia Roth" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"), "Penélope Cruz" });

            migrationBuilder.DeleteData(
                table: "FilmFilmRols",
                keyColumns: new[] { "FilmId", "FilmRolId", "MemberRol" },
                keyValues: new object[] { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"), "Pedro Almodovar" });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"), new Guid("d7118649-a5cd-49f7-ad13-349250d923db") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("0c152707-c111-4b46-99b3-f67af40f626d") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") });

            migrationBuilder.DeleteData(
                table: "FilmGenres",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"), new Guid("42911db9-3e60-4c14-81ad-b9acea96bead") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("50bbe8d6-f0da-4530-9c47-3861c83708f5"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("5521f5f4-32cc-42d1-b5b5-190aeec12ea3"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("bc89f149-2220-4012-b993-3d2c22e551d7"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("df83f580-d4c9-4e1e-b17e-1a9b1025c530"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2f3467b5-dccd-4042-bcc3-0da5cb570088"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4223d3e3-9f2a-443d-af93-aa4509d6e6a9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8900c0e7-0c9f-4206-a9f2-3bccf8b90760"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9b0d47a9-b5c5-4da9-8a87-ffea8c3c991a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a144467d-5bde-4215-a18e-bd469a5b0a19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bb990033-8e39-4a07-80d7-a894c2589a06"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d2354062-bafe-48f1-8854-e735244ec8cb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e1cd48f8-4a30-4fcc-8dc6-84c4c3104494"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e47452e3-fb27-4ddb-a1d3-57243effcb31"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fc0acb80-e0eb-480e-b398-6003d5c1023e"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("c6eb1bef-6240-4c9b-9d21-c8f4a94cc0cc"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("d9701ace-55e8-46c2-bf7e-55dd40694255"));

            migrationBuilder.DeleteData(
                table: "PriceModifications",
                keyColumn: "Id",
                keyValue: new Guid("e5750eb3-2e7a-4b20-b6a0-5c9f86132adb"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("00ec5766-b3ba-4fed-8ed4-3e86959dde72"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0120ed84-d1f4-412e-8fd0-a6755ba2236d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("040f04d3-4ad6-4f32-ba60-2304d77e820e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("042e31bd-daf3-4133-9f9f-d671b0237855"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("044f58a7-53bf-4cc7-84aa-998da6620c56"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("04dd5d29-7f0b-4aa0-a778-364ae8741a71"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("04fa07f8-d881-40ab-9b3f-6a2bc3cf3421"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("05b97778-50b9-4945-8da6-702b60bc457d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("06866108-ce52-4ad6-9738-d942b720ec65"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("07758518-11c4-4917-a798-75c947151c95"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("07c593e2-cc75-4b11-bd87-d14a3243a6da"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("07c679f4-31ee-4fff-8230-342a33553a48"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("081a8397-8577-4455-b06f-67106b852489"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("09adce4f-df2b-4621-bb3a-0a081a94c03b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a0d7b85-c6f5-423c-a4da-7e471c77a9a6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a44c6c5-dcb9-4957-8deb-dc419f28b999"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a8a29b4-3c56-40e7-8b43-334bd0d6a630"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0a9d7313-d574-4aa0-ab52-ea5743f19a82"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0b49cfeb-47dd-4b83-9603-8a7b2b4987d3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0bb9b7d6-f169-40d7-91d3-cd0133b9186e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("0bbe95c0-b691-4838-8221-64b3472d521b"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0bffa5c5-529c-48c9-8c9c-d9ea4cf10c70"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("0fd4e515-ab16-4238-9b60-7dd22fbb26d2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("108522d3-9be2-4cba-aae4-9416d483d8fb"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("11112115-ca4a-41f5-8f91-035d4a19a17a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("124c56d6-a1dc-468f-aadb-0526fe1d45eb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("126a4ce6-e822-4811-9fc0-a063b5ba4c14"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1386bd53-e007-46b7-8e3a-c882e0c7114b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("14631fb7-f3ba-41c2-9ab7-dc93699c06fa"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("16b8f3e3-1b98-42e6-b8b9-5cc6a5360b40"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("18e1b463-429b-4780-af46-6e872422fe6b"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("19920320-e5d8-476d-b690-3b1668860f48"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("19da9781-3dd5-4aac-8035-2992491f0739"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1c79ffda-4e7f-4edf-ae5b-bba8dedefe04"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("1cd06bef-0636-4ba7-9eb4-e263b3e4b1b9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("1e10a215-bae8-44a5-9625-9083c06e7440"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("20342efa-8381-4601-8673-3ecd79873091"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("245fc076-1fe1-4885-b931-4fd8c52c4438"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2553b3d2-1ba6-42b8-8758-b8f1ac6db360"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2558d60b-da48-4da6-ac22-757510da31d9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("25bbbf9e-18a2-4515-bba0-42c31cec9bfa"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("25d7ba2b-4206-4392-92b6-835725d951d2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("26470872-d5df-42b3-8551-010f9d7a3657"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("27ec053e-a4ca-4724-9c7d-4cadafc6e264"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("28022469-d773-48a7-a3c7-c486a89536ac"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("281daf8a-c6c5-4dd7-825b-5745c33c6cd3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2864ae5b-a0bd-4375-9aee-836848b4944c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2962ef9e-d3df-4261-bd17-1749551cb4e6"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2a1ed7a9-a189-4626-8361-e8cdefd46836"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2b820449-ec05-4919-a17d-d9a47bda6530"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("2f7ab287-8051-465e-8c64-6c3f92d0b1ab"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("2fee958d-2ecc-496e-839f-7cc1640db3e9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("30de6f88-698d-4965-b1cf-49ad45cab072"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3146f03d-c2d2-459d-b793-d5170eef8cc9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3332edf1-35d0-476e-9d59-e5667f13b7a0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("33f3ee58-c423-4c9c-974d-03c492ae89e0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("34b0c9c4-3f8c-41d8-aa7e-e17609d2dcfb"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("361fa3d8-3cb2-477d-9d34-0f792bafc7b1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3717307f-2982-4b35-856a-91a5e37973f9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("38ea3b0f-6e3a-4a45-b76d-43dbf80234ae"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("390ae902-ef0a-46b7-9606-02fd870ef5e9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("39243733-4e99-44c9-b435-619b07e00ff6"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3950527f-a436-40cd-a20f-1572dc72fe1c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3aeb2cd0-8de5-426d-9445-266fcbdcbaec"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3bc55ca2-838a-47fd-abce-4b3a180fcb80"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3c0f1e6f-406c-4cd0-b727-26bc65239321"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3f248027-5c7b-47af-906b-bc74f80aa401"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("3f68b4b0-24b2-47ee-841a-709191e12e76"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("3f9cfb64-d04f-40e7-9fc1-fba8ac97dccf"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4098c51a-026d-4854-95ab-d7008105d329"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("43fb4345-da84-4b71-b38c-6c0f1f31a6a9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("44afb2c9-50d5-4b03-8db8-488928cab96c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("451644e7-6d28-47db-8376-f5fbb864df99"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("45adb2c1-4b0f-4ea6-9562-95c7fb812805"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("477cbc13-c56c-4870-a2bb-c997cdb483f7"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("482c2b2a-cb47-41d7-a620-f04012887658"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4921e002-bd39-4e3d-babd-b26dc82ba0ae"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4a1dcc00-74cf-42d7-aa02-679f9fba3ff2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4a239efa-af3b-4a33-8f40-be3d49ecad8a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4b455918-8c6e-472b-9c38-8425de0350bc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("4bbf6b1e-1ed0-4146-98f1-3b1a46f5a759"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4bf4baf9-725a-479a-a9ba-ce7bba6bff97"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4c543199-49fc-49f6-96aa-48a0f2c5d9f2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("4f68cf84-2c88-489b-827b-508a5d889e1f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("503d5554-7e43-4125-860d-e3f8113d36f4"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("50db0553-21e5-460f-9b08-bf1fa234927d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5131e662-a32c-46cd-97cc-5e634ed1e4c0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("54bf6f4f-91e8-478a-9b15-9e7d43309b97"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("54c71883-cc12-46ee-804a-1e5db8f6251c"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("55177983-68cd-447a-9a04-21774dd9b6d7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("55c3fc29-f856-4232-a9ba-a954e26aed92"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("55f3a781-63c5-4404-8be3-7c2ca600d4e3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5737961a-7ac6-4e56-8b4b-ff2d5c44d938"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("57493160-5cbd-4ca9-b9dd-a56a5f9eec0b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5784d165-d8ed-4108-b696-96494d2607dd"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("57eee6df-80c7-4665-81ac-09e06578314f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("58f2a2e9-b2a7-4227-b173-f9cf420d1553"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5a1a7101-8c8c-4d7b-8f73-6d113f90682d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5ab27f05-054e-4b54-a0a0-5e2fc986f45d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5aec0da1-a064-4bdc-a2b7-9df488a77072"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5b0cb3bb-b3fa-4971-acee-d9264fa2fc2d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5bc0927d-1efa-47d1-9078-ca3598bc2448"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5bd66bba-0d8d-4a73-b22f-74f4a94f707f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5cc0b07d-d553-4314-b41f-0eb1aad605ef"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("5e6bb853-afa9-4002-8ebd-8ce6db3be4f3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5f7e8c20-ea11-4e39-a261-16e4815ca381"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("5feb9db2-5ca4-4bd6-9132-73cba1f72786"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("603727ec-4857-41b9-b751-3e2b6cfba669"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("60b6993c-efb0-46ba-bdd4-7ff97dbf81be"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("61255d28-1679-4a87-b391-55dd9886de29"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6350a1c0-4b61-4822-be70-84e7106b62e3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("64927abe-39b0-48cf-bc2c-62467e5a6450"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("659f1eab-4df4-4cef-9ad4-771ab78540f6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("6817d7f7-ae00-4d98-aee9-885ed67b2e93"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("69472373-69ad-4307-87b4-31f47645e64d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6abf3c65-4fe2-4aa5-8bbb-8a1280df92f1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6cb73cb9-8e61-4f58-abdb-ff003572e832"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6cfd343e-a551-4e64-abc9-ccc488ce2aa5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("6f4ae073-68d4-40f6-8ab8-ba2a27c8b10a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6f9262c3-a6b6-416e-8abf-824773b5e8ab"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6fac600d-27b7-4124-9704-de228b982fd1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("6fcd090a-9be7-45da-90e9-f2cb25d2b919"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("700d3914-0f69-4578-8d74-57a53c456c5e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7013d12b-0ec9-41ee-8b98-83f40bc90ca5"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("70a7b702-174b-4dd1-b248-b1267ceaf4e8"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("714a2713-99cf-427a-917c-668e69cab8aa"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7195ec6e-d8a0-4edd-b663-e1654aa07bc3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("73ca7dc0-238b-4d22-8c73-f37e2f8871ba"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("73d5bd4e-6f4b-4e44-864a-c86c1e8f7804"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("754eed3d-1e16-4314-b363-719704d39adf"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("76428f87-07db-43db-9b11-946648aa63e2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("7b9e2c3c-8bdf-4ccc-b0aa-cb030caddde8"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7be211f8-935b-4b28-8ded-c51aecd86aa8"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("7ea93ba6-3b8b-47ed-9615-a928855ffa51"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("81e1a6e1-af7d-4a38-a708-7f41456e13a3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("82934dff-241e-4e89-a9ae-0c1e52024487"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("83fbd11c-da7a-41c0-823d-3b8d4289e676"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("84c1044c-4774-4c15-97e6-68bfc3e43769"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("85f1f8b0-983d-4e1e-a94b-98aa39cdd0e1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("86f4ea90-e98a-4c07-9fb3-209fbb8dfbe7"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("870a458b-509a-4c78-9552-54af263f62cc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("87d051cc-0e73-4721-ab8c-5960b61c4bc0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("884f3276-8189-4ac9-90f1-25291758abb1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("89fd5733-b204-4d64-8de2-7d40353c686a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8a358b97-1b95-4a21-a26f-ac8dd087468f"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8aa62b78-1f94-43d5-989d-05b3fa7a965a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("8ddb1d0a-3f7f-4dfe-a13c-f3d7de62549b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("8de0189f-c645-43de-b7dd-a7d06fcbb161"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("8f15f7ab-3eef-431b-aa3f-83a84049e963"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("902ee57b-19e0-419d-a35a-0ebccc12ee8d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("910c7034-6a04-4983-9d69-209343184c68"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("924408c8-9fdb-41fe-99b4-779815f6cb95"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("92e463ae-c405-4a99-90ea-5f319f97348e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9573982f-5a41-479a-9710-77001dd9b975"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("95a74b72-2d97-4ea9-9c49-ba929ecd3df0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("95f9651a-859d-4642-aa90-2310b2161607"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9663a3af-fd15-4370-ad49-c790585cd339"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9a134027-7d58-4863-9ca0-fb9fead9448a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9bf5a1e6-de9a-4d71-b653-a18b2598c87c"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9c52dde3-c4d3-4f0e-8418-e3fc8809cc6f"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9c7bdf68-37dc-49b7-a4c6-72f1a41773f5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9d6624a3-b6fc-45f3-8845-3cb6537f8c1d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9e2be97d-1ddb-41e8-8754-99386de29501"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("9e8efc8a-a48c-4659-b312-434ce733a7fb"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("9f018d0b-cfbe-4dd7-8c27-9f2c6be8af6e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a42d7d4c-f759-4aa6-b1b4-87523eff09b0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a5305283-a1ae-4006-85d2-b577d6b0ed00"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("a5ac3aa8-b787-4bf1-ae59-7e7ee07068a3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a5bbe32d-5033-4f39-a27b-57ce80944d34"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a75dec22-e3d8-44c2-a3f9-0ece4da62a41"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a7914a6e-63d4-46d7-a4c2-d2b304c7460e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a95e7923-f80f-4284-a2ca-0453c271c59e"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("a984d835-4dd5-4eef-839d-10c8f6bbe2a3"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("a9ae6a66-af4f-460b-a7d5-198b28882831"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aaa220fc-ccf2-4b41-9975-e158dce906be"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aab1b537-a1c8-4d07-80a1-7ffc97157858"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("aadca6d6-d1a2-44e2-8f96-253f886415fb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ab0a05e9-5b5c-4507-9053-07f1f8451b9d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ab3ad768-e3e2-4acb-bac1-6b19373054b0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ab4d0c6f-3cf1-409d-af4f-d93026dd8553"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ace3dc3f-6cb9-4eb8-988b-07ad08b9df7a"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ae5d395d-ede7-4692-9b8d-908ede5cdf40"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ae952063-e8d3-4fd3-934d-2f26b7c70a38"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("af07f7b1-ce01-4c05-aa23-a865027bd550"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("afb06163-bdd8-48e9-a472-b9c32dc2711c"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b0d95145-e319-4599-8630-faab91368af7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b284ebc9-57bc-4ddd-b6f7-43ce78d39fa3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b4a8cbee-a60d-4d80-b57b-4a7f35120383"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b5e9fdc8-77a0-4331-ba63-1896fa1ab8f9"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b707216a-5467-4b19-9061-7293296e1468"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("b89e8534-c5a4-47ec-9dcc-15e65048ead1"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("b909e103-b1bb-437c-9023-b591a58bb0f9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("baa3132f-7c1a-4e14-8773-acfac6ded9bf"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("bf5e3dea-db6f-4482-af3a-707cb594b9c2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("bfe5c515-5df7-4eae-ba68-df7835062778"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c0743d3d-8c04-4224-b693-679db05ff2bb"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c2e54892-ee78-474b-bf19-5fdef1e80754"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c3ea6ab6-70b8-4229-b731-d4151ae7652f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c581468e-12dc-42fa-8a35-5217b014350b"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c5f6b841-c4e4-4fdc-8535-03a2b370c443"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c63101cb-8343-47bc-bd50-3a383cf604ef"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c674b923-423f-4cb1-a0bf-f5cb968038c4"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c6d347d6-b618-4d0b-b732-842dc4fba6e3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c77d250c-6694-4bcf-a260-236b4cf9f174"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c798944b-b3e5-40df-a7b9-83e14adb5e60"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("c7d2e6b0-cce1-451f-981e-073c0c5409ff"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("c8e18f1a-7a4e-44a9-b4f0-4bd79c1f78b1"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ca473881-3107-4a30-9736-f65bd4778f33"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cb540183-5381-4611-afdb-0fae77381d88"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cbb9599c-598c-46e6-b0b8-049c3bb925f2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cbd68dd6-f5d7-409b-8908-6f27df5df69a"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ccbc7367-6af7-4e5a-9f8c-b4bd1f02eef9"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ccd6333c-f499-47c1-af0f-0ee76ee11d77"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("cd1c5006-b506-49e6-9421-ae35dba6a3fe"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf054698-d96a-4d04-9e29-3e4079c723e0"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf1f8909-ee93-450f-a1c0-9e7c103226b0"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("cf917ee6-203e-40bb-a2f1-6dc1edf25ae2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d053734a-e24a-4f3e-854e-792d5bd97d2f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d0ff8364-6867-48a0-9493-6ebfb9071bb4"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d115ae55-ce71-446f-be0f-606a209063c2"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d14e8a32-c404-4737-9a34-db93b1311bc2"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d174828a-df9e-420c-9d7d-06df2a0e0bd2"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d1f63dca-0019-411b-955e-9c0177c1158d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d2bb00c1-6512-4d52-95e3-eae0b2f53009"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d3d0a4f2-8cf5-48a8-b06f-f64936ecdd99"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d3d32611-7c7d-4851-9feb-a7c8d5f44ec5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d42a3d61-511e-43a7-ac6a-0e7a4a269f7d"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d469eb38-b8c9-4aa1-b116-4fcd1d29516d"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("d5d5697c-6f44-4bec-a2b2-2e4a55b90642"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d67d02b7-cc05-40ea-8ee9-14d559a24c6e"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("d9c42d4d-4dd0-4815-b079-928c8482e03e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("db8a0a57-4b53-4698-9a3e-8cbf9558abb7"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("dcd65a76-0243-49fa-9627-c8924da7523c"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ddcaa82d-1aed-44dc-9273-6e914c04ea82"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("de77c760-b7c8-46c0-a2f9-41dd01d56bb0"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("de7858fa-6be7-4e87-aca3-c124805a5bea"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("dfc4d779-b296-4b19-bd70-a51955a26386"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("e00ca3f0-6814-4d2d-b06e-3e1db6a3a8a5"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("e1499785-1d7c-4410-b207-f1024fcede6f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e1da2164-00e0-43be-a68c-41595963066e"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e21af0a3-8e3c-4985-a015-054a17a1e26f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e3450db7-0c33-41db-b6cb-bb5405fe46b3"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("e7bb0d4e-8080-4946-bba2-e2e09f473c1f"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ecbabae9-f98d-42fe-9c25-9bac6f68fe12"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ed77c5c5-ac9c-4f53-ae51-36a1344863f6"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ed99fc66-4a47-449a-bfc3-02caf83e97d5"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("ef5348d4-267b-40b9-844b-f756f643662a"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ef63a46d-f91c-4512-9a22-d5f6e2862ccc"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("efb02e3b-8303-49c7-bbdc-64e500c8affc"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("efb0e400-b188-47a7-b5bb-6f8c1864b039"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f155a0eb-e374-4a93-89dd-0b24831b71dd"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f18846f6-9613-481c-b183-fe63f68682b3"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f1e686fa-08dd-400f-96da-83f06bcd360d"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("f3005176-2785-412d-bd36-33dea728d924"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("f4369454-49b3-4163-83f6-b16658a0c7d9"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f6f50d42-a329-433f-9b9c-2ec8c769b5dc"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f73f8b58-9e53-4f88-aa0a-76749b41705b"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("f866c2fc-e498-4432-8833-33d0e60c55d4"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fae88cb8-2193-4a0b-894d-472bc530121c"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fafd18ea-6557-4b2b-a661-b5b9e0223517"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fc051d3c-43bb-43ea-958e-b3d53fe51aae"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fc71bbed-4c80-4611-a1f7-b82bb0913ecd"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fd5e8c7a-ffe5-41da-8781-ba2ac6abeef1"), new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("fd95fac9-66cb-4473-9342-02b6d919e826"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"), new Guid("e7842029-1662-44b2-b22d-797387f62299"), new Guid("fe245245-263e-4a24-9aef-e4065afb1322"), new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"), new Guid("510be9c8-acf6-48e6-8600-291d818f9428"), new Guid("ff0f7a6c-4cba-46ce-a475-0eceff901125"), new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f") });

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("611e1ed5-c3ee-40f0-a2be-65ee941654bb"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("a9fa7435-05b8-44f6-9e96-26a63631fa60"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("d559a526-66bd-4af5-a871-e4431b428020"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e0653d0b-0607-4814-9f9a-4a186f4c9c9c"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("066c51f9-c4e9-4703-9bf1-f2d54fa586c1"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("06dcedac-71ba-4121-b128-ca0ccaf19d95"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("548a3449-4ae8-4559-bc5e-f9c4e6901af5"));

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: new Guid("b0be7598-12a1-4ba5-9d41-31d0c88580c7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0c152707-c111-4b46-99b3-f67af40f626d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("42911db9-3e60-4c14-81ad-b9acea96bead"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d7118649-a5cd-49f7-ad13-349250d923db"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("3c36c695-e612-4113-a3f6-1e4016945c08"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("9f93fe8e-1c4b-4f91-8977-6820033de35c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("510be9c8-acf6-48e6-8600-291d818f9428"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e7842029-1662-44b2-b22d-797387f62299"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00ec5766-b3ba-4fed-8ed4-3e86959dde72"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0120ed84-d1f4-412e-8fd0-a6755ba2236d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("040f04d3-4ad6-4f32-ba60-2304d77e820e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("042e31bd-daf3-4133-9f9f-d671b0237855"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("044f58a7-53bf-4cc7-84aa-998da6620c56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04dd5d29-7f0b-4aa0-a778-364ae8741a71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04fa07f8-d881-40ab-9b3f-6a2bc3cf3421"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05b97778-50b9-4945-8da6-702b60bc457d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06866108-ce52-4ad6-9738-d942b720ec65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07758518-11c4-4917-a798-75c947151c95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07c593e2-cc75-4b11-bd87-d14a3243a6da"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("07c679f4-31ee-4fff-8230-342a33553a48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("081a8397-8577-4455-b06f-67106b852489"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09adce4f-df2b-4621-bb3a-0a081a94c03b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a0d7b85-c6f5-423c-a4da-7e471c77a9a6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a44c6c5-dcb9-4957-8deb-dc419f28b999"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a8a29b4-3c56-40e7-8b43-334bd0d6a630"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a9d7313-d574-4aa0-ab52-ea5743f19a82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b49cfeb-47dd-4b83-9603-8a7b2b4987d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bb9b7d6-f169-40d7-91d3-cd0133b9186e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bbe95c0-b691-4838-8221-64b3472d521b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bffa5c5-529c-48c9-8c9c-d9ea4cf10c70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fd4e515-ab16-4238-9b60-7dd22fbb26d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("108522d3-9be2-4cba-aae4-9416d483d8fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11112115-ca4a-41f5-8f91-035d4a19a17a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("124c56d6-a1dc-468f-aadb-0526fe1d45eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("126a4ce6-e822-4811-9fc0-a063b5ba4c14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1386bd53-e007-46b7-8e3a-c882e0c7114b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14631fb7-f3ba-41c2-9ab7-dc93699c06fa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16b8f3e3-1b98-42e6-b8b9-5cc6a5360b40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18e1b463-429b-4780-af46-6e872422fe6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19920320-e5d8-476d-b690-3b1668860f48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19da9781-3dd5-4aac-8035-2992491f0739"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c79ffda-4e7f-4edf-ae5b-bba8dedefe04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1cd06bef-0636-4ba7-9eb4-e263b3e4b1b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e10a215-bae8-44a5-9625-9083c06e7440"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20342efa-8381-4601-8673-3ecd79873091"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("245fc076-1fe1-4885-b931-4fd8c52c4438"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2553b3d2-1ba6-42b8-8758-b8f1ac6db360"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2558d60b-da48-4da6-ac22-757510da31d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25bbbf9e-18a2-4515-bba0-42c31cec9bfa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25d7ba2b-4206-4392-92b6-835725d951d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26470872-d5df-42b3-8551-010f9d7a3657"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27ec053e-a4ca-4724-9c7d-4cadafc6e264"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28022469-d773-48a7-a3c7-c486a89536ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("281daf8a-c6c5-4dd7-825b-5745c33c6cd3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2864ae5b-a0bd-4375-9aee-836848b4944c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2962ef9e-d3df-4261-bd17-1749551cb4e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a1ed7a9-a189-4626-8361-e8cdefd46836"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b820449-ec05-4919-a17d-d9a47bda6530"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f7ab287-8051-465e-8c64-6c3f92d0b1ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2fee958d-2ecc-496e-839f-7cc1640db3e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30de6f88-698d-4965-b1cf-49ad45cab072"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3146f03d-c2d2-459d-b793-d5170eef8cc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3332edf1-35d0-476e-9d59-e5667f13b7a0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("33f3ee58-c423-4c9c-974d-03c492ae89e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("34b0c9c4-3f8c-41d8-aa7e-e17609d2dcfb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("361fa3d8-3cb2-477d-9d34-0f792bafc7b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3717307f-2982-4b35-856a-91a5e37973f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38ea3b0f-6e3a-4a45-b76d-43dbf80234ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("390ae902-ef0a-46b7-9606-02fd870ef5e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39243733-4e99-44c9-b435-619b07e00ff6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3950527f-a436-40cd-a20f-1572dc72fe1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3aeb2cd0-8de5-426d-9445-266fcbdcbaec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bc55ca2-838a-47fd-abce-4b3a180fcb80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c0f1e6f-406c-4cd0-b727-26bc65239321"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f248027-5c7b-47af-906b-bc74f80aa401"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f68b4b0-24b2-47ee-841a-709191e12e76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f9cfb64-d04f-40e7-9fc1-fba8ac97dccf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4098c51a-026d-4854-95ab-d7008105d329"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43fb4345-da84-4b71-b38c-6c0f1f31a6a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44afb2c9-50d5-4b03-8db8-488928cab96c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("451644e7-6d28-47db-8376-f5fbb864df99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45adb2c1-4b0f-4ea6-9562-95c7fb812805"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("477cbc13-c56c-4870-a2bb-c997cdb483f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("482c2b2a-cb47-41d7-a620-f04012887658"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4921e002-bd39-4e3d-babd-b26dc82ba0ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a1dcc00-74cf-42d7-aa02-679f9fba3ff2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a239efa-af3b-4a33-8f40-be3d49ecad8a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b455918-8c6e-472b-9c38-8425de0350bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bbf6b1e-1ed0-4146-98f1-3b1a46f5a759"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bf4baf9-725a-479a-a9ba-ce7bba6bff97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c543199-49fc-49f6-96aa-48a0f2c5d9f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f68cf84-2c88-489b-827b-508a5d889e1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("503d5554-7e43-4125-860d-e3f8113d36f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50db0553-21e5-460f-9b08-bf1fa234927d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5131e662-a32c-46cd-97cc-5e634ed1e4c0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54bf6f4f-91e8-478a-9b15-9e7d43309b97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54c71883-cc12-46ee-804a-1e5db8f6251c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55177983-68cd-447a-9a04-21774dd9b6d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55c3fc29-f856-4232-a9ba-a954e26aed92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55f3a781-63c5-4404-8be3-7c2ca600d4e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5737961a-7ac6-4e56-8b4b-ff2d5c44d938"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57493160-5cbd-4ca9-b9dd-a56a5f9eec0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5784d165-d8ed-4108-b696-96494d2607dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57eee6df-80c7-4665-81ac-09e06578314f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58f2a2e9-b2a7-4227-b173-f9cf420d1553"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a1a7101-8c8c-4d7b-8f73-6d113f90682d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ab27f05-054e-4b54-a0a0-5e2fc986f45d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5aec0da1-a064-4bdc-a2b7-9df488a77072"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b0cb3bb-b3fa-4971-acee-d9264fa2fc2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bc0927d-1efa-47d1-9078-ca3598bc2448"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5bd66bba-0d8d-4a73-b22f-74f4a94f707f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5cc0b07d-d553-4314-b41f-0eb1aad605ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5e6bb853-afa9-4002-8ebd-8ce6db3be4f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f7e8c20-ea11-4e39-a261-16e4815ca381"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5feb9db2-5ca4-4bd6-9132-73cba1f72786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("603727ec-4857-41b9-b751-3e2b6cfba669"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60b6993c-efb0-46ba-bdd4-7ff97dbf81be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("61255d28-1679-4a87-b391-55dd9886de29"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6350a1c0-4b61-4822-be70-84e7106b62e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64927abe-39b0-48cf-bc2c-62467e5a6450"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("659f1eab-4df4-4cef-9ad4-771ab78540f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6817d7f7-ae00-4d98-aee9-885ed67b2e93"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69472373-69ad-4307-87b4-31f47645e64d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6abf3c65-4fe2-4aa5-8bbb-8a1280df92f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cb73cb9-8e61-4f58-abdb-ff003572e832"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cfd343e-a551-4e64-abc9-ccc488ce2aa5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f4ae073-68d4-40f6-8ab8-ba2a27c8b10a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f9262c3-a6b6-416e-8abf-824773b5e8ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fac600d-27b7-4124-9704-de228b982fd1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fcd090a-9be7-45da-90e9-f2cb25d2b919"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("700d3914-0f69-4578-8d74-57a53c456c5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7013d12b-0ec9-41ee-8b98-83f40bc90ca5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("70a7b702-174b-4dd1-b248-b1267ceaf4e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("714a2713-99cf-427a-917c-668e69cab8aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7195ec6e-d8a0-4edd-b663-e1654aa07bc3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73ca7dc0-238b-4d22-8c73-f37e2f8871ba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73d5bd4e-6f4b-4e44-864a-c86c1e8f7804"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("754eed3d-1e16-4314-b363-719704d39adf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76428f87-07db-43db-9b11-946648aa63e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7b9e2c3c-8bdf-4ccc-b0aa-cb030caddde8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7be211f8-935b-4b28-8ded-c51aecd86aa8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ea93ba6-3b8b-47ed-9615-a928855ffa51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81e1a6e1-af7d-4a38-a708-7f41456e13a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82934dff-241e-4e89-a9ae-0c1e52024487"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83fbd11c-da7a-41c0-823d-3b8d4289e676"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84c1044c-4774-4c15-97e6-68bfc3e43769"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85f1f8b0-983d-4e1e-a94b-98aa39cdd0e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("86f4ea90-e98a-4c07-9fb3-209fbb8dfbe7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("870a458b-509a-4c78-9552-54af263f62cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("87d051cc-0e73-4721-ab8c-5960b61c4bc0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("884f3276-8189-4ac9-90f1-25291758abb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89fd5733-b204-4d64-8de2-7d40353c686a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a358b97-1b95-4a21-a26f-ac8dd087468f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8aa62b78-1f94-43d5-989d-05b3fa7a965a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ddb1d0a-3f7f-4dfe-a13c-f3d7de62549b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8de0189f-c645-43de-b7dd-a7d06fcbb161"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f15f7ab-3eef-431b-aa3f-83a84049e963"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("902ee57b-19e0-419d-a35a-0ebccc12ee8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("910c7034-6a04-4983-9d69-209343184c68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("924408c8-9fdb-41fe-99b4-779815f6cb95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92e463ae-c405-4a99-90ea-5f319f97348e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9573982f-5a41-479a-9710-77001dd9b975"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95a74b72-2d97-4ea9-9c49-ba929ecd3df0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95f9651a-859d-4642-aa90-2310b2161607"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9663a3af-fd15-4370-ad49-c790585cd339"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a134027-7d58-4863-9ca0-fb9fead9448a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bf5a1e6-de9a-4d71-b653-a18b2598c87c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c52dde3-c4d3-4f0e-8418-e3fc8809cc6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c7bdf68-37dc-49b7-a4c6-72f1a41773f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d6624a3-b6fc-45f3-8845-3cb6537f8c1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e2be97d-1ddb-41e8-8754-99386de29501"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e8efc8a-a48c-4659-b312-434ce733a7fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f018d0b-cfbe-4dd7-8c27-9f2c6be8af6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a42d7d4c-f759-4aa6-b1b4-87523eff09b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5305283-a1ae-4006-85d2-b577d6b0ed00"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5ac3aa8-b787-4bf1-ae59-7e7ee07068a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a5bbe32d-5033-4f39-a27b-57ce80944d34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a75dec22-e3d8-44c2-a3f9-0ece4da62a41"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7914a6e-63d4-46d7-a4c2-d2b304c7460e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a95e7923-f80f-4284-a2ca-0453c271c59e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a984d835-4dd5-4eef-839d-10c8f6bbe2a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9ae6a66-af4f-460b-a7d5-198b28882831"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aaa220fc-ccf2-4b41-9975-e158dce906be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aab1b537-a1c8-4d07-80a1-7ffc97157858"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aadca6d6-d1a2-44e2-8f96-253f886415fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab0a05e9-5b5c-4507-9053-07f1f8451b9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab3ad768-e3e2-4acb-bac1-6b19373054b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab4d0c6f-3cf1-409d-af4f-d93026dd8553"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ace3dc3f-6cb9-4eb8-988b-07ad08b9df7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae5d395d-ede7-4692-9b8d-908ede5cdf40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae952063-e8d3-4fd3-934d-2f26b7c70a38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af07f7b1-ce01-4c05-aa23-a865027bd550"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afb06163-bdd8-48e9-a472-b9c32dc2711c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0d95145-e319-4599-8630-faab91368af7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b284ebc9-57bc-4ddd-b6f7-43ce78d39fa3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4a8cbee-a60d-4d80-b57b-4a7f35120383"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b5e9fdc8-77a0-4331-ba63-1896fa1ab8f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b707216a-5467-4b19-9061-7293296e1468"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b89e8534-c5a4-47ec-9dcc-15e65048ead1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b909e103-b1bb-437c-9023-b591a58bb0f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("baa3132f-7c1a-4e14-8773-acfac6ded9bf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf5e3dea-db6f-4482-af3a-707cb594b9c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfe5c515-5df7-4eae-ba68-df7835062778"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0743d3d-8c04-4224-b693-679db05ff2bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2e54892-ee78-474b-bf19-5fdef1e80754"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c3ea6ab6-70b8-4229-b731-d4151ae7652f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c581468e-12dc-42fa-8a35-5217b014350b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c5f6b841-c4e4-4fdc-8535-03a2b370c443"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c63101cb-8343-47bc-bd50-3a383cf604ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c674b923-423f-4cb1-a0bf-f5cb968038c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6d347d6-b618-4d0b-b732-842dc4fba6e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c77d250c-6694-4bcf-a260-236b4cf9f174"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c798944b-b3e5-40df-a7b9-83e14adb5e60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7d2e6b0-cce1-451f-981e-073c0c5409ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8e18f1a-7a4e-44a9-b4f0-4bd79c1f78b1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca473881-3107-4a30-9736-f65bd4778f33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb540183-5381-4611-afdb-0fae77381d88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbb9599c-598c-46e6-b0b8-049c3bb925f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cbd68dd6-f5d7-409b-8908-6f27df5df69a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccbc7367-6af7-4e5a-9f8c-b4bd1f02eef9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccd6333c-f499-47c1-af0f-0ee76ee11d77"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd1c5006-b506-49e6-9421-ae35dba6a3fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf054698-d96a-4d04-9e29-3e4079c723e0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf1f8909-ee93-450f-a1c0-9e7c103226b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf917ee6-203e-40bb-a2f1-6dc1edf25ae2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d053734a-e24a-4f3e-854e-792d5bd97d2f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0ff8364-6867-48a0-9493-6ebfb9071bb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d115ae55-ce71-446f-be0f-606a209063c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d14e8a32-c404-4737-9a34-db93b1311bc2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d174828a-df9e-420c-9d7d-06df2a0e0bd2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1f63dca-0019-411b-955e-9c0177c1158d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2bb00c1-6512-4d52-95e3-eae0b2f53009"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3d0a4f2-8cf5-48a8-b06f-f64936ecdd99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3d32611-7c7d-4851-9feb-a7c8d5f44ec5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d42a3d61-511e-43a7-ac6a-0e7a4a269f7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d469eb38-b8c9-4aa1-b116-4fcd1d29516d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5d5697c-6f44-4bec-a2b2-2e4a55b90642"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d67d02b7-cc05-40ea-8ee9-14d559a24c6e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9c42d4d-4dd0-4815-b079-928c8482e03e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db8a0a57-4b53-4698-9a3e-8cbf9558abb7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcd65a76-0243-49fa-9627-c8924da7523c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ddcaa82d-1aed-44dc-9273-6e914c04ea82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de77c760-b7c8-46c0-a2f9-41dd01d56bb0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de7858fa-6be7-4e87-aca3-c124805a5bea"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dfc4d779-b296-4b19-bd70-a51955a26386"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e00ca3f0-6814-4d2d-b06e-3e1db6a3a8a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1499785-1d7c-4410-b207-f1024fcede6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1da2164-00e0-43be-a68c-41595963066e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e21af0a3-8e3c-4985-a015-054a17a1e26f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3450db7-0c33-41db-b6cb-bb5405fe46b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7bb0d4e-8080-4946-bba2-e2e09f473c1f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ecbabae9-f98d-42fe-9c25-9bac6f68fe12"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed77c5c5-ac9c-4f53-ae51-36a1344863f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed99fc66-4a47-449a-bfc3-02caf83e97d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef5348d4-267b-40b9-844b-f756f643662a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef63a46d-f91c-4512-9a22-d5f6e2862ccc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efb02e3b-8303-49c7-bbdc-64e500c8affc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efb0e400-b188-47a7-b5bb-6f8c1864b039"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f155a0eb-e374-4a93-89dd-0b24831b71dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f18846f6-9613-481c-b183-fe63f68682b3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1e686fa-08dd-400f-96da-83f06bcd360d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f3005176-2785-412d-bd36-33dea728d924"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f4369454-49b3-4163-83f6-b16658a0c7d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f6f50d42-a329-433f-9b9c-2ec8c769b5dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f73f8b58-9e53-4f88-aa0a-76749b41705b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f866c2fc-e498-4432-8833-33d0e60c55d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fae88cb8-2193-4a0b-894d-472bc530121c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fafd18ea-6557-4b2b-a661-b5b9e0223517"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc051d3c-43bb-43ea-958e-b3d53fe51aae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fc71bbed-4c80-4611-a1f7-b82bb0913ecd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd5e8c7a-ffe5-41da-8781-ba2ac6abeef1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd95fac9-66cb-4473-9342-02b6d919e826"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe245245-263e-4a24-9aef-e4065afb1322"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ff0f7a6c-4cba-46ce-a475-0eceff901125"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("5642ecbd-f222-4a00-b27e-b0a2ce19ead5"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("7eaa3922-68fa-4a14-9648-348c510d2e07"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("841a2cfd-9292-4e96-9669-8e6d775ccb2f"));

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
        }
    }
}
