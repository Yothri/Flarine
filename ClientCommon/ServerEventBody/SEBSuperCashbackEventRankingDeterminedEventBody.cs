using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBSuperCashbackEventRankingDeterminedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.ranking);
			writer.Write(this.cashbackBonusUnOwnDia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.ranking = reader.ReadInt32();
			this.cashbackBonusUnOwnDia = reader.ReadInt32();
		}

		public SEBSuperCashbackEventRankingDeterminedEventBody()
		{
		}

		public int entryId;

		public int ranking;

		public int cashbackBonusUnOwnDia;
	}
}
