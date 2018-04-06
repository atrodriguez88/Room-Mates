using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RoomMates.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnsuiteBathroom",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "PrefOcuppation",
                table: "Rooms",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "Ocupation",
                table: "Profiles",
                newName: "UserId1");

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cleanliness",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pet",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Smoking",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MovingDate",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId1",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OcupationId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ocupations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocupations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocupations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyFeatures_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyRules_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Name = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomFeatures_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_PropertyTypeId",
                table: "Rooms",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_UserId1",
                table: "Rooms",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_OcupationId",
                table: "Profiles",
                column: "OcupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId1",
                table: "Profiles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ocupations_RoomId",
                table: "Ocupations",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFeatures_RoomId",
                table: "PropertyFeatures",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRules_RoomId",
                table: "PropertyRules",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFeatures_RoomId",
                table: "RoomFeatures",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Ocupations_OcupationId",
                table: "Profiles",
                column: "OcupationId",
                principalTable: "Ocupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_AspNetUsers_UserId1",
                table: "Profiles",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_PropertyTypes_PropertyTypeId",
                table: "Rooms",
                column: "PropertyTypeId",
                principalTable: "PropertyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_UserId1",
                table: "Rooms",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Ocupations_OcupationId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_AspNetUsers_UserId1",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_PropertyTypes_PropertyTypeId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_UserId1",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "Ocupations");

            migrationBuilder.DropTable(
                name: "PropertyFeatures");

            migrationBuilder.DropTable(
                name: "PropertyRules");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "RoomFeatures");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_PropertyTypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_UserId1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_OcupationId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_UserId1",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Cleanliness",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Pet",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Smoking",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "OcupationId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Rooms",
                newName: "PrefOcuppation");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Profiles",
                newName: "Ocupation");

            migrationBuilder.AlterColumn<string>(
                name: "PrefOcuppation",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnsuiteBathroom",
                table: "Rooms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "Rooms",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MovingDate",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Ocupation",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
