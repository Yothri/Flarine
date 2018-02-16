using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBSecretChamberMonsterDeadEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isBoss);
			writer.Write(this.killerId);
			writer.Write(this.killerName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isBoss = reader.ReadBoolean();
			this.killerId = reader.ReadInt32();
			this.killerName = reader.ReadString();
		}

		public SEBSecretChamberMonsterDeadEventBody()
		{
		}

		public bool isBoss;

		public int killerId;

		public string killerName;
	}
}
