using System;

namespace WebCommon
{
	public class WPDDailyActiveReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardNo);
			writer.Write(this.activePoint);
			writer.Write(this.ownGold);
			writer.Write(this.magicPowder);
			writer.Write(this.vipPoint);
			writer.Write(this.receivedRewardNo);
			writer.Write(this.date);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardNo = reader.ReadInt32();
			this.activePoint = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.vipPoint = reader.ReadInt32();
			this.receivedRewardNo = reader.ReadInt32();
			this.date = reader.ReadString();
		}

		public WPDDailyActiveReward()
		{
		}

		public int rewardNo;

		public int activePoint;

		public int ownGold;

		public int magicPowder;

		public int vipPoint;

		public int receivedRewardNo;

		public string date;
	}
}
