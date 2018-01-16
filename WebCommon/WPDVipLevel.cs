using System;

namespace WebCommon
{
	public class WPDVipLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.vipLevel);
			writer.Write(this.requiredTotalVipPoint);
			writer.Write(this.rewardMagicPowder);
			writer.Write(this.rewardStarEssence);
			writer.Write(this.teleportEnabled);
			writer.Write(this.remoteWarehouseEnabled);
			writer.Write(this.remotePotionShopEnabled);
			writer.Write(this.dailyQuestCompleteEnabled);
			writer.Write(this.fieldOfHonorWaitingTimeRemoved);
			writer.Write(this.additionalEnchantSuccessRate);
			writer.Write(this.resurrectionCount);
			writer.Write(this.additionalUseGoldCount);
			writer.Write(this.additionalActivePoint);
			writer.Write(this.fieldOfHonorBuyLimitCount);
			writer.Write(this.training2xExpEnabled);
			writer.Write(this.training4xExpEnabled);
			writer.Write(this.additionalTombEnterCount);
			writer.Write(this.additionalTradeShipEnterCount);
			writer.Write(this.additionalExchangeGoldCount);
			writer.Write(this.additionalExchangeOwnGoldCount);
			writer.Write(this.additionalExchangeDiaCount);
			writer.Write(this.additionalExchangeOwnDiaCount);
			writer.Write(this.vipBossDungeonEnabled);
			writer.Write(this.vipGoldDungeonEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.vipLevel = reader.ReadInt32();
			this.requiredTotalVipPoint = reader.ReadInt32();
			this.rewardMagicPowder = reader.ReadInt32();
			this.rewardStarEssence = reader.ReadInt32();
			this.teleportEnabled = reader.ReadBoolean();
			this.remoteWarehouseEnabled = reader.ReadBoolean();
			this.remotePotionShopEnabled = reader.ReadBoolean();
			this.dailyQuestCompleteEnabled = reader.ReadBoolean();
			this.fieldOfHonorWaitingTimeRemoved = reader.ReadBoolean();
			this.additionalEnchantSuccessRate = reader.ReadInt32();
			this.resurrectionCount = reader.ReadInt32();
			this.additionalUseGoldCount = reader.ReadInt32();
			this.additionalActivePoint = reader.ReadInt32();
			this.fieldOfHonorBuyLimitCount = reader.ReadInt32();
			this.training2xExpEnabled = reader.ReadBoolean();
			this.training4xExpEnabled = reader.ReadBoolean();
			this.additionalTombEnterCount = reader.ReadInt32();
			this.additionalTradeShipEnterCount = reader.ReadInt32();
			this.additionalExchangeGoldCount = reader.ReadInt32();
			this.additionalExchangeOwnGoldCount = reader.ReadInt32();
			this.additionalExchangeDiaCount = reader.ReadInt32();
			this.additionalExchangeOwnDiaCount = reader.ReadInt32();
			this.vipBossDungeonEnabled = reader.ReadBoolean();
			this.vipGoldDungeonEnabled = reader.ReadBoolean();
		}

		public WPDVipLevel()
		{
		}

		public int vipLevel;

		public int requiredTotalVipPoint;

		public int rewardMagicPowder;

		public int rewardStarEssence;

		public bool teleportEnabled;

		public bool remoteWarehouseEnabled;

		public bool remotePotionShopEnabled;

		public bool dailyQuestCompleteEnabled;

		public bool fieldOfHonorWaitingTimeRemoved;

		public int additionalEnchantSuccessRate;

		public int resurrectionCount;

		public int additionalUseGoldCount;

		public int additionalActivePoint;

		public int fieldOfHonorBuyLimitCount;

		public bool training2xExpEnabled;

		public bool training4xExpEnabled;

		public int additionalTombEnterCount;

		public int additionalTradeShipEnterCount;

		public int additionalExchangeGoldCount;

		public int additionalExchangeOwnGoldCount;

		public int additionalExchangeDiaCount;

		public int additionalExchangeOwnDiaCount;

		public bool vipBossDungeonEnabled;

		public bool vipGoldDungeonEnabled;
	}
}
