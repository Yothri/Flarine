using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Flarine.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserSecret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_heros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: true),
                    CostumeId = table.Column<int>(nullable: false),
                    CostumeVisible = table.Column<bool>(nullable: false),
                    FaceId = table.Column<int>(nullable: false),
                    HeroId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    MountTier = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Tradition = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_heros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_heros_tbl_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "tbl_accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_heros_AccountId",
                table: "tbl_heros",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_heros");

            migrationBuilder.DropTable(
                name: "tbl_accounts");
        }
    }
}
