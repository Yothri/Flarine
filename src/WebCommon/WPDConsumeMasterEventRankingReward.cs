using System;

namespace WebCommon
{
	public class WPDConsumeMasterEventRankingReward : WPDPacketData
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

		public WPDConsumeMasterEventRankingReward()
		{
		}

		public int ranking;

		public int rewardNo;

		public int itemId;

		public int count;
	}
}
