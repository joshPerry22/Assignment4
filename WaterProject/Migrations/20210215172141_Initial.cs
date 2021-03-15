﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Program = table.Column<string>(nullable: true),
                    Impact = table.Column<int>(nullable: false),
                    Phase = table.Column<string>(nullable: true),
                    CompletionDate = table.Column<DateTime>(nullable: false),
                    Features = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
