using System;

namespace ClientCommon.CommandBody
{
	public class ContinentBossInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.spawned);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.spawned = reader.ReadBoolean();
		}

		public ContinentBossInfoResponseBody()
		{
		}

		public int continentId;

		public bool spawned;
	}
}
