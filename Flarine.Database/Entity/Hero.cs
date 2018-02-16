using System;
using Flarine.Database.Interface;

namespace Flarine.Database.Entity
{
    public sealed class Hero : IDatabaseEntity
    {
        public Account ParentAccount { get; set; }
        public int Id { get; set; }
        public int HeroId { get; set; }
        public int FaceId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Tradition { get; set; }
        public int CostumeId { get; set; }
        public bool CostumeVisible { get; set; }
        public int MountTier { get; set; }
        public int Exp { get; set; }
        public int AchieveId { get; set; }
        public string AchieveTitleKey { get; set; } = string.Empty;
        public int AchievePoint { get; set; }
        public int FameId { get; set; }
        public string FameTitleKey { get; set; } = string.Empty;
        public int FamePoint { get; set; }
        public int OwnDia { get; set; }
        public int Dia { get; set; }
        public int TotalPurchasedDia { get; set; }
        public int Gold { get; set; }
        public int OwnGold { get; set; }
        public int WarehouseGold { get; set; }
        public int WarehouseOwnGold { get; set; }
        public int InventorySlotCount { get; set; } = 50;
        public int WarehouseSlotCount { get; set; } = 60;
        public int PetEquipSlotCout { get; set; } = 1;
        public int InventoryExtendLoginDuration { get; set; }
        public int WarehouseExtendLoginDuration { get; set; }
        public int MagicPowder { get; set; }
        public int StarEssense { get; set; }
        public int Heart { get; set; }
        public int BeadPowder { get; set; }
        public int Hp { get; set; } = 25;
        public int Mp { get; set; } = 100;
        public DateTime HpUpdateTime { get; set; } = DateTime.UtcNow;
        public DateTime MpUdpateTime { get; set; } = DateTime.UtcNow;
        public int Fp { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Stamina { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int HpRecovery { get; set; }
        public int MpRecovery { get; set; }
        public int PhysicalOffense { get; set; }
        public int MagicalOffense { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }
        public int Accuracy { get; set; }
        public int Dodge { get; set; }
        public int Critical { get; set; }
        public int Block { get; set; }
        public float AttackSpeed { get; set; }
        public float MoveSpeed { get; set; }
        public int StatStrength { get; set; } = 3;
        public int StatStamina { get; set; } = 1;
        public int StatAgility { get; set; } = 1;
        public int StatIntelligence { get; set; }
        public int StatPoint { get; set; }
        public bool StatAutoDistribution { get; set; } = true;
        public int LastCompletedMainChapterId { get; set; }
        public int OpenedContinentId { get; set; }
        public int ContinentId { get; set; }
        public int MonsterKillCount { get; set; }
        public int BossMonsterKillCount { get; set; }
        public int ComposeSuccessCount { get; set; }
        public int TranscendSuccessCount { get; set; }
        public int Difficulty1DungeonClearCount { get; set; }
        public int Difficulty2DungeonClearCount { get; set; }
        public int Difficulty3DungeonClearCount { get; set; }
        public int HpPotionAutoRate { get; set; } = 80;
        public string FreeItemPickTime { get; set; }
        public string FreePetPickTime { get; set; }
        public int PickPoint { get; set; }
        public int ReceivedCheerCount { get; set; }
        public bool IsLootGearGrade1 { get; set; } = true;
        public bool IsLootGearGrade2 { get; set; } = true;
        public bool IsLootGearGrade3 { get; set; } = true;
        public bool IsLootGearGrade4 { get; set; } = true;
        public bool IsLootGearGrade5 { get; set; } = true;
        public bool IsLootJewel { get; set; } = true;
        public bool IsLootGold { get; set; } = true;
        public bool IsLootMonsterEssense { get; set; } = true;
        public bool IsLootPotion { get; set; }
        public bool IsLootEtc { get; set; } = true;
        public bool PartyInviteRefused { get; set; }
        public bool WhisperRefused { get; set; }
        public bool TradeRequestRefused { get; set; }
        public bool DualRequestRefused { get; set; }
        public bool PushEnabled { get; set; }
        public bool TrainingTimePushEnabled { get; set; }
        public bool FieldOfHonorRankingChangePushEnabled { get; set; }
        public bool ReceiveMailPushEnabled { get; set; }
        public string ActivatedAccountHeroPetId { get; set; }
        public int FieldOfHonorRanking { get; set; }
        public int CurrentFieldOfHonorSuccessiveVictories { get; set; }
        public int BestFieldOfHonorSuccessiveVictories { get; set; }
        public string FieldOfHonorRankingRewardTime { get; set; }
        public int BeadSocketCount { get; set; }
        public int PkPoint { get; set; }
        public int VipLevel { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float RotationY { get; set; }
    }
}