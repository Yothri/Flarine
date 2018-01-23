using System.Linq;
using Flarine.Game.Network.Web.Response;
using Flarine.Network.Web;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebCommon;

namespace Flarine.Game.Network.Web.Request
{
    internal sealed class AccountHeroInfoRequest : GameWPDRequest
    {
        public override WPDResponse Handle()
        {
            var session = GameContext.GameSessions
                .Where(s => s.GameAccessToken == GameAccessToken).FirstOrDefault();

            if (session == null) return new AccountHeroInfoResponse { Result = 1 };

            var account = DataContext.Accounts
                .Where(a => a.UserId == session.User.UserId)
                .Include(a => a.AccountHeros)
                .FirstOrDefault();

            if (account == null) return new AccountHeroInfoResponse { Result = 1 };

            var hero = account.AccountHeros
                .Where(h => h.Id == AccountHeroId)
                .FirstOrDefault();

            if(hero == null) return new AccountHeroInfoResponse { Result = 1 };

            var accountHeroInfo = new WPDAccountHeroInfo
            {
                accountHero = new WPDAccountHero
                {
                    accountHeroId = hero.Id,
                    accountId = account.AccountId,
                    accuracy = hero.Accuracy,
                    achieveId = hero.AchieveId,
                    achievePoint = hero.AchievePoint,
                    achieveTitleKey = hero.AchieveTitleKey,
                    activatedAccountHeroPetId = hero.ActivatedAccountHeroPetId,
                    agility = hero.Agility,
                    attackSpeed = hero.AttackSpeed,
                    beadPowder = hero.BeadPowder,
                    beadSocketCount = hero.BeadSocketCount,
                    bestFieldOfHonorSuccessiveVictories = hero.BestFieldOfHonorSuccessiveVictories,
                    block = hero.Block,
                    bossMonsterKillCount = hero.BossMonsterKillCount,
                    composeSuccessCount = hero.ComposeSuccessCount,
                    critical = hero.Critical,
                    currentFieldOfHonorSuccessiveVictories = hero.CurrentFieldOfHonorSuccessiveVictories,
                    dia = hero.Dia,
                    ownDia = hero.OwnDia,
                    difficulty1DungeonClearCount = hero.Difficulty1DungeonClearCount,
                    difficulty2DungeonClearCount = hero.Difficulty2DungeonClearCount,
                    difficulty3DungeonClearCount = hero.Difficulty3DungeonClearCount,
                    dodge = hero.Dodge,
                    dualRequestRefused = hero.DualRequestRefused,
                    exp = hero.Exp,
                    faceId = hero.FaceId,
                    fameId = hero.FameId,
                    famePoint = hero.FamePoint,
                    fameTitleKey = hero.FameTitleKey,
                    fieldOfHonorRanking = hero.FieldOfHonorRanking,
                    fieldOfHonorRankingChangePushEnabled = hero.FieldOfHonorRankingChangePushEnabled,
                    fieldOfHonorRankingRewardTime = hero.FieldOfHonorRankingRewardTime,
                    fp = hero.Fp,
                    freeItemPickTime = hero.FreeItemPickTime,
                    freePetPickTime = hero.FreePetPickTime,
                    gold = hero.Gold,
                    heart = hero.Heart,
                    heroId = hero.HeroId,
                    hp = hero.Hp,
                    hpPotionAutoRate = hero.HpPotionAutoRate,
                    hpRecovery = hero.HpRecovery,
                    hpUpdateTime = hero.HpUpdateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    mpUpdateTime = hero.MpUdpateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    intelligence = hero.Intelligence,
                    inventoryExtendLoginDuration = hero.InventoryExtendLoginDuration,
                    inventorySlotCount = hero.InventorySlotCount,
                    isLootEtc = hero.IsLootEtc,
                    isLootGearGrade1 = hero.IsLootGearGrade1,
                    isLootGearGrade2 = hero.IsLootGearGrade2,
                    isLootGearGrade3 = hero.IsLootGearGrade3,
                    isLootGearGrade4 = hero.IsLootGearGrade4,
                    isLootGearGrade5 = hero.IsLootGearGrade5,
                    isLootGold = hero.IsLootGold,
                    isLootJewel = hero.IsLootJewel,
                    isLootMonsterEssense = hero.IsLootMonsterEssense,
                    isLootPotion = hero.IsLootPotion,
                    lastCompletedMainChapterId = hero.LastCompletedMainChapterId,
                    level = hero.Level,
                    magicalDefense = hero.MagicalDefense,
                    magicalOffense = hero.MagicalOffense,
                    magicPowder = hero.MagicPowder,
                    maxHp = hero.MaxHp,
                    maxMp = hero.MaxMp,
                    monsterKillCount = hero.MonsterKillCount,
                    moveSpeed = hero.MoveSpeed,
                    mp = hero.Mp,
                    mpRecovery = hero.MpRecovery,
                    name = hero.Name,
                    openedContinentId = hero.OpenedContinentId,
                    ownGold = hero.OwnGold,
                    partyInviteRefused = hero.PartyInviteRefused,
                    petEquipSlotCount = hero.PetEquipSlotCout,
                    physicalDefense = hero.PhysicalDefense,
                    physicalOffense = hero.PhysicalOffense,
                    pickPoint = hero.PickPoint,
                    pkPoint = hero.PkPoint,
                    pushEnabled = hero.PushEnabled,
                    receivedCheerCount = hero.ReceivedCheerCount,
                    receiveMailPushEnabled = hero.ReceiveMailPushEnabled,
                    stamina = hero.Stamina,
                    starEssense = hero.StarEssense,
                    statAgility = hero.StatAgility,
                    statAutoDistribution = hero.StatAutoDistribution,
                    statIntelligence = hero.StatIntelligence,
                    statPoint = hero.StatPoint,
                    statStamina = hero.StatStamina,
                    statStrength = hero.StatStrength,
                    strength = hero.Strength,
                    totalPurchasedDia = hero.TotalPurchasedDia,
                    tradeRequestRefused = hero.TradeRequestRefused,
                    tradition = hero.Tradition,
                    trainingTimePushEnabled = hero.TrainingTimePushEnabled,
                    transcendSuccessCount = hero.TranscendSuccessCount,
                    vipLevel = hero.VipLevel,
                    warehouseExtendLoginDuration = hero.WarehouseExtendLoginDuration,
                    warehouseGold = hero.WarehouseGold,
                    warehouseOwnGold = hero.WarehouseOwnGold,
                    warehouseSlotCount = hero.WarehouseSlotCount,
                    whisperRefused = hero.WhisperRefused
                },
                accountHeroAchieveEntries = new WPDAccountHeroAchieveEntry[] { },
                accountHeroGears = new WPDAccountHeroGear[] { },
                accountHeroMenuActivations = new WPDAccountHeroMenuActivation[] { },
                accountHeroMonsterBooks = new WPDAccountHeroMonsterBook[] { },
                accountHeroSkills = new WPDAccountHeroSkill[] { },
                accountHeroVipLevelRewards = new WPDAccountHeroVipLevelReward[] { },
                accumulateLoginRewardItems = new WPDAccumulateLoginRewardItem[] { },
                accumulateLoginRewards = new WPDAccumulateLoginReward[] { },
                ankouTombDifficulties = new WPDAHAnkouTombDifficulty[] { },
                beadInventorySlots = new WPDBeadInventorySlot[] { },
                beadSockets = new WPDBeadSocket[] { },
                bossAnnihilationDifficulties = new WPDAHBossAnnihilationDifficulty[] { },
                constellationStepEntries = new WPDAHConstellationStepEntry[] { },
                continuationLoginRewardItems = new WPDContinuationLoginRewardItem[] { },
                dailyAccessRewards = new WPDDailyAccessReward[] { },
                dailyActiveEntries = new WPDDailyActiveEntry[] { },
                dailyActiveRewardItems = new WPDDailyActiveRewardItem[] { },
                dailyActiveRewards = new WPDDailyActiveReward[] { },
                dailyExchangeProducts = new WPDDailyExchangeProduct[] { },
                dailyExchangeProductTargets = new WPDDailyExchangeProductTarget[] { },
                equipedGears = new WPDEquipedGear[] { },
                equipmentProducts = new WPDEquipmentProduct[] { },
                equippedGearRunes = new WPDEquippedGearRune[] { },
                equippedGearSockets = new WPDEquippedGearSocket[] { },
                equippedPets = new WPDEquippedPet[] { },
                expDungeonDifficulties = new WPDAHExpDungeonDifficulty[] { },
                gearInstanceAttrs = new WPDGearInstanceAttr[] { },
                gearInstances = new WPDGearInstance[] { },
                heroLevelRewardItems = new WPDHeroLevelRewardItem[] { },
                heroLevelRewards = new WPDHeroLevelReward[] { },
                inventories = new WPDInventory[] { },
                inventorySlotGearRunes = new WPDInventorySlotGearRune[] { },
                limitedProductMasters = new WPDLimitedProductMaster[] { },
                limitedProducts = new WPDLimitedProduct[] { },
                magicPowderExchangeProducts = new WPDMagicPowderExchangeProduct[] { },
                mainQuest = new WPDMainQuest(),
                mainQuestComplete = new WPDMainQuestComplete(),
                mainQuestDialogues = new WPDMainQuestDialogue[] { },
                mainQuestRewards = new WPDMainQuestReward[] { },
                monsterBookBuffs = new WPDMonsterBookBuff[] { },
                petInstanceAttrs = new WPDPetInstanceAttr[] { },
                petInstances = new WPDPetInstance[] { },
                petInventorySlots = new WPDPetInventorySlot[] { },
                pickAvailableProductGears = new WPDPickAvailableProductGear[] { },
                pickAvailableProducts = new WPDPickAvailableProduct[] { },
                pickPetAvailableProducts = new WPDPickPetAvailableProduct[] { },
                pickPetWarehouseSlots = new WPDPickPetWarehouseSlot[] { },
                pickPointExchangeProducts = new WPDPickPointExchangeProduct[] { },
                pickProductWarehouseSlotGears = new WPDPickProductWarehouseSlotGear[] { },
                pickProductWarehouseSlotItems = new WPDPickProductWarehouseSlotItem[] { },
                products = new WPDProduct[] { },
                sockets = new WPDSocket[] { },
                storeCategories = new WPDStoreCategory[] { },
                stores = new WPDStore[] { },
                storyDungeonDifficulties = new WPDAHStoryDungeonDifficulty[] { },
                taskEntries = new WPDTaskEntry[] { },
                taskMainChapterRewards = new WPDTaskMainChapterReward[] { },
                taskRewardItems = new WPDTaskRewardItem[] { },
                taskTraditionRewards = new WPDTaskTraditionReward[] { },
                tradeShipDifficulties = new WPDAHTradeShipDifficulty[] { },
                warehouseSlotGearRunes = new WPDWarehouseSlotGearRune[] { },
                warehouseSlotGears = new WPDWarehouseSlotGear[] { },
                warehouseSlotGearSockets = new WPDWarehouseSlotGearSocket[] { },
                warehouseSlotItems = new WPDWarehouseSlotItem[] { }
            };

            return new AccountHeroInfoResponse
            {
                AccountHeroInfo = accountHeroInfo.SerializeBase64String()
            };
        }

        [JsonProperty("accessToken")]
        public string GameAccessToken { get; set; }

        [JsonProperty("accountHeroId")]
        public int AccountHeroId { get; set; }
    }
}