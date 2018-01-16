using System;

namespace WebCommon
{
	public class WPDChargeMasterEventRankingReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.rewardNo);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.rewardNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDChargeMasterEventRankingReward()
		{
		}

		public int ranking;

		public int rewardNo;

		public int itemId;

		public int count;
	}
}
