using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBWorldBuffUpdatedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.worldBuffs);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.worldBuffs = reader.ReadPDPacketDatas<PDWorldBuff>();
		}

		public SEBWorldBuffUpdatedEventBody()
		{
		}

		public PDWorldBuff[] worldBuffs;
	}
}
