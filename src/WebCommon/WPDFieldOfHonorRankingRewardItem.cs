using System;

namespace WebCommon
{
	public class WPDFieldOfHonorRankingRewardItem : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.minRank);
			writer.Write(this.maxRank);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.minRank = reader.ReadInt32();
			this.maxRank = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
		}

		public WPDFieldOfHonorRankingRewardItem()
		{
		}

		public int minRank;

		public int maxRank;

		public int itemId;

		public int itemCount;
	}
}
