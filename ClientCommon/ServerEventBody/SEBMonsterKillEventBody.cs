using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterKillEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.monsterId);
			writer.Write(this.isBoss);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.monsterId = reader.ReadInt32();
			this.isBoss = reader.ReadBoolean();
		}

		public SEBMonsterKillEventBody()
		{
		}

		public DateTime date;

		public int monsterId;

		public bool isBoss;
	}
}
