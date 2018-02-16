using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorRankingsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fieldOfHonorRankings);
			writer.Write(this.rankingEquippedGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fieldOfHonorRankings = reader.ReadPDPacketDatas<PDFieldOfHonorRanking>();
			this.rankingEquippedGears = reader.ReadPDPacketDatas<PDRankingEquippedGear>();
		}

		public FieldOfHonorRankingsResponseBody()
		{
		}

		public PDFieldOfHonorRanking[] fieldOfHonorRankings;

		public PDRankingEquippedGear[] rankingEquippedGears;
	}
}
