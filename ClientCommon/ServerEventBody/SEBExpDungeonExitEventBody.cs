using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBExpDungeonExitEventBody : SEBServerEventBody
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

		public SEBExpDungeonExitEventBody()
		{
		}

		public int continentId;
	}
}
