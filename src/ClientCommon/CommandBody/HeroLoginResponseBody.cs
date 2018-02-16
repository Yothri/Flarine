using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class HeroLoginResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.arenaWinnerId);
			writer.Write(this.worldBuffs);
			writer.Write(this.spawnedContinentBossMonsters);
			writer.Write(this.continentId);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
			writer.Write(this.dropObjects);
			writer.Write(this.arenaStatue);
			writer.Write(this.guildBattlefieldStatue);
			writer.Write(this.myAccountHero);
			writer.Write(this.isGM);
			writer.Write(this.vipLevel);
			writer.Write(this.vipPoint);
			writer.Write(this.dia);
			writer.Write(this.totalPurchasedDia);
			writer.Write(this.totalConsumedDia);
			writer.Write(this.fp);
			writer.Write(this.fpAutoRecoveryRemainingTime);
			writer.Write(this.trainingTime);
			writer.Write(this.freeItemPickElapsedTime);
			writer.Write(this.elixirBuffs);
			writer.Write(this.continuationLoginCount);
			writer.Write(this.accumulateLoginCount);
			writer.Write(this.fieldOfHonorRanking);
			writer.Write(this.fieldOfHonorBestSuccessiveVictories);
			writer.Write(this.fieldOfHonorWaitingRemainingTime);
			writer.Write(this.fieldOfHonorRankingRewardRemainingTime);
			writer.Write(this.arenaWinnerBuffRemainingTime);
			writer.Write(this.abyssTowerFloor);
			writer.Write(this.isBossAnnihilationEnterable);
			writer.Write(this.pvpModeId);
			writer.Write(this.pkPoint);
			writer.Write(this.enemyIds);
			writer.Write(this.heart);
			writer.Write(this.beadMakeStepId);
			writer.Write(this.guildBuffs);
			writer.Write(this.jobBattlefieldWinnerBuffRemainingTime);
			writer.Write(this.guildAutoJoinRefused);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.guildBattlefieldWinnerBuffRemainingTime);
			writer.Write(this.guildMemberGrade);
			writer.Write(this.guildPoint);
			writer.Write(this.mountTier);
			writer.Write(this.mountTierExp);
			writer.Write(this.mountLevel);
			writer.Write(this.mountLevelExp);
			writer.Write(this.purchaseProductBuyCounts);
			writer.Write(this.isFirstPurchase);
			writer.Write(this.levelUpMasterEventEntryRewardLogs);
			writer.Write(this.bossSlayerEventRanking);
			writer.Write(this.bossSlayerEventRewardReceived);
			writer.Write(this.chargeMasterEventRanking);
			writer.Write(this.chargeMasterEventRewardReceived);
			writer.Write(this.consumeMasterEventRanking);
			writer.Write(this.consumeMasterEventRewardReceived);
			writer.Write(this.superCashbackEventEntryId);
			writer.Write(this.superCashbackEventRanking);
			writer.Write(this.superCashbackEventCashbackBonusUnOwnDia);
			writer.Write(this.superCashbackEventRewardReceived);
			writer.Write(this.continuationChargeDayCount);
			writer.Write(this.lastChargeTime);
			writer.Write(this.accumulateChargeRewardReceiveEntryIds);
			writer.Write(this.accumulateConsumeRewardReceiveEntryIds);
			writer.Write(this.fullMoonBuffId);
			writer.Write(this.fullMoonBuffRemainingTime);
			writer.Write(this.dungeonKingEventClearCount);
			writer.Write(this.dungeonKingEventEntryLogs);
			writer.Write(this.levelUpPackageRemainingTime);
			writer.Write(this.levelUpPackageEventEntryLogs);
			writer.Write(this.levelUpPackage2RemainingTime);
			writer.Write(this.levelUpPackageEvent2EntryLogs);
			writer.Write(this.levelUpPackage3RemainingTime);
			writer.Write(this.levelUpPackageEvent3EntryLogs);
			writer.Write(this.firstChargeEventAccomplished);
			writer.Write(this.firstChargeEventRewardReceived);
			writer.Write(this.day30StartDate);
			writer.Write(this.day30EndDate);
			writer.Write(this.day30RewardReceiveDays);
			writer.Write(this.day30DiaStartDate);
			writer.Write(this.day30DiaEndDate);
			writer.Write(this.day30DiaRewardReceiveDays);
			writer.Write(this.essenceExchangeContinents);
			writer.Write(this.patternId);
			writer.Write(this.patternRemainingTime);
			writer.Write(this.costumes);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
			writer.Write(this.smallPotionPrefered);
			writer.Write(this.isAutomaticUseHpPotion);
			writer.Write(this.automaticHpPotionId);
			writer.Write(this.manualHpPotionId);
			writer.Write(this.date);
			writer.Write(this.dailyAccumulatePlayTime);
			writer.Write(this.revivalCount);
			writer.Write(this.storyDungeonPlayCounts);
			writer.Write(this.expDungeonPlayCount);
			writer.Write(this.expDungeonPlayCountOfLastDate);
			writer.Write(this.goldDungeonPlayCount);
			writer.Write(this.goldDungeonPlayCountOfLastDate);
			writer.Write(this.cursedDockPlayCount);
			writer.Write(this.cursedDockPlayCountOfLastDate);
			writer.Write(this.fallenCityPlayCount);
			writer.Write(this.fallenCityPlayCountOfLastDate);
			writer.Write(this.secretChamberPlayCount);
			writer.Write(this.secretChamberPlayCountOfLastDate);
			writer.Write(this.ankouTombPlayCount);
			writer.Write(this.ankouTombPlayCountOfLastDate);
			writer.Write(this.tradeShipPlayCount);
			writer.Write(this.tradeShipPlayCountOfLastDate);
			writer.Write(this.bossAnnihilationPlayCount);
			writer.Write(this.bossAnnihilationPlayCountOfLastDate);
			writer.Write(this.arenaPlayCount);
			writer.Write(this.arenaPlayCountOfLastDate);
			writer.Write(this.gouthanMineMiningCount);
			writer.Write(this.gouthanMineMiningCountOfLastDate);
			writer.Write(this.actualTrainingTurn);
			writer.Write(this.actualTrainingRemainingTime);
			writer.Write(this.actualTrainingTurnOfLastDate);
			writer.Write(this.actualTrainingRemainingTimeOfLastDate);
			writer.Write(this.abyssTowerSweepCount);
			writer.Write(this.teamBattlefieldPlayCount);
			writer.Write(this.teamBattlefieldPlayCountOfLastDate);
			writer.Write(this.guildBattlefieldPlayCount);
			writer.Write(this.guildBattlefieldPlayCountOfLastDate);
			writer.Write(this.jobBattlefieldPlayCount);
			writer.Write(this.possibleGuildBattlefieldPraise);
			writer.Write(this.dailyQuest);
			writer.Write(this.dailyQuestOfLastDate);
			writer.Write(this.suppressionQuest);
			writer.Write(this.suppressionQuestOfLastDate);
			writer.Write(this.cheerAccountHeroes);
			writer.Write(this.fieldOfHonorFreePlayCount);
			writer.Write(this.fieldOfHonorVipPlayCount);
			writer.Write(this.fieldOfHonorFreePlayCountOfLastDate);
			writer.Write(this.possiblePraise);
			writer.Write(this.itemTypeUseCounts);
			writer.Write(this.dailyAccumulateChargeDia);
			writer.Write(this.dailyChargeRewardReceiveEntryIds);
			writer.Write(this.continuationChargeRewardReceiveList);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.arenaWinnerId = reader.ReadInt32();
			this.worldBuffs = reader.ReadPDPacketDatas<PDWorldBuff>();
			this.spawnedContinentBossMonsters = reader.ReadInts();
			this.continentId = reader.ReadInt32();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.dropObjects = reader.ReadPDPacketDatas<PDDropObject>();
			this.arenaStatue = reader.ReadPDPacketData<PDArenaStatue>();
			this.guildBattlefieldStatue = reader.ReadPDPacketData<PDGuildBattlefieldStatue>();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.isGM = reader.ReadBoolean();
			this.vipLevel = reader.ReadInt32();
			this.vipPoint = reader.ReadInt32();
			this.dia = reader.ReadInt32();
			this.totalPurchasedDia = reader.ReadInt32();
			this.totalConsumedDia = reader.ReadInt32();
			this.fp = reader.ReadInt32();
			this.fpAutoRecoveryRemainingTime = reader.ReadSingle();
			this.trainingTime = reader.ReadInt32();
			this.freeItemPickElapsedTime = reader.ReadInt32();
			this.elixirBuffs = reader.ReadPDPacketDatas<PDAccountHeroElixirBuff>();
			this.continuationLoginCount = reader.ReadInt32();
			this.accumulateLoginCount = reader.ReadInt32();
			this.fieldOfHonorRanking = reader.ReadInt32();
			this.fieldOfHonorBestSuccessiveVictories = reader.ReadInt32();
			this.fieldOfHonorWaitingRemainingTime = reader.ReadSingle();
			this.fieldOfHonorRankingRewardRemainingTime = reader.ReadSingle();
			this.arenaWinnerBuffRemainingTime = reader.ReadSingle();
			this.abyssTowerFloor = reader.ReadInt32();
			this.isBossAnnihilationEnterable = reader.ReadBoolean();
			this.pvpModeId = reader.ReadInt32();
			this.pkPoint = reader.ReadInt32();
			this.enemyIds = reader.ReadInts();
			this.heart = reader.ReadInt64();
			this.beadMakeStepId = reader.ReadInt32();
			this.guildBuffs = reader.ReadPDPacketDatas<PDAccountHeroGuildBuff>();
			this.jobBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
			this.guildAutoJoinRefused = reader.ReadBoolean();
			this.guildId = reader.ReadNullableGuid();
			this.guildName = reader.ReadString();
			this.guildBattlefieldWinnerBuffRemainingTime = reader.ReadSingle();
			this.guildMemberGrade = reader.ReadInt32();
			this.guildPoint = reader.ReadInt32();
			this.mountTier = reader.ReadInt32();
			this.mountTierExp = reader.ReadInt32();
			this.mountLevel = reader.ReadInt32();
			this.mountLevelExp = reader.ReadInt32();
			this.purchaseProductBuyCounts = reader.ReadPDPacketDatas<PDPurchaseProductBuyCount>();
			this.isFirstPurchase = reader.ReadBoolean();
			this.levelUpMasterEventEntryRewardLogs = reader.ReadInts();
			this.bossSlayerEventRanking = reader.ReadInt32();
			this.bossSlayerEventRewardReceived = reader.ReadBoolean();
			this.chargeMasterEventRanking = reader.ReadInt32();
			this.chargeMasterEventRewardReceived = reader.ReadBoolean();
			this.consumeMasterEventRanking = reader.ReadInt32();
			this.consumeMasterEventRewardReceived = reader.ReadBoolean();
			this.superCashbackEventEntryId = reader.ReadInt32();
			this.superCashbackEventRanking = reader.ReadInt32();
			this.superCashbackEventCashbackBonusUnOwnDia = reader.ReadInt32();
			this.superCashbackEventRewardReceived = reader.ReadBoolean();
			this.continuationChargeDayCount = reader.ReadInt32();
			this.lastChargeTime = reader.ReadNullableDateTimeOffset();
			this.accumulateChargeRewardReceiveEntryIds = reader.ReadInts();
			this.accumulateConsumeRewardReceiveEntryIds = reader.ReadInts();
			this.fullMoonBuffId = reader.ReadInt32();
			this.fullMoonBuffRemainingTime = reader.ReadSingle();
			this.dungeonKingEventClearCount = reader.ReadInt32();
			this.dungeonKingEventEntryLogs = reader.ReadInts();
			this.levelUpPackageRemainingTime = reader.ReadSingle();
			this.levelUpPackageEventEntryLogs = reader.ReadInts();
			this.levelUpPackage2RemainingTime = reader.ReadSingle();
			this.levelUpPackageEvent2EntryLogs = reader.ReadInts();
			this.levelUpPackage3RemainingTime = reader.ReadSingle();
			this.levelUpPackageEvent3EntryLogs = reader.ReadInts();
			this.firstChargeEventAccomplished = reader.ReadBoolean();
			this.firstChargeEventRewardReceived = reader.ReadBoolean();
			this.day30StartDate = reader.ReadNullableDateTime();
			this.day30EndDate = reader.ReadNullableDateTime();
			this.day30RewardReceiveDays = reader.ReadInts();
			this.day30DiaStartDate = reader.ReadNullableDateTime();
			this.day30DiaEndDate = reader.ReadNullableDateTime();
			this.day30DiaRewardReceiveDays = reader.ReadInts();
			this.essenceExchangeContinents = reader.ReadPDPacketDatas<PDAccountHeroEssenceExchangeContinent>();
			this.patternId = reader.ReadInt32();
			this.patternRemainingTime = reader.ReadSingle();
			this.costumes = reader.ReadPDPacketDatas<PDAccountHeroCostume>();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
			this.smallPotionPrefered = reader.ReadBoolean();
			this.isAutomaticUseHpPotion = reader.ReadBoolean();
			this.automaticHpPotionId = reader.ReadInt32();
			this.manualHpPotionId = reader.ReadInt32();
			this.date = reader.ReadDateTime();
			this.dailyAccumulatePlayTime = reader.ReadSingle();
			this.revivalCount = reader.ReadInt32();
			this.storyDungeonPlayCounts = reader.ReadPDPacketDatas<PDStoryDungeonPlayCount>();
			this.expDungeonPlayCount = reader.ReadInt32();
			this.expDungeonPlayCountOfLastDate = reader.ReadInt32();
			this.goldDungeonPlayCount = reader.ReadInt32();
			this.goldDungeonPlayCountOfLastDate = reader.ReadInt32();
			this.cursedDockPlayCount = reader.ReadInt32();
			this.cursedDockPlayCountOfLastDate = reader.ReadInt32();
			this.fallenCityPlayCount = reader.ReadInt32();
			this.fallenCityPlayCountOfLastDate = reader.ReadInt32();
			this.secretChamberPlayCount = reader.ReadInt32();
			this.secretChamberPlayCountOfLastDate = reader.ReadInt32();
			this.ankouTombPlayCount = reader.ReadInt32();
			this.ankouTombPlayCountOfLastDate = reader.ReadInt32();
			this.tradeShipPlayCount = reader.ReadInt32();
			this.tradeShipPlayCountOfLastDate = reader.ReadInt32();
			this.bossAnnihilationPlayCount = reader.ReadInt32();
			this.bossAnnihilationPlayCountOfLastDate = reader.ReadInt32();
			this.arenaPlayCount = reader.ReadInt32();
			this.arenaPlayCountOfLastDate = reader.ReadInt32();
			this.gouthanMineMiningCount = reader.ReadInt32();
			this.gouthanMineMiningCountOfLastDate = reader.ReadInt32();
			this.actualTrainingTurn = reader.ReadInt32();
			this.actualTrainingRemainingTime = reader.ReadSingle();
			this.actualTrainingTurnOfLastDate = reader.ReadInt32();
			this.actualTrainingRemainingTimeOfLastDate = reader.ReadSingle();
			this.abyssTowerSweepCount = reader.ReadInt32();
			this.teamBattlefieldPlayCount = reader.ReadInt32();
			this.teamBattlefieldPlayCountOfLastDate = reader.ReadInt32();
			this.guildBattlefieldPlayCount = reader.ReadInt32();
			this.guildBattlefieldPlayCountOfLastDate = reader.ReadInt32();
			this.jobBattlefieldPlayCount = reader.ReadInt32();
			this.possibleGuildBattlefieldPraise = reader.ReadBoolean();
			this.dailyQuest = reader.ReadPDPacketData<PDAccountHeroDailyQuest>();
			this.dailyQuestOfLastDate = reader.ReadPDPacketData<PDAccountHeroDailyQuest>();
			this.suppressionQuest = reader.ReadPDPacketData<PDAccountHeroSuppressionQuest>();
			this.suppressionQuestOfLastDate = reader.ReadPDPacketData<PDAccountHeroSuppressionQuest>();
			this.cheerAccountHeroes = reader.ReadInts();
			this.fieldOfHonorFreePlayCount = reader.ReadInt32();
			this.fieldOfHonorVipPlayCount = reader.ReadInt32();
			this.fieldOfHonorFreePlayCountOfLastDate = reader.ReadInt32();
			this.possiblePraise = reader.ReadBoolean();
			this.itemTypeUseCounts = reader.ReadPDPacketDatas<PDAccountHeroItemTypeUseCount>();
			this.dailyAccumulateChargeDia = reader.ReadInt32();
			this.dailyChargeRewardReceiveEntryIds = reader.ReadInts();
			this.continuationChargeRewardReceiveList = reader.ReadInts();
		}

		public HeroLoginResponseBody()
		{
		}

		public int arenaWinnerId;

		public PDWorldBuff[] worldBuffs;

		public int[] spawnedContinentBossMonsters;

		public int continentId;

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;

		public PDDropObject[] dropObjects;

		public PDArenaStatue arenaStatue;

		public PDGuildBattlefieldStatue guildBattlefieldStatue;

		public PDAccountHero myAccountHero;

		public bool isGM;

		public int vipLevel;

		public int vipPoint;

		public int dia;

		public int totalPurchasedDia;

		public int totalConsumedDia;

		public int fp;

		public float fpAutoRecoveryRemainingTime;

		public int trainingTime;

		public int freeItemPickElapsedTime;

		public PDAccountHeroElixirBuff[] elixirBuffs;

		public int continuationLoginCount;

		public int accumulateLoginCount;

		public int fieldOfHonorRanking;

		public int fieldOfHonorBestSuccessiveVictories;

		public float fieldOfHonorWaitingRemainingTime;

		public float fieldOfHonorRankingRewardRemainingTime;

		public float arenaWinnerBuffRemainingTime;

		public int abyssTowerFloor;

		public bool isBossAnnihilationEnterable;

		public int pvpModeId;

		public int pkPoint;

		public int[] enemyIds;

		public long heart;

		public int beadMakeStepId;

		public PDAccountHeroGuildBuff[] guildBuffs;

		public float jobBattlefieldWinnerBuffRemainingTime;

		public bool guildAutoJoinRefused;

		public Guid? guildId;

		public string guildName;

		public float guildBattlefieldWinnerBuffRemainingTime;

		public int guildMemberGrade;

		public int guildPoint;

		public int mountTier;

		public int mountTierExp;

		public int mountLevel;

		public int mountLevelExp;

		public PDPurchaseProductBuyCount[] purchaseProductBuyCounts;

		public bool isFirstPurchase;

		public int[] levelUpMasterEventEntryRewardLogs;

		public int bossSlayerEventRanking;

		public bool bossSlayerEventRewardReceived;

		public int chargeMasterEventRanking;

		public bool chargeMasterEventRewardReceived;

		public int consumeMasterEventRanking;

		public bool consumeMasterEventRewardReceived;

		public int superCashbackEventEntryId;

		public int superCashbackEventRanking;

		public int superCashbackEventCashbackBonusUnOwnDia;

		public bool superCashbackEventRewardReceived;

		public int continuationChargeDayCount;

		public DateTimeOffset? lastChargeTime;

		public int[] accumulateChargeRewardReceiveEntryIds;

		public int[] accumulateConsumeRewardReceiveEntryIds;

		public int fullMoonBuffId;

		public float fullMoonBuffRemainingTime;

		public int dungeonKingEventClearCount;

		public int[] dungeonKingEventEntryLogs;

		public float levelUpPackageRemainingTime;

		public int[] levelUpPackageEventEntryLogs;

		public float levelUpPackage2RemainingTime;

		public int[] levelUpPackageEvent2EntryLogs;

		public float levelUpPackage3RemainingTime;

		public int[] levelUpPackageEvent3EntryLogs;

		public bool firstChargeEventAccomplished;

		public bool firstChargeEventRewardReceived;

		public DateTime? day30StartDate;

		public DateTime? day30EndDate;

		public int[] day30RewardReceiveDays;

		public DateTime? day30DiaStartDate;

		public DateTime? day30DiaEndDate;

		public int[] day30DiaRewardReceiveDays;

		public PDAccountHeroEssenceExchangeContinent[] essenceExchangeContinents;

		public int patternId;

		public float patternRemainingTime;

		public PDAccountHeroCostume[] costumes;

		public int costumeId;

		public bool costumeVisible;

		public bool smallPotionPrefered;

		public bool isAutomaticUseHpPotion;

		public int automaticHpPotionId;

		public int manualHpPotionId;

		public DateTime date;

		public float dailyAccumulatePlayTime;

		public int revivalCount;

		public PDStoryDungeonPlayCount[] storyDungeonPlayCounts;

		public int expDungeonPlayCount;

		public int expDungeonPlayCountOfLastDate;

		public int goldDungeonPlayCount;

		public int goldDungeonPlayCountOfLastDate;

		public int cursedDockPlayCount;

		public int cursedDockPlayCountOfLastDate;

		public int fallenCityPlayCount;

		public int fallenCityPlayCountOfLastDate;

		public int secretChamberPlayCount;

		public int secretChamberPlayCountOfLastDate;

		public int ankouTombPlayCount;

		public int ankouTombPlayCountOfLastDate;

		public int tradeShipPlayCount;

		public int tradeShipPlayCountOfLastDate;

		public int bossAnnihilationPlayCount;

		public int bossAnnihilationPlayCountOfLastDate;

		public int arenaPlayCount;

		public int arenaPlayCountOfLastDate;

		public int gouthanMineMiningCount;

		public int gouthanMineMiningCountOfLastDate;

		public int actualTrainingTurn;

		public float actualTrainingRemainingTime;

		public int actualTrainingTurnOfLastDate;

		public float actualTrainingRemainingTimeOfLastDate;

		public int abyssTowerSweepCount;

		public int teamBattlefieldPlayCount;

		public int teamBattlefieldPlayCountOfLastDate;

		public int guildBattlefieldPlayCount;

		public int guildBattlefieldPlayCountOfLastDate;

		public int jobBattlefieldPlayCount;

		public bool possibleGuildBattlefieldPraise;

		public PDAccountHeroDailyQuest dailyQuest;

		public PDAccountHeroDailyQuest dailyQuestOfLastDate;

		public PDAccountHeroSuppressionQuest suppressionQuest;

		public PDAccountHeroSuppressionQuest suppressionQuestOfLastDate;

		public int[] cheerAccountHeroes;

		public int fieldOfHonorFreePlayCount;

		public int fieldOfHonorVipPlayCount;

		public int fieldOfHonorFreePlayCountOfLastDate;

		public bool possiblePraise;

		public PDAccountHeroItemTypeUseCount[] itemTypeUseCounts;

		public int dailyAccumulateChargeDia;

		public int[] dailyChargeRewardReceiveEntryIds;

		public int[] continuationChargeRewardReceiveList;
	}
}
