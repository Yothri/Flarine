using System;

namespace WebCommon
{
	public class WPDBossSlayerEventRanking : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ranking);
			writer.Write(this.minKillCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.ranking = reader.ReadInt32();
			this.minKillCount = reader.ReadInt32();
		}

		public WPDBossSlayerEventRanking()
		{
		}

		public int ranking;

		public int minKillCount;
	}
}
