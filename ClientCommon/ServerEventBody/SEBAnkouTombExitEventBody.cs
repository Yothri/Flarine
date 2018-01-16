using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAnkouTombExitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
		}

		public SEBAnkouTombExitEventBody()
		{
		}

		public int continentId;
	}
}
