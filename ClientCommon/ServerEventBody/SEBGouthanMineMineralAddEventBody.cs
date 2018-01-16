using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBGouthanMineMineralAddEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mineralInsts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mineralInsts = reader.ReadPDPacketDatas<PDGouthanMineMineralInstance>();
		}

		public SEBGouthanMineMineralAddEventBody()
		{
		}

		public PDGouthanMineMineralInstance[] mineralInsts;
	}
}
