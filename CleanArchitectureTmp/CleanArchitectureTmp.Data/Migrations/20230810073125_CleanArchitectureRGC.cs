using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureTmp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CleanArchitectureRGC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Director_Videos_VideoId",
                table: "Director");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoActor_Actor_ActorId",
                table: "VideoActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directores");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actores");

            migrationBuilder.RenameIndex(
                name: "IX_Director_VideoId",
                table: "Directores",
                newName: "IX_Directores_VideoId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Videos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Videos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "VideoActor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VideoActor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VideoActor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "VideoActor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "VideoActor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Streamers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Streamers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Streamers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Streamers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Directores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Directores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Directores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Actores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Actores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Actores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directores",
                table: "Directores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actores",
                table: "Actores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Directores_Videos_VideoId",
                table: "Directores",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoActor_Actores_ActorId",
                table: "VideoActor",
                column: "ActorId",
                principalTable: "Actores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directores_Videos_VideoId",
                table: "Directores");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoActor_Actores_ActorId",
                table: "VideoActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directores",
                table: "Directores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actores",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "VideoActor");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VideoActor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VideoActor");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "VideoActor");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "VideoActor");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Directores");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Actores");

            migrationBuilder.RenameTable(
                name: "Directores",
                newName: "Director");

            migrationBuilder.RenameTable(
                name: "Actores",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_Directores_VideoId",
                table: "Director",
                newName: "IX_Director_VideoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Videos_VideoId",
                table: "Director",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoActor_Actor_ActorId",
                table: "VideoActor",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
