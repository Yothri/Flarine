using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Flarine.Database.Migrations
{
    public partial class HeroUpdate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeadSocketCount",
                table: "tbl_heros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dia",
                table: "tbl_heros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsLootPotion",
                table: "tbl_heros",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PkPoint",
                table: "tbl_heros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPurchasedDia",
                table: "tbl_heros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VipLevel",
                table: "tbl_heros",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeadSocketCount",
                table: "tbl_heros");

            migrationBuilder.DropColumn(
                name: "Dia",
                table: "tbl_heros");

            migrationBuilder.DropColumn(
                name: "IsLootPotion",
                table: "tbl_heros");

            migrationBuilder.DropColumn(
                name: "PkPoint",
                table: "tbl_heros");

            migrationBuilder.DropColumn(
                name: "TotalPurchasedDia",
                table: "tbl_heros");

            migrationBuilder.DropColumn(
                name: "VipLevel",
                table: "tbl_heros");
        }
    }
}
