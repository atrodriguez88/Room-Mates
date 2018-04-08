using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RoomMates.Migrations
{
    public partial class CreateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ocupations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    MaxRentMonth = table.Column<string>(nullable: false),
                    MovingDate = table.Column<DateTime>(nullable: false),
                    OcupationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Ocupations_OcupationId",
                        column: x => x.OcupationId,
                        principalTable: "Ocupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    AvailableFrom = table.Column<DateTime>(nullable: false),
                    Cleanliness = table.Column<string>(nullable: true),
                    IsFurnished = table.Column<bool>(nullable: false),
                    IsUtilityIncluded = table.Column<bool>(nullable: false),
                    MinStayMonths = table.Column<int>(nullable: false),
                    NumberBathrooms = table.Column<int>(nullable: false),
                    NumberBedrooms = table.Column<int>(nullable: false),
                    NumberRoomatesAlready = table.Column<int>(nullable: false),
                    OcupationId = table.Column<int>(nullable: false),
                    Pet = table.Column<string>(nullable: true),
                    PrefGender = table.Column<string>(nullable: true),
                    PrefMaxAge = table.Column<int>(nullable: false),
                    PrefMinAge = table.Column<int>(nullable: false),
                    PropertyId = table.Column<int>(nullable: false),
                    PropertyTypeId = table.Column<int>(nullable: true),
                    RentPerMonth = table.Column<float>(nullable: false),
                    RoomSquareMeters = table.Column<float>(nullable: false),
                    RoomType = table.Column<string>(maxLength: 50, nullable: false),
                    RoomsToRent = table.Column<int>(nullable: false),
                    Smoking = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Ocupations_OcupationId",
                        column: x => x.OcupationId,
                        principalTable: "Ocupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomRoomFeatures",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false),
                    RoomFeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRoomFeatures", x => new { x.RoomId, x.RoomFeaturesId });
                    table.ForeignKey(
                        name: "FK_RoomRoomFeatures_RoomFeatures_RoomFeaturesId",
                        column: x => x.RoomFeaturesId,
                        principalTable: "RoomFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomRoomFeatures_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomsPropertyFeatures",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false),
                    PropertyFeaturesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsPropertyFeatures", x => new { x.RoomId, x.PropertyFeaturesId });
                    table.ForeignKey(
                        name: "FK_RoomsPropertyFeatures_PropertyFeatures_PropertyFeaturesId",
                        column: x => x.PropertyFeaturesId,
                        principalTable: "PropertyFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsPropertyFeatures_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomsPropertyRules",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false),
                    PropertyRulesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomsPropertyRules", x => new { x.RoomId, x.PropertyRulesId });
                    table.ForeignKey(
                        name: "FK_RoomsPropertyRules_PropertyRules_PropertyRulesId",
                        column: x => x.PropertyRulesId,
                        principalTable: "PropertyRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomsPropertyRules_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_OcupationId",
                table: "Profiles",
                column: "OcupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId1",
                table: "Profiles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRoomFeatures_RoomFeaturesId",
                table: "RoomRoomFeatures",
                column: "RoomFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_OcupationId",
                table: "Rooms",
                column: "OcupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PropertyTypeId",
                table: "Rooms",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_UserId1",
                table: "Rooms",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsPropertyFeatures_PropertyFeaturesId",
                table: "RoomsPropertyFeatures",
                column: "PropertyFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsPropertyRules_PropertyRulesId",
                table: "RoomsPropertyRules",
                column: "PropertyRulesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "RoomRoomFeatures");

            migrationBuilder.DropTable(
                name: "RoomsPropertyFeatures");

            migrationBuilder.DropTable(
                name: "RoomsPropertyRules");

            migrationBuilder.DropTable(
                name: "RoomFeatures");

            migrationBuilder.DropTable(
                name: "PropertyFeatures");

            migrationBuilder.DropTable(
                name: "PropertyRules");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Ocupations");

            migrationBuilder.DropTable(
                name: "PropertyTypes");
        }
    }
}
