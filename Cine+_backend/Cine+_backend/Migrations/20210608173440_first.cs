using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Income = table.Column<double>(type: "float", nullable: false),
                    Expense = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubMembers",
                columns: table => new
                {
                    Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "date", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMembers", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "FilmRols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmRols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

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
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceModifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceModifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmFilmRols",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmRolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberRol = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmFilmRols", x => new { x.FilmId, x.FilmRolId, x.MemberRol });
                    table.ForeignKey(
                        name: "FK_FilmFilmRols_FilmRols_FilmRolId",
                        column: x => x.FilmRolId,
                        principalTable: "FilmRols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmFilmRols_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clubMemberGenres",
                columns: table => new
                {
                    ClubMemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clubMemberGenres", x => new { x.ClubMemberId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_clubMemberGenres_ClubMembers_ClubMemberId",
                        column: x => x.ClubMemberId,
                        principalTable: "ClubMembers",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clubMemberGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenres",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenres", x => new { x.FilmId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_FilmGenres_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmScreenings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StarTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmScreenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmScreenings_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmScreenings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatSectionLevelRooms",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatSectionLevelRooms", x => new { x.SeatId, x.SectionId, x.LevelId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_SeatSectionLevelRooms_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatSectionLevelRooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatSectionLevelRooms_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatSectionLevelRooms_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CredictCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilms",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilms", x => new { x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_UserFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilms_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmScreeningPriceModifications",
                columns: table => new
                {
                    FilmScreeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceModificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Optional = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmScreeningPriceModifications", x => new { x.FilmScreeningId, x.PriceModificationId });
                    table.ForeignKey(
                        name: "FK_FilmScreeningPriceModifications_FilmScreenings_FilmScreeningId",
                        column: x => x.FilmScreeningId,
                        principalTable: "FilmScreenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmScreeningPriceModifications_PriceModifications_PriceModificationId",
                        column: x => x.PriceModificationId,
                        principalTable: "PriceModifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilmSreeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_FilmScreenings_FilmSreeningId",
                        column: x => x.FilmSreeningId,
                        principalTable: "FilmScreenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_clubMemberGenres_GenreId",
                table: "clubMemberGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmFilmRols_FilmRolId",
                table: "FilmFilmRols",
                column: "FilmRolId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmGenres_GenreId",
                table: "FilmGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmScreeningPriceModifications_PriceModificationId",
                table: "FilmScreeningPriceModifications",
                column: "PriceModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmScreenings_FilmId",
                table: "FilmScreenings",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmScreenings_RoomId",
                table: "FilmScreenings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_FilmSreeningId",
                table: "Items",
                column: "FilmSreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PurchaseOrderId",
                table: "Items",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SeatId",
                table: "Items",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_UserId",
                table: "PurchaseOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatSectionLevelRooms_LevelId",
                table: "SeatSectionLevelRooms",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatSectionLevelRooms_RoomId",
                table: "SeatSectionLevelRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatSectionLevelRooms_SectionId",
                table: "SeatSectionLevelRooms",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilms_FilmId",
                table: "UserFilms",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookEntries");

            migrationBuilder.DropTable(
                name: "clubMemberGenres");

            migrationBuilder.DropTable(
                name: "FilmFilmRols");

            migrationBuilder.DropTable(
                name: "FilmGenres");

            migrationBuilder.DropTable(
                name: "FilmScreeningPriceModifications");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SeatSectionLevelRooms");

            migrationBuilder.DropTable(
                name: "UserFilms");

            migrationBuilder.DropTable(
                name: "ClubMembers");

            migrationBuilder.DropTable(
                name: "FilmRols");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "PriceModifications");

            migrationBuilder.DropTable(
                name: "FilmScreenings");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
