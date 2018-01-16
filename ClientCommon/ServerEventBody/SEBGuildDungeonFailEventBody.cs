using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildDungeonFailEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
		}

		public SEBGuildDungeonFailEventBody()
		{
		}

		public int hp;
	}
}
