using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBContinentBossMonsterDeadEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.killerId);
			writer.Write(this.killerName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.killerId = reader.ReadInt32();
			this.killerName = reader.ReadString();
		}

		public SEBContinentBossMonsterDeadEventBody()
		{
		}

		public int continentId;

		public int killerId;

		public string killerName;
	}
}
