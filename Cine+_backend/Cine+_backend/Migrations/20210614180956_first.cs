using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Income = table.Column<double>(type: "float", nullable: true),
                    Expense = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmRols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
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
                    Year = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PercentOfPriceIncrement = table.Column<int>(type: "int", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubMembers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMembers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ClubMembers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxOffice = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PaidByPoints = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmFilmRols",
                columns: table => new
                {
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmRolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberRol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserFilms",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilms", x => new { x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_UserFilms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
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
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Points = table.Column<double>(type: "float", nullable: false)
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
                    SeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "ClubMemberGenres",
                columns: table => new
                {
                    ClubMemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClubMemberUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubMemberGenres", x => new { x.ClubMemberId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_ClubMemberGenres_ClubMembers_ClubMemberUserId",
                        column: x => x.ClubMemberUserId,
                        principalTable: "ClubMembers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubMemberGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
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
                    Price = table.Column<double>(type: "float", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilmSreeningId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatSeatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeatRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_Items_SeatSectionLevelRooms_SeatSeatId_SeatSectionId_SeatLevelId_SeatRoomId",
                        columns: x => new { x.SeatSeatId, x.SeatSectionId, x.SeatLevelId, x.SeatRoomId },
                        principalTable: "SeatSectionLevelRooms",
                        principalColumns: new[] { "SeatId", "SectionId", "LevelId", "RoomId" },
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMemberGenres_ClubMemberUserId",
                table: "ClubMemberGenres",
                column: "ClubMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubMemberGenres_GenreId",
                table: "ClubMemberGenres",
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
                name: "IX_Items_SeatSeatId_SeatSectionId_SeatLevelId_SeatRoomId",
                table: "Items",
                columns: new[] { "SeatSeatId", "SeatSectionId", "SeatLevelId", "SeatRoomId" });

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookEntries");

            migrationBuilder.DropTable(
                name: "ClubMemberGenres");

            migrationBuilder.DropTable(
                name: "FilmFilmRols");

            migrationBuilder.DropTable(
                name: "FilmGenres");

            migrationBuilder.DropTable(
                name: "FilmScreeningPriceModifications");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Top10");

            migrationBuilder.DropTable(
                name: "UserFilms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
                name: "SeatSectionLevelRooms");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
