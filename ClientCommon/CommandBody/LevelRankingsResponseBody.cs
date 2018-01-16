using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LevelRankingsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.levelRankings);
			writer.Write(this.rankingEquippedGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.levelRankings = reader.ReadPDPacketDatas<PDLevelRanking>();
			this.rankingEquippedGear = reader.ReadPDPacketDatas<PDRankingEquippedGear>();
		}

		public LevelRankingsResponseBody()
		{
		}

		public PDLevelRanking[] levelRankings;

		public PDRankingEquippedGear[] rankingEquippedGear;
	}
}
