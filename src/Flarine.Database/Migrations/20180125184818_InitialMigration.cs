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
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountGuid = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserSecret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Accuracy = table.Column<int>(nullable: false),
                    AchieveId = table.Column<int>(nullable: false),
                    AchievePoint = table.Column<int>(nullable: false),
                    AchieveTitleKey = table.Column<string>(nullable: true),
                    ActivatedAccountHeroPetId = table.Column<string>(nullable: true),
                    Agility = table.Column<int>(nullable: false),
                    AttackSpeed = table.Column<float>(nullable: false),
                    BeadPowder = table.Column<int>(nullable: false),
                    BeadSocketCount = table.Column<int>(nullable: false),
                    BestFieldOfHonorSuccessiveVictories = table.Column<int>(nullable: false),
                    Block = table.Column<int>(nullable: false),
                    BossMonsterKillCount = table.Column<int>(nullable: false),
                    ComposeSuccessCount = table.Column<int>(nullable: false),
                    ContinentId = table.Column<int>(nullable: false),
                    CostumeId = table.Column<int>(nullable: false),
                    CostumeVisible = table.Column<bool>(nullable: false),
                    Critical = table.Column<int>(nullable: false),
                    CurrentFieldOfHonorSuccessiveVictories = table.Column<int>(nullable: false),
                    Dia = table.Column<int>(nullable: false),
                    Difficulty1DungeonClearCount = table.Column<int>(nullable: false),
                    Difficulty2DungeonClearCount = table.Column<int>(nullable: false),
                    Difficulty3DungeonClearCount = table.Column<int>(nullable: false),
                    Dodge = table.Column<int>(nullable: false),
                    DualRequestRefused = table.Column<bool>(nullable: false),
                    Exp = table.Column<int>(nullable: false),
                    FaceId = table.Column<int>(nullable: false),
                    FameId = table.Column<int>(nullable: false),
                    FamePoint = table.Column<int>(nullable: false),
                    FameTitleKey = table.Column<string>(nullable: true),
                    FieldOfHonorRanking = table.Column<int>(nullable: false),
                    FieldOfHonorRankingChangePushEnabled = table.Column<bool>(nullable: false),
                    FieldOfHonorRankingRewardTime = table.Column<string>(nullable: true),
                    Fp = table.Column<int>(nullable: false),
                    FreeItemPickTime = table.Column<string>(nullable: true),
                    FreePetPickTime = table.Column<string>(nullable: true),
                    Gold = table.Column<int>(nullable: false),
                    Heart = table.Column<int>(nullable: false),
                    HeroId = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    HpPotionAutoRate = table.Column<int>(nullable: false),
                    HpRecovery = table.Column<int>(nullable: false),
                    HpUpdateTime = table.Column<DateTime>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    InventoryExtendLoginDuration = table.Column<int>(nullable: false),
                    InventorySlotCount = table.Column<int>(nullable: false),
                    IsLootEtc = table.Column<bool>(nullable: false),
                    IsLootGearGrade1 = table.Column<bool>(nullable: false),
                    IsLootGearGrade2 = table.Column<bool>(nullable: false),
                    IsLootGearGrade3 = table.Column<bool>(nullable: false),
                    IsLootGearGrade4 = table.Column<bool>(nullable: false),
                    IsLootGearGrade5 = table.Column<bool>(nullable: false),
                    IsLootGold = table.Column<bool>(nullable: false),
                    IsLootJewel = table.Column<bool>(nullable: false),
                    IsLootMonsterEssense = table.Column<bool>(nullable: false),
                    IsLootPotion = table.Column<bool>(nullable: false),
                    LastCompletedMainChapterId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    MagicPowder = table.Column<int>(nullable: false),
                    MagicalDefense = table.Column<int>(nullable: false),
                    MagicalOffense = table.Column<int>(nullable: false),
                    MaxHp = table.Column<int>(nullable: false),
                    MaxMp = table.Column<int>(nullable: false),
                    MonsterKillCount = table.Column<int>(nullable: false),
                    MountTier = table.Column<int>(nullable: false),
                    MoveSpeed = table.Column<float>(nullable: false),
                    Mp = table.Column<int>(nullable: false),
                    MpRecovery = table.Column<int>(nullable: false),
                    MpUdpateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OpenedContinentId = table.Column<int>(nullable: false),
                    OwnDia = table.Column<int>(nullable: false),
                    OwnGold = table.Column<int>(nullable: false),
                    ParentAccountId = table.Column<int>(nullable: true),
                    PartyInviteRefused = table.Column<bool>(nullable: false),
                    PetEquipSlotCout = table.Column<int>(nullable: false),
                    PhysicalDefense = table.Column<int>(nullable: false),
                    PhysicalOffense = table.Column<int>(nullable: false),
                    PickPoint = table.Column<int>(nullable: false),
                    PkPoint = table.Column<int>(nullable: false),
                    PushEnabled = table.Column<bool>(nullable: false),
                    ReceiveMailPushEnabled = table.Column<bool>(nullable: false),
                    ReceivedCheerCount = table.Column<int>(nullable: false),
                    RotationY = table.Column<float>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    StarEssense = table.Column<int>(nullable: false),
                    StatAgility = table.Column<int>(nullable: false),
                    StatAutoDistribution = table.Column<bool>(nullable: false),
                    StatIntelligence = table.Column<int>(nullable: false),
                    StatPoint = table.Column<int>(nullable: false),
                    StatStamina = table.Column<int>(nullable: false),
                    StatStrength = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    TotalPurchasedDia = table.Column<int>(nullable: false),
                    TradeRequestRefused = table.Column<bool>(nullable: false),
                    Tradition = table.Column<int>(nullable: false),
                    TrainingTimePushEnabled = table.Column<bool>(nullable: false),
                    TranscendSuccessCount = table.Column<int>(nullable: false),
                    VipLevel = table.Column<int>(nullable: false),
                    WarehouseExtendLoginDuration = table.Column<int>(nullable: false),
                    WarehouseGold = table.Column<int>(nullable: false),
                    WarehouseOwnGold = table.Column<int>(nullable: false),
                    WarehouseSlotCount = table.Column<int>(nullable: false),
                    WhisperRefused = table.Column<bool>(nullable: false),
                    X = table.Column<float>(nullable: false),
                    Y = table.Column<float>(nullable: false),
                    Z = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heros_Accounts_ParentAccountId",
                        column: x => x.ParentAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heros_ParentAccountId",
                table: "Heros",
                column: "ParentAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heros");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
