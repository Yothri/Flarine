using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Flarine.Database.Migrations
{
    public partial class UserIdAndUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "tbl_accounts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserSecret",
                table: "tbl_accounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "tbl_accounts");

            migrationBuilder.DropColumn(
                name: "UserSecret",
                table: "tbl_accounts");
        }
    }
}
