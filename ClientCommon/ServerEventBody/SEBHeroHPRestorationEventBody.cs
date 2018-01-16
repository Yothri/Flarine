using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroHPRestorationEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.hp);
			writer.Write(this.restoredHP);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.restoredHP = reader.ReadInt32();
		}

		public SEBHeroHPRestorationEventBody()
		{
		}

		public int accountHeroId;

		public int hp;

		public int restoredHP;
	}
}
