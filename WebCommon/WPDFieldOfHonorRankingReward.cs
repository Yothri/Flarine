using System;

namespace WebCommon
{
	public class WPDFieldOfHonorRankingReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.minRank);
			writer.Write(this.maxRank);
			writer.Write(this.exp);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.minRank = reader.ReadInt32();
			this.maxRank = reader.ReadInt32();
			this.exp = reader.ReadInt32();
		}

		public WPDFieldOfHonorRankingReward()
		{
		}

		public int minRank;

		public int maxRank;

		public int exp;
	}
}
