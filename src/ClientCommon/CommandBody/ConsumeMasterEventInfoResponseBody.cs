using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ConsumeMasterEventInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isFinal);
			writer.Write(this.rankings);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isFinal = reader.ReadBoolean();
			this.rankings = reader.ReadPDPacketDatas<PDConsumeMasterEventRankingInstance>();
		}

		public ConsumeMasterEventInfoResponseBody()
		{
		}

		public bool isFinal;

		public PDConsumeMasterEventRankingInstance[] rankings;
	}
}
