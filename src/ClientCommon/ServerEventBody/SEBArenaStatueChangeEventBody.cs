using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBArenaStatueChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.statue);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.statue = reader.ReadPDPacketData<PDArenaStatue>();
		}

		public SEBArenaStatueChangeEventBody()
		{
		}

		public PDArenaStatue statue;
	}
}
