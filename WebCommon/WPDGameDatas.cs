using System;
using System.IO;

namespace WebCommon
{
	public class WPDGameDatas : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gameConfig);
			writer.Write(this.heros);
			writer.Write(this.faces);
			writer.Write(this.heroLevels);
			writer.Write(this.traditions);
			writer.Write(this.fames);
			writer.Write(this.fameBuffs);
			writer.Write(this.achieves);
			writer.Write(this.heroAchieves);
			writer.Write(this.heroAchieveBuffs);
			writer.Write(this.gears);
			writer.Write(this.gearTiers);
			writer.Write(this.gearTypes);
			writer.Write(this.gearAttrs);
			writer.Write(this.gearOptionAttrs);
			writer.Write(this.grades);
			writer.Write(this.elementals);
			writer.Write(this.attrs);
			writer.Write(this.itemTypes);
			writer.Write(this.items);
			writer.Write(this.gearDisassembleResults);
			writer.Write(this.runeRecipes);
			writer.Write(this.jewelRecipes);
			writer.Write(this.shineOrichalcumRecipes);
			writer.Write(this.heroSkills);
			writer.Write(this.continents);
			writer.Write(this.regions);
			writer.Write(this.portals);
			writer.Write(this.npcs);
			writer.Write(this.mainChapters);
			writer.Write(this.mainChapterBuffs);
			writer.Write(this.monsters);
			writer.Write(this.monsterSkills);
			writer.Write(this.gearEnchantRecipes);
			writer.Write(this.gearEnchantLevelInheritRecipes);
			writer.Write(this.gearElementalEnchantRecipes);
			writer.Write(this.gearElementalChangeRecipes);
			writer.Write(this.gearElementalLevelInheritRecipes);
			writer.Write(this.gearComposeRecipes);
			writer.Write(this.gearTranscendRecipes);
			writer.Write(this.continentMonsterPositions);
			writer.Write(this.inventorySlotExtendRecipes);
			writer.Write(this.warehouseSlotExtendRecipes);
			writer.Write(this.gearEnchantLevelAttrs);
			writer.Write(this.gearElementalLevels);
			writer.Write(this.achieveMasters);
			writer.Write(this.monsterBookContinentBuffs);
			writer.Write(this.traditionBuffs);
			writer.Write(this.vipLevels);
			writer.Write(this.vipLevelBuffs);
			writer.Write(this.vipLevelRewards);
			writer.Write(this.statWeightingFactors);
			writer.Write(this.equippedGearEnchantSets);
			writer.Write(this.equippedGearEnchantSetBuffs);
			writer.Write(this.equippedGearGradeSets);
			writer.Write(this.equippedGearGradeSetBuffs);
			writer.Write(this.cursedDock);
			writer.Write(this.cursedDockNpc);
			writer.Write(this.cursedDockClearGrades);
			writer.Write(this.cursedDockWayPoints);
			writer.Write(this.cursedDockAvailableRewards);
			writer.Write(this.marketCategories);
			writer.Write(this.locations);
			writer.Write(this.gouthanMine);
			writer.Write(this.gouthanMineMinerals);
			writer.Write(this.gouthanMineMineralArranges);
			writer.Write(this.gouthanMineEventSchedules);
			writer.Write(this.systemMessages);
			writer.Write(this.menuActivations);
			writer.Write(this.growthEntries);
			writer.Write(this.heroLevelGrowthEntries);
			writer.Write(this.heroSetGears);
			writer.Write(this.moneyBuffs);
			writer.Write(this.moneyBuffAttrs);
			writer.Write(this.dailyQuestRewards);
			writer.Write(this.dailyQuestRewardItems);
			writer.Write(this.dailyQuestRoundRewards);
			writer.Write(this.dailyQuestRoundRewardItems);
			writer.Write(this.suppressionQuestRoundRewards);
			writer.Write(this.marbleRecipe);
			writer.Write(this.petPhases);
			writer.Write(this.pets);
			writer.Write(this.petLevels);
			writer.Write(this.fieldOfHonor);
			writer.Write(this.fieldOfHonorRankingRewards);
			writer.Write(this.fieldOfHonorRankingRewardItems);
			writer.Write(this.abyssTower);
			writer.Write(this.abyssTowerFloors);
			writer.Write(this.abyssTowerFloorRewardItems);
			writer.Write(this.arena);
			writer.Write(this.arenaWinnerBuffs);
			writer.Write(this.arenaAvailableRewards);
			writer.Write(this.arenaOpenSchedules);
			writer.Write(this.teamBattlefield);
			writer.Write(this.teamBattlefieldAvailableRewards);
			writer.Write(this.jobBattlefield);
			writer.Write(this.jobBattlefieldAvailableRewards);
			writer.Write(this.jobBattlefieldWinnerBuffs);
			writer.Write(this.guildBattlefield);
			writer.Write(this.guildBattlefieldAvailableRewards);
			writer.Write(this.guildBattlefieldWinnerBuffs);
			writer.Write(this.linkPlaces);
			writer.Write(this.actualTraining);
			writer.Write(this.beadLevels);
			writer.Write(this.beadMakeSteps);
			writer.Write(this.beadSocketExtendRecipes);
			writer.Write(this.pvpModes);
			writer.Write(this.chaoticSteps);
			writer.Write(this.guildDonationEntries);
			writer.Write(this.guildBuffs);
			writer.Write(this.guildBuffLevels);
			writer.Write(this.guildProducts);
			writer.Write(this.guildDungeons);
			writer.Write(this.guildDungeonAvailableRewards);
			writer.Write(this.guildMemberGrades);
			writer.Write(this.secretChamber);
			writer.Write(this.secretChamberAvailableRewards);
			writer.Write(this.secretChamberFloors);
			writer.Write(this.secretChamberFloorPortals);
			writer.Write(this.fallenCity);
			writer.Write(this.fallenCityAvailableRewards);
			writer.Write(this.fallenCityHiddenBossMonsters);
			writer.Write(this.gearGradeDisassembleResults);
			writer.Write(this.constellations);
			writer.Write(this.constellationSteps);
			writer.Write(this.constellationCycles);
			writer.Write(this.constellationCycleBuffs);
			writer.Write(this.constellationStepEntries);
			writer.Write(this.constellationStepEntryBuffs);
			writer.Write(this.inAppProducts);
			writer.Write(this.inAppProductPrices);
			writer.Write(this.purchaseProducts);
			writer.Write(this.mainQuestAdjustTokens);
			writer.Write(this.gameTips);
			writer.Write(this.banWords);
			writer.Write(this.gearGrades);
			writer.Write(this.gearSkillDegreeSteps);
			writer.Write(this.continentBossMonsterAvailableRewards);
			writer.Write(this.continentBossMonsterSpawnSchedules);
			writer.Write(this.mountTiers);
			writer.Write(this.mountTierLevels);
			writer.Write(this.storyDungeons);
			writer.Write(this.storyDungeonAvailableRewards);
			writer.Write(this.storyDungeonClearGrades);
			writer.Write(this.storyDungeonObstacles);
			writer.Write(this.storyDungeonDifficulties);
			writer.Write(this.expDungeons);
			writer.Write(this.expDungeonAvailableRewards);
			writer.Write(this.expDungeonClearGrades);
			writer.Write(this.expDungeonDifficulties);
			writer.Write(this.goldDungeons);
			writer.Write(this.goldDungeonAvailableRewards);
			writer.Write(this.goldDungeonDifficulties);
			writer.Write(this.ankouTomb);
			writer.Write(this.ankouTombDifficulties);
			writer.Write(this.ankouTombAvailableRewards);
			writer.Write(this.ankouTombOpenSchedules);
			writer.Write(this.bossAnnihilation);
			writer.Write(this.bossAnnihilationDifficulties);
			writer.Write(this.bossAnnihilationAvailableRewards);
			writer.Write(this.bossAnnihilationOpenSchedules);
			writer.Write(this.tradeShip);
			writer.Write(this.tradeShipDifficulties);
			writer.Write(this.tradeShipAvailableRewards);
			writer.Write(this.tradeShipObstacles);
			writer.Write(this.tradeShipSteps);
			writer.Write(this.tradeShipOpenSchedules);
			writer.Write(this.tradeShipObjects);
			writer.Write(this.levelUpMasterEvent);
			writer.Write(this.levelUpMasterEventEntries);
			writer.Write(this.levelUpMasterEventEntryRewards);
			writer.Write(this.bossSlayerEvent);
			writer.Write(this.bossSlayerEventRankings);
			writer.Write(this.bossSlayerEventRankingRewards);
			writer.Write(this.chargeMasterEvent);
			writer.Write(this.chargeMasterEventRankings);
			writer.Write(this.chargeMasterEventRankingRewards);
			writer.Write(this.consumeMasterEvent);
			writer.Write(this.consumeMasterEventRankings);
			writer.Write(this.consumeMasterEventRankingRewards);
			writer.Write(this.superCashbackEvent);
			writer.Write(this.superCashbackEventEntries);
			writer.Write(this.superCashbackEventRankings);
			writer.Write(this.continuationChargeEntries);
			writer.Write(this.continuationChargeEntryRewards);
			writer.Write(this.dailyChargeEntries);
			writer.Write(this.dailyChargeEntryRewards);
			writer.Write(this.accumulateChargeEntries);
			writer.Write(this.accumulateChargeEntryRewards);
			writer.Write(this.accumulateConsumeEntries);
			writer.Write(this.accumulateConsumeEntryRewards);
			writer.Write(this.actualTrainingAdditionalEnters);
			writer.Write(this.storyDungeonAdditionalEnters);
			writer.Write(this.helpEntries);
			writer.Write(this.day30Rewards);
			writer.Write(this.firstChargeEvent);
			writer.Write(this.firstChargeEventRewards);
			writer.Write(this.levelUpPackageEvent);
			writer.Write(this.levelUpPackageEventEntries);
			writer.Write(this.levelUpPackageEvent2);
			writer.Write(this.levelUpPackageEvent2Entries);
			writer.Write(this.levelUpPackageEvent3);
			writer.Write(this.levelUpPackageEvent3Entries);
			writer.Write(this.dungeonKingEvent);
			writer.Write(this.dungeonKingEventEntries);
			writer.Write(this.luckyBagEvent);
			writer.Write(this.luckyBagEventRewardEntries);
			writer.Write(this.fullMoonBuffs);
			writer.Write(this.essenceExchangeRounds);
			writer.Write(this.essenceExchangeRoundEntries);
			writer.Write(this.essenceExchangeRoundRewardEntries);
			writer.Write(this.gearAttrEnchantLevelAttrs);
			writer.Write(this.gearAttrEnchantRecipes);
			writer.Write(this.gearRunes);
			writer.Write(this.gearRuneEnchantSettings);
			writer.Write(this.gearRuneEnchantRecipes);
			writer.Write(this.gearTypeRunes);
			writer.Write(this.petEquippedSlotExtendRecipes);
			writer.Write(this.patterns);
			writer.Write(this.gearAttrEnchantLevelInheritRecipes);
			writer.Write(this.skyDungeons);
			writer.Write(this.skyDungeonAvailableRewards);
			writer.Write(this.skyDungeonObstacles);
			writer.Write(this.skyDungeonClearGrades);
			writer.Write(this.costumeTypes);
			writer.Write(this.costumes);
			writer.Write(this.costumeLevels);
			writer.Write(this.costumeLevelAttrs);
			writer.Write(this.deadTipLowLevelEntries);
			writer.Write(this.deadTipHighLevelEntries);
			writer.Write(this.heroLevelDeadTipHighLevelEntries);
			writer.Write(this.pickCostumeAvailableProducts);
			writer.Write(this.eventLists);
			writer.Write(this.day30DiaRewards);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gameConfig = reader.ReadPDPacketData<WPDGameConfig>();
			this.heros = reader.ReadPDPacketDatas<WPDHero>();
			this.faces = reader.ReadPDPacketDatas<WPDFace>();
			this.heroLevels = reader.ReadPDPacketDatas<WPDHeroLevel>();
			this.traditions = reader.ReadPDPacketDatas<WPDTradition>();
			this.fames = reader.ReadPDPacketDatas<WPDFame>();
			this.fameBuffs = reader.ReadPDPacketDatas<WPDFameBuff>();
			this.achieves = reader.ReadPDPacketDatas<WPDAchieve>();
			this.heroAchieves = reader.ReadPDPacketDatas<WPDHeroAchieve>();
			this.heroAchieveBuffs = reader.ReadPDPacketDatas<WPDHeroAchieveBuff>();
			this.gears = reader.ReadPDPacketDatas<WPDGear>();
			this.gearTiers = reader.ReadPDPacketDatas<WPDGearTier>();
			this.gearTypes = reader.ReadPDPacketDatas<WPDGearType>();
			this.gearAttrs = reader.ReadPDPacketDatas<WPDGearAttr>();
			this.gearOptionAttrs = reader.ReadPDPacketDatas<WPDGearOptionAttr>();
			this.grades = reader.ReadPDPacketDatas<WPDGrade>();
			this.elementals = reader.ReadPDPacketDatas<WPDElemental>();
			this.attrs = reader.ReadPDPacketDatas<WPDAttr>();
			this.itemTypes = reader.ReadPDPacketDatas<WPDItemType>();
			this.items = reader.ReadPDPacketDatas<WPDItem>();
			this.gearDisassembleResults = reader.ReadPDPacketDatas<WPDGearDisassembleResult>();
			this.runeRecipes = reader.ReadPDPacketDatas<WPDRuneRecipe>();
			this.jewelRecipes = reader.ReadPDPacketDatas<WPDJewelRecipe>();
			this.shineOrichalcumRecipes = reader.ReadPDPacketDatas<WPDShineOrichalcumRecipe>();
			this.heroSkills = reader.ReadPDPacketDatas<WPDHeroSkill>();
			this.continents = reader.ReadPDPacketDatas<WPDContinent>();
			this.regions = reader.ReadPDPacketDatas<WPDRegion>();
			this.portals = reader.ReadPDPacketDatas<WPDPortal>();
			this.npcs = reader.ReadPDPacketDatas<WPDNpc>();
			this.mainChapters = reader.ReadPDPacketDatas<WPDMainChapter>();
			this.mainChapterBuffs = reader.ReadPDPacketDatas<WPDMainChapterBuff>();
			this.monsters = reader.ReadPDPacketDatas<WPDMonster>();
			this.monsterSkills = reader.ReadPDPacketDatas<WPDMonsterSkill>();
			this.gearEnchantRecipes = reader.ReadPDPacketDatas<WPDGearEnchantRecipe>();
			this.gearEnchantLevelInheritRecipes = reader.ReadPDPacketDatas<WPDGearEnchantLevelInheritRecipe>();
			this.gearElementalEnchantRecipes = reader.ReadPDPacketDatas<WPDGearElementalEnchantRecipe>();
			this.gearElementalChangeRecipes = reader.ReadPDPacketDatas<WPDGearElementalChangeRecipe>();
			this.gearElementalLevelInheritRecipes = reader.ReadPDPacketDatas<WPDGearElementalLevelInheritRecipe>();
			this.gearComposeRecipes = reader.ReadPDPacketDatas<WPDGearComposeRecipe>();
			this.gearTranscendRecipes = reader.ReadPDPacketDatas<WPDGearTranscendRecipe>();
			this.continentMonsterPositions = reader.ReadPDPacketDatas<WPDContinentMonsterPosition>();
			this.inventorySlotExtendRecipes = reader.ReadPDPacketDatas<WPDInventorySlotExtendRecipe>();
			this.warehouseSlotExtendRecipes = reader.ReadPDPacketDatas<WPDWarehouseSlotExtendRecipe>();
			this.gearEnchantLevelAttrs = reader.ReadPDPacketDatas<WPDGearEnchantLevelAttr>();
			this.gearElementalLevels = reader.ReadPDPacketDatas<WPDGearElementalLevel>();
			this.achieveMasters = reader.ReadPDPacketDatas<WPDAchieveMaster>();
			this.monsterBookContinentBuffs = reader.ReadPDPacketDatas<WPDMonsterBookContinentBuff>();
			this.traditionBuffs = reader.ReadPDPacketDatas<WPDTraditionBuff>();
			this.vipLevels = reader.ReadPDPacketDatas<WPDVipLevel>();
			this.vipLevelBuffs = reader.ReadPDPacketDatas<WPDVipLevelBuff>();
			this.vipLevelRewards = reader.ReadPDPacketDatas<WPDVipLevelReward>();
			this.statWeightingFactors = reader.ReadPDPacketDatas<WPDStatWeightingFactor>();
			this.equippedGearEnchantSets = reader.ReadPDPacketDatas<WPDEquippedGearEnchantSet>();
			this.equippedGearEnchantSetBuffs = reader.ReadPDPacketDatas<WPDEquippedGearEnchantSetBuff>();
			this.equippedGearGradeSets = reader.ReadPDPacketDatas<WPDEquippedGearGradeSet>();
			this.equippedGearGradeSetBuffs = reader.ReadPDPacketDatas<WPDEquippedGearGradeSetBuff>();
			this.cursedDock = reader.ReadPDPacketData<WPDCursedDock>();
			this.cursedDockNpc = reader.ReadPDPacketData<WPDCursedDockNpc>();
			this.cursedDockClearGrades = reader.ReadPDPacketDatas<WPDCursedDockClearGrade>();
			this.cursedDockWayPoints = reader.ReadPDPacketDatas<WPDCursedDockWayPoint>();
			this.cursedDockAvailableRewards = reader.ReadPDPacketDatas<WPDCursedDockAvailableReward>();
			this.marketCategories = reader.ReadPDPacketDatas<WPDMarketCategory>();
			this.locations = reader.ReadPDPacketDatas<WPDLocation>();
			this.gouthanMine = reader.ReadPDPacketData<WPDGouthanMine>();
			this.gouthanMineMinerals = reader.ReadPDPacketDatas<WPDGouthanMineMineral>();
			this.gouthanMineMineralArranges = reader.ReadPDPacketDatas<WPDGouthanMineMineralArrange>();
			this.gouthanMineEventSchedules = reader.ReadPDPacketDatas<WPDGouthanMineEventSchedule>();
			this.systemMessages = reader.ReadPDPacketDatas<WPDSystemMessage>();
			this.menuActivations = reader.ReadPDPacketDatas<WPDMenuActivation>();
			this.growthEntries = reader.ReadPDPacketDatas<WPDGrowthEntry>();
			this.heroLevelGrowthEntries = reader.ReadPDPacketDatas<WPDHeroLevelGrowthEntry>();
			this.heroSetGears = reader.ReadPDPacketDatas<WPDHeroSetGear>();
			this.moneyBuffs = reader.ReadPDPacketDatas<WPDMoneyBuff>();
			this.moneyBuffAttrs = reader.ReadPDPacketDatas<WPDMoneyBuffAttr>();
			this.dailyQuestRewards = reader.ReadPDPacketDatas<WPDDailyQuestReward>();
			this.dailyQuestRewardItems = reader.ReadPDPacketDatas<WPDDailyQuestRewardItem>();
			this.dailyQuestRoundRewards = reader.ReadPDPacketDatas<WPDDailyQuestRoundReward>();
			this.dailyQuestRoundRewardItems = reader.ReadPDPacketDatas<WPDDailyQuestRoundRewardItem>();
			this.suppressionQuestRoundRewards = reader.ReadPDPacketDatas<WPDSuppressionQuestRoundReward>();
			this.marbleRecipe = reader.ReadPDPacketData<WPDMarbleRecipe>();
			this.petPhases = reader.ReadPDPacketDatas<WPDPetPhase>();
			this.pets = reader.ReadPDPacketDatas<WPDPet>();
			this.petLevels = reader.ReadPDPacketDatas<WPDPetLevel>();
			this.fieldOfHonor = reader.ReadPDPacketData<WPDFieldOfHonor>();
			this.fieldOfHonorRankingRewards = reader.ReadPDPacketDatas<WPDFieldOfHonorRankingReward>();
			this.fieldOfHonorRankingRewardItems = reader.ReadPDPacketDatas<WPDFieldOfHonorRankingRewardItem>();
			this.abyssTower = reader.ReadPDPacketData<WPDAbyssTower>();
			this.abyssTowerFloors = reader.ReadPDPacketDatas<WPDAbyssTowerFloor>();
			this.abyssTowerFloorRewardItems = reader.ReadPDPacketDatas<WPDAbyssTowerFloorRewardItem>();
			this.arena = reader.ReadPDPacketData<WPDArena>();
			this.arenaWinnerBuffs = reader.ReadPDPacketDatas<WPDArenaWinnerBuff>();
			this.arenaAvailableRewards = reader.ReadPDPacketDatas<WPDArenaAvailableReward>();
			this.arenaOpenSchedules = reader.ReadPDPacketDatas<WPDArenaOpenSchedule>();
			this.teamBattlefield = reader.ReadPDPacketData<WPDTeamBattlefield>();
			this.teamBattlefieldAvailableRewards = reader.ReadPDPacketDatas<WPDTeamBattlefieldAvailableReward>();
			this.jobBattlefield = reader.ReadPDPacketData<WPDJobBattlefield>();
			this.jobBattlefieldAvailableRewards = reader.ReadPDPacketDatas<WPDJobBattlefieldAvailableReward>();
			this.jobBattlefieldWinnerBuffs = reader.ReadPDPacketDatas<WPDJobBattlefieldWinnerBuff>();
			this.guildBattlefield = reader.ReadPDPacketData<WPDGuildBattlefield>();
			this.guildBattlefieldAvailableRewards = reader.ReadPDPacketDatas<WPDGuildBattlefieldAvailableReward>();
			this.guildBattlefieldWinnerBuffs = reader.ReadPDPacketDatas<WPDGuildBattlefieldWinnerBuff>();
			this.linkPlaces = reader.ReadPDPacketDatas<WPDLinkPlace>();
			this.actualTraining = reader.ReadPDPacketData<WPDActualTraining>();
			this.beadLevels = reader.ReadPDPacketDatas<WPDBeadLevel>();
			this.beadMakeSteps = reader.ReadPDPacketDatas<WPDBeadMakeStep>();
			this.beadSocketExtendRecipes = reader.ReadPDPacketDatas<WPDBeadSocketExtendRecipe>();
			this.pvpModes = reader.ReadPDPacketDatas<WPDPvpMode>();
			this.chaoticSteps = reader.ReadPDPacketDatas<WPDChaoticStep>();
			this.guildDonationEntries = reader.ReadPDPacketDatas<WPDGuildDonationEntry>();
			this.guildBuffs = reader.ReadPDPacketDatas<WPDGuildBuff>();
			this.guildBuffLevels = reader.ReadPDPacketDatas<WPDGuildBuffLevel>();
			this.guildProducts = reader.ReadPDPacketDatas<WPDGuildProduct>();
			this.guildDungeons = reader.ReadPDPacketDatas<WPDGuildDungeon>();
			this.guildDungeonAvailableRewards = reader.ReadPDPacketDatas<WPDGuildDungeonAvailableReward>();
			this.guildMemberGrades = reader.ReadPDPacketDatas<WPDGuildMemberGrade>();
			this.secretChamber = reader.ReadPDPacketData<WPDSecretChamber>();
			this.secretChamberAvailableRewards = reader.ReadPDPacketDatas<WPDSecretChamberAvailableReward>();
			this.secretChamberFloors = reader.ReadPDPacketDatas<WPDSecretChamberFloor>();
			this.secretChamberFloorPortals = reader.ReadPDPacketDatas<WPDSecretChamberFloorPortal>();
			this.fallenCity = reader.ReadPDPacketData<WPDFallenCity>();
			this.fallenCityAvailableRewards = reader.ReadPDPacketDatas<WPDFallenCityAvailableReward>();
			this.fallenCityHiddenBossMonsters = reader.ReadPDPacketDatas<WPDFallenCityHiddenBossMonster>();
			this.gearGradeDisassembleResults = reader.ReadPDPacketDatas<WPDGearGradeDisassembleResult>();
			this.constellations = reader.ReadPDPacketDatas<WPDConstellation>();
			this.constellationSteps = reader.ReadPDPacketDatas<WPDConstellationStep>();
			this.constellationCycles = reader.ReadPDPacketDatas<WPDConstellationCycle>();
			this.constellationCycleBuffs = reader.ReadPDPacketDatas<WPDConstellationCycleBuff>();
			this.constellationStepEntries = reader.ReadPDPacketDatas<WPDConstellationStepEntry>();
			this.constellationStepEntryBuffs = reader.ReadPDPacketDatas<WPDConstellationStepEntryBuff>();
			this.inAppProducts = reader.ReadPDPacketDatas<WPDInAppProduct>();
			this.inAppProductPrices = reader.ReadPDPacketDatas<WPDInAppProductPrice>();
			this.purchaseProducts = reader.ReadPDPacketDatas<WPDPurchaseProduct>();
			this.mainQuestAdjustTokens = reader.ReadPDPacketDatas<WPDMainQuestAdjustToken>();
			this.gameTips = reader.ReadPDPacketDatas<WPDGameTip>();
			this.banWords = reader.ReadPDPacketDatas<WPDBanWord>();
			this.gearGrades = reader.ReadPDPacketDatas<WPDGearGrade>();
			this.gearSkillDegreeSteps = reader.ReadPDPacketDatas<WPDGearSkillDegreeStep>();
			this.continentBossMonsterAvailableRewards = reader.ReadPDPacketDatas<WPDContinentBossMonsterAvailableReward>();
			this.continentBossMonsterSpawnSchedules = reader.ReadPDPacketDatas<WPDContinentBossMonsterSpawnSchedule>();
			this.mountTiers = reader.ReadPDPacketDatas<WPDMountTier>();
			this.mountTierLevels = reader.ReadPDPacketDatas<WPDMountTierLevel>();
			this.storyDungeons = reader.ReadPDPacketDatas<WPDStoryDungeon>();
			this.storyDungeonAvailableRewards = reader.ReadPDPacketDatas<WPDStoryDungeonAvailableReward>();
			this.storyDungeonClearGrades = reader.ReadPDPacketDatas<WPDStoryDungeonClearGrade>();
			this.storyDungeonObstacles = reader.ReadPDPacketDatas<WPDStoryDungeonObstacle>();
			this.storyDungeonDifficulties = reader.ReadPDPacketDatas<WPDStoryDungeonDifficulty>();
			this.expDungeons = reader.ReadPDPacketDatas<WPDExpDungeon>();
			this.expDungeonAvailableRewards = reader.ReadPDPacketDatas<WPDExpDungeonAvailableReward>();
			this.expDungeonClearGrades = reader.ReadPDPacketDatas<WPDExpDungeonClearGrade>();
			this.expDungeonDifficulties = reader.ReadPDPacketDatas<WPDExpDungeonDifficulty>();
			this.goldDungeons = reader.ReadPDPacketDatas<WPDGoldDungeon>();
			this.goldDungeonAvailableRewards = reader.ReadPDPacketDatas<WPDGoldDungeonAvailableReward>();
			this.goldDungeonDifficulties = reader.ReadPDPacketDatas<WPDGoldDungeonDifficulty>();
			this.ankouTomb = reader.ReadPDPacketData<WPDAnkouTomb>();
			this.ankouTombDifficulties = reader.ReadPDPacketDatas<WPDAnkouTombDifficulty>();
			this.ankouTombAvailableRewards = reader.ReadPDPacketDatas<WPDAnkouTombAvailableReward>();
			this.ankouTombOpenSchedules = reader.ReadPDPacketDatas<WPDAnkouTombOpenSchedule>();
			this.bossAnnihilation = reader.ReadPDPacketData<WPDBossAnnihilation>();
			this.bossAnnihilationDifficulties = reader.ReadPDPacketDatas<WPDBossAnnihilationDifficulty>();
			this.bossAnnihilationAvailableRewards = reader.ReadPDPacketDatas<WPDBossAnnihilationAvailableReward>();
			this.bossAnnihilationOpenSchedules = reader.ReadPDPacketDatas<WPDBossAnnihilationOpenSchedule>();
			this.tradeShip = reader.ReadPDPacketData<WPDTradeShip>();
			this.tradeShipDifficulties = reader.ReadPDPacketDatas<WPDTradeShipDifficulty>();
			this.tradeShipAvailableRewards = reader.ReadPDPacketDatas<WPDTradeShipAvailableReward>();
			this.tradeShipObstacles = reader.ReadPDPacketDatas<WPDTradeShipObstacle>();
			this.tradeShipSteps = reader.ReadPDPacketDatas<WPDTradeShipStep>();
			this.tradeShipOpenSchedules = reader.ReadPDPacketDatas<WPDTradeShipOpenSchedule>();
			this.tradeShipObjects = reader.ReadPDPacketDatas<WPDTradeShipObject>();
			this.levelUpMasterEvent = reader.ReadPDPacketData<WPDLevelUpMasterEvent>();
			this.levelUpMasterEventEntries = reader.ReadPDPacketDatas<WPDLevelUpMasterEventEntry>();
			this.levelUpMasterEventEntryRewards = reader.ReadPDPacketDatas<WPDLevelUpMasterEventEntryReward>();
			this.bossSlayerEvent = reader.ReadPDPacketData<WPDBossSlayerEvent>();
			this.bossSlayerEventRankings = reader.ReadPDPacketDatas<WPDBossSlayerEventRanking>();
			this.bossSlayerEventRankingRewards = reader.ReadPDPacketDatas<WPDBossSlayerEventRankingReward>();
			this.chargeMasterEvent = reader.ReadPDPacketData<WPDChargeMasterEvent>();
			this.chargeMasterEventRankings = reader.ReadPDPacketDatas<WPDChargeMasterEventRanking>();
			this.chargeMasterEventRankingRewards = reader.ReadPDPacketDatas<WPDChargeMasterEventRankingReward>();
			this.consumeMasterEvent = reader.ReadPDPacketData<WPDConsumeMasterEvent>();
			this.consumeMasterEventRankings = reader.ReadPDPacketDatas<WPDConsumeMasterEventRanking>();
			this.consumeMasterEventRankingRewards = reader.ReadPDPacketDatas<WPDConsumeMasterEventRankingReward>();
			this.superCashbackEvent = reader.ReadPDPacketData<WPDSuperCashbackEvent>();
			this.superCashbackEventEntries = reader.ReadPDPacketDatas<WPDSuperCashbackEventEntry>();
			this.superCashbackEventRankings = reader.ReadPDPacketDatas<WPDSuperCashbackEventRanking>();
			this.continuationChargeEntries = reader.ReadPDPacketDatas<WPDContinuationChargeEntry>();
			this.continuationChargeEntryRewards = reader.ReadPDPacketDatas<WPDContinuationChargeEntryReward>();
			this.dailyChargeEntries = reader.ReadPDPacketDatas<WPDDailyChargeEntry>();
			this.dailyChargeEntryRewards = reader.ReadPDPacketDatas<WPDDailyChargeEntryReward>();
			this.accumulateChargeEntries = reader.ReadPDPacketDatas<WPDAccumulateChargeEntry>();
			this.accumulateChargeEntryRewards = reader.ReadPDPacketDatas<WPDAccumulateChargeEntryReward>();
			this.accumulateConsumeEntries = reader.ReadPDPacketDatas<WPDAccumulateConsumeEntry>();
			this.accumulateConsumeEntryRewards = reader.ReadPDPacketDatas<WPDAccumulateConsumeEntryReward>();
			this.actualTrainingAdditionalEnters = reader.ReadPDPacketDatas<WPDActualTrainingAdditionalEnter>();
			this.storyDungeonAdditionalEnters = reader.ReadPDPacketDatas<WPDStoryDungeonAdditionalEnter>();
			this.helpEntries = reader.ReadPDPacketDatas<WPDHelpEntry>();
			this.day30Rewards = reader.ReadPDPacketDatas<WPDDay30Reward>();
			this.firstChargeEvent = reader.ReadPDPacketData<WPDFirstChargeEvent>();
			this.firstChargeEventRewards = reader.ReadPDPacketDatas<WPDFirstChargeEventReward>();
			this.levelUpPackageEvent = reader.ReadPDPacketData<WPDLevelUpPackageEvent>();
			this.levelUpPackageEventEntries = reader.ReadPDPacketDatas<WPDLevelUpPackageEventEntry>();
			this.levelUpPackageEvent2 = reader.ReadPDPacketData<WPDLevelUpPackageEvent2>();
			this.levelUpPackageEvent2Entries = reader.ReadPDPacketDatas<WPDLevelUpPackageEvent2Entry>();
			this.levelUpPackageEvent3 = reader.ReadPDPacketData<WPDLevelUpPackageEvent3>();
			this.levelUpPackageEvent3Entries = reader.ReadPDPacketDatas<WPDLevelUpPackageEvent3Entry>();
			this.dungeonKingEvent = reader.ReadPDPacketData<WPDDungeonKingEvent>();
			this.dungeonKingEventEntries = reader.ReadPDPacketDatas<WPDDungeonKingEventEntry>();
			this.luckyBagEvent = reader.ReadPDPacketData<WPDLuckyBagEvent>();
			this.luckyBagEventRewardEntries = reader.ReadPDPacketDatas<WPDLuckyBagEventRewardEntry>();
			this.fullMoonBuffs = reader.ReadPDPacketDatas<WPDFullMoonBuff>();
			this.essenceExchangeRounds = reader.ReadPDPacketDatas<WPDEssenceExchangeRound>();
			this.essenceExchangeRoundEntries = reader.ReadPDPacketDatas<WPDEssenceExchangeRoundEntry>();
			this.essenceExchangeRoundRewardEntries = reader.ReadPDPacketDatas<WPDEssenceExchangeRoundRewardEntry>();
			this.gearAttrEnchantLevelAttrs = reader.ReadPDPacketDatas<WPDGearAttrEnchantLevelAttr>();
			this.gearAttrEnchantRecipes = reader.ReadPDPacketDatas<WPDGearAttrEnchantRecipe>();
			this.gearRunes = reader.ReadPDPacketDatas<WPDGearRune>();
			this.gearRuneEnchantSettings = reader.ReadPDPacketDatas<WPDGearRuneEnchantSetting>();
			this.gearRuneEnchantRecipes = reader.ReadPDPacketDatas<WPDGearRuneEnchantRecipe>();
			this.gearTypeRunes = reader.ReadPDPacketDatas<WPDGearTypeRune>();
			this.petEquippedSlotExtendRecipes = reader.ReadPDPacketDatas<WPDPetEquippedSlotExtendRecipe>();
			this.patterns = reader.ReadPDPacketDatas<WPDPattern>();
			this.gearAttrEnchantLevelInheritRecipes = reader.ReadPDPacketDatas<WPDGearAttrEnchantLevelInheritRecipe>();
			this.skyDungeons = reader.ReadPDPacketDatas<WPDSkyDungeon>();
			this.skyDungeonAvailableRewards = reader.ReadPDPacketDatas<WPDSkyDungeonAvailableReward>();
			this.skyDungeonObstacles = reader.ReadPDPacketDatas<WPDSkyDungeonObstacle>();
			this.skyDungeonClearGrades = reader.ReadPDPacketDatas<WPDSkyDungeonClearGrade>();
			this.costumeTypes = reader.ReadPDPacketDatas<WPDCostumeType>();
			this.costumes = reader.ReadPDPacketDatas<WPDCostume>();
			this.costumeLevels = reader.ReadPDPacketDatas<WPDCostumeLevel>();
			this.costumeLevelAttrs = reader.ReadPDPacketDatas<WPDCostumeLevelAttr>();
			this.deadTipLowLevelEntries = reader.ReadPDPacketDatas<WPDDeadTipLowLevelEntry>();
			this.deadTipHighLevelEntries = reader.ReadPDPacketDatas<WPDDeadTipHighLevelEntry>();
			this.heroLevelDeadTipHighLevelEntries = reader.ReadPDPacketDatas<WPDHeroLevelDeadTipHighLevelEntry>();
			this.pickCostumeAvailableProducts = reader.ReadPDPacketDatas<WPDPickCostumeAvailableProduct>();
			this.eventLists = reader.ReadPDPacketDatas<WPDEventList>();
			this.day30DiaRewards = reader.ReadPDPacketDatas<WPDDay30DiaReward>();
		}

		public string SerializeBase64String()
		{
			byte[] inArray;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				WPacketWriter writer = new WPacketWriter(memoryStream);
				this.Serialize(writer);
				inArray = memoryStream.ToArray();
			}
			return Convert.ToBase64String(inArray);
		}

		public void DeserializeFromBase64String(string sData)
		{
			byte[] buffer = Convert.FromBase64String(sData);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				WPacketReader reader = new WPacketReader(memoryStream);
				this.Deserialize(reader);
			}
		}

		public WPDGameDatas()
		{
		}

		public WPDGameConfig gameConfig;

		public WPDHero[] heros;

		public WPDFace[] faces;

		public WPDHeroLevel[] heroLevels;

		public WPDTradition[] traditions;

		public WPDFame[] fames;

		public WPDFameBuff[] fameBuffs;

		public WPDAchieve[] achieves;

		public WPDHeroAchieve[] heroAchieves;

		public WPDHeroAchieveBuff[] heroAchieveBuffs;

		public WPDGear[] gears;

		public WPDGearTier[] gearTiers;

		public WPDGearType[] gearTypes;

		public WPDGearAttr[] gearAttrs;

		public WPDGearOptionAttr[] gearOptionAttrs;

		public WPDGrade[] grades;

		public WPDElemental[] elementals;

		public WPDAttr[] attrs;

		public WPDItemType[] itemTypes;

		public WPDItem[] items;

		public WPDGearDisassembleResult[] gearDisassembleResults;

		public WPDRuneRecipe[] runeRecipes;

		public WPDJewelRecipe[] jewelRecipes;

		public WPDShineOrichalcumRecipe[] shineOrichalcumRecipes;

		public WPDHeroSkill[] heroSkills;

		public WPDContinent[] continents;

		public WPDRegion[] regions;

		public WPDPortal[] portals;

		public WPDNpc[] npcs;

		public WPDMainChapter[] mainChapters;

		public WPDMainChapterBuff[] mainChapterBuffs;

		public WPDMonster[] monsters;

		public WPDMonsterSkill[] monsterSkills;

		public WPDGearEnchantRecipe[] gearEnchantRecipes;

		public WPDGearEnchantLevelInheritRecipe[] gearEnchantLevelInheritRecipes;

		public WPDGearElementalEnchantRecipe[] gearElementalEnchantRecipes;

		public WPDGearElementalChangeRecipe[] gearElementalChangeRecipes;

		public WPDGearElementalLevelInheritRecipe[] gearElementalLevelInheritRecipes;

		public WPDGearComposeRecipe[] gearComposeRecipes;

		public WPDGearTranscendRecipe[] gearTranscendRecipes;

		public WPDContinentMonsterPosition[] continentMonsterPositions;

		public WPDInventorySlotExtendRecipe[] inventorySlotExtendRecipes;

		public WPDWarehouseSlotExtendRecipe[] warehouseSlotExtendRecipes;

		public WPDGearEnchantLevelAttr[] gearEnchantLevelAttrs;

		public WPDGearElementalLevel[] gearElementalLevels;

		public WPDAchieveMaster[] achieveMasters;

		public WPDMonsterBookContinentBuff[] monsterBookContinentBuffs;

		public WPDTraditionBuff[] traditionBuffs;

		public WPDVipLevel[] vipLevels;

		public WPDVipLevelBuff[] vipLevelBuffs;

		public WPDVipLevelReward[] vipLevelRewards;

		public WPDStatWeightingFactor[] statWeightingFactors;

		public WPDEquippedGearEnchantSet[] equippedGearEnchantSets;

		public WPDEquippedGearEnchantSetBuff[] equippedGearEnchantSetBuffs;

		public WPDEquippedGearGradeSet[] equippedGearGradeSets;

		public WPDEquippedGearGradeSetBuff[] equippedGearGradeSetBuffs;

		public WPDCursedDock cursedDock;

		public WPDCursedDockNpc cursedDockNpc;

		public WPDCursedDockClearGrade[] cursedDockClearGrades;

		public WPDCursedDockWayPoint[] cursedDockWayPoints;

		public WPDCursedDockAvailableReward[] cursedDockAvailableRewards;

		public WPDMarketCategory[] marketCategories;

		public WPDLocation[] locations;

		public WPDGouthanMine gouthanMine;

		public WPDGouthanMineMineral[] gouthanMineMinerals;

		public WPDGouthanMineMineralArrange[] gouthanMineMineralArranges;

		public WPDGouthanMineEventSchedule[] gouthanMineEventSchedules;

		public WPDSystemMessage[] systemMessages;

		public WPDMenuActivation[] menuActivations;

		public WPDGrowthEntry[] growthEntries;

		public WPDHeroLevelGrowthEntry[] heroLevelGrowthEntries;

		public WPDHeroSetGear[] heroSetGears;

		public WPDMoneyBuff[] moneyBuffs;

		public WPDMoneyBuffAttr[] moneyBuffAttrs;

		public WPDDailyQuestReward[] dailyQuestRewards;

		public WPDDailyQuestRewardItem[] dailyQuestRewardItems;

		public WPDDailyQuestRoundReward[] dailyQuestRoundRewards;

		public WPDDailyQuestRoundRewardItem[] dailyQuestRoundRewardItems;

		public WPDSuppressionQuestRoundReward[] suppressionQuestRoundRewards;

		public WPDMarbleRecipe marbleRecipe;

		public WPDPetPhase[] petPhases;

		public WPDPet[] pets;

		public WPDPetLevel[] petLevels;

		public WPDFieldOfHonor fieldOfHonor;

		public WPDFieldOfHonorRankingReward[] fieldOfHonorRankingRewards;

		public WPDFieldOfHonorRankingRewardItem[] fieldOfHonorRankingRewardItems;

		public WPDAbyssTower abyssTower;

		public WPDAbyssTowerFloor[] abyssTowerFloors;

		public WPDAbyssTowerFloorRewardItem[] abyssTowerFloorRewardItems;

		public WPDArena arena;

		public WPDArenaWinnerBuff[] arenaWinnerBuffs;

		public WPDArenaAvailableReward[] arenaAvailableRewards;

		public WPDArenaOpenSchedule[] arenaOpenSchedules;

		public WPDTeamBattlefield teamBattlefield;

		public WPDTeamBattlefieldAvailableReward[] teamBattlefieldAvailableRewards;

		public WPDJobBattlefield jobBattlefield;

		public WPDJobBattlefieldAvailableReward[] jobBattlefieldAvailableRewards;

		public WPDJobBattlefieldWinnerBuff[] jobBattlefieldWinnerBuffs;

		public WPDGuildBattlefield guildBattlefield;

		public WPDGuildBattlefieldAvailableReward[] guildBattlefieldAvailableRewards;

		public WPDGuildBattlefieldWinnerBuff[] guildBattlefieldWinnerBuffs;

		public WPDLinkPlace[] linkPlaces;

		public WPDActualTraining actualTraining;

		public WPDBeadLevel[] beadLevels;

		public WPDBeadMakeStep[] beadMakeSteps;

		public WPDBeadSocketExtendRecipe[] beadSocketExtendRecipes;

		public WPDPvpMode[] pvpModes;

		public WPDChaoticStep[] chaoticSteps;

		public WPDGuildDonationEntry[] guildDonationEntries;

		public WPDGuildBuff[] guildBuffs;

		public WPDGuildBuffLevel[] guildBuffLevels;

		public WPDGuildProduct[] guildProducts;

		public WPDGuildDungeon[] guildDungeons;

		public WPDGuildDungeonAvailableReward[] guildDungeonAvailableRewards;

		public WPDGuildMemberGrade[] guildMemberGrades;

		public WPDSecretChamber secretChamber;

		public WPDSecretChamberAvailableReward[] secretChamberAvailableRewards;

		public WPDSecretChamberFloor[] secretChamberFloors;

		public WPDSecretChamberFloorPortal[] secretChamberFloorPortals;

		public WPDFallenCity fallenCity;

		public WPDFallenCityAvailableReward[] fallenCityAvailableRewards;

		public WPDFallenCityHiddenBossMonster[] fallenCityHiddenBossMonsters;

		public WPDGearGradeDisassembleResult[] gearGradeDisassembleResults;

		public WPDConstellation[] constellations;

		public WPDConstellationStep[] constellationSteps;

		public WPDConstellationCycle[] constellationCycles;

		public WPDConstellationCycleBuff[] constellationCycleBuffs;

		public WPDConstellationStepEntry[] constellationStepEntries;

		public WPDConstellationStepEntryBuff[] constellationStepEntryBuffs;

		public WPDInAppProduct[] inAppProducts;

		public WPDInAppProductPrice[] inAppProductPrices;

		public WPDPurchaseProduct[] purchaseProducts;

		public WPDMainQuestAdjustToken[] mainQuestAdjustTokens;

		public WPDGameTip[] gameTips;

		public WPDBanWord[] banWords;

		public WPDGearGrade[] gearGrades;

		public WPDGearSkillDegreeStep[] gearSkillDegreeSteps;

		public WPDContinentBossMonsterAvailableReward[] continentBossMonsterAvailableRewards;

		public WPDContinentBossMonsterSpawnSchedule[] continentBossMonsterSpawnSchedules;

		public WPDMountTier[] mountTiers;

		public WPDMountTierLevel[] mountTierLevels;

		public WPDStoryDungeon[] storyDungeons;

		public WPDStoryDungeonAvailableReward[] storyDungeonAvailableRewards;

		public WPDStoryDungeonClearGrade[] storyDungeonClearGrades;

		public WPDStoryDungeonObstacle[] storyDungeonObstacles;

		public WPDStoryDungeonDifficulty[] storyDungeonDifficulties;

		public WPDExpDungeon[] expDungeons;

		public WPDExpDungeonAvailableReward[] expDungeonAvailableRewards;

		public WPDExpDungeonClearGrade[] expDungeonClearGrades;

		public WPDExpDungeonDifficulty[] expDungeonDifficulties;

		public WPDGoldDungeon[] goldDungeons;

		public WPDGoldDungeonAvailableReward[] goldDungeonAvailableRewards;

		public WPDGoldDungeonDifficulty[] goldDungeonDifficulties;

		public WPDAnkouTomb ankouTomb;

		public WPDAnkouTombDifficulty[] ankouTombDifficulties;

		public WPDAnkouTombAvailableReward[] ankouTombAvailableRewards;

		public WPDAnkouTombOpenSchedule[] ankouTombOpenSchedules;

		public WPDBossAnnihilation bossAnnihilation;

		public WPDBossAnnihilationDifficulty[] bossAnnihilationDifficulties;

		public WPDBossAnnihilationAvailableReward[] bossAnnihilationAvailableRewards;

		public WPDBossAnnihilationOpenSchedule[] bossAnnihilationOpenSchedules;

		public WPDTradeShip tradeShip;

		public WPDTradeShipDifficulty[] tradeShipDifficulties;

		public WPDTradeShipAvailableReward[] tradeShipAvailableRewards;

		public WPDTradeShipObstacle[] tradeShipObstacles;

		public WPDTradeShipStep[] tradeShipSteps;

		public WPDTradeShipOpenSchedule[] tradeShipOpenSchedules;

		public WPDTradeShipObject[] tradeShipObjects;

		public WPDLevelUpMasterEvent levelUpMasterEvent;

		public WPDLevelUpMasterEventEntry[] levelUpMasterEventEntries;

		public WPDLevelUpMasterEventEntryReward[] levelUpMasterEventEntryRewards;

		public WPDBossSlayerEvent bossSlayerEvent;

		public WPDBossSlayerEventRanking[] bossSlayerEventRankings;

		public WPDBossSlayerEventRankingReward[] bossSlayerEventRankingRewards;

		public WPDChargeMasterEvent chargeMasterEvent;

		public WPDChargeMasterEventRanking[] chargeMasterEventRankings;

		public WPDChargeMasterEventRankingReward[] chargeMasterEventRankingRewards;

		public WPDConsumeMasterEvent consumeMasterEvent;

		public WPDConsumeMasterEventRanking[] consumeMasterEventRankings;

		public WPDConsumeMasterEventRankingReward[] consumeMasterEventRankingRewards;

		public WPDSuperCashbackEvent superCashbackEvent;

		public WPDSuperCashbackEventEntry[] superCashbackEventEntries;

		public WPDSuperCashbackEventRanking[] superCashbackEventRankings;

		public WPDContinuationChargeEntry[] continuationChargeEntries;

		public WPDContinuationChargeEntryReward[] continuationChargeEntryRewards;

		public WPDDailyChargeEntry[] dailyChargeEntries;

		public WPDDailyChargeEntryReward[] dailyChargeEntryRewards;

		public WPDAccumulateChargeEntry[] accumulateChargeEntries;

		public WPDAccumulateChargeEntryReward[] accumulateChargeEntryRewards;

		public WPDAccumulateConsumeEntry[] accumulateConsumeEntries;

		public WPDAccumulateConsumeEntryReward[] accumulateConsumeEntryRewards;

		public WPDActualTrainingAdditionalEnter[] actualTrainingAdditionalEnters;

		public WPDStoryDungeonAdditionalEnter[] storyDungeonAdditionalEnters;

		public WPDHelpEntry[] helpEntries;

		public WPDDay30Reward[] day30Rewards;

		public WPDFirstChargeEvent firstChargeEvent;

		public WPDFirstChargeEventReward[] firstChargeEventRewards;

		public WPDLevelUpPackageEvent levelUpPackageEvent;

		public WPDLevelUpPackageEventEntry[] levelUpPackageEventEntries;

		public WPDLevelUpPackageEvent2 levelUpPackageEvent2;

		public WPDLevelUpPackageEvent2Entry[] levelUpPackageEvent2Entries;

		public WPDLevelUpPackageEvent3 levelUpPackageEvent3;

		public WPDLevelUpPackageEvent3Entry[] levelUpPackageEvent3Entries;

		public WPDDungeonKingEvent dungeonKingEvent;

		public WPDDungeonKingEventEntry[] dungeonKingEventEntries;

		public WPDLuckyBagEvent luckyBagEvent;

		public WPDLuckyBagEventRewardEntry[] luckyBagEventRewardEntries;

		public WPDFullMoonBuff[] fullMoonBuffs;

		public WPDEssenceExchangeRound[] essenceExchangeRounds;

		public WPDEssenceExchangeRoundEntry[] essenceExchangeRoundEntries;

		public WPDEssenceExchangeRoundRewardEntry[] essenceExchangeRoundRewardEntries;

		public WPDGearAttrEnchantLevelAttr[] gearAttrEnchantLevelAttrs;

		public WPDGearAttrEnchantRecipe[] gearAttrEnchantRecipes;

		public WPDGearRune[] gearRunes;

		public WPDGearRuneEnchantSetting[] gearRuneEnchantSettings;

		public WPDGearRuneEnchantRecipe[] gearRuneEnchantRecipes;

		public WPDGearTypeRune[] gearTypeRunes;

		public WPDPetEquippedSlotExtendRecipe[] petEquippedSlotExtendRecipes;

		public WPDPattern[] patterns;

		public WPDGearAttrEnchantLevelInheritRecipe[] gearAttrEnchantLevelInheritRecipes;

		public WPDSkyDungeon[] skyDungeons;

		public WPDSkyDungeonAvailableReward[] skyDungeonAvailableRewards;

		public WPDSkyDungeonObstacle[] skyDungeonObstacles;

		public WPDSkyDungeonClearGrade[] skyDungeonClearGrades;

		public WPDCostumeType[] costumeTypes;

		public WPDCostume[] costumes;

		public WPDCostumeLevel[] costumeLevels;

		public WPDCostumeLevelAttr[] costumeLevelAttrs;

		public WPDDeadTipLowLevelEntry[] deadTipLowLevelEntries;

		public WPDDeadTipHighLevelEntry[] deadTipHighLevelEntries;

		public WPDHeroLevelDeadTipHighLevelEntry[] heroLevelDeadTipHighLevelEntries;

		public WPDPickCostumeAvailableProduct[] pickCostumeAvailableProducts;

		public WPDEventList[] eventLists;

		public WPDDay30DiaReward[] day30DiaRewards;
	}
}
