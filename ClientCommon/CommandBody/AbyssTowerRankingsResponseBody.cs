using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class AbyssTowerRankingsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.abyssTowerRankings);
			writer.Write(this.rankingEquippedGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.abyssTowerRankings = reader.ReadPDPacketDatas<PDAbyssTowerRanking>();
			this.rankingEquippedGear = reader.ReadPDPacketDatas<PDRankingEquippedGear>();
		}

		public AbyssTowerRankingsResponseBody()
		{
		}

		public PDAbyssTowerRanking[] abyssTowerRankings;

		public PDRankingEquippedGear[] rankingEquippedGear;
	}
}
