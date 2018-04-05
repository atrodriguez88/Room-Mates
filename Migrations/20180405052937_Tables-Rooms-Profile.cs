using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RoomMates.Migrations
{
    public partial class TablesRoomsProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    MovingDate = table.Column<string>(nullable: true),
                    Ocupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    AvailableFrom = table.Column<DateTime>(nullable: false),
                    IsEnsuiteBathroom = table.Column<bool>(nullable: false),
                    IsFurnished = table.Column<bool>(nullable: false),
                    IsUtilityIncluded = table.Column<bool>(nullable: false),
                    MinStayMonths = table.Column<int>(nullable: false),
                    NumberBathrooms = table.Column<int>(nullable: false),
                    NumberBedrooms = table.Column<int>(nullable: false),
                    NumberRoomatesAlready = table.Column<int>(nullable: false),
                    PrefGender = table.Column<string>(nullable: true),
                    PrefMaxAge = table.Column<int>(nullable: false),
                    PrefMinAge = table.Column<int>(nullable: false),
                    PrefOcuppation = table.Column<string>(nullable: true),
                    PropertyType = table.Column<string>(maxLength: 50, nullable: false),
                    RentPerMonth = table.Column<float>(nullable: false),
                    RoomSquareMeters = table.Column<float>(nullable: false),
                    RoomType = table.Column<string>(maxLength: 50, nullable: false),
                    RoomsToRent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
