﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMvcMysql.Migrations
{
    public partial class AddCampoBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Usuario",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Usuario");
        }
    }
}
