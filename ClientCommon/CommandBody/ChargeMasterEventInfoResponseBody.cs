using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ChargeMasterEventInfoResponseBody : ResponseBody
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
			this.rankings = reader.ReadPDPacketDatas<PDChargeMasterEventRankingInstance>();
		}

		public ChargeMasterEventInfoResponseBody()
		{
		}

		public bool isFinal;

		public PDChargeMasterEventRankingInstance[] rankings;
	}
}
