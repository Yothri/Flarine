using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterHPRestorationEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.hp);
			writer.Write(this.restoredHP);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.hp = reader.ReadInt32();
			this.restoredHP = reader.ReadInt32();
		}

		public SEBMonsterHPRestorationEventBody()
		{
		}

		public long monsterInstanceId;

		public int hp;

		public int restoredHP;
	}
}
