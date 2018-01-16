using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroLevelChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.level);
			writer.Write(this.maxHP);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
		}

		public SEBHeroLevelChangeEventBody()
		{
		}

		public int accountHeroId;

		public int level;

		public int maxHP;
	}
}
