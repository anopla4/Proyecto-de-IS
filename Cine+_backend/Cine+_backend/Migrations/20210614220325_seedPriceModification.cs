using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class seedPriceModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
