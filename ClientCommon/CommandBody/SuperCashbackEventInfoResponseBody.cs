using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SuperCashbackEventInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.rankings);
			writer.Write(this.lastEntryId);
			writer.Write(this.isLastRankingFinal);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.rankings = reader.ReadPDPacketDatas<PDSuperCashbackEventRankingInstance>();
			this.lastEntryId = reader.ReadInt32();
			this.isLastRankingFinal = reader.ReadBoolean();
		}

		public SuperCashbackEventInfoResponseBody()
		{
		}

		public int entryId;

		public PDSuperCashbackEventRankingInstance[] rankings;

		public int lastEntryId;

		public bool isLastRankingFinal;
	}
}
