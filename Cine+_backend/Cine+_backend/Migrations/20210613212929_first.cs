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
                    Points = table.Column<int>(type: "int", nullable: false)
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
                    { new Guid("f4f94641-32c2-4d00-8157-f7c52276d501"), "Actor" },
                    { new Guid("43929ecd-3580-4232-b612-ed3e4bf1f2e5"), "Director" },
                    { new Guid("694b343a-651c-4d26-a1ec-de2bfbb60cb1"), "Productor" },
                    { new Guid("5e53563c-ff3d-4bc8-89c5-7285632e414a"), "Asistente de dirección" },
                    { new Guid("24f5cec2-cb5f-4911-8dad-713508f42ce4"), "Productor Ejecutivo" },
                    { new Guid("4a3424f8-a94f-4482-9528-bd4be8f47bcc"), "Guionista" },
                    { new Guid("aaeed7cb-f4b1-424e-9060-c8433effca53"), "Diseñador de Vestuario" },
                    { new Guid("7a054630-c0b1-4cdc-a00e-5677fbc3e2c4"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45a52ffa-4986-44b6-ba7f-a263bbe5ed03"), "Erótico" },
                    { new Guid("fd8b503c-d710-40be-a69e-f407e596c331"), "Aventura" },
                    { new Guid("cb93c231-b010-4578-92f6-cd2749bff0f0"), "Ciencia Ficción" },
                    { new Guid("eb5a9a56-4f44-47cd-b2c7-5dbf678038af"), "Ficción" },
                    { new Guid("016edee0-c8be-439a-93ac-e045e26c5a93"), "Documental" },
                    { new Guid("6c737276-013d-41da-9670-c7c397668ce6"), "Hístorico" },
                    { new Guid("d67651ea-2fd7-4190-bbcd-6d6e4e777cc3"), "Musical" },
                    { new Guid("c35d6c4d-f8c9-40ea-a041-0161692c7ac7"), "Terror" },
                    { new Guid("63933f23-5614-487d-b29a-0df40e72f9d2"), "Suspenso" },
                    { new Guid("cd594fa6-e8ef-48ef-b149-c03b99411c88"), "Romántica" },
                    { new Guid("364b4473-8557-436e-95c9-fc8ee21c79bd"), "Comedia" },
                    { new Guid("3ec56f1f-58a4-4e7a-8f01-0e37d5040e9d"), "Drama" },
                    { new Guid("8568ac9e-879b-409c-8b20-a60cf7f8289a"), "Tragicomedia" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), "Platea Baja", 10 },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), "Sala 1" },
                    { new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), "Sala 2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("97c5987c-31e6-4e0c-b3c4-dda7b355f8ee"), "C2" },
                    { new Guid("e820540b-c4be-48d2-9370-ebeb1a81a33a"), "C1" },
                    { new Guid("3e707d10-2d63-4d85-9936-cac9ebb4a49e"), "B3" },
                    { new Guid("d7be6509-1f5a-45ae-9ad4-bc4d8912c7d2"), "B2" },
                    { new Guid("8143cb11-9e5b-4c38-9d92-8d98244a38b3"), "B1" },
                    { new Guid("fb95ccea-45f0-4967-89fa-4cf376c4cf07"), "A3" },
                    { new Guid("85993d7a-6446-4e3b-805a-cfcc4b76ab44"), "G2" },
                    { new Guid("1ad89efb-0a07-4c86-8329-3d72f797e573"), "A1" },
                    { new Guid("4f27eb87-bf4e-438c-9bd3-def969df6864"), "H2" },
                    { new Guid("752fb550-cba8-468d-be45-4e1ef2e37d3e"), "H1" },
                    { new Guid("2aa59cb6-3fc8-431f-a1d4-a02203215999"), "G1" },
                    { new Guid("01d87621-db52-4588-9295-630973891600"), "C3" },
                    { new Guid("ec7c988c-df4a-43a6-ba8b-fd2e51f816dd"), "A2" },
                    { new Guid("2c6990c9-70eb-4fd3-a755-bf36d5466038"), "D1" },
                    { new Guid("720f53c8-efbd-4bdb-9348-6e497b13dee4"), "H2" },
                    { new Guid("5e663e65-941e-4b91-a4b3-470a4feef9ad"), "D3" },
                    { new Guid("1d06223a-0b1a-425d-8974-e302b6a8db0f"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("e05f4fa7-1eac-42c5-87e5-5516465f3478"), "E2" },
                    { new Guid("6f348193-010a-4b35-8506-741947ec1bd4"), "E3" },
                    { new Guid("a8b91922-e757-4b5d-b0ca-dcd45ebf00cc"), "F1" },
                    { new Guid("2eaf4512-f931-48a3-b84e-aff642092123"), "F2" },
                    { new Guid("d5c3b5c0-04fd-43bd-9807-7d4321c6db18"), "F3" },
                    { new Guid("bf91c188-2629-4227-84cf-5fbdaee38ca4"), "G1" },
                    { new Guid("bb3e9c7e-9a3f-4bfc-85a1-e1783eb9af79"), "G2" },
                    { new Guid("3cd41321-10be-43f0-a8a6-8f9736d4786f"), "G3" },
                    { new Guid("90342920-271e-4cac-8651-f4132665c22f"), "H1" },
                    { new Guid("45837956-bce2-4bb7-af15-2287b897cca3"), "F2" },
                    { new Guid("3b0462ff-d615-41d5-9120-c8ed40d9b4a6"), "H3" },
                    { new Guid("332672fe-f6fd-4cc4-b1eb-ee7bf3a1e013"), "A1" },
                    { new Guid("e755b3e8-3534-4b8b-9a50-637993f0785c"), "D2" },
                    { new Guid("20f546dc-03b0-412e-83aa-cb81edfbc651"), "F1" },
                    { new Guid("b6574280-d7a8-4ca2-8aca-db8d72c4ab4f"), "H1" },
                    { new Guid("8dce35ed-f963-4b7a-a16e-faf6dbd8f632"), "E1" },
                    { new Guid("29c04a06-92ed-4067-ad35-6274761f8e6e"), "A3" },
                    { new Guid("028ba911-a7c3-40a6-a57f-1198d8b7295a"), "B1" },
                    { new Guid("0de8b220-25dc-40c4-bb9b-76c9c17ae713"), "B2" },
                    { new Guid("420ad9be-4670-4b3c-9572-47693da74edc"), "B3" },
                    { new Guid("decf9cc1-6bdc-4c51-8f71-0d4495408ded"), "C1" },
                    { new Guid("d43aa1b0-eeac-48c7-9af0-92e2c233766d"), "C2" },
                    { new Guid("33214681-2e6a-43f0-a7a3-573508db33c1"), "C3" },
                    { new Guid("c498b4c6-4167-4c54-b0d2-f6b579298089"), "D1" },
                    { new Guid("a5e0fcca-8c49-425c-b385-2049e5ca3839"), "D2" },
                    { new Guid("7a7003b2-df38-45f6-a5bf-d0799ede02fa"), "D3" },
                    { new Guid("57165eac-7415-4b78-8f68-6a88ac483234"), "E1" },
                    { new Guid("86c1263e-9b66-42d0-a53a-fdd606cf27cf"), "E2" },
                    { new Guid("78412030-f433-45d9-8a74-b07964241eeb"), "E3" },
                    { new Guid("a7d0fce7-6922-4729-9023-d1e69d54f24b"), "F1" },
                    { new Guid("aba55142-fdb7-47d3-8fcb-468c6b75a8cf"), "E2" },
                    { new Guid("d5dfce58-ba4e-4655-855d-12390d263d82"), "F2" },
                    { new Guid("26f50d5c-e6bc-48fb-bc66-1abd34a57d68"), "G1" },
                    { new Guid("09dbbee4-a189-4f48-b7b5-2cd45e518ac9"), "G2" },
                    { new Guid("a4b68144-8206-4195-90c9-f52ed4e2cf1a"), "G3" },
                    { new Guid("251447c1-c563-4a29-a6ab-393b0124c3f7"), "B1" },
                    { new Guid("e55c27d6-76b7-47d3-8ad5-2c29ffce80b6"), "H2" },
                    { new Guid("552ab185-98ae-4894-8d2f-bf39b25dc218"), "H3" },
                    { new Guid("f9d1cf79-a57d-475d-8922-3df86c63e82e"), "A1" },
                    { new Guid("db8cd67a-201b-4eb1-86e1-a8b033d528e4"), "A2" },
                    { new Guid("528ff4de-a277-45f3-a7bf-75d87934c64b"), "B1" },
                    { new Guid("a2e5ce17-e8cf-4227-b894-75676ab8bea8"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("6231d8ba-037d-4d57-842a-c689a26b5b53"), "C1" },
                    { new Guid("7bc67426-4bfb-4ab2-902b-cc9d77f45ad3"), "C2" },
                    { new Guid("e2892633-dbf3-4a4c-a783-fb5988e4e25e"), "D1" },
                    { new Guid("c6415327-b5ed-497f-a7a8-489f2fa72878"), "D2" },
                    { new Guid("92593fb9-86eb-4366-a538-015870f14485"), "F3" },
                    { new Guid("21cbd736-e9bc-4023-9bae-caaa6e8eb4e7"), "B2" },
                    { new Guid("eb4d9637-798f-41a9-a218-95ce39a479f6"), "F1" },
                    { new Guid("a05da739-b393-43c0-bc39-3beadc75534d"), "C2" },
                    { new Guid("c45d6baf-99a8-433b-be7a-c0ad459dce23"), "D1" },
                    { new Guid("712fbaee-b952-4fd1-92aa-6ad448ecf75b"), "D2" },
                    { new Guid("5e7377d3-5417-442a-8245-87a084989c85"), "D3" },
                    { new Guid("cc8f48ed-4a30-4c16-a464-67d28fe4ae7c"), "D4" },
                    { new Guid("ba722e4c-e22b-4553-9133-a0cd4bc7cac2"), "E1" },
                    { new Guid("8a0030e6-f1e7-49fc-85e3-fefd26a9e6a9"), "E2" },
                    { new Guid("ffccc01c-7f44-45f2-a529-250dd6d461f7"), "E3" },
                    { new Guid("06fd58b5-f014-44dc-910b-0cae553dc577"), "F1" },
                    { new Guid("6b17d39b-69f7-4ec6-be84-7da9e4b5d40f"), "F2" },
                    { new Guid("907d4183-fefc-4712-86b8-359d41b027f1"), "A1" },
                    { new Guid("e0a867eb-ca04-4685-a4e1-864c456cd825"), "B1" },
                    { new Guid("920fa4c7-1465-4ba4-883f-7f8a41e16824"), "B2" },
                    { new Guid("5a56a9ad-7df8-4042-9836-64d1c3452245"), "C1" },
                    { new Guid("10aad891-5e1f-4f81-8412-e55a4f7aed95"), "C2" },
                    { new Guid("4b07ace0-70ae-4f92-a7a0-a1efba78b7d1"), "C5" },
                    { new Guid("c83efb5f-d2cb-43a2-94fe-878aa5d58b68"), "C3" },
                    { new Guid("9373cbbb-d778-4a01-b74d-5b989f227347"), "D2" },
                    { new Guid("a8094dda-7f8d-4826-b8d5-8f99f8023714"), "D3" },
                    { new Guid("5d09ee42-50a1-4f2e-a447-94c5c0d7d44c"), "D4" },
                    { new Guid("38796e3c-fa11-43eb-bd90-0f35bf7b5957"), "E1" },
                    { new Guid("188fa128-cbb0-48e1-923a-50a6efb81f33"), "E2" },
                    { new Guid("ffec3e51-1a59-4871-af8d-f25b9a39f830"), "E3" },
                    { new Guid("e8b7c141-2a3e-4dc0-a6b2-cdae6ce0ae42"), "E4" },
                    { new Guid("538a9f08-16f4-4169-a462-6be91fab859a"), "E5" },
                    { new Guid("12c193b9-e146-4a2d-bfc7-4e260afc911a"), "F1" },
                    { new Guid("245738fc-1618-438d-a004-812d5dacf989"), "F2" },
                    { new Guid("76c426fc-1839-4614-9496-ef703af48e5d"), "F3" },
                    { new Guid("dfccc643-c756-471c-916c-a797d51ddf2a"), "F4" },
                    { new Guid("d65ecad5-4613-4f8f-ad19-c5ea055a146c"), "F5" },
                    { new Guid("8dde50a8-2233-4e9a-a88e-f2f8a38d7a42"), "F6" },
                    { new Guid("86d47af6-dd1c-4b24-931a-b4b77fded0fa"), "D1" },
                    { new Guid("a8b5496d-d3fe-45ca-b6b9-b02216a5a65d"), "C1" },
                    { new Guid("ad2ad082-8e01-4ff6-ac21-f318a1253a03"), "C4" },
                    { new Guid("7dfb0174-b2a8-4dc5-a8c0-e6288c6e5edb"), "C2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("9b688581-8310-4530-ba49-49b89187f818"), "C3" },
                    { new Guid("d702dd5c-1402-42d9-8681-6401b878cecb"), "D1" },
                    { new Guid("0412b8f5-c15a-4b5b-acb9-fe26f9d45645"), "D2" },
                    { new Guid("6619ca1b-d0f5-4393-8cb6-426000484595"), "D3" },
                    { new Guid("b899967c-1e05-427a-b1e8-966505170985"), "D4" },
                    { new Guid("35254b71-7cab-497e-ac32-4fed099ada33"), "E1" },
                    { new Guid("031c5d10-806b-4b35-abbf-4f7891d4f608"), "E2" },
                    { new Guid("6d1a84f0-4239-4ddd-8117-3a38afcfce1b"), "E3" },
                    { new Guid("0d39a9b6-12ea-4b37-aaa8-a6d8b87ca4fd"), "E4" },
                    { new Guid("be0a8e15-6c98-44be-87ff-fa86c2bf3eac"), "E5" },
                    { new Guid("6edd391c-6295-4fcb-98a5-03925b1419ac"), "A2" },
                    { new Guid("0d02a955-8101-4f07-8bf1-cfdf0688aedc"), "F2" },
                    { new Guid("3c57e63e-15e3-40af-946f-db1114bcaea3"), "F3" },
                    { new Guid("b7b8c5f5-70de-4cfa-b5dc-623f72e99b9c"), "F4" },
                    { new Guid("c729d1c8-3ead-4511-ab24-e903746c3669"), "C3" },
                    { new Guid("31911159-f563-4b72-8410-3f26bf49841d"), "F5" },
                    { new Guid("7f037393-b147-4687-bcce-9b6cb4b9c7e4"), "A1" },
                    { new Guid("7ba5ad3f-a159-46fb-abbf-2be5d6504b9f"), "A2" },
                    { new Guid("44d0b2b5-2634-4879-8e43-6eea8ba72fa3"), "A3" },
                    { new Guid("14a85633-c646-4838-9d36-f96c9bfcbb84"), "A4" },
                    { new Guid("2da9f508-6b47-48b6-bb2a-4235bb79f9b1"), "A5" },
                    { new Guid("4303d554-3d46-45ca-b80c-2899f798841b"), "A6" },
                    { new Guid("da1dd098-95d1-4c6e-b945-26cdb349095f"), "A7" },
                    { new Guid("6c3a46f5-6196-40f2-95b9-7e7fa933cf72"), "B1" },
                    { new Guid("b1893d97-2573-4afc-a9c9-d8ca378899dd"), "B2" },
                    { new Guid("861b5941-db66-47ca-b69f-79ce6a4b046c"), "B3" },
                    { new Guid("a9f0f470-b06c-4cf6-a5ba-a593b402ce1d"), "B4" },
                    { new Guid("20bf099f-60d5-4a5a-b397-b9f4cee82437"), "B5" },
                    { new Guid("fa2f8111-ad02-440c-b943-b43a89a2c6e0"), "B6" },
                    { new Guid("b2138600-a0d9-4bfd-89f2-d610762f3d30"), "C1" },
                    { new Guid("3bcc6ec2-1a51-429b-8119-aab29d3486f2"), "F6" },
                    { new Guid("3e6fd6ee-b5aa-4972-a35e-41dddacc4277"), "A1" },
                    { new Guid("3e04c882-6e49-4da6-b37b-86f641408b11"), "D4" },
                    { new Guid("7e8ee0fb-2846-445c-98eb-6bb0bf7accf3"), "F5" },
                    { new Guid("d56c1007-635b-46de-bad4-d15d69580f21"), "F1" },
                    { new Guid("501a7818-3e83-425b-bebc-7985047e1d1d"), "F2" },
                    { new Guid("87210ca2-4d30-4d26-a44e-5ded53a08a89"), "G1" },
                    { new Guid("4870e8f5-9e3b-4ff8-963d-128421662017"), "G2" },
                    { new Guid("9aba0a17-4a71-484b-961a-c859be234d95"), "H1" },
                    { new Guid("b5da63eb-7bde-4c17-9eaa-6fe0b7ddc7c5"), "H2" },
                    { new Guid("95b575ac-6369-4369-98ed-b269ea31f13b"), "A1" },
                    { new Guid("fa036c5c-9af4-4773-82ec-6a70e9a21ee7"), "A2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("c3b78c3e-f3c7-45ad-8db1-5f6d4141edc0"), "A3" },
                    { new Guid("8d2531db-5e4f-4231-a7e2-abbbfd7fb957"), "B1" },
                    { new Guid("28e9500c-9032-4f66-8786-93aa066fdc8e"), "B2" },
                    { new Guid("cfa88ac4-56e2-4fc9-9319-14d19109444b"), "B3" },
                    { new Guid("0f5f64d4-63c0-4d62-9655-47b5ca0e635a"), "C1" },
                    { new Guid("fe7aab8f-45d4-42de-bf30-26aeaf5cabe4"), "C2" },
                    { new Guid("1cd28f49-de34-489e-b324-3db3ebbef53a"), "C3" },
                    { new Guid("a93f6023-abf4-4224-b8cb-7530de20f966"), "D1" },
                    { new Guid("1c3edf23-f97c-4c2f-b147-5300427d185d"), "D2" },
                    { new Guid("a0446be8-59f7-407d-a3e8-75edabbe953f"), "D3" },
                    { new Guid("9f59d39a-0f0b-4abd-a0c8-45b0de7ab92f"), "E1" },
                    { new Guid("11cd4ece-4695-4614-910e-6935cf3ed63c"), "E2" },
                    { new Guid("94c3a62d-bc95-4196-8d4e-06a42967ac28"), "E3" },
                    { new Guid("2b47770a-7cf2-43df-8751-06f2bc909444"), "F1" },
                    { new Guid("26b82fed-b85a-4f1e-94f5-61b72b5adee7"), "F2" },
                    { new Guid("a9dccad5-e585-4d29-98d9-bfd937540324"), "F3" },
                    { new Guid("ff0475d7-e691-47c4-bc9d-fc546a8f4eb8"), "G1" },
                    { new Guid("d317f22c-19ac-47e2-94c4-78d4407e6bb9"), "G2" },
                    { new Guid("8bb1ffa4-3fee-481d-a1fa-32822b161fb5"), "G3" },
                    { new Guid("d3e4da3a-48a6-4af6-8d4b-e80dae6a0bb5"), "H1" },
                    { new Guid("119f0fe2-5a08-4ce2-8b5f-3aafb412d02f"), "H2" },
                    { new Guid("5728166a-7484-4195-8c05-40a65ae8ae47"), "E2" },
                    { new Guid("6c9afc8a-6e69-4810-b3f8-2355d3ae2a3d"), "E1" },
                    { new Guid("add2ba35-55c0-4ef0-b31f-b6c4824585d2"), "D2" },
                    { new Guid("46f93ab6-971b-47b2-af35-64c1318ae18d"), "D1" },
                    { new Guid("8101f1bf-0b25-4c5e-b1e1-7be26ea7c972"), "A1" },
                    { new Guid("fd020f91-8312-4804-bbc4-66ad70fd1846"), "A2" },
                    { new Guid("f5acc70e-f032-4eb4-af95-c6bac1e70708"), "A3" },
                    { new Guid("f97f7d26-f2e5-4c3e-8f82-174231860749"), "B1" },
                    { new Guid("ee160b8a-644c-4ab4-ad65-44e113852be2"), "B2" },
                    { new Guid("04df8502-20fb-49a8-86d5-db543aacab3e"), "B3" },
                    { new Guid("758db4a7-c7d3-4fd1-af7f-8d8559e0e8a7"), "C1" },
                    { new Guid("531de3e5-7a57-4820-949c-211b0ed673f9"), "C2" },
                    { new Guid("8ac100e0-3186-404c-9998-011435088d4a"), "C3" },
                    { new Guid("0793f027-6909-416c-a0b8-1bb35bd18afb"), "D1" },
                    { new Guid("96f9a67d-e61a-4307-a208-01ffaf6b4c85"), "D2" },
                    { new Guid("7475f123-1cfe-4a78-8cc8-d3595d102c80"), "D3" },
                    { new Guid("90c7595e-5177-4638-8c1b-767a6a7e3338"), "E1" },
                    { new Guid("a93d1683-98d6-43c0-a9cf-672b0248fe67"), "E2" },
                    { new Guid("86460a77-7416-4f62-ba31-0e2bab768e4b"), "H3" },
                    { new Guid("0c8dae90-9cac-4eb6-a0d8-2a65bf6440f8"), "E3" },
                    { new Guid("075296f1-abf1-448d-a3b3-84e9d8b1eae5"), "F2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("fab25446-6713-480c-a176-ecd4d979f1e8"), "F3" },
                    { new Guid("0ebf1ec6-ad1c-4582-901e-f003c94be6e6"), "G1" },
                    { new Guid("063ee51f-3684-4106-acaa-b55a476ba023"), "G2" },
                    { new Guid("6738616d-d974-44c8-b2f2-5ce44d6c72e5"), "G3" },
                    { new Guid("a9693689-975b-48e3-b063-eef2337643e9"), "H1" },
                    { new Guid("e41d5752-86de-4849-9090-686df9a62aa8"), "H2" },
                    { new Guid("c69eb3d7-a35d-44ae-b5d2-b4dadd603cd7"), "H3" },
                    { new Guid("10c22650-6f31-4ccf-856d-7072b42d92ed"), "A1" },
                    { new Guid("4788df1c-dece-40b3-ab60-1d058d01d2a2"), "A2" },
                    { new Guid("0f60e194-6447-4807-8cc6-3b7d16fb79be"), "B1" },
                    { new Guid("fd25f3d3-e9d4-4c77-93f6-73d91f6fcd58"), "B2" },
                    { new Guid("e65ab9a2-27a8-4d77-90fb-15218bb25451"), "C1" },
                    { new Guid("1fe39665-929a-48d5-bbe1-20d9a2d9d5dd"), "C2" },
                    { new Guid("de17ebac-7a82-42b9-9f46-6146508715ba"), "F1" },
                    { new Guid("5f645a17-88b9-4bc3-b1c0-ec3c6ba9ed1a"), "F6" },
                    { new Guid("46d8d1a0-c61a-4fb7-9b99-ab0658c77b7c"), "A1" },
                    { new Guid("033a5da9-a4d9-4839-a4c5-d240f6804e05"), "B2" },
                    { new Guid("12027c0a-42f7-41ff-aca3-6a5a897dfc4e"), "C4" },
                    { new Guid("7d4bcd86-11d0-45b3-b808-693b7be4b226"), "C5" },
                    { new Guid("b900708f-fa59-4d0b-9980-933735715241"), "D1" },
                    { new Guid("01bc3f04-2e06-4b51-aac1-876addc2e0de"), "D2" },
                    { new Guid("81f6a260-474e-4f58-ae13-dd72be049633"), "D3" },
                    { new Guid("27ab65af-c8bd-45b0-a750-7be6f36bac0b"), "D4" },
                    { new Guid("058d9170-d1be-49bb-947c-0f2448a0045a"), "E1" },
                    { new Guid("f64fa449-5d28-43e9-9802-269e409f0ca2"), "E2" },
                    { new Guid("25f9a155-f5e8-4af5-b1f1-0d5fada3a2f2"), "E3" },
                    { new Guid("c1b20300-e07e-44b8-b5cc-76e21a16d3da"), "F1" },
                    { new Guid("4d79b9e6-bb7c-49ea-9f9f-8f5ff4b81a8f"), "F2" },
                    { new Guid("d5408e2f-1034-4d46-911b-8a04728f65f3"), "A1" },
                    { new Guid("3367cc0a-5a96-478d-badc-70b6ecb7ada4"), "B1" },
                    { new Guid("f7c404b1-3d3f-4626-a9c5-d355bad52b96"), "B2" },
                    { new Guid("6a84bf53-edb7-46c9-90b4-7cb159b9d053"), "C1" },
                    { new Guid("2dbf2b30-c60a-4a6d-b4ff-54c94108fa73"), "C2" },
                    { new Guid("61c71dcc-6497-494c-8dc0-de7dde7d6771"), "C3" },
                    { new Guid("92da8836-980e-4f1e-8de6-6bf84be86623"), "D1" },
                    { new Guid("aef7df62-843e-4a64-a79b-b588e253c092"), "D2" },
                    { new Guid("ba5a257f-bf1f-47f0-858f-918e8448bccb"), "D3" },
                    { new Guid("6ed3b8c0-96bb-40cd-b502-e820723b1b6a"), "E1" },
                    { new Guid("913bb486-8c99-441b-9399-f207a6e5e3ba"), "E2" },
                    { new Guid("af8c10af-d0a1-42d4-93d5-1dfb12faee2e"), "E3" },
                    { new Guid("7cd3aadd-eea6-40fe-9f03-58f870b57871"), "E4" },
                    { new Guid("cedcb10f-4e2c-4f89-bb15-1a839faa261b"), "E5" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("1dec16a3-223e-431d-823b-c7226da38996"), "F1" },
                    { new Guid("bd9dd1a5-6b83-4828-b8f6-8f0355d22d99"), "F2" },
                    { new Guid("3098b585-d6cc-4489-a10a-7ee5771031f2"), "F3" },
                    { new Guid("f6630e22-3ff1-4af5-b7a1-0634080551fc"), "F4" },
                    { new Guid("7dd733ac-ae80-4faf-9f2e-d542f5d32d53"), "C3" },
                    { new Guid("687607f8-fa87-4e31-86a1-50c1135a54c9"), "B1" },
                    { new Guid("90d001c4-d053-475a-a0ea-06a5fb7958e6"), "C2" },
                    { new Guid("d9cde7cf-77da-4bee-ab15-9a42865ce290"), "B6" },
                    { new Guid("387f3cd0-3cee-4d7d-98f6-dc870649fc53"), "C1" },
                    { new Guid("5b963798-f1c7-47cc-a29c-c09ac256e0bc"), "C2" },
                    { new Guid("05417f16-bfa5-45bb-a837-bd9778bc5e40"), "C3" },
                    { new Guid("daee108a-a390-42b8-b55b-92e794b9b418"), "D1" },
                    { new Guid("00939fe4-21eb-4589-a6e2-0cc8b7f02810"), "D2" },
                    { new Guid("063dc022-46c2-4337-a691-08ba3e11dcff"), "D3" },
                    { new Guid("3eb1e3ea-b401-48eb-896d-65f13c81d30b"), "D4" },
                    { new Guid("6440bf89-a1ef-46b0-a1c7-38d0f620e0a7"), "E1" },
                    { new Guid("530b813c-2edd-474d-8201-16eeade21a0c"), "E2" },
                    { new Guid("ab55cab5-7c95-4707-8eea-a2e07534ddd9"), "E3" },
                    { new Guid("4ef94ab0-35f9-4a0a-af4f-1a3eb96a6ce9"), "E4" },
                    { new Guid("58188110-f459-4dc6-aeb4-da829eb3a866"), "E5" },
                    { new Guid("a4e9623a-40c0-4126-a7f2-8f2f5fac6281"), "F1" },
                    { new Guid("e3152034-c1d5-4415-8a05-7664b8037665"), "C1" },
                    { new Guid("87368e14-4614-40e9-8970-0f4b8177bca1"), "F3" },
                    { new Guid("198d4e2e-5c6a-41db-a88a-17d5e950405e"), "F2" },
                    { new Guid("c1dc5776-eb7a-4c6c-a9c7-ce5fd52a357e"), "F5" },
                    { new Guid("bd594121-be10-4061-ab43-9d32186173f4"), "B5" },
                    { new Guid("e8c56551-c8b6-4087-b2a7-b4308d2103e8"), "B4" },
                    { new Guid("94540a99-37b6-4904-bb2a-31bbbdcda73f"), "B3" },
                    { new Guid("87aad985-f932-46f4-9f6a-e4b7625a8ed3"), "B2" },
                    { new Guid("59d48bd3-da0b-4a9d-b4fb-1e35c4114ddb"), "B1" },
                    { new Guid("78f0ca91-126a-496f-9476-13d9a5f9973b"), "A7" },
                    { new Guid("c4594bef-344d-4244-a3f4-02ff35e47180"), "F4" },
                    { new Guid("69e2a971-f0b3-4629-9e59-549c64220208"), "A6" },
                    { new Guid("bfa2022b-8042-493c-96c4-3811aab4b165"), "A4" },
                    { new Guid("01a65e4e-5951-4f7a-87da-06fb13955ea4"), "A3" },
                    { new Guid("d962b84f-0465-4dfb-b281-d35bb9e7cc5f"), "A2" },
                    { new Guid("a166b344-e865-4534-aed8-8c7b20b1537d"), "A1" },
                    { new Guid("f93e382b-4a4a-4bee-b0e6-782460427d05"), "F6" },
                    { new Guid("f674ae61-37d7-4966-8052-b5a76a9632f8"), "A5" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974"), "Sección 2" },
                    { new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f"), "Sección 1" },
                    { new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("8101f1bf-0b25-4c5e-b1e1-7be26ea7c972"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("712fbaee-b952-4fd1-92aa-6ad448ecf75b"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("5e7377d3-5417-442a-8245-87a084989c85"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("cc8f48ed-4a30-4c16-a464-67d28fe4ae7c"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("ba722e4c-e22b-4553-9133-a0cd4bc7cac2"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("8a0030e6-f1e7-49fc-85e3-fefd26a9e6a9"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("ffccc01c-7f44-45f2-a529-250dd6d461f7"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("06fd58b5-f014-44dc-910b-0cae553dc577"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6b17d39b-69f7-4ec6-be84-7da9e4b5d40f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("95b575ac-6369-4369-98ed-b269ea31f13b"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("fa036c5c-9af4-4773-82ec-6a70e9a21ee7"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("c3b78c3e-f3c7-45ad-8db1-5f6d4141edc0"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("8d2531db-5e4f-4231-a7e2-abbbfd7fb957"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("28e9500c-9032-4f66-8786-93aa066fdc8e"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("cfa88ac4-56e2-4fc9-9319-14d19109444b"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("0f5f64d4-63c0-4d62-9655-47b5ca0e635a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("fe7aab8f-45d4-42de-bf30-26aeaf5cabe4"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("1cd28f49-de34-489e-b324-3db3ebbef53a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a93f6023-abf4-4224-b8cb-7530de20f966"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("1c3edf23-f97c-4c2f-b147-5300427d185d"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a0446be8-59f7-407d-a3e8-75edabbe953f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("9f59d39a-0f0b-4abd-a0c8-45b0de7ab92f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("11cd4ece-4695-4614-910e-6935cf3ed63c"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("94c3a62d-bc95-4196-8d4e-06a42967ac28"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("2b47770a-7cf2-43df-8751-06f2bc909444"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("26b82fed-b85a-4f1e-94f5-61b72b5adee7"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a9dccad5-e585-4d29-98d9-bfd937540324"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("ff0475d7-e691-47c4-bc9d-fc546a8f4eb8"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d317f22c-19ac-47e2-94c4-78d4407e6bb9"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("8bb1ffa4-3fee-481d-a1fa-32822b161fb5"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("c45d6baf-99a8-433b-be7a-c0ad459dce23"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d3e4da3a-48a6-4af6-8d4b-e80dae6a0bb5"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("4b07ace0-70ae-4f92-a7a0-a1efba78b7d1"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("c729d1c8-3ead-4511-ab24-e903746c3669"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("528ff4de-a277-45f3-a7bf-75d87934c64b"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a2e5ce17-e8cf-4227-b894-75676ab8bea8"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6231d8ba-037d-4d57-842a-c689a26b5b53"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("7bc67426-4bfb-4ab2-902b-cc9d77f45ad3"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e2892633-dbf3-4a4c-a783-fb5988e4e25e"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("c6415327-b5ed-497f-a7a8-489f2fa72878"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("8dce35ed-f963-4b7a-a16e-faf6dbd8f632"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("aba55142-fdb7-47d3-8fcb-468c6b75a8cf"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("20f546dc-03b0-412e-83aa-cb81edfbc651"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("45837956-bce2-4bb7-af15-2287b897cca3"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("2aa59cb6-3fc8-431f-a1d4-a02203215999"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("85993d7a-6446-4e3b-805a-cfcc4b76ab44"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("752fb550-cba8-468d-be45-4e1ef2e37d3e"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("4f27eb87-bf4e-438c-9bd3-def969df6864"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("7f037393-b147-4687-bcce-9b6cb4b9c7e4"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("7ba5ad3f-a159-46fb-abbf-2be5d6504b9f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("44d0b2b5-2634-4879-8e43-6eea8ba72fa3"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("14a85633-c646-4838-9d36-f96c9bfcbb84"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("2da9f508-6b47-48b6-bb2a-4235bb79f9b1"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("4303d554-3d46-45ca-b80c-2899f798841b"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("da1dd098-95d1-4c6e-b945-26cdb349095f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6c3a46f5-6196-40f2-95b9-7e7fa933cf72"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("b1893d97-2573-4afc-a9c9-d8ca378899dd"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("861b5941-db66-47ca-b69f-79ce6a4b046c"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a9f0f470-b06c-4cf6-a5ba-a593b402ce1d"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("20bf099f-60d5-4a5a-b397-b9f4cee82437"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("fa2f8111-ad02-440c-b943-b43a89a2c6e0"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("b2138600-a0d9-4bfd-89f2-d610762f3d30"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("7dfb0174-b2a8-4dc5-a8c0-e6288c6e5edb"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("ad2ad082-8e01-4ff6-ac21-f318a1253a03"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("119f0fe2-5a08-4ce2-8b5f-3aafb412d02f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("86460a77-7416-4f62-ba31-0e2bab768e4b"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d5408e2f-1034-4d46-911b-8a04728f65f3"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6f348193-010a-4b35-8506-741947ec1bd4"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a8b91922-e757-4b5d-b0ca-dcd45ebf00cc"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("2eaf4512-f931-48a3-b84e-aff642092123"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d5c3b5c0-04fd-43bd-9807-7d4321c6db18"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("bf91c188-2629-4227-84cf-5fbdaee38ca4"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("bb3e9c7e-9a3f-4bfc-85a1-e1783eb9af79"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3cd41321-10be-43f0-a8a6-8f9736d4786f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("90342920-271e-4cac-8651-f4132665c22f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("720f53c8-efbd-4bdb-9348-6e497b13dee4"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3b0462ff-d615-41d5-9120-c8ed40d9b4a6"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("907d4183-fefc-4712-86b8-359d41b027f1"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e0a867eb-ca04-4685-a4e1-864c456cd825"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("920fa4c7-1465-4ba4-883f-7f8a41e16824"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("5a56a9ad-7df8-4042-9836-64d1c3452245"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("10aad891-5e1f-4f81-8412-e55a4f7aed95"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("c83efb5f-d2cb-43a2-94fe-878aa5d58b68"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("86d47af6-dd1c-4b24-931a-b4b77fded0fa"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("9373cbbb-d778-4a01-b74d-5b989f227347"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a8094dda-7f8d-4826-b8d5-8f99f8023714"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("5d09ee42-50a1-4f2e-a447-94c5c0d7d44c"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("38796e3c-fa11-43eb-bd90-0f35bf7b5957"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("188fa128-cbb0-48e1-923a-50a6efb81f33"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("ffec3e51-1a59-4871-af8d-f25b9a39f830"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e8b7c141-2a3e-4dc0-a6b2-cdae6ce0ae42"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("538a9f08-16f4-4169-a462-6be91fab859a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("12c193b9-e146-4a2d-bfc7-4e260afc911a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("245738fc-1618-438d-a004-812d5dacf989"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("76c426fc-1839-4614-9496-ef703af48e5d"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("dfccc643-c756-471c-916c-a797d51ddf2a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e05f4fa7-1eac-42c5-87e5-5516465f3478"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("1d06223a-0b1a-425d-8974-e302b6a8db0f"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("5e663e65-941e-4b91-a4b3-470a4feef9ad"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e755b3e8-3534-4b8b-9a50-637993f0785c"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("3367cc0a-5a96-478d-badc-70b6ecb7ada4"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f7c404b1-3d3f-4626-a9c5-d355bad52b96"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("6a84bf53-edb7-46c9-90b4-7cb159b9d053"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("2dbf2b30-c60a-4a6d-b4ff-54c94108fa73"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("61c71dcc-6497-494c-8dc0-de7dde7d6771"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("92da8836-980e-4f1e-8de6-6bf84be86623"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("aef7df62-843e-4a64-a79b-b588e253c092"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("ba5a257f-bf1f-47f0-858f-918e8448bccb"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("3e04c882-6e49-4da6-b37b-86f641408b11"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("6ed3b8c0-96bb-40cd-b502-e820723b1b6a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("913bb486-8c99-441b-9399-f207a6e5e3ba"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("af8c10af-d0a1-42d4-93d5-1dfb12faee2e"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("7cd3aadd-eea6-40fe-9f03-58f870b57871"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("cedcb10f-4e2c-4f89-bb15-1a839faa261b"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("db8cd67a-201b-4eb1-86e1-a8b033d528e4"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("1dec16a3-223e-431d-823b-c7226da38996"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("3098b585-d6cc-4489-a10a-7ee5771031f2"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f6630e22-3ff1-4af5-b7a1-0634080551fc"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("7e8ee0fb-2846-445c-98eb-6bb0bf7accf3"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("5f645a17-88b9-4bc3-b1c0-ec3c6ba9ed1a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("1ad89efb-0a07-4c86-8329-3d72f797e573"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("ec7c988c-df4a-43a6-ba8b-fd2e51f816dd"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("fb95ccea-45f0-4967-89fa-4cf376c4cf07"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("8143cb11-9e5b-4c38-9d92-8d98244a38b3"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d7be6509-1f5a-45ae-9ad4-bc4d8912c7d2"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3e707d10-2d63-4d85-9936-cac9ebb4a49e"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e820540b-c4be-48d2-9370-ebeb1a81a33a"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("97c5987c-31e6-4e0c-b3c4-dda7b355f8ee"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("01d87621-db52-4588-9295-630973891600"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("2c6990c9-70eb-4fd3-a755-bf36d5466038"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("bd9dd1a5-6b83-4828-b8f6-8f0355d22d99"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("f9d1cf79-a57d-475d-8922-3df86c63e82e"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("4d79b9e6-bb7c-49ea-9f9f-8f5ff4b81a8f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("c1b20300-e07e-44b8-b5cc-76e21a16d3da"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("530b813c-2edd-474d-8201-16eeade21a0c"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("ab55cab5-7c95-4707-8eea-a2e07534ddd9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("4ef94ab0-35f9-4a0a-af4f-1a3eb96a6ce9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("58188110-f459-4dc6-aeb4-da829eb3a866"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a4e9623a-40c0-4126-a7f2-8f2f5fac6281"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("198d4e2e-5c6a-41db-a88a-17d5e950405e"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("87368e14-4614-40e9-8970-0f4b8177bca1"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("c4594bef-344d-4244-a3f4-02ff35e47180"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("c1dc5776-eb7a-4c6c-a9c7-ce5fd52a357e"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f93e382b-4a4a-4bee-b0e6-782460427d05"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3e6fd6ee-b5aa-4972-a35e-41dddacc4277"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6edd391c-6295-4fcb-98a5-03925b1419ac"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("29c04a06-92ed-4067-ad35-6274761f8e6e"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("028ba911-a7c3-40a6-a57f-1198d8b7295a"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("0de8b220-25dc-40c4-bb9b-76c9c17ae713"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("420ad9be-4670-4b3c-9572-47693da74edc"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("decf9cc1-6bdc-4c51-8f71-0d4495408ded"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d43aa1b0-eeac-48c7-9af0-92e2c233766d"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("33214681-2e6a-43f0-a7a3-573508db33c1"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("c498b4c6-4167-4c54-b0d2-f6b579298089"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a5e0fcca-8c49-425c-b385-2049e5ca3839"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("7a7003b2-df38-45f6-a5bf-d0799ede02fa"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("57165eac-7415-4b78-8f68-6a88ac483234"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("86c1263e-9b66-42d0-a53a-fdd606cf27cf"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("78412030-f433-45d9-8a74-b07964241eeb"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a7d0fce7-6922-4729-9023-d1e69d54f24b"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d5dfce58-ba4e-4655-855d-12390d263d82"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("92593fb9-86eb-4366-a538-015870f14485"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("26f50d5c-e6bc-48fb-bc66-1abd34a57d68"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("6440bf89-a1ef-46b0-a1c7-38d0f620e0a7"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("3eb1e3ea-b401-48eb-896d-65f13c81d30b"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("063dc022-46c2-4337-a691-08ba3e11dcff"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("00939fe4-21eb-4589-a6e2-0cc8b7f02810"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("fd020f91-8312-4804-bbc4-66ad70fd1846"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f5acc70e-f032-4eb4-af95-c6bac1e70708"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f97f7d26-f2e5-4c3e-8f82-174231860749"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("ee160b8a-644c-4ab4-ad65-44e113852be2"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("04df8502-20fb-49a8-86d5-db543aacab3e"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("758db4a7-c7d3-4fd1-af7f-8d8559e0e8a7"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("531de3e5-7a57-4820-949c-211b0ed673f9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("8ac100e0-3186-404c-9998-011435088d4a"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("0793f027-6909-416c-a0b8-1bb35bd18afb"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("96f9a67d-e61a-4307-a208-01ffaf6b4c85"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("7475f123-1cfe-4a78-8cc8-d3595d102c80"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("90c7595e-5177-4638-8c1b-767a6a7e3338"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a93d1683-98d6-43c0-a9cf-672b0248fe67"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("0c8dae90-9cac-4eb6-a0d8-2a65bf6440f8"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("09dbbee4-a189-4f48-b7b5-2cd45e518ac9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("de17ebac-7a82-42b9-9f46-6146508715ba"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("fab25446-6713-480c-a176-ecd4d979f1e8"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("0ebf1ec6-ad1c-4582-901e-f003c94be6e6"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("063ee51f-3684-4106-acaa-b55a476ba023"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("6738616d-d974-44c8-b2f2-5ce44d6c72e5"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a9693689-975b-48e3-b063-eef2337643e9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("e41d5752-86de-4849-9090-686df9a62aa8"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("c69eb3d7-a35d-44ae-b5d2-b4dadd603cd7"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("46d8d1a0-c61a-4fb7-9b99-ab0658c77b7c"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("687607f8-fa87-4e31-86a1-50c1135a54c9"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("033a5da9-a4d9-4839-a4c5-d240f6804e05"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("387f3cd0-3cee-4d7d-98f6-dc870649fc53"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("5b963798-f1c7-47cc-a29c-c09ac256e0bc"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("05417f16-bfa5-45bb-a837-bd9778bc5e40"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("daee108a-a390-42b8-b55b-92e794b9b418"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("075296f1-abf1-448d-a3b3-84e9d8b1eae5"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d65ecad5-4613-4f8f-ad19-c5ea055a146c"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a4b68144-8206-4195-90c9-f52ed4e2cf1a"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("e55c27d6-76b7-47d3-8ad5-2c29ffce80b6"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("87210ca2-4d30-4d26-a44e-5ded53a08a89"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("4870e8f5-9e3b-4ff8-963d-128421662017"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("9aba0a17-4a71-484b-961a-c859be234d95"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("b5da63eb-7bde-4c17-9eaa-6fe0b7ddc7c5"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("a166b344-e865-4534-aed8-8c7b20b1537d"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d962b84f-0465-4dfb-b281-d35bb9e7cc5f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("01a65e4e-5951-4f7a-87da-06fb13955ea4"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("bfa2022b-8042-493c-96c4-3811aab4b165"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f674ae61-37d7-4966-8052-b5a76a9632f8"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("69e2a971-f0b3-4629-9e59-549c64220208"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("78f0ca91-126a-496f-9476-13d9a5f9973b"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("59d48bd3-da0b-4a9d-b4fb-1e35c4114ddb"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("87aad985-f932-46f4-9f6a-e4b7625a8ed3"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("94540a99-37b6-4904-bb2a-31bbbdcda73f"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("e8c56551-c8b6-4087-b2a7-b4308d2103e8"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("bd594121-be10-4061-ab43-9d32186173f4"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d9cde7cf-77da-4bee-ab15-9a42865ce290"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("e3152034-c1d5-4415-8a05-7664b8037665"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("90d001c4-d053-475a-a0ea-06a5fb7958e6"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("7dd733ac-ae80-4faf-9f2e-d542f5d32d53"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("12027c0a-42f7-41ff-aca3-6a5a897dfc4e"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("7d4bcd86-11d0-45b3-b808-693b7be4b226"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("b900708f-fa59-4d0b-9980-933735715241"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("01bc3f04-2e06-4b51-aac1-876addc2e0de"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("81f6a260-474e-4f58-ae13-dd72be049633"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("27ab65af-c8bd-45b0-a750-7be6f36bac0b"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("058d9170-d1be-49bb-947c-0f2448a0045a"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("f64fa449-5d28-43e9-9802-269e409f0ca2"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("25f9a155-f5e8-4af5-b1f1-0d5fada3a2f2"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("501a7818-3e83-425b-bebc-7985047e1d1d"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("d56c1007-635b-46de-bad4-d15d69580f21"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("5728166a-7484-4195-8c05-40a65ae8ae47"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("6c9afc8a-6e69-4810-b3f8-2355d3ae2a3d"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("552ab185-98ae-4894-8d2f-bf39b25dc218"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("332672fe-f6fd-4cc4-b1eb-ee7bf3a1e013"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("251447c1-c563-4a29-a6ab-393b0124c3f7"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("21cbd736-e9bc-4023-9bae-caaa6e8eb4e7"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a8b5496d-d3fe-45ca-b6b9-b02216a5a65d"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("a05da739-b393-43c0-bc39-3beadc75534d"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("9b688581-8310-4530-ba49-49b89187f818"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("d702dd5c-1402-42d9-8681-6401b878cecb"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("0412b8f5-c15a-4b5b-acb9-fe26f9d45645"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6619ca1b-d0f5-4393-8cb6-426000484595"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("b899967c-1e05-427a-b1e8-966505170985"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("35254b71-7cab-497e-ac32-4fed099ada33"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("031c5d10-806b-4b35-abbf-4f7891d4f608"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("6d1a84f0-4239-4ddd-8117-3a38afcfce1b"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("b6574280-d7a8-4ca2-8aca-db8d72c4ab4f"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("0d39a9b6-12ea-4b37-aaa8-a6d8b87ca4fd"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("eb4d9637-798f-41a9-a218-95ce39a479f6"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("0d02a955-8101-4f07-8bf1-cfdf0688aedc"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3c57e63e-15e3-40af-946f-db1114bcaea3"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("b7b8c5f5-70de-4cfa-b5dc-623f72e99b9c"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("31911159-f563-4b72-8410-3f26bf49841d"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("3bcc6ec2-1a51-429b-8119-aab29d3486f2"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("10c22650-6f31-4ccf-856d-7072b42d92ed"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("4788df1c-dece-40b3-ab60-1d058d01d2a2"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("0f60e194-6447-4807-8cc6-3b7d16fb79be"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("fd25f3d3-e9d4-4c77-93f6-73d91f6fcd58"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("e65ab9a2-27a8-4d77-90fb-15218bb25451"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("1fe39665-929a-48d5-bbe1-20d9a2d9d5dd"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("46f93ab6-971b-47b2-af35-64c1318ae18d"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("e1f026d8-e1ec-429f-a991-c73d1831cde4"), new Guid("8b1ec59c-d768-418c-b213-0fda539ef590"), new Guid("add2ba35-55c0-4ef0-b31f-b6c4824585d2"), new Guid("109b72c1-463a-4c8d-b2c0-64c331f88974") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("be0a8e15-6c98-44be-87ff-fa86c2bf3eac"), new Guid("ba25a253-424c-4ce1-a793-33bbe8cbcb6f") },
                    { new Guid("3490001e-f9d6-454e-9880-3473f304c71a"), new Guid("73aba84b-10bd-4eb2-93ed-b9a495ed201d"), new Guid("8dde50a8-2233-4e9a-a88e-f2f8a38d7a42"), new Guid("0a4640a9-94e6-4bb5-84c1-86bb952d89f9") }
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
