using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GoldRankingsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.goldRankings);
			writer.Write(this.rankingEquippedGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.goldRankings = reader.ReadPDPacketDatas<PDGoldRanking>();
			this.rankingEquippedGear = reader.ReadPDPacketDatas<PDRankingEquippedGear>();
		}

		public GoldRankingsResponseBody()
		{
		}

		public PDGoldRanking[] goldRankings;

		public PDRankingEquippedGear[] rankingEquippedGear;
	}
}
