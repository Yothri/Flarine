using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroAbnormalStateFinishedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.maxHP);
			writer.Write(this.hp);
			writer.Write(this.moveSpeed);
			writer.Write(this.abnormalStateInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
			this.abnormalStateInstanceId = reader.ReadInt64();
		}

		public SEBHeroAbnormalStateFinishedEventBody()
		{
		}

		public int accountHeroId;

		public int maxHP;

		public int hp;

		public float moveSpeed;

		public long abnormalStateInstanceId;
	}
}
