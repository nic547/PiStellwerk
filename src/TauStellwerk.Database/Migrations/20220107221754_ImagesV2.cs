﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TauStellwerk.Database.Migrations
{
    public partial class ImagesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGenerated",
                table: "EngineImages");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastImageUpdate",
                table: "Engines",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastImageUpdate",
                table: "Engines");

            migrationBuilder.AddColumn<bool>(
                name: "IsGenerated",
                table: "EngineImages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
