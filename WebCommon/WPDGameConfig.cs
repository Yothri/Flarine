using System;

namespace WebCommon
{
	public class WPDGameConfig : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.elementalLevelWeightingFactor);
			writer.Write(this.dailyQuestRoundCount);
			writer.Write(this.dailyQuestRoundClearUnOwnDia);
			writer.Write(this.dailyQuestStarGradeUpGold);
			writer.Write(this.dailyQuestClearUnOwnDiaPerRound);
			writer.Write(this.suppressionQuestRewardOwnDia);
			writer.Write(this.suppressionQuestRoundCount);
			writer.Write(this.storyDungeonEnterCount);
			writer.Write(this.storyDungeonLimitTime);
			writer.Write(this.storyDungeonRewardDuration);
			writer.Write(this.serverTime);
			writer.Write(this.trainingStartDelayTime);
			writer.Write(this.trainingTimeMaxAmount);
			writer.Write(this.training2xExpInterval);
			writer.Write(this.training2xExpGold);
			writer.Write(this.training4xExpInterval);
			writer.Write(this.training4xExpUnOwnDia);
			writer.Write(this.hpPotionCoolTime);
			writer.Write(this.pickWarehouseSlotCount);
			writer.Write(this.pickFreeInterval);
			writer.Write(this.pick1xUnOwnDia);
			writer.Write(this.pick10xUnOwnDia);
			writer.Write(this.pickGear1xUnOwnDia);
			writer.Write(this.pickGear10xUnOwnDia);
			writer.Write(this.maxFriendCount);
			writer.Write(this.maxEnemyFriendCount);
			writer.Write(this.maxBlockFriendCount);
			writer.Write(this.tradeRequestDuration);
			writer.Write(this.tradeSlotCount);
			writer.Write(this.marketRegistLimitLevel);
			writer.Write(this.marketPurchaseLimitLevel);
			writer.Write(this.marketFeeRate);
			writer.Write(this.marketRegistLimitCount);
			writer.Write(this.resurrectionUnOwnDia);
			writer.Write(this.maxDailyGoldBarUseCount);
			writer.Write(this.partyInvitationPopUpDisplayed);
			writer.Write(this.partyMemberMaxCount);
			writer.Write(this.partyRequestReceiveMaxCount);
			writer.Write(this.surroundingPartyMaxCount);
			writer.Write(this.surroundingUserMaxCount);
			writer.Write(this.praiseTotalGold);
			writer.Write(this.praiseTotalGoldExp);
			writer.Write(this.praiseTotalGoldFame);
			writer.Write(this.praiseUnOwnDia);
			writer.Write(this.praiseUnOwnDiaExp);
			writer.Write(this.praiseUnOwnDiaFame);
			writer.Write(this.flyRequiredMainQuestId);
			writer.Write(this.mountEnchantRequiredMainQuestId);
			writer.Write(this.townWaitingPkPointDecInterval);
			writer.Write(this.townWaitingPkPointDecAmount);
			writer.Write(this.petInventorySlotCount);
			writer.Write(this.petEquipSlotCount);
			writer.Write(this.pickPetFreeInterval);
			writer.Write(this.pickPet1xUnOwnDia);
			writer.Write(this.pickPet10xUnOwnDia);
			writer.Write(this.pickPetWarehouseSlotCount);
			writer.Write(this.beadInventorySlotCount);
			writer.Write(this.beadSocketCount);
			writer.Write(this.beadMakeStepChangeUnOwnDia);
			writer.Write(this.guildRequiredMainQuestId);
			writer.Write(this.guildExecutiveMemberCount);
			writer.Write(this.guildMemberMaxCount);
			writer.Write(this.guildMakeRequiredHeroLevel);
			writer.Write(this.guildMakeRequiredOwnGold);
			writer.Write(this.guildBuffLevelMax);
			writer.Write(this.gearSkillDegreeIncreaseAmount);
			writer.Write(this.gearDurabilityDecreaseAmount);
			writer.Write(this.gearDurabilityIncreaseTotalGold);
			writer.Write(this.takeoffMotionDuration);
			writer.Write(this.helpDisplayDuration);
			writer.Write(this.helpDisplayInterval);
			writer.Write(this.essenceExchangeDuration);
			writer.Write(this.essenceExchangeRoundCount);
			writer.Write(this.partyDungeonAdInterval);
			writer.Write(this.inventorySlotMaxCount);
			writer.Write(this.warehouseSlotMaxCount);
			writer.Write(this.monsterReturnDistance);
			writer.Write(this.guildJoinInterval);
			writer.Write(this.gearRuneInheritGold);
			writer.Write(this.gearRuneInheritGoldRate);
			writer.Write(this.gearRuneInheritUnOwnDia);
			writer.Write(this.gearComposeBlessRate1);
			writer.Write(this.gearComposeBlessRate2);
			writer.Write(this.gearComposeBlessRate3);
			writer.Write(this.blessScrollEnabled);
			writer.Write(this.heroHighLevelMinLevel);
			writer.Write(this.fpRecoveryAmount);
			writer.Write(this.fpRecoveryInterval);
			writer.Write(this.nameRegex);
			writer.Write(this.guildNameRegex);
			writer.Write(this.guildBreakUpDelayTime);
			writer.Write(this.guildBreakUpInformInterval);
			writer.Write(this.pickCostume1xUnOwnDia);
			writer.Write(this.pickCostume10xUnOwnDia);
			writer.Write(this.automaticHpPotionCoolTime);
			writer.Write(this.manualHpPotionCoolTime);
			writer.Write(this.partyInvitationLifetime);
			writer.Write(this.marketPetSaleable);
			writer.Write(this.languageChatEnabled);
			writer.Write(this.autoBattleBaseSetting);
			writer.Write(this.autoBattleConditionEnabled);
			writer.Write(this.autoQuestBaseSetting);
			writer.Write(this.chattingMinInterval);
			writer.Write(this.autoCounterAttackTraceDistance);
			writer.Write(this.specialPackagePopupVipLevel);
			writer.Write(this.specialPackagePopupHeroLevel);
			writer.Write(this.marketMoneyType);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.elementalLevelWeightingFactor = reader.ReadInt32();
			this.dailyQuestRoundCount = reader.ReadInt32();
			this.dailyQuestRoundClearUnOwnDia = reader.ReadInt32();
			this.dailyQuestStarGradeUpGold = reader.ReadInt32();
			this.dailyQuestClearUnOwnDiaPerRound = reader.ReadInt32();
			this.suppressionQuestRewardOwnDia = reader.ReadInt32();
			this.suppressionQuestRoundCount = reader.ReadInt32();
			this.storyDungeonEnterCount = reader.ReadInt32();
			this.storyDungeonLimitTime = reader.ReadInt32();
			this.storyDungeonRewardDuration = reader.ReadInt32();
			this.serverTime = reader.ReadString();
			this.trainingStartDelayTime = reader.ReadInt32();
			this.trainingTimeMaxAmount = reader.ReadInt32();
			this.training2xExpInterval = reader.ReadInt32();
			this.training2xExpGold = reader.ReadInt32();
			this.training4xExpInterval = reader.ReadInt32();
			this.training4xExpUnOwnDia = reader.ReadInt32();
			this.hpPotionCoolTime = reader.ReadInt32();
			this.pickWarehouseSlotCount = reader.ReadInt32();
			this.pickFreeInterval = reader.ReadInt32();
			this.pick1xUnOwnDia = reader.ReadInt32();
			this.pick10xUnOwnDia = reader.ReadInt32();
			this.pickGear1xUnOwnDia = reader.ReadInt32();
			this.pickGear10xUnOwnDia = reader.ReadInt32();
			this.maxFriendCount = reader.ReadInt32();
			this.maxEnemyFriendCount = reader.ReadInt32();
			this.maxBlockFriendCount = reader.ReadInt32();
			this.tradeRequestDuration = reader.ReadInt32();
			this.tradeSlotCount = reader.ReadInt32();
			this.marketRegistLimitLevel = reader.ReadInt32();
			this.marketPurchaseLimitLevel = reader.ReadInt32();
			this.marketFeeRate = reader.ReadInt32();
			this.marketRegistLimitCount = reader.ReadInt32();
			this.resurrectionUnOwnDia = reader.ReadInt32();
			this.maxDailyGoldBarUseCount = reader.ReadInt32();
			this.partyInvitationPopUpDisplayed = reader.ReadBoolean();
			this.partyMemberMaxCount = reader.ReadInt32();
			this.partyRequestReceiveMaxCount = reader.ReadInt32();
			this.surroundingPartyMaxCount = reader.ReadInt32();
			this.surroundingUserMaxCount = reader.ReadInt32();
			this.praiseTotalGold = reader.ReadInt32();
			this.praiseTotalGoldExp = reader.ReadInt32();
			this.praiseTotalGoldFame = reader.ReadInt32();
			this.praiseUnOwnDia = reader.ReadInt32();
			this.praiseUnOwnDiaExp = reader.ReadInt32();
			this.praiseUnOwnDiaFame = reader.ReadInt32();
			this.flyRequiredMainQuestId = reader.ReadInt32();
			this.mountEnchantRequiredMainQuestId = reader.ReadInt32();
			this.townWaitingPkPointDecInterval = reader.ReadInt32();
			this.townWaitingPkPointDecAmount = reader.ReadInt32();
			this.petInventorySlotCount = reader.ReadInt32();
			this.petEquipSlotCount = reader.ReadInt32();
			this.pickPetFreeInterval = reader.ReadInt32();
			this.pickPet1xUnOwnDia = reader.ReadInt32();
			this.pickPet10xUnOwnDia = reader.ReadInt32();
			this.pickPetWarehouseSlotCount = reader.ReadInt32();
			this.beadInventorySlotCount = reader.ReadInt32();
			this.beadSocketCount = reader.ReadInt32();
			this.beadMakeStepChangeUnOwnDia = reader.ReadInt32();
			this.guildRequiredMainQuestId = reader.ReadInt32();
			this.guildExecutiveMemberCount = reader.ReadInt32();
			this.guildMemberMaxCount = reader.ReadInt32();
			this.guildMakeRequiredHeroLevel = reader.ReadInt32();
			this.guildMakeRequiredOwnGold = reader.ReadInt32();
			this.guildBuffLevelMax = reader.ReadInt32();
			this.gearSkillDegreeIncreaseAmount = reader.ReadInt32();
			this.gearDurabilityDecreaseAmount = reader.ReadInt32();
			this.gearDurabilityIncreaseTotalGold = reader.ReadInt32();
			this.takeoffMotionDuration = reader.ReadInt32();
			this.helpDisplayDuration = reader.ReadInt32();
			this.helpDisplayInterval = reader.ReadInt32();
			this.essenceExchangeDuration = reader.ReadInt32();
			this.essenceExchangeRoundCount = reader.ReadInt32();
			this.partyDungeonAdInterval = reader.ReadInt32();
			this.inventorySlotMaxCount = reader.ReadInt32();
			this.warehouseSlotMaxCount = reader.ReadInt32();
			this.monsterReturnDistance = reader.ReadDouble();
			this.guildJoinInterval = reader.ReadInt32();
			this.gearRuneInheritGold = reader.ReadInt32();
			this.gearRuneInheritGoldRate = reader.ReadInt32();
			this.gearRuneInheritUnOwnDia = reader.ReadInt32();
			this.gearComposeBlessRate1 = reader.ReadInt32();
			this.gearComposeBlessRate2 = reader.ReadInt32();
			this.gearComposeBlessRate3 = reader.ReadInt32();
			this.blessScrollEnabled = reader.ReadBoolean();
			this.heroHighLevelMinLevel = reader.ReadInt32();
			this.fpRecoveryAmount = reader.ReadInt32();
			this.fpRecoveryInterval = reader.ReadInt32();
			this.nameRegex = reader.ReadString();
			this.guildNameRegex = reader.ReadString();
			this.guildBreakUpDelayTime = reader.ReadInt32();
			this.guildBreakUpInformInterval = reader.ReadInt32();
			this.pickCostume1xUnOwnDia = reader.ReadInt32();
			this.pickCostume10xUnOwnDia = reader.ReadInt32();
			this.automaticHpPotionCoolTime = reader.ReadInt32();
			this.manualHpPotionCoolTime = reader.ReadInt32();
			this.partyInvitationLifetime = reader.ReadInt32();
			this.marketPetSaleable = reader.ReadBoolean();
			this.languageChatEnabled = reader.ReadBoolean();
			this.autoBattleBaseSetting = reader.ReadBoolean();
			this.autoBattleConditionEnabled = reader.ReadBoolean();
			this.autoQuestBaseSetting = reader.ReadBoolean();
			this.chattingMinInterval = reader.ReadInt32();
			this.autoCounterAttackTraceDistance = reader.ReadInt32();
			this.specialPackagePopupVipLevel = reader.ReadInt32();
			this.specialPackagePopupHeroLevel = reader.ReadInt32();
			this.marketMoneyType = reader.ReadInt32();
		}

		public WPDGameConfig()
		{
		}

		public int elementalLevelWeightingFactor;

		public int dailyQuestRoundCount;

		public int dailyQuestRoundClearUnOwnDia;

		public int dailyQuestStarGradeUpGold;

		public int dailyQuestClearUnOwnDiaPerRound;

		public int suppressionQuestRewardOwnDia;

		public int suppressionQuestRoundCount;

		public int storyDungeonEnterCount;

		public int storyDungeonLimitTime;

		public int storyDungeonRewardDuration;

		public string serverTime;

		public int trainingStartDelayTime;

		public int trainingTimeMaxAmount;

		public int training2xExpInterval;

		public int training2xExpGold;

		public int training4xExpInterval;

		public int training4xExpUnOwnDia;

		public int hpPotionCoolTime;

		public int pickWarehouseSlotCount;

		public int pickFreeInterval;

		public int pick1xUnOwnDia;

		public int pick10xUnOwnDia;

		public int pickGear1xUnOwnDia;

		public int pickGear10xUnOwnDia;

		public int maxFriendCount;

		public int maxEnemyFriendCount;

		public int maxBlockFriendCount;

		public int tradeRequestDuration;

		public int tradeSlotCount;

		public int marketRegistLimitLevel;

		public int marketPurchaseLimitLevel;

		public int marketFeeRate;

		public int marketRegistLimitCount;

		public int resurrectionUnOwnDia;

		public int maxDailyGoldBarUseCount;

		public bool partyInvitationPopUpDisplayed;

		public int partyMemberMaxCount;

		public int partyRequestReceiveMaxCount;

		public int surroundingPartyMaxCount;

		public int surroundingUserMaxCount;

		public int praiseTotalGold;

		public int praiseTotalGoldExp;

		public int praiseTotalGoldFame;

		public int praiseUnOwnDia;

		public int praiseUnOwnDiaExp;

		public int praiseUnOwnDiaFame;

		public int flyRequiredMainQuestId;

		public int mountEnchantRequiredMainQuestId;

		public int townWaitingPkPointDecInterval;

		public int townWaitingPkPointDecAmount;

		public int petInventorySlotCount;

		public int petEquipSlotCount;

		public int pickPetFreeInterval;

		public int pickPet1xUnOwnDia;

		public int pickPet10xUnOwnDia;

		public int pickPetWarehouseSlotCount;

		public int beadInventorySlotCount;

		public int beadSocketCount;

		public int beadMakeStepChangeUnOwnDia;

		public int guildRequiredMainQuestId;

		public int guildExecutiveMemberCount;

		public int guildMemberMaxCount;

		public int guildMakeRequiredHeroLevel;

		public int guildMakeRequiredOwnGold;

		public int guildBuffLevelMax;

		public int gearSkillDegreeIncreaseAmount;

		public int gearDurabilityDecreaseAmount;

		public int gearDurabilityIncreaseTotalGold;

		public int takeoffMotionDuration;

		public int helpDisplayDuration;

		public int helpDisplayInterval;

		public int essenceExchangeDuration;

		public int essenceExchangeRoundCount;

		public int partyDungeonAdInterval;

		public int inventorySlotMaxCount;

		public int warehouseSlotMaxCount;

		public double monsterReturnDistance;

		public int guildJoinInterval;

		public int gearRuneInheritGold;

		public int gearRuneInheritGoldRate;

		public int gearRuneInheritUnOwnDia;

		public int gearComposeBlessRate1;

		public int gearComposeBlessRate2;

		public int gearComposeBlessRate3;

		public bool blessScrollEnabled;

		public int heroHighLevelMinLevel;

		public int fpRecoveryAmount;

		public int fpRecoveryInterval;

		public string nameRegex;

		public string guildNameRegex;

		public int guildBreakUpDelayTime;

		public int guildBreakUpInformInterval;

		public int pickCostume1xUnOwnDia;

		public int pickCostume10xUnOwnDia;

		public int automaticHpPotionCoolTime;

		public int manualHpPotionCoolTime;

		public int partyInvitationLifetime;

		public bool marketPetSaleable;

		public bool languageChatEnabled;

		public bool autoBattleBaseSetting;

		public bool autoBattleConditionEnabled;

		public bool autoQuestBaseSetting;

		public int chattingMinInterval;

		public int autoCounterAttackTraceDistance;

		public int specialPackagePopupVipLevel;

		public int specialPackagePopupHeroLevel;

		public int marketMoneyType;
	}
}
