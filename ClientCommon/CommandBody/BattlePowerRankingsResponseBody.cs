using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BattlePowerRankingsResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.battlePowerRankings);
			writer.Write(this.rankingEquippedGear);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.battlePowerRankings = reader.ReadPDPacketDatas<PDBattlePowerRanking>();
			this.rankingEquippedGear = reader.ReadPDPacketDatas<PDRankingEquippedGear>();
		}

		public BattlePowerRankingsResponseBody()
		{
		}

		public PDBattlePowerRanking[] battlePowerRankings;

		public PDRankingEquippedGear[] rankingEquippedGear;
	}
}
